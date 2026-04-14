using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Godot;

namespace GDComponentSystem.BindingGenerator;

[Tool]
public partial class BindingGenerator : Node
{
    [ExportToolButton("Generate Bindings")]
    private Callable BindCallable => Callable.From(GenerateBindings);


    private void GenerateBindings()
    {
        GD.Print("Generating bindings...");
        Error error;
        const string componentDir = "res://addons/GDComponentSystem/ComponentBases/";
        const string hostDir = "res://addons/GDComponentSystem/ComponentHosts/";
        const string componentHostFilePath = "res://addons/GDComponentSystem/IComponentHost.cs";

        var globalComponentDir = ProjectSettings.GlobalizePath(componentDir);
        var globalHostDir = ProjectSettings.GlobalizePath(hostDir);
        var globalComponentHostFilePath = ProjectSettings.GlobalizePath(componentHostFilePath);

        if (Directory.Exists(globalComponentDir)) Directory.Delete(globalComponentDir, true);
        Directory.CreateDirectory(globalComponentDir!);

        if (Directory.Exists(globalHostDir)) Directory.Delete(globalHostDir, true);
        Directory.CreateDirectory(globalHostDir!);
        
        if (File.Exists(globalComponentHostFilePath)) File.Delete(globalComponentHostFilePath);
        File.WriteAllText(globalComponentHostFilePath,
            """
            #nullable enable
            namespace Godot.Components.Hosts;

            public interface IComponentHost
            {
                void AddComponent(NodeComponent nodeComponent);
                void RemoveComponent(NodeComponent nodeComponent);
            }
            """
        );

        var nodeType = typeof(Node);
        foreach (var type in EnumerateSubtypeRecursively(nodeType))
        {
            var componentName = $"{type.Name}Component";
            var hostName = $"{type.Name}ComponentHost";
            var componentPath = $"{globalComponentDir}{componentName}.cs";
            var hostPath = $"{globalHostDir}{hostName}.cs";

            var isRoot = type == nodeType;

            var componentBuilder = new StringBuilder();
            var hostBuilder = new StringBuilder();

            const string __ = "    ";

            var parentComponentType = isRoot ? "Resource" : type.BaseType!.Name + "Component";

            componentBuilder.AppendLine(
                $$"""
                  #nullable disable

                  using System;
                  using Godot.Components.Hosts;
                  using Godot.Collections;
                  using Godot;
                  using Array = Godot.Collections.Array;

                  namespace Godot.Components;

                  /// <inheritdoc cref="{{ReflectionUtils.ConstructTypeName(type)}}" />
                  [Tool, GlobalClass]
                  public abstract partial class {{componentName}} : {{parentComponentType}}
                  {

                  """
            );

            hostBuilder.AppendLine(
                $$"""
                  #nullable disable

                  using System;
                  using System.Runtime.CompilerServices;
                  using Godot.Components.Hosts;
                  using Godot.Collections;
                  using Godot;
                  using Array = Godot.Collections.Array;

                  namespace Godot.Components.Hosts;

                  /// <inheritdoc cref="{{ReflectionUtils.ConstructTypeName(type)}}" />
                  [Tool, GlobalClass]
                  public partial class {{hostName}} : {{ReflectionUtils.ConstructTypeName(type)}}, IComponentHost
                  {
                  {{__}}[Export] private Array<NodeComponent> _components = [];

                  {{__}}public void AddComponent(NodeComponent nodeComponent)
                  {{__}}{
                  {{__}}{{__}}if (_components.Contains(nodeComponent)) return;
                  {{__}}{{__}}HostAccessor(nodeComponent) = this;
                  {{__}}{{__}}_components.Add(nodeComponent);
                  {{__}}{{__}}OnComponentAdded(nodeComponent, this);
                  {{__}}}

                  {{__}}public void RemoveComponent(NodeComponent nodeComponent)
                  {{__}}{
                  {{__}}{{__}}if (!_components.Contains(nodeComponent)) return;
                  {{__}}{{__}}HostAccessor(nodeComponent) = null;
                  {{__}}{{__}}_components.Remove(nodeComponent);
                  {{__}}{{__}}OnComponentRemoved(nodeComponent, this);
                  {{__}}}

                  {{__}}[UnsafeAccessor(UnsafeAccessorKind.Field, Name = "_host")]
                  {{__}}private static extern ref IComponentHost? HostAccessor(NodeComponent nodeComponent);

                  {{__}}[UnsafeAccessor(UnsafeAccessorKind.Method, Name = "_OnComponentAdded")]
                  {{__}}private static extern void OnComponentAdded(NodeComponent nodeComponent, {{hostName}} hostInstance);

                  {{__}}[UnsafeAccessor(UnsafeAccessorKind.Method, Name = "_OnComponentRemoved")]
                  {{__}}private static extern void OnComponentRemoved(NodeComponent nodeComponent, {{hostName}} hostInstance);

                  """
            );


            if (isRoot)
            {
                componentBuilder.AppendLine(
                    $$"""
                      {{__}}private protected IComponentHost _host;

                      {{__}}private protected virtual void _OnComponentAdded(Node hostInstance) { }

                      {{__}}private protected virtual void _OnComponentRemoved(Node hostInstance) { }

                      """);
            }


            foreach (var methodInfo in type.GetMethods(BindingFlags.Public | BindingFlags.Instance))
            {
                if (methodInfo.IsSpecialName) continue;
                if (methodInfo.DeclaringType!.Assembly != nodeType.Assembly) continue;
                if (methodInfo.DeclaringType == typeof(GodotObject)) continue;

                var parameters = methodInfo.GetParameters();
                var parameterList = string.Join(", ", parameters.Select(p => $"{ReflectionUtils.ConstructTypeName(p.ParameterType)} @{p.Name}"));
                var typeOnlyParameterList = string.Join(", ", parameters.Select(p => $"{ReflectionUtils.ConstructTypeName(p.ParameterType).Replace('<', '{').Replace('>', '}')}"));
                var argumentList = string.Join(", ", parameters.Select(p => $"@{p.Name}"));

                if (methodInfo.IsVirtual)
                {
                    if (methodInfo.DeclaringType == type)
                    {
                        if (methodInfo.ReturnType != typeof(void))
                        {
                            if (methodInfo.IsGenericMethod)
                            {
                                var genericArgs = methodInfo.GetGenericArguments();
                                var genericArgList = string.Join(", ", genericArgs.Select(a => a.Name));
                                componentBuilder.AppendLine(
                                    $$"""
                                      {{__}}/// <inheritdoc cref="{{ReflectionUtils.ConstructTypeName(type)}}.{{methodInfo.Name}}{{{genericArgList}}}({{typeOnlyParameterList}})" />
                                      {{__}}public virtual {{ReflectionUtils.ConstructTypeName(methodInfo.ReturnType, false)}} {{methodInfo.Name}}<{{genericArgList}}>({{parameterList}}) where {{string.Join(" where ", genericArgs.Select(a => $"{a.Name} : class"))}}
                                      {{__+__}} => (({{ReflectionUtils.ConstructTypeName(type)}})_host).{{methodInfo.Name}}<{{genericArgList}}>({{argumentList}});

                                      """);
                            }
                            else
                            {
                                componentBuilder.AppendLine(
                                    $$"""
                                      {{__}}/// <inheritdoc cref="{{ReflectionUtils.ConstructTypeName(type)}}.{{methodInfo.Name}}({{typeOnlyParameterList}})" />
                                      {{__}}public virtual {{ReflectionUtils.ConstructTypeName(methodInfo.ReturnType)}} {{methodInfo.Name}}({{parameterList}}) => (({{ReflectionUtils.ConstructTypeName(type)}})_host).{{methodInfo.Name}}({{argumentList}});

                                      """);
                            }
                        }
                        else
                        {
                            if (methodInfo.IsGenericMethod)
                            {
                                var genericArgs = methodInfo.GetGenericArguments();
                                var genericArgList = string.Join(", ", genericArgs.Select(a => a.Name));
                                componentBuilder.AppendLine(
                                    $$"""
                                      {{__}}/// <inheritdoc cref="{{ReflectionUtils.ConstructTypeName(type)}}.{{methodInfo.Name}}{{{genericArgList}}}({{typeOnlyParameterList}})" />
                                      {{__}}public virtual {{ReflectionUtils.ConstructTypeName(methodInfo.ReturnType, false)}} {{methodInfo.Name}}<{{genericArgList}}>({{parameterList}}) where {{string.Join(" where ", genericArgs.Select(a => $"{a.Name} : class"))}} { }
                                      """);
                            }
                            else
                            {
                                componentBuilder.AppendLine(
                                    $$"""
                                      {{__}}/// <inheritdoc cref="{{ReflectionUtils.ConstructTypeName(type)}}.{{methodInfo.Name}}({{typeOnlyParameterList}})" />
                                      {{__}}public virtual {{ReflectionUtils.ConstructTypeName(methodInfo.ReturnType)}} {{methodInfo.Name}}({{parameterList}}) { }

                                      """);
                            }
                        }
                    }

                    hostBuilder.AppendLine(
                        $$"""
                          {{__}}/// <inheritdoc />
                          {{__}}public override {{ReflectionUtils.ConstructTypeName(methodInfo.ReturnType)}} {{methodInfo.Name}}({{parameterList}})
                          {{__}}{
                          """
                    );

                    if (methodInfo.Name == "_EnterTree")
                    {
                        hostBuilder.AppendLine(
                            $$"""
                              {{__ + __}}foreach (var component in _components)
                              {{__ + __ + __}}HostAccessor(component) = this;
                              """
                        );
                    }

                    var methodOwnerType = methodInfo.DeclaringType;
                    var methodOwnerTypeComponentName = methodOwnerType == nodeType ? "NodeComponent" : methodOwnerType.Name + "Component";

                    if (methodInfo.ReturnType != typeof(void))
                    {
                        hostBuilder.AppendLine(
                            $$"""
                              {{__ + __}}foreach (var component in _components)
                              {{__ + __}}{
                              {{__ + __ + __}}if (component is not {{methodOwnerTypeComponentName}} typedComponent) continue;
                              {{__ + __ + __}}return typedComponent.{{methodInfo.Name}}({{argumentList}});
                              {{__ + __}}}
                              {{__ + __}}return base.{{methodInfo.Name}}({{argumentList}});
                              {{__}}}

                              """
                        );
                    }
                    else
                    {
                        hostBuilder.AppendLine(
                            $$"""
                              {{__ + __}}foreach (var component in _components)
                              {{__ + __}}{
                              {{__ + __ + __}}if (component is not {{methodOwnerTypeComponentName}} typedComponent) continue;
                              {{__ + __ + __}}typedComponent.{{methodInfo.Name}}({{argumentList}});
                              {{__ + __}}}
                              {{__}}}

                              """
                        );
                    }
                }
                else
                {
                    if (methodInfo.DeclaringType == type)
                    {
                        if (methodInfo.IsGenericMethod)
                        {
                            var genericArgs = methodInfo.GetGenericArguments();
                            var genericArgList = string.Join(", ", genericArgs.Select(a => a.Name));
                            componentBuilder.AppendLine(
                                $$"""
                                  {{__}}/// <inheritdoc cref="{{ReflectionUtils.ConstructTypeName(type)}}.{{methodInfo.Name}}{{{genericArgList}}}({{typeOnlyParameterList}})" />
                                  {{__}}public {{ReflectionUtils.ConstructTypeName(methodInfo.ReturnType, false)}} {{methodInfo.Name}}<{{genericArgList}}>({{parameterList}}) where {{string.Join(" where ", genericArgs.Select(a => $"{a.Name} : class"))}}
                                  {{__+__}}=> (({{ReflectionUtils.ConstructTypeName(type)}})_host).{{methodInfo.Name}}<{{genericArgList}}>({{argumentList}});

                                  """);
                        }
                        else
                        {
                            componentBuilder.AppendLine(
                                $$"""
                                  {{__}}/// <inheritdoc cref="{{ReflectionUtils.ConstructTypeName(type)}}.{{methodInfo.Name}}({{typeOnlyParameterList}})" />
                                  {{__}}public {{ReflectionUtils.ConstructTypeName(methodInfo.ReturnType)}} {{methodInfo.Name}}({{parameterList}}) => (({{ReflectionUtils.ConstructTypeName(type)}})_host).{{methodInfo.Name}}({{argumentList}});

                                  """);
                        }
                    }
                }
            }

            componentBuilder.Append(
                """
                }

                """
            );

            hostBuilder.Append(
                """
                }

                """
            );

            File.WriteAllText(componentPath, componentBuilder.ToString());
            
            if(type.GetConstructors().Any(x => x.GetParameters().Length == 0 && x.IsPublic))
                File.WriteAllText(hostPath, hostBuilder.ToString());
        }
    }

