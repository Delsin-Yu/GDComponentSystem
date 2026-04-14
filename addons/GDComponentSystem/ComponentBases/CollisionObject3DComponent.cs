#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CollisionObject3D" />
[Tool, GlobalClass]
public abstract partial class CollisionObject3DComponent : Node3DComponent
{

    /// <inheritdoc cref="CollisionObject3D._InputEvent(Camera3D, InputEvent, Vector3, Vector3, int)" />
    public virtual void _InputEvent(Camera3D @camera, InputEvent @event, Vector3 @eventPosition, Vector3 @normal, int @shapeIdx) { }

    /// <inheritdoc cref="CollisionObject3D._MouseEnter()" />
    public virtual void _MouseEnter() { }

    /// <inheritdoc cref="CollisionObject3D._MouseExit()" />
    public virtual void _MouseExit() { }

    /// <inheritdoc cref="CollisionObject3D.SetCollisionLayer(uint)" />
    public void SetCollisionLayer(uint @layer) => ((CollisionObject3D)_host).SetCollisionLayer(@layer);

    /// <inheritdoc cref="CollisionObject3D.GetCollisionLayer()" />
    public uint GetCollisionLayer() => ((CollisionObject3D)_host).GetCollisionLayer();

    /// <inheritdoc cref="CollisionObject3D.SetCollisionMask(uint)" />
    public void SetCollisionMask(uint @mask) => ((CollisionObject3D)_host).SetCollisionMask(@mask);

    /// <inheritdoc cref="CollisionObject3D.GetCollisionMask()" />
    public uint GetCollisionMask() => ((CollisionObject3D)_host).GetCollisionMask();

    /// <inheritdoc cref="CollisionObject3D.SetCollisionLayerValue(int, bool)" />
    public void SetCollisionLayerValue(int @layerNumber, bool @value) => ((CollisionObject3D)_host).SetCollisionLayerValue(@layerNumber, @value);

    /// <inheritdoc cref="CollisionObject3D.GetCollisionLayerValue(int)" />
    public bool GetCollisionLayerValue(int @layerNumber) => ((CollisionObject3D)_host).GetCollisionLayerValue(@layerNumber);

    /// <inheritdoc cref="CollisionObject3D.SetCollisionMaskValue(int, bool)" />
    public void SetCollisionMaskValue(int @layerNumber, bool @value) => ((CollisionObject3D)_host).SetCollisionMaskValue(@layerNumber, @value);

    /// <inheritdoc cref="CollisionObject3D.GetCollisionMaskValue(int)" />
    public bool GetCollisionMaskValue(int @layerNumber) => ((CollisionObject3D)_host).GetCollisionMaskValue(@layerNumber);

    /// <inheritdoc cref="CollisionObject3D.SetCollisionPriority(float)" />
    public void SetCollisionPriority(float @priority) => ((CollisionObject3D)_host).SetCollisionPriority(@priority);

    /// <inheritdoc cref="CollisionObject3D.GetCollisionPriority()" />
    public float GetCollisionPriority() => ((CollisionObject3D)_host).GetCollisionPriority();

    /// <inheritdoc cref="CollisionObject3D.SetDisableMode(CollisionObject3D.DisableModeEnum)" />
    public void SetDisableMode(CollisionObject3D.DisableModeEnum @mode) => ((CollisionObject3D)_host).SetDisableMode(@mode);

    /// <inheritdoc cref="CollisionObject3D.GetDisableMode()" />
    public CollisionObject3D.DisableModeEnum GetDisableMode() => ((CollisionObject3D)_host).GetDisableMode();

    /// <inheritdoc cref="CollisionObject3D.SetRayPickable(bool)" />
    public void SetRayPickable(bool @rayPickable) => ((CollisionObject3D)_host).SetRayPickable(@rayPickable);

    /// <inheritdoc cref="CollisionObject3D.IsRayPickable()" />
    public bool IsRayPickable() => ((CollisionObject3D)_host).IsRayPickable();

    /// <inheritdoc cref="CollisionObject3D.SetCaptureInputOnDrag(bool)" />
    public void SetCaptureInputOnDrag(bool @enable) => ((CollisionObject3D)_host).SetCaptureInputOnDrag(@enable);

    /// <inheritdoc cref="CollisionObject3D.GetCaptureInputOnDrag()" />
    public bool GetCaptureInputOnDrag() => ((CollisionObject3D)_host).GetCaptureInputOnDrag();

