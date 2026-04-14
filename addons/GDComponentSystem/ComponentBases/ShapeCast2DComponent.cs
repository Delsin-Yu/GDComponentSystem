#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ShapeCast2D" />
[Tool, GlobalClass]
public abstract partial class ShapeCast2DComponent : Node2DComponent
{

    /// <inheritdoc cref="ShapeCast2D.SetEnabled(bool)" />
    public void SetEnabled(bool @enabled) => ((ShapeCast2D)_host).SetEnabled(@enabled);

    /// <inheritdoc cref="ShapeCast2D.IsEnabled()" />
    public bool IsEnabled() => ((ShapeCast2D)_host).IsEnabled();

    /// <inheritdoc cref="ShapeCast2D.SetShape(Shape2D)" />
    public void SetShape(Shape2D @shape) => ((ShapeCast2D)_host).SetShape(@shape);

    /// <inheritdoc cref="ShapeCast2D.GetShape()" />
    public Shape2D GetShape() => ((ShapeCast2D)_host).GetShape();

    /// <inheritdoc cref="ShapeCast2D.SetTargetPosition(Vector2)" />
    public void SetTargetPosition(Vector2 @localPoint) => ((ShapeCast2D)_host).SetTargetPosition(@localPoint);

    /// <inheritdoc cref="ShapeCast2D.GetTargetPosition()" />
    public Vector2 GetTargetPosition() => ((ShapeCast2D)_host).GetTargetPosition();

    /// <inheritdoc cref="ShapeCast2D.SetMargin(float)" />
    public void SetMargin(float @margin) => ((ShapeCast2D)_host).SetMargin(@margin);

    /// <inheritdoc cref="ShapeCast2D.GetMargin()" />
    public float GetMargin() => ((ShapeCast2D)_host).GetMargin();

    /// <inheritdoc cref="ShapeCast2D.SetMaxResults(int)" />
    public void SetMaxResults(int @maxResults) => ((ShapeCast2D)_host).SetMaxResults(@maxResults);

    /// <inheritdoc cref="ShapeCast2D.GetMaxResults()" />
    public int GetMaxResults() => ((ShapeCast2D)_host).GetMaxResults();

    /// <inheritdoc cref="ShapeCast2D.IsColliding()" />
    public bool IsColliding() => ((ShapeCast2D)_host).IsColliding();

    /// <inheritdoc cref="ShapeCast2D.GetCollisionCount()" />
    public int GetCollisionCount() => ((ShapeCast2D)_host).GetCollisionCount();

    /// <inheritdoc cref="ShapeCast2D.ForceShapecastUpdate()" />
    public void ForceShapecastUpdate() => ((ShapeCast2D)_host).ForceShapecastUpdate();

    /// <inheritdoc cref="ShapeCast2D.GetCollider(int)" />
    public GodotObject GetCollider(int @index) => ((ShapeCast2D)_host).GetCollider(@index);

    /// <inheritdoc cref="ShapeCast2D.GetColliderRid(int)" />
    public Rid GetColliderRid(int @index) => ((ShapeCast2D)_host).GetColliderRid(@index);

    /// <inheritdoc cref="ShapeCast2D.GetColliderShape(int)" />
    public int GetColliderShape(int @index) => ((ShapeCast2D)_host).GetColliderShape(@index);

    /// <inheritdoc cref="ShapeCast2D.GetCollisionPoint(int)" />
    public Vector2 GetCollisionPoint(int @index) => ((ShapeCast2D)_host).GetCollisionPoint(@index);

    /// <inheritdoc cref="ShapeCast2D.GetCollisionNormal(int)" />
    public Vector2 GetCollisionNormal(int @index) => ((ShapeCast2D)_host).GetCollisionNormal(@index);

    /// <inheritdoc cref="ShapeCast2D.GetClosestCollisionSafeFraction()" />
    public float GetClosestCollisionSafeFraction() => ((ShapeCast2D)_host).GetClosestCollisionSafeFraction();

    /// <inheritdoc cref="ShapeCast2D.GetClosestCollisionUnsafeFraction()" />
    public float GetClosestCollisionUnsafeFraction() => ((ShapeCast2D)_host).GetClosestCollisionUnsafeFraction();

    /// <inheritdoc cref="ShapeCast2D.AddExceptionRid(Rid)" />
    public void AddExceptionRid(Rid @rid) => ((ShapeCast2D)_host).AddExceptionRid(@rid);

    /// <inheritdoc cref="ShapeCast2D.AddException(CollisionObject2D)" />
    public void AddException(CollisionObject2D @node) => ((ShapeCast2D)_host).AddException(@node);

    /// <inheritdoc cref="ShapeCast2D.RemoveExceptionRid(Rid)" />
    public void RemoveExceptionRid(Rid @rid) => ((ShapeCast2D)_host).RemoveExceptionRid(@rid);

    /// <inheritdoc cref="ShapeCast2D.RemoveException(CollisionObject2D)" />
    public void RemoveException(CollisionObject2D @node) => ((ShapeCast2D)_host).RemoveException(@node);

    /// <inheritdoc cref="ShapeCast2D.ClearExceptions()" />
    public void ClearExceptions() => ((ShapeCast2D)_host).ClearExceptions();

    /// <inheritdoc cref="ShapeCast2D.SetCollisionMask(uint)" />
    public void SetCollisionMask(uint @mask) => ((ShapeCast2D)_host).SetCollisionMask(@mask);

    /// <inheritdoc cref="ShapeCast2D.GetCollisionMask()" />
    public uint GetCollisionMask() => ((ShapeCast2D)_host).GetCollisionMask();

    /// <inheritdoc cref="ShapeCast2D.SetCollisionMaskValue(int, bool)" />
    public void SetCollisionMaskValue(int @layerNumber, bool @value) => ((ShapeCast2D)_host).SetCollisionMaskValue(@layerNumber, @value);

    /// <inheritdoc cref="ShapeCast2D.GetCollisionMaskValue(int)" />
    public bool GetCollisionMaskValue(int @layerNumber) => ((ShapeCast2D)_host).GetCollisionMaskValue(@layerNumber);

    /// <inheritdoc cref="ShapeCast2D.SetExcludeParentBody(bool)" />
    public void SetExcludeParentBody(bool @mask) => ((ShapeCast2D)_host).SetExcludeParentBody(@mask);

    /// <inheritdoc cref="ShapeCast2D.GetExcludeParentBody()" />
    public bool GetExcludeParentBody() => ((ShapeCast2D)_host).GetExcludeParentBody();

    /// <inheritdoc cref="ShapeCast2D.SetCollideWithAreas(bool)" />
    public void SetCollideWithAreas(bool @enable) => ((ShapeCast2D)_host).SetCollideWithAreas(@enable);

    /// <inheritdoc cref="ShapeCast2D.IsCollideWithAreasEnabled()" />
    public bool IsCollideWithAreasEnabled() => ((ShapeCast2D)_host).IsCollideWithAreasEnabled();

    /// <inheritdoc cref="ShapeCast2D.SetCollideWithBodies(bool)" />
    public void SetCollideWithBodies(bool @enable) => ((ShapeCast2D)_host).SetCollideWithBodies(@enable);

    /// <inheritdoc cref="ShapeCast2D.IsCollideWithBodiesEnabled()" />
    public bool IsCollideWithBodiesEnabled() => ((ShapeCast2D)_host).IsCollideWithBodiesEnabled();

    /// <inheritdoc cref="ShapeCast2D.GetCollisionResult()" />
    public Array GetCollisionResult() => ((ShapeCast2D)_host).GetCollisionResult();

}