    private static IEnumerable<Type> EnumerateSubtypeRecursively(Type type)
    {
        var childrenByParent = new Dictionary<Type, List<Type>>();
        foreach (var assemblyType in type.Assembly.GetTypes())
        {
            if (!assemblyType.IsSubclassOf(type) || assemblyType.BaseType is null) continue;

            if (!childrenByParent.TryGetValue(assemblyType.BaseType, out var children))
            {
                children = [];
                childrenByParent[assemblyType.BaseType] = children;
            }

            children.Add(assemblyType);
        }

        var queue = new Queue<Type>();
        var visited = new HashSet<Type>();

        queue.Enqueue(type);
        visited.Add(type);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            yield return current;

            if (!childrenByParent.TryGetValue(current, out var children)) continue;

            foreach (var child in children)
            {
                if (!visited.Add(child)) continue;
                queue.Enqueue(child);
            }
        }
    }

    internal static class ReflectionUtils
    {
        private static readonly HashSet<Type>? _tupleTypeSet;
        private static readonly Dictionary<Type, string>? _builtinTypeNameDictionary;
        internal static readonly bool IsEditorHintCached;

        static ReflectionUtils()
        {
            IsEditorHintCached = Engine.IsEditorHint();
            if (!IsEditorHintCached)
            {
                return;
            }

            _tupleTypeSet = new HashSet<Type>
            {
                // ValueTuple with only one element should be treated as normal generic type.
                //typeof(ValueTuple<>),
                typeof(ValueTuple<,>),
                typeof(ValueTuple<,,>),
                typeof(ValueTuple<,,,>),
                typeof(ValueTuple<,,,,>),
                typeof(ValueTuple<,,,,,>),
                typeof(ValueTuple<,,,,,,>),
                typeof(ValueTuple<,,,,,,,>),
            };

            _builtinTypeNameDictionary ??= new Dictionary<Type, string>
            {
                { typeof(sbyte), "sbyte" },
                { typeof(byte), "byte" },
                { typeof(short), "short" },
                { typeof(ushort), "ushort" },
                { typeof(int), "int" },
                { typeof(uint), "uint" },
                { typeof(long), "long" },
                { typeof(ulong), "ulong" },
                { typeof(nint), "nint" },
                { typeof(nuint), "nuint" },
                { typeof(float), "float" },
                { typeof(double), "double" },
                { typeof(decimal), "decimal" },
                { typeof(bool), "bool" },
                { typeof(char), "char" },
                { typeof(string), "string" },
                { typeof(object), "object" },
            };
        }
        
        public static string ConstructTypeName(Type type, bool includeParent = true)
        {
            if (!IsEditorHintCached)
            {
                return type.Name;
            }

            if (type is { IsArray: false, IsGenericType: false })
            {
                if (includeParent && type.DeclaringType != null) return $"{ConstructTypeName(type.DeclaringType, true)}.{GetSimpleTypeName(type)}";
                return GetSimpleTypeName(type);
            }

            var typeNameBuilder = new StringBuilder();

            if (includeParent && type.DeclaringType != null)
            {
                AppendType(typeNameBuilder, type.DeclaringType);
                typeNameBuilder.Append('.');
            }

            AppendType(typeNameBuilder, type);
            return typeNameBuilder.ToString();

            static void AppendType(StringBuilder sb, Type type)
            {
                if (type.IsArray)
                {
                    AppendArray(sb, type);
                }
                else if (type.IsGenericType)
                {
                    AppendGeneric(sb, type);
                }
                else
                {
                    sb.Append(GetSimpleTypeName(type));
                }
            }

            static void AppendArray(StringBuilder sb, Type type)
            {
                // Append inner most non-array element.
                var elementType = type.GetElementType()!;
                while (elementType.IsArray)
                {
                    elementType = elementType.GetElementType()!;
                }

                AppendType(sb, elementType);
                // Append brackets.
                AppendArrayBrackets(sb, type);

                static void AppendArrayBrackets(StringBuilder sb, Type? type)
                {
                    while (type != null && type.IsArray)
                    {
                        int rank = type.GetArrayRank();
                        sb.Append('[');
                        sb.Append(',', rank - 1);
                        sb.Append(']');
                        type = type.GetElementType();
                    }
                }
            }

            static void AppendGeneric(StringBuilder sb, Type type)
            {
                var genericArgs = type.GenericTypeArguments;
                var genericDefinition = type.GetGenericTypeDefinition();

                // Nullable<T>
                if (genericDefinition == typeof(Nullable<>))
                {
                    AppendType(sb, genericArgs[0]);
                    sb.Append('?');
                    return;
                }

                // ValueTuple
                Debug.Assert(_tupleTypeSet != null);
                if (_tupleTypeSet.Contains(genericDefinition))
                {
                    sb.Append('(');
                    while (true)
                    {
                        // We assume that ValueTuple has 1~8 elements.
                        // And the 8th element (TRest) is always another ValueTuple.

                        // This is a hard coded tuple element length check.
                        if (genericArgs.Length != 8)
                        {
                            AppendParamTypes(sb, genericArgs);
                            break;
                        }
                        else
                        {
                            AppendParamTypes(sb, genericArgs.AsSpan(0, 7));
                            sb.Append(", ");

                            // TRest should be a ValueTuple!
                            var nextTuple = genericArgs[7];

                            genericArgs = nextTuple.GenericTypeArguments;
                        }
                    }

                    sb.Append(')');
                    return;
                }

                // Normal generic
                var typeName = type.Name.AsSpan();
                sb.Append(typeName[..typeName.LastIndexOf('`')]);
                sb.Append('<');
                AppendParamTypes(sb, genericArgs);
                sb.Append('>');

                static void AppendParamTypes(StringBuilder sb, ReadOnlySpan<Type> genericArgs)
                {
                    int n = genericArgs.Length - 1;
                    for (int i = 0; i < n; i += 1)
                    {
                        AppendType(sb, genericArgs[i]);
                        sb.Append(", ");
                    }

                    AppendType(sb, genericArgs[n]);
                }
            }

            static string GetSimpleTypeName(Type type)
            {
                Debug.Assert(_builtinTypeNameDictionary != null);
                if (type == typeof(void)) return "void";
                return _builtinTypeNameDictionary.TryGetValue(type, out string? name) ? name : type.Name;
            }
        }
    }
}
