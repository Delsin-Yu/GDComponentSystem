#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ShapeCast3D" />
[Tool, GlobalClass]
public abstract partial class ShapeCast3DComponent : Node3DComponent
{

    /// <inheritdoc cref="ShapeCast3D.ResourceChanged(Resource)" />
    public void ResourceChanged(Resource @resource) => ((ShapeCast3D)_host).ResourceChanged(@resource);

    /// <inheritdoc cref="ShapeCast3D.SetEnabled(bool)" />
    public void SetEnabled(bool @enabled) => ((ShapeCast3D)_host).SetEnabled(@enabled);

    /// <inheritdoc cref="ShapeCast3D.IsEnabled()" />
    public bool IsEnabled() => ((ShapeCast3D)_host).IsEnabled();

    /// <inheritdoc cref="ShapeCast3D.SetShape(Shape3D)" />
    public void SetShape(Shape3D @shape) => ((ShapeCast3D)_host).SetShape(@shape);

    /// <inheritdoc cref="ShapeCast3D.GetShape()" />
    public Shape3D GetShape() => ((ShapeCast3D)_host).GetShape();

    /// <inheritdoc cref="ShapeCast3D.SetTargetPosition(Vector3)" />
    public void SetTargetPosition(Vector3 @localPoint) => ((ShapeCast3D)_host).SetTargetPosition(@localPoint);

    /// <inheritdoc cref="ShapeCast3D.GetTargetPosition()" />
    public Vector3 GetTargetPosition() => ((ShapeCast3D)_host).GetTargetPosition();

    /// <inheritdoc cref="ShapeCast3D.SetMargin(float)" />
    public void SetMargin(float @margin) => ((ShapeCast3D)_host).SetMargin(@margin);

    /// <inheritdoc cref="ShapeCast3D.GetMargin()" />
    public float GetMargin() => ((ShapeCast3D)_host).GetMargin();

    /// <inheritdoc cref="ShapeCast3D.SetMaxResults(int)" />
    public void SetMaxResults(int @maxResults) => ((ShapeCast3D)_host).SetMaxResults(@maxResults);

    /// <inheritdoc cref="ShapeCast3D.GetMaxResults()" />
    public int GetMaxResults() => ((ShapeCast3D)_host).GetMaxResults();

    /// <inheritdoc cref="ShapeCast3D.IsColliding()" />
    public bool IsColliding() => ((ShapeCast3D)_host).IsColliding();

    /// <inheritdoc cref="ShapeCast3D.GetCollisionCount()" />
    public int GetCollisionCount() => ((ShapeCast3D)_host).GetCollisionCount();

    /// <inheritdoc cref="ShapeCast3D.ForceShapecastUpdate()" />
    public void ForceShapecastUpdate() => ((ShapeCast3D)_host).ForceShapecastUpdate();

    /// <inheritdoc cref="ShapeCast3D.GetCollider(int)" />
    public GodotObject GetCollider(int @index) => ((ShapeCast3D)_host).GetCollider(@index);

    /// <inheritdoc cref="ShapeCast3D.GetColliderRid(int)" />
    public Rid GetColliderRid(int @index) => ((ShapeCast3D)_host).GetColliderRid(@index);

    /// <inheritdoc cref="ShapeCast3D.GetColliderShape(int)" />
    public int GetColliderShape(int @index) => ((ShapeCast3D)_host).GetColliderShape(@index);

    /// <inheritdoc cref="ShapeCast3D.GetCollisionPoint(int)" />
    public Vector3 GetCollisionPoint(int @index) => ((ShapeCast3D)_host).GetCollisionPoint(@index);

    /// <inheritdoc cref="ShapeCast3D.GetCollisionNormal(int)" />
    public Vector3 GetCollisionNormal(int @index) => ((ShapeCast3D)_host).GetCollisionNormal(@index);

    /// <inheritdoc cref="ShapeCast3D.GetClosestCollisionSafeFraction()" />
    public float GetClosestCollisionSafeFraction() => ((ShapeCast3D)_host).GetClosestCollisionSafeFraction();

