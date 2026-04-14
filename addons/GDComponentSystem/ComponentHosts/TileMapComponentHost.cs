#nullable disable

using System;
using System.Runtime.CompilerServices;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components.Hosts;

/// <inheritdoc cref="TileMap" />
[Tool, GlobalClass]
public partial class TileMapComponentHost : TileMap, IComponentHost
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
    private static extern void OnComponentAdded(NodeComponent nodeComponent, TileMapComponentHost hostInstance);

    [UnsafeAccessor(UnsafeAccessorKind.Method, Name = "_OnComponentRemoved")]
    private static extern void OnComponentRemoved(NodeComponent nodeComponent, TileMapComponentHost hostInstance);

    /// <inheritdoc />
    public override void _TileDataRuntimeUpdate(int @layer, Vector2I @coords, TileData @tileData)
    {
        foreach (var component in _components)
        {
            if (component is not TileMapComponent typedComponent) continue;
            typedComponent._TileDataRuntimeUpdate(@layer, @coords, @tileData);
        }
    }

    /// <inheritdoc />
    public override bool _UseTileDataRuntimeUpdate(int @layer, Vector2I @coords)
    {
        foreach (var component in _components)
        {
            if (component is not TileMapComponent typedComponent) continue;
            return typedComponent._UseTileDataRuntimeUpdate(@layer, @coords);
        }
        return base._UseTileDataRuntimeUpdate(@layer, @coords);
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
