#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CollisionPolygon3D" />
[Tool, GlobalClass]
public abstract partial class CollisionPolygon3DComponent : Node3DComponent
{

    /// <inheritdoc cref="CollisionPolygon3D.SetDepth(float)" />
    public void SetDepth(float @depth) => ((CollisionPolygon3D)_host).SetDepth(@depth);

    /// <inheritdoc cref="CollisionPolygon3D.GetDepth()" />
    public float GetDepth() => ((CollisionPolygon3D)_host).GetDepth();

    /// <inheritdoc cref="CollisionPolygon3D.SetPolygon(Vector2[])" />
    public void SetPolygon(Vector2[] @polygon) => ((CollisionPolygon3D)_host).SetPolygon(@polygon);

    /// <inheritdoc cref="CollisionPolygon3D.SetPolygon(ReadOnlySpan{Vector2})" />
    public void SetPolygon(ReadOnlySpan<Vector2> @polygon) => ((CollisionPolygon3D)_host).SetPolygon(@polygon);

    /// <inheritdoc cref="CollisionPolygon3D.GetPolygon()" />
    public Vector2[] GetPolygon() => ((CollisionPolygon3D)_host).GetPolygon();

    /// <inheritdoc cref="CollisionPolygon3D.SetDisabled(bool)" />
    public void SetDisabled(bool @disabled) => ((CollisionPolygon3D)_host).SetDisabled(@disabled);

    /// <inheritdoc cref="CollisionPolygon3D.IsDisabled()" />
    public bool IsDisabled() => ((CollisionPolygon3D)_host).IsDisabled();

    /// <inheritdoc cref="CollisionPolygon3D.SetDebugColor(Color)" />
    public void SetDebugColor(Color @color) => ((CollisionPolygon3D)_host).SetDebugColor(@color);

    /// <inheritdoc cref="CollisionPolygon3D.GetDebugColor()" />
    public Color GetDebugColor() => ((CollisionPolygon3D)_host).GetDebugColor();

    /// <inheritdoc cref="CollisionPolygon3D.SetEnableDebugFill(bool)" />
    public void SetEnableDebugFill(bool @enable) => ((CollisionPolygon3D)_host).SetEnableDebugFill(@enable);

    /// <inheritdoc cref="CollisionPolygon3D.GetEnableDebugFill()" />
    public bool GetEnableDebugFill() => ((CollisionPolygon3D)_host).GetEnableDebugFill();

    /// <inheritdoc cref="CollisionPolygon3D.SetMargin(float)" />
    public void SetMargin(float @margin) => ((CollisionPolygon3D)_host).SetMargin(@margin);

    /// <inheritdoc cref="CollisionPolygon3D.GetMargin()" />
    public float GetMargin() => ((CollisionPolygon3D)_host).GetMargin();

}
