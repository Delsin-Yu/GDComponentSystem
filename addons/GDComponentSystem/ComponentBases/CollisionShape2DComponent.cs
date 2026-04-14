#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CollisionShape2D" />
[Tool, GlobalClass]
public abstract partial class CollisionShape2DComponent : Node2DComponent
{

    /// <inheritdoc cref="CollisionShape2D.SetShape(Shape2D)" />
    public void SetShape(Shape2D @shape) => ((CollisionShape2D)_host).SetShape(@shape);

    /// <inheritdoc cref="CollisionShape2D.GetShape()" />
    public Shape2D GetShape() => ((CollisionShape2D)_host).GetShape();

    /// <inheritdoc cref="CollisionShape2D.SetDisabled(bool)" />
    public void SetDisabled(bool @disabled) => ((CollisionShape2D)_host).SetDisabled(@disabled);

    /// <inheritdoc cref="CollisionShape2D.IsDisabled()" />
    public bool IsDisabled() => ((CollisionShape2D)_host).IsDisabled();

    /// <inheritdoc cref="CollisionShape2D.SetOneWayCollision(bool)" />
    public void SetOneWayCollision(bool @enabled) => ((CollisionShape2D)_host).SetOneWayCollision(@enabled);

    /// <inheritdoc cref="CollisionShape2D.IsOneWayCollisionEnabled()" />
    public bool IsOneWayCollisionEnabled() => ((CollisionShape2D)_host).IsOneWayCollisionEnabled();

    /// <inheritdoc cref="CollisionShape2D.SetOneWayCollisionMargin(float)" />
    public void SetOneWayCollisionMargin(float @margin) => ((CollisionShape2D)_host).SetOneWayCollisionMargin(@margin);

    /// <inheritdoc cref="CollisionShape2D.GetOneWayCollisionMargin()" />
    public float GetOneWayCollisionMargin() => ((CollisionShape2D)_host).GetOneWayCollisionMargin();

    /// <inheritdoc cref="CollisionShape2D.SetDebugColor(Color)" />
    public void SetDebugColor(Color @color) => ((CollisionShape2D)_host).SetDebugColor(@color);

    /// <inheritdoc cref="CollisionShape2D.GetDebugColor()" />
    public Color GetDebugColor() => ((CollisionShape2D)_host).GetDebugColor();

}