    /// <inheritdoc cref="ShapeCast3D.GetClosestCollisionUnsafeFraction()" />
    public float GetClosestCollisionUnsafeFraction() => ((ShapeCast3D)_host).GetClosestCollisionUnsafeFraction();

    /// <inheritdoc cref="ShapeCast3D.AddExceptionRid(Rid)" />
    public void AddExceptionRid(Rid @rid) => ((ShapeCast3D)_host).AddExceptionRid(@rid);

    /// <inheritdoc cref="ShapeCast3D.AddException(CollisionObject3D)" />
    public void AddException(CollisionObject3D @node) => ((ShapeCast3D)_host).AddException(@node);

    /// <inheritdoc cref="ShapeCast3D.RemoveExceptionRid(Rid)" />
    public void RemoveExceptionRid(Rid @rid) => ((ShapeCast3D)_host).RemoveExceptionRid(@rid);

    /// <inheritdoc cref="ShapeCast3D.RemoveException(CollisionObject3D)" />
    public void RemoveException(CollisionObject3D @node) => ((ShapeCast3D)_host).RemoveException(@node);

    /// <inheritdoc cref="ShapeCast3D.ClearExceptions()" />
    public void ClearExceptions() => ((ShapeCast3D)_host).ClearExceptions();

    /// <inheritdoc cref="ShapeCast3D.SetCollisionMask(uint)" />
    public void SetCollisionMask(uint @mask) => ((ShapeCast3D)_host).SetCollisionMask(@mask);

    /// <inheritdoc cref="ShapeCast3D.GetCollisionMask()" />
    public uint GetCollisionMask() => ((ShapeCast3D)_host).GetCollisionMask();

    /// <inheritdoc cref="ShapeCast3D.SetCollisionMaskValue(int, bool)" />
    public void SetCollisionMaskValue(int @layerNumber, bool @value) => ((ShapeCast3D)_host).SetCollisionMaskValue(@layerNumber, @value);

    /// <inheritdoc cref="ShapeCast3D.GetCollisionMaskValue(int)" />
    public bool GetCollisionMaskValue(int @layerNumber) => ((ShapeCast3D)_host).GetCollisionMaskValue(@layerNumber);

    /// <inheritdoc cref="ShapeCast3D.SetExcludeParentBody(bool)" />
    public void SetExcludeParentBody(bool @mask) => ((ShapeCast3D)_host).SetExcludeParentBody(@mask);

    /// <inheritdoc cref="ShapeCast3D.GetExcludeParentBody()" />
    public bool GetExcludeParentBody() => ((ShapeCast3D)_host).GetExcludeParentBody();

    /// <inheritdoc cref="ShapeCast3D.SetCollideWithAreas(bool)" />
    public void SetCollideWithAreas(bool @enable) => ((ShapeCast3D)_host).SetCollideWithAreas(@enable);

    /// <inheritdoc cref="ShapeCast3D.IsCollideWithAreasEnabled()" />
    public bool IsCollideWithAreasEnabled() => ((ShapeCast3D)_host).IsCollideWithAreasEnabled();

    /// <inheritdoc cref="ShapeCast3D.SetCollideWithBodies(bool)" />
    public void SetCollideWithBodies(bool @enable) => ((ShapeCast3D)_host).SetCollideWithBodies(@enable);

    /// <inheritdoc cref="ShapeCast3D.IsCollideWithBodiesEnabled()" />
    public bool IsCollideWithBodiesEnabled() => ((ShapeCast3D)_host).IsCollideWithBodiesEnabled();

    /// <inheritdoc cref="ShapeCast3D.GetCollisionResult()" />
    public Array GetCollisionResult() => ((ShapeCast3D)_host).GetCollisionResult();

    /// <inheritdoc cref="ShapeCast3D.SetDebugShapeCustomColor(Color)" />
    public void SetDebugShapeCustomColor(Color @debugShapeCustomColor) => ((ShapeCast3D)_host).SetDebugShapeCustomColor(@debugShapeCustomColor);

    /// <inheritdoc cref="ShapeCast3D.GetDebugShapeCustomColor()" />
    public Color GetDebugShapeCustomColor() => ((ShapeCast3D)_host).GetDebugShapeCustomColor();

}
