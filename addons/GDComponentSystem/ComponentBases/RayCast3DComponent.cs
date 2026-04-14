#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="RayCast3D" />
[Tool, GlobalClass]
public abstract partial class RayCast3DComponent : Node3DComponent
{

    /// <inheritdoc cref="RayCast3D.SetEnabled(bool)" />
    public void SetEnabled(bool @enabled) => ((RayCast3D)_host).SetEnabled(@enabled);

    /// <inheritdoc cref="RayCast3D.IsEnabled()" />
    public bool IsEnabled() => ((RayCast3D)_host).IsEnabled();

    /// <inheritdoc cref="RayCast3D.SetTargetPosition(Vector3)" />
    public void SetTargetPosition(Vector3 @localPoint) => ((RayCast3D)_host).SetTargetPosition(@localPoint);

    /// <inheritdoc cref="RayCast3D.GetTargetPosition()" />
    public Vector3 GetTargetPosition() => ((RayCast3D)_host).GetTargetPosition();

    /// <inheritdoc cref="RayCast3D.IsColliding()" />
    public bool IsColliding() => ((RayCast3D)_host).IsColliding();

    /// <inheritdoc cref="RayCast3D.ForceRaycastUpdate()" />
    public void ForceRaycastUpdate() => ((RayCast3D)_host).ForceRaycastUpdate();

    /// <inheritdoc cref="RayCast3D.GetCollider()" />
    public GodotObject GetCollider() => ((RayCast3D)_host).GetCollider();

    /// <inheritdoc cref="RayCast3D.GetColliderRid()" />
    public Rid GetColliderRid() => ((RayCast3D)_host).GetColliderRid();

    /// <inheritdoc cref="RayCast3D.GetColliderShape()" />
    public int GetColliderShape() => ((RayCast3D)_host).GetColliderShape();

    /// <inheritdoc cref="RayCast3D.GetCollisionPoint()" />
    public Vector3 GetCollisionPoint() => ((RayCast3D)_host).GetCollisionPoint();

    /// <inheritdoc cref="RayCast3D.GetCollisionNormal()" />
    public Vector3 GetCollisionNormal() => ((RayCast3D)_host).GetCollisionNormal();

    /// <inheritdoc cref="RayCast3D.GetCollisionFaceIndex()" />
    public int GetCollisionFaceIndex() => ((RayCast3D)_host).GetCollisionFaceIndex();

    /// <inheritdoc cref="RayCast3D.AddExceptionRid(Rid)" />
    public void AddExceptionRid(Rid @rid) => ((RayCast3D)_host).AddExceptionRid(@rid);

    /// <inheritdoc cref="RayCast3D.AddException(CollisionObject3D)" />
    public void AddException(CollisionObject3D @node) => ((RayCast3D)_host).AddException(@node);

    /// <inheritdoc cref="RayCast3D.RemoveExceptionRid(Rid)" />
    public void RemoveExceptionRid(Rid @rid) => ((RayCast3D)_host).RemoveExceptionRid(@rid);

    /// <inheritdoc cref="RayCast3D.RemoveException(CollisionObject3D)" />
    public void RemoveException(CollisionObject3D @node) => ((RayCast3D)_host).RemoveException(@node);

    /// <inheritdoc cref="RayCast3D.ClearExceptions()" />
    public void ClearExceptions() => ((RayCast3D)_host).ClearExceptions();

    /// <inheritdoc cref="RayCast3D.SetCollisionMask(uint)" />
    public void SetCollisionMask(uint @mask) => ((RayCast3D)_host).SetCollisionMask(@mask);

    /// <inheritdoc cref="RayCast3D.GetCollisionMask()" />
    public uint GetCollisionMask() => ((RayCast3D)_host).GetCollisionMask();

    /// <inheritdoc cref="RayCast3D.SetCollisionMaskValue(int, bool)" />
    public void SetCollisionMaskValue(int @layerNumber, bool @value) => ((RayCast3D)_host).SetCollisionMaskValue(@layerNumber, @value);

    /// <inheritdoc cref="RayCast3D.GetCollisionMaskValue(int)" />
    public bool GetCollisionMaskValue(int @layerNumber) => ((RayCast3D)_host).GetCollisionMaskValue(@layerNumber);

    /// <inheritdoc cref="RayCast3D.SetExcludeParentBody(bool)" />
    public void SetExcludeParentBody(bool @mask) => ((RayCast3D)_host).SetExcludeParentBody(@mask);

    /// <inheritdoc cref="RayCast3D.GetExcludeParentBody()" />
    public bool GetExcludeParentBody() => ((RayCast3D)_host).GetExcludeParentBody();

    /// <inheritdoc cref="RayCast3D.SetCollideWithAreas(bool)" />
    public void SetCollideWithAreas(bool @enable) => ((RayCast3D)_host).SetCollideWithAreas(@enable);

    /// <inheritdoc cref="RayCast3D.IsCollideWithAreasEnabled()" />
    public bool IsCollideWithAreasEnabled() => ((RayCast3D)_host).IsCollideWithAreasEnabled();

    /// <inheritdoc cref="RayCast3D.SetCollideWithBodies(bool)" />
    public void SetCollideWithBodies(bool @enable) => ((RayCast3D)_host).SetCollideWithBodies(@enable);

    /// <inheritdoc cref="RayCast3D.IsCollideWithBodiesEnabled()" />
    public bool IsCollideWithBodiesEnabled() => ((RayCast3D)_host).IsCollideWithBodiesEnabled();

    /// <inheritdoc cref="RayCast3D.SetHitFromInside(bool)" />
    public void SetHitFromInside(bool @enable) => ((RayCast3D)_host).SetHitFromInside(@enable);

    /// <inheritdoc cref="RayCast3D.IsHitFromInsideEnabled()" />
    public bool IsHitFromInsideEnabled() => ((RayCast3D)_host).IsHitFromInsideEnabled();

    /// <inheritdoc cref="RayCast3D.SetHitBackFaces(bool)" />
    public void SetHitBackFaces(bool @enable) => ((RayCast3D)_host).SetHitBackFaces(@enable);

    /// <inheritdoc cref="RayCast3D.IsHitBackFacesEnabled()" />
    public bool IsHitBackFacesEnabled() => ((RayCast3D)_host).IsHitBackFacesEnabled();

    /// <inheritdoc cref="RayCast3D.SetDebugShapeCustomColor(Color)" />
    public void SetDebugShapeCustomColor(Color @debugShapeCustomColor) => ((RayCast3D)_host).SetDebugShapeCustomColor(@debugShapeCustomColor);

    /// <inheritdoc cref="RayCast3D.GetDebugShapeCustomColor()" />
    public Color GetDebugShapeCustomColor() => ((RayCast3D)_host).GetDebugShapeCustomColor();

    /// <inheritdoc cref="RayCast3D.SetDebugShapeThickness(int)" />
    public void SetDebugShapeThickness(int @debugShapeThickness) => ((RayCast3D)_host).SetDebugShapeThickness(@debugShapeThickness);

    /// <inheritdoc cref="RayCast3D.GetDebugShapeThickness()" />
    public int GetDebugShapeThickness() => ((RayCast3D)_host).GetDebugShapeThickness();

}