    /// <inheritdoc cref="CollisionObject3D.GetRid()" />
    public Rid GetRid() => ((CollisionObject3D)_host).GetRid();

    /// <inheritdoc cref="CollisionObject3D.CreateShapeOwner(GodotObject)" />
    public uint CreateShapeOwner(GodotObject @owner) => ((CollisionObject3D)_host).CreateShapeOwner(@owner);

    /// <inheritdoc cref="CollisionObject3D.RemoveShapeOwner(uint)" />
    public void RemoveShapeOwner(uint @ownerId) => ((CollisionObject3D)_host).RemoveShapeOwner(@ownerId);

    /// <inheritdoc cref="CollisionObject3D.GetShapeOwners()" />
    public int[] GetShapeOwners() => ((CollisionObject3D)_host).GetShapeOwners();

    /// <inheritdoc cref="CollisionObject3D.ShapeOwnerSetTransform(uint, Transform3D)" />
    public void ShapeOwnerSetTransform(uint @ownerId, Transform3D @transform) => ((CollisionObject3D)_host).ShapeOwnerSetTransform(@ownerId, @transform);

    /// <inheritdoc cref="CollisionObject3D.ShapeOwnerGetTransform(uint)" />
    public Transform3D ShapeOwnerGetTransform(uint @ownerId) => ((CollisionObject3D)_host).ShapeOwnerGetTransform(@ownerId);

    /// <inheritdoc cref="CollisionObject3D.ShapeOwnerGetOwner(uint)" />
    public GodotObject ShapeOwnerGetOwner(uint @ownerId) => ((CollisionObject3D)_host).ShapeOwnerGetOwner(@ownerId);

    /// <inheritdoc cref="CollisionObject3D.ShapeOwnerSetDisabled(uint, bool)" />
    public void ShapeOwnerSetDisabled(uint @ownerId, bool @disabled) => ((CollisionObject3D)_host).ShapeOwnerSetDisabled(@ownerId, @disabled);

    /// <inheritdoc cref="CollisionObject3D.IsShapeOwnerDisabled(uint)" />
    public bool IsShapeOwnerDisabled(uint @ownerId) => ((CollisionObject3D)_host).IsShapeOwnerDisabled(@ownerId);

    /// <inheritdoc cref="CollisionObject3D.ShapeOwnerAddShape(uint, Shape3D)" />
    public void ShapeOwnerAddShape(uint @ownerId, Shape3D @shape) => ((CollisionObject3D)_host).ShapeOwnerAddShape(@ownerId, @shape);

    /// <inheritdoc cref="CollisionObject3D.ShapeOwnerGetShapeCount(uint)" />
    public int ShapeOwnerGetShapeCount(uint @ownerId) => ((CollisionObject3D)_host).ShapeOwnerGetShapeCount(@ownerId);

    /// <inheritdoc cref="CollisionObject3D.ShapeOwnerGetShape(uint, int)" />
    public Shape3D ShapeOwnerGetShape(uint @ownerId, int @shapeId) => ((CollisionObject3D)_host).ShapeOwnerGetShape(@ownerId, @shapeId);

    /// <inheritdoc cref="CollisionObject3D.ShapeOwnerGetShapeIndex(uint, int)" />
    public int ShapeOwnerGetShapeIndex(uint @ownerId, int @shapeId) => ((CollisionObject3D)_host).ShapeOwnerGetShapeIndex(@ownerId, @shapeId);

    /// <inheritdoc cref="CollisionObject3D.ShapeOwnerRemoveShape(uint, int)" />
    public void ShapeOwnerRemoveShape(uint @ownerId, int @shapeId) => ((CollisionObject3D)_host).ShapeOwnerRemoveShape(@ownerId, @shapeId);

    /// <inheritdoc cref="CollisionObject3D.ShapeOwnerClearShapes(uint)" />
    public void ShapeOwnerClearShapes(uint @ownerId) => ((CollisionObject3D)_host).ShapeOwnerClearShapes(@ownerId);

    /// <inheritdoc cref="CollisionObject3D.ShapeFindOwner(int)" />
    public uint ShapeFindOwner(int @shapeIndex) => ((CollisionObject3D)_host).ShapeFindOwner(@shapeIndex);

}
