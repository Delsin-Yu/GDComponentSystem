#nullable disable

using System;
using System.Runtime.CompilerServices;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components.Hosts;

/// <inheritdoc cref="VScrollBar" />
[Tool, GlobalClass]
public partial class VScrollBarComponentHost : VScrollBar, IComponentHost
{
    [Export] private Array<NodeComponent> _components = [];

    public void AddComponent(NodeComponent nodeComponent)
    {
        if (_components.Contains(nodeComponent)) return;
        HostAccessor(nodeComponent) = this;
        _components.Add(nodeComponent);
        OnComponentAdded(nodeComponent, this);
    }

    public void RemoveComponent(NodeComponent nodeComponent)
    {
        if (!_components.Contains(nodeComponent)) return;
        HostAccessor(nodeComponent) = null;
        _components.Remove(nodeComponent);
        OnComponentRemoved(nodeComponent, this);
    }

    [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "_host")]
    private static extern ref IComponentHost? HostAccessor(NodeComponent nodeComponent);

    [UnsafeAccessor(UnsafeAccessorKind.Method, Name = "_OnComponentAdded")]
    private static extern void OnComponentAdded(NodeComponent nodeComponent, VScrollBarComponentHost hostInstance);

    [UnsafeAccessor(UnsafeAccessorKind.Method, Name = "_OnComponentRemoved")]
    private static extern void OnComponentRemoved(NodeComponent nodeComponent, VScrollBarComponentHost hostInstance);

    /// <inheritdoc />
    public override void _ValueChanged(double @newValue)
    {
        foreach (var component in _components)
        {
            if (component is not RangeComponent typedComponent) continue;
            typedComponent._ValueChanged(@newValue);
        }
    }

    /// <inheritdoc />
    public override string _AccessibilityGetContextualInfo()
    {
        foreach (var component in _components)
        {
            if (component is not ControlComponent typedComponent) continue;
            return typedComponent._AccessibilityGetContextualInfo();
        }
        return base._AccessibilityGetContextualInfo();
    }

    /// <inheritdoc />
    public override bool _CanDropData(Vector2 @atPosition, Variant @data)
    {
        foreach (var component in _components)
        {
            if (component is not ControlComponent typedComponent) continue;
            return typedComponent._CanDropData(@atPosition, @data);
        }
        return base._CanDropData(@atPosition, @data);
    }

    /// <inheritdoc />
    public override void _DropData(Vector2 @atPosition, Variant @data)
    {
        foreach (var component in _components)
        {
            if (component is not ControlComponent typedComponent) continue;
            typedComponent._DropData(@atPosition, @data);
        }
    }

    /// <inheritdoc />
    public override string _GetAccessibilityContainerName(Node @node)
    {
        foreach (var component in _components)
        {
            if (component is not ControlComponent typedComponent) continue;
            return typedComponent._GetAccessibilityContainerName(@node);
        }
        return base._GetAccessibilityContainerName(@node);
    }

    /// <inheritdoc />
    public override Variant _GetDragData(Vector2 @atPosition)
    {
        foreach (var component in _components)
        {
            if (component is not ControlComponent typedComponent) continue;
            return typedComponent._GetDragData(@atPosition);
        }
        return base._GetDragData(@atPosition);
    }

    /// <inheritdoc />
    public override Vector2 _GetMinimumSize()
    {
        foreach (var component in _components)
        {
            if (component is not ControlComponent typedComponent) continue;
            return typedComponent._GetMinimumSize();
        }
        return base._GetMinimumSize();
    }

    /// <inheritdoc />
    public override string _GetTooltip(Vector2 @atPosition)
    {
        foreach (var component in _components)
        {
            if (component is not ControlComponent typedComponent) continue;
            return typedComponent._GetTooltip(@atPosition);
        }
        return base._GetTooltip(@atPosition);
    }

    /// <inheritdoc />
    public override void _GuiInput(InputEvent @event)
    {
        foreach (var component in _components)
        {
            if (component is not ControlComponent typedComponent) continue;
            typedComponent._GuiInput(@event);
        }
    }

    /// <inheritdoc />
    public override bool _HasPoint(Vector2 @point)
    {
        foreach (var component in _components)
        {
            if (component is not ControlComponent typedComponent) continue;
            return typedComponent._HasPoint(@point);
        }
        return base._HasPoint(@point);
    }

    /// <inheritdoc />
    public override GodotObject _MakeCustomTooltip(string @forText)
    {
        foreach (var component in _components)
        {
            if (component is not ControlComponent typedComponent) continue;
            return typedComponent._MakeCustomTooltip(@forText);
        }
        return base._MakeCustomTooltip(@forText);
    }

    /// <inheritdoc />
    public override Array<Vector3I> _StructuredTextParser(Array @args, string @text)
    {
        foreach (var component in _components)
        {
            if (component is not ControlComponent typedComponent) continue;
            return typedComponent._StructuredTextParser(@args, @text);
        }
        return base._StructuredTextParser(@args, @text);
    }

    /// <inheritdoc />
    public override void _Draw()
    {
        foreach (var component in _components)
        {
            if (component is not CanvasItemComponent typedComponent) continue;
            typedComponent._Draw();
        }
    }

    /// <inheritdoc />
    public override void _EnterTree()
    {
        foreach (var component in _components)
            HostAccessor(component) = this;
        foreach (var component in _components)
        {
            if (component is not NodeComponent typedComponent) continue;
            typedComponent._EnterTree();
        }
    }

    /// <inheritdoc />
    public override void _ExitTree()
    {
        foreach (var component in _components)
        {
            if (component is not NodeComponent typedComponent) continue;
            typedComponent._ExitTree();
        }
    }

    /// <inheritdoc />
    public override string[] _GetAccessibilityConfigurationWarnings()
    {
        foreach (var component in _components)
        {
            if (component is not NodeComponent typedComponent) continue;
            return typedComponent._GetAccessibilityConfigurationWarnings();
        }
        return base._GetAccessibilityConfigurationWarnings();
    }

    /// <inheritdoc />
    public override string[] _GetConfigurationWarnings()
    {
        foreach (var component in _components)
        {
            if (component is not NodeComponent typedComponent) continue;
            return typedComponent._GetConfigurationWarnings();
        }
        return base._GetConfigurationWarnings();
    }

    /// <inheritdoc />
    public override Rid _GetFocusedAccessibilityElement()
    {
        foreach (var component in _components)
        {
            if (component is not NodeComponent typedComponent) continue;
            return typedComponent._GetFocusedAccessibilityElement();
        }
        return base._GetFocusedAccessibilityElement();
    }

    /// <inheritdoc />
    public override void _Input(InputEvent @event)
    {
        foreach (var component in _components)
        {
            if (component is not NodeComponent typedComponent) continue;
            typedComponent._Input(@event);
        }
    }

    /// <inheritdoc />
    public override void _PhysicsProcess(double @delta)
    {
        foreach (var component in _components)
        {
            if (component is not NodeComponent typedComponent) continue;
            typedComponent._PhysicsProcess(@delta);
        }
    }

    /// <inheritdoc />
    public override void _Process(double @delta)
    {
        foreach (var component in _components)
        {
            if (component is not NodeComponent typedComponent) continue;
            typedComponent._Process(@delta);
        }
    }

    /// <inheritdoc />
    public override void _Ready()
    {
        foreach (var component in _components)
        {
            if (component is not NodeComponent typedComponent) continue;
            typedComponent._Ready();
        }
    }

    /// <inheritdoc />
    public override void _ShortcutInput(InputEvent @event)
    {
        foreach (var component in _components)
        {
            if (component is not NodeComponent typedComponent) continue;
            typedComponent._ShortcutInput(@event);
        }
    }

    /// <inheritdoc />
    public override void _UnhandledInput(InputEvent @event)
    {
        foreach (var component in _components)
        {
            if (component is not NodeComponent typedComponent) continue;
            typedComponent._UnhandledInput(@event);
        }
    }

    /// <inheritdoc />
    public override void _UnhandledKeyInput(InputEvent @event)
    {
        foreach (var component in _components)
        {
            if (component is not NodeComponent typedComponent) continue;
            typedComponent._UnhandledKeyInput(@event);
        }
    }

}
