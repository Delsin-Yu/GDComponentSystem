#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CollisionShape3D" />
[Tool, GlobalClass]
public abstract partial class CollisionShape3DComponent : Node3DComponent
{

    /// <inheritdoc cref="CollisionShape3D.ResourceChanged(Resource)" />
    public void ResourceChanged(Resource @resource) => ((CollisionShape3D)_host).ResourceChanged(@resource);

    /// <inheritdoc cref="CollisionShape3D.SetShape(Shape3D)" />
    public void SetShape(Shape3D @shape) => ((CollisionShape3D)_host).SetShape(@shape);

    /// <inheritdoc cref="CollisionShape3D.GetShape()" />
    public Shape3D GetShape() => ((CollisionShape3D)_host).GetShape();

    /// <inheritdoc cref="CollisionShape3D.SetDisabled(bool)" />
    public void SetDisabled(bool @enable) => ((CollisionShape3D)_host).SetDisabled(@enable);

    /// <inheritdoc cref="CollisionShape3D.IsDisabled()" />
    public bool IsDisabled() => ((CollisionShape3D)_host).IsDisabled();

    /// <inheritdoc cref="CollisionShape3D.MakeConvexFromSiblings()" />
    public void MakeConvexFromSiblings() => ((CollisionShape3D)_host).MakeConvexFromSiblings();

    /// <inheritdoc cref="CollisionShape3D.SetDebugColor(Color)" />
    public void SetDebugColor(Color @color) => ((CollisionShape3D)_host).SetDebugColor(@color);

    /// <inheritdoc cref="CollisionShape3D.GetDebugColor()" />
    public Color GetDebugColor() => ((CollisionShape3D)_host).GetDebugColor();

    /// <inheritdoc cref="CollisionShape3D.SetEnableDebugFill(bool)" />
    public void SetEnableDebugFill(bool @enable) => ((CollisionShape3D)_host).SetEnableDebugFill(@enable);

    /// <inheritdoc cref="CollisionShape3D.GetEnableDebugFill()" />
    public bool GetEnableDebugFill() => ((CollisionShape3D)_host).GetEnableDebugFill();

}
