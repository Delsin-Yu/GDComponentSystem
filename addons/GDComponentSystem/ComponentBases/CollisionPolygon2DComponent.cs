#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CollisionPolygon2D" />
[Tool, GlobalClass]
public abstract partial class CollisionPolygon2DComponent : Node2DComponent
{

    /// <inheritdoc cref="CollisionPolygon2D.SetPolygon(Vector2[])" />
    public void SetPolygon(Vector2[] @polygon) => ((CollisionPolygon2D)_host).SetPolygon(@polygon);

    /// <inheritdoc cref="CollisionPolygon2D.SetPolygon(ReadOnlySpan{Vector2})" />
    public void SetPolygon(ReadOnlySpan<Vector2> @polygon) => ((CollisionPolygon2D)_host).SetPolygon(@polygon);

    /// <inheritdoc cref="CollisionPolygon2D.GetPolygon()" />
    public Vector2[] GetPolygon() => ((CollisionPolygon2D)_host).GetPolygon();

    /// <inheritdoc cref="CollisionPolygon2D.SetBuildMode(CollisionPolygon2D.BuildModeEnum)" />
    public void SetBuildMode(CollisionPolygon2D.BuildModeEnum @buildMode) => ((CollisionPolygon2D)_host).SetBuildMode(@buildMode);

    /// <inheritdoc cref="CollisionPolygon2D.GetBuildMode()" />
    public CollisionPolygon2D.BuildModeEnum GetBuildMode() => ((CollisionPolygon2D)_host).GetBuildMode();

    /// <inheritdoc cref="CollisionPolygon2D.SetDisabled(bool)" />
    public void SetDisabled(bool @disabled) => ((CollisionPolygon2D)_host).SetDisabled(@disabled);

    /// <inheritdoc cref="CollisionPolygon2D.IsDisabled()" />
    public bool IsDisabled() => ((CollisionPolygon2D)_host).IsDisabled();

    /// <inheritdoc cref="CollisionPolygon2D.SetOneWayCollision(bool)" />
    public void SetOneWayCollision(bool @enabled) => ((CollisionPolygon2D)_host).SetOneWayCollision(@enabled);

    /// <inheritdoc cref="CollisionPolygon2D.IsOneWayCollisionEnabled()" />
    public bool IsOneWayCollisionEnabled() => ((CollisionPolygon2D)_host).IsOneWayCollisionEnabled();

    /// <inheritdoc cref="CollisionPolygon2D.SetOneWayCollisionMargin(float)" />
    public void SetOneWayCollisionMargin(float @margin) => ((CollisionPolygon2D)_host).SetOneWayCollisionMargin(@margin);

    /// <inheritdoc cref="CollisionPolygon2D.GetOneWayCollisionMargin()" />
    public float GetOneWayCollisionMargin() => ((CollisionPolygon2D)_host).GetOneWayCollisionMargin();

}
