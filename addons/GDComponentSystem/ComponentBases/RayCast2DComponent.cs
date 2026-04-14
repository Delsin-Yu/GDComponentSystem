#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="RayCast2D" />
[Tool, GlobalClass]
public abstract partial class RayCast2DComponent : Node2DComponent
{

    /// <inheritdoc cref="RayCast2D.SetEnabled(bool)" />
    public void SetEnabled(bool @enabled) => ((RayCast2D)_host).SetEnabled(@enabled);

    /// <inheritdoc cref="RayCast2D.IsEnabled()" />
    public bool IsEnabled() => ((RayCast2D)_host).IsEnabled();

    /// <inheritdoc cref="RayCast2D.SetTargetPosition(Vector2)" />
    public void SetTargetPosition(Vector2 @localPoint) => ((RayCast2D)_host).SetTargetPosition(@localPoint);

    /// <inheritdoc cref="RayCast2D.GetTargetPosition()" />
    public Vector2 GetTargetPosition() => ((RayCast2D)_host).GetTargetPosition();

    /// <inheritdoc cref="RayCast2D.IsColliding()" />
    public bool IsColliding() => ((RayCast2D)_host).IsColliding();

    /// <inheritdoc cref="RayCast2D.ForceRaycastUpdate()" />
    public void ForceRaycastUpdate() => ((RayCast2D)_host).ForceRaycastUpdate();

    /// <inheritdoc cref="RayCast2D.GetCollider()" />
    public GodotObject GetCollider() => ((RayCast2D)_host).GetCollider();

    /// <inheritdoc cref="RayCast2D.GetColliderRid()" />
    public Rid GetColliderRid() => ((RayCast2D)_host).GetColliderRid();

    /// <inheritdoc cref="RayCast2D.GetColliderShape()" />
    public int GetColliderShape() => ((RayCast2D)_host).GetColliderShape();

    /// <inheritdoc cref="RayCast2D.GetCollisionPoint()" />
    public Vector2 GetCollisionPoint() => ((RayCast2D)_host).GetCollisionPoint();

    /// <inheritdoc cref="RayCast2D.GetCollisionNormal()" />
    public Vector2 GetCollisionNormal() => ((RayCast2D)_host).GetCollisionNormal();

    /// <inheritdoc cref="RayCast2D.AddExceptionRid(Rid)" />
    public void AddExceptionRid(Rid @rid) => ((RayCast2D)_host).AddExceptionRid(@rid);

    /// <inheritdoc cref="RayCast2D.AddException(CollisionObject2D)" />
    public void AddException(CollisionObject2D @node) => ((RayCast2D)_host).AddException(@node);

    /// <inheritdoc cref="RayCast2D.RemoveExceptionRid(Rid)" />
    public void RemoveExceptionRid(Rid @rid) => ((RayCast2D)_host).RemoveExceptionRid(@rid);

    /// <inheritdoc cref="RayCast2D.RemoveException(CollisionObject2D)" />
    public void RemoveException(CollisionObject2D @node) => ((RayCast2D)_host).RemoveException(@node);

    /// <inheritdoc cref="RayCast2D.ClearExceptions()" />
    public void ClearExceptions() => ((RayCast2D)_host).ClearExceptions();

    /// <inheritdoc cref="RayCast2D.SetCollisionMask(uint)" />
    public void SetCollisionMask(uint @mask) => ((RayCast2D)_host).SetCollisionMask(@mask);

    /// <inheritdoc cref="RayCast2D.GetCollisionMask()" />
    public uint GetCollisionMask() => ((RayCast2D)_host).GetCollisionMask();

    /// <inheritdoc cref="RayCast2D.SetCollisionMaskValue(int, bool)" />
    public void SetCollisionMaskValue(int @layerNumber, bool @value) => ((RayCast2D)_host).SetCollisionMaskValue(@layerNumber, @value);

    /// <inheritdoc cref="RayCast2D.GetCollisionMaskValue(int)" />
    public bool GetCollisionMaskValue(int @layerNumber) => ((RayCast2D)_host).GetCollisionMaskValue(@layerNumber);

    /// <inheritdoc cref="RayCast2D.SetExcludeParentBody(bool)" />
    public void SetExcludeParentBody(bool @mask) => ((RayCast2D)_host).SetExcludeParentBody(@mask);

    /// <inheritdoc cref="RayCast2D.GetExcludeParentBody()" />
    public bool GetExcludeParentBody() => ((RayCast2D)_host).GetExcludeParentBody();

    /// <inheritdoc cref="RayCast2D.SetCollideWithAreas(bool)" />
    public void SetCollideWithAreas(bool @enable) => ((RayCast2D)_host).SetCollideWithAreas(@enable);

    /// <inheritdoc cref="RayCast2D.IsCollideWithAreasEnabled()" />
    public bool IsCollideWithAreasEnabled() => ((RayCast2D)_host).IsCollideWithAreasEnabled();

    /// <inheritdoc cref="RayCast2D.SetCollideWithBodies(bool)" />
    public void SetCollideWithBodies(bool @enable) => ((RayCast2D)_host).SetCollideWithBodies(@enable);

    /// <inheritdoc cref="RayCast2D.IsCollideWithBodiesEnabled()" />
    public bool IsCollideWithBodiesEnabled() => ((RayCast2D)_host).IsCollideWithBodiesEnabled();

    /// <inheritdoc cref="RayCast2D.SetHitFromInside(bool)" />
    public void SetHitFromInside(bool @enable) => ((RayCast2D)_host).SetHitFromInside(@enable);

    /// <inheritdoc cref="RayCast2D.IsHitFromInsideEnabled()" />
    public bool IsHitFromInsideEnabled() => ((RayCast2D)_host).IsHitFromInsideEnabled();

}
