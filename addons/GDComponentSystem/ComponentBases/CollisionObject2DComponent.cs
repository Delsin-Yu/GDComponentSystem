#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CollisionObject2D" />
[Tool, GlobalClass]
public abstract partial class CollisionObject2DComponent : Node2DComponent
{

    /// <inheritdoc cref="CollisionObject2D._InputEvent(Viewport, InputEvent, int)" />
    public virtual void _InputEvent(Viewport @viewport, InputEvent @event, int @shapeIdx) { }

    /// <inheritdoc cref="CollisionObject2D._MouseEnter()" />
    public virtual void _MouseEnter() { }

    /// <inheritdoc cref="CollisionObject2D._MouseExit()" />
    public virtual void _MouseExit() { }

    /// <inheritdoc cref="CollisionObject2D._MouseShapeEnter(int)" />
    public virtual void _MouseShapeEnter(int @shapeIdx) { }

    /// <inheritdoc cref="CollisionObject2D._MouseShapeExit(int)" />
    public virtual void _MouseShapeExit(int @shapeIdx) { }

    /// <inheritdoc cref="CollisionObject2D.GetRid()" />
    public Rid GetRid() => ((CollisionObject2D)_host).GetRid();

    /// <inheritdoc cref="CollisionObject2D.SetCollisionLayer(uint)" />
    public void SetCollisionLayer(uint @layer) => ((CollisionObject2D)_host).SetCollisionLayer(@layer);

    /// <inheritdoc cref="CollisionObject2D.GetCollisionLayer()" />
    public uint GetCollisionLayer() => ((CollisionObject2D)_host).GetCollisionLayer();

    /// <inheritdoc cref="CollisionObject2D.SetCollisionMask(uint)" />
    public void SetCollisionMask(uint @mask) => ((CollisionObject2D)_host).SetCollisionMask(@mask);

    /// <inheritdoc cref="CollisionObject2D.GetCollisionMask()" />
    public uint GetCollisionMask() => ((CollisionObject2D)_host).GetCollisionMask();

    /// <inheritdoc cref="CollisionObject2D.SetCollisionLayerValue(int, bool)" />
    public void SetCollisionLayerValue(int @layerNumber, bool @value) => ((CollisionObject2D)_host).SetCollisionLayerValue(@layerNumber, @value);

    /// <inheritdoc cref="CollisionObject2D.GetCollisionLayerValue(int)" />
    public bool GetCollisionLayerValue(int @layerNumber) => ((CollisionObject2D)_host).GetCollisionLayerValue(@layerNumber);

    /// <inheritdoc cref="CollisionObject2D.SetCollisionMaskValue(int, bool)" />
    public void SetCollisionMaskValue(int @layerNumber, bool @value) => ((CollisionObject2D)_host).SetCollisionMaskValue(@layerNumber, @value);

    /// <inheritdoc cref="CollisionObject2D.GetCollisionMaskValue(int)" />
    public bool GetCollisionMaskValue(int @layerNumber) => ((CollisionObject2D)_host).GetCollisionMaskValue(@layerNumber);

    /// <inheritdoc cref="CollisionObject2D.SetCollisionPriority(float)" />
    public void SetCollisionPriority(float @priority) => ((CollisionObject2D)_host).SetCollisionPriority(@priority);

    /// <inheritdoc cref="CollisionObject2D.GetCollisionPriority()" />
    public float GetCollisionPriority() => ((CollisionObject2D)_host).GetCollisionPriority();

    /// <inheritdoc cref="CollisionObject2D.SetDisableMode(CollisionObject2D.DisableModeEnum)" />
    public void SetDisableMode(CollisionObject2D.DisableModeEnum @mode) => ((CollisionObject2D)_host).SetDisableMode(@mode);

    /// <inheritdoc cref="CollisionObject2D.GetDisableMode()" />
    public CollisionObject2D.DisableModeEnum GetDisableMode() => ((CollisionObject2D)_host).GetDisableMode();

    /// <inheritdoc cref="CollisionObject2D.SetPickable(bool)" />
    public void SetPickable(bool @enabled) => ((CollisionObject2D)_host).SetPickable(@enabled);

    /// <inheritdoc cref="CollisionObject2D.IsPickable()" />
    public bool IsPickable() => ((CollisionObject2D)_host).IsPickable();

    /// <inheritdoc cref="CollisionObject2D.CreateShapeOwner(GodotObject)" />
    public uint CreateShapeOwner(GodotObject @owner) => ((CollisionObject2D)_host).CreateShapeOwner(@owner);

    /// <inheritdoc cref="CollisionObject2D.RemoveShapeOwner(uint)" />
    public void RemoveShapeOwner(uint @ownerId) => ((CollisionObject2D)_host).RemoveShapeOwner(@ownerId);

    /// <inheritdoc cref="CollisionObject2D.GetShapeOwners()" />
    public int[] GetShapeOwners() => ((CollisionObject2D)_host).GetShapeOwners();

    /// <inheritdoc cref="CollisionObject2D.ShapeOwnerSetTransform(uint, Transform2D)" />
    public void ShapeOwnerSetTransform(uint @ownerId, Transform2D @transform) => ((CollisionObject2D)_host).ShapeOwnerSetTransform(@ownerId, @transform);

    /// <inheritdoc cref="CollisionObject2D.ShapeOwnerGetTransform(uint)" />
    public Transform2D ShapeOwnerGetTransform(uint @ownerId) => ((CollisionObject2D)_host).ShapeOwnerGetTransform(@ownerId);

    /// <inheritdoc cref="CollisionObject2D.ShapeOwnerGetOwner(uint)" />
    public GodotObject ShapeOwnerGetOwner(uint @ownerId) => ((CollisionObject2D)_host).ShapeOwnerGetOwner(@ownerId);

    /// <inheritdoc cref="CollisionObject2D.ShapeOwnerSetDisabled(uint, bool)" />
    public void ShapeOwnerSetDisabled(uint @ownerId, bool @disabled) => ((CollisionObject2D)_host).ShapeOwnerSetDisabled(@ownerId, @disabled);

    /// <inheritdoc cref="CollisionObject2D.IsShapeOwnerDisabled(uint)" />
    public bool IsShapeOwnerDisabled(uint @ownerId) => ((CollisionObject2D)_host).IsShapeOwnerDisabled(@ownerId);

    /// <inheritdoc cref="CollisionObject2D.ShapeOwnerSetOneWayCollision(uint, bool)" />
    public void ShapeOwnerSetOneWayCollision(uint @ownerId, bool @enable) => ((CollisionObject2D)_host).ShapeOwnerSetOneWayCollision(@ownerId, @enable);

    /// <inheritdoc cref="CollisionObject2D.IsShapeOwnerOneWayCollisionEnabled(uint)" />
    public bool IsShapeOwnerOneWayCollisionEnabled(uint @ownerId) => ((CollisionObject2D)_host).IsShapeOwnerOneWayCollisionEnabled(@ownerId);

    /// <inheritdoc cref="CollisionObject2D.ShapeOwnerSetOneWayCollisionMargin(uint, float)" />
    public void ShapeOwnerSetOneWayCollisionMargin(uint @ownerId, float @margin) => ((CollisionObject2D)_host).ShapeOwnerSetOneWayCollisionMargin(@ownerId, @margin);

    /// <inheritdoc cref="CollisionObject2D.GetShapeOwnerOneWayCollisionMargin(uint)" />
    public float GetShapeOwnerOneWayCollisionMargin(uint @ownerId) => ((CollisionObject2D)_host).GetShapeOwnerOneWayCollisionMargin(@ownerId);

    /// <inheritdoc cref="CollisionObject2D.ShapeOwnerAddShape(uint, Shape2D)" />
    public void ShapeOwnerAddShape(uint @ownerId, Shape2D @shape) => ((CollisionObject2D)_host).ShapeOwnerAddShape(@ownerId, @shape);

    /// <inheritdoc cref="CollisionObject2D.ShapeOwnerGetShapeCount(uint)" />
    public int ShapeOwnerGetShapeCount(uint @ownerId) => ((CollisionObject2D)_host).ShapeOwnerGetShapeCount(@ownerId);

    /// <inheritdoc cref="CollisionObject2D.ShapeOwnerGetShape(uint, int)" />
    public Shape2D ShapeOwnerGetShape(uint @ownerId, int @shapeId) => ((CollisionObject2D)_host).ShapeOwnerGetShape(@ownerId, @shapeId);

    /// <inheritdoc cref="CollisionObject2D.ShapeOwnerGetShapeIndex(uint, int)" />
    public int ShapeOwnerGetShapeIndex(uint @ownerId, int @shapeId) => ((CollisionObject2D)_host).ShapeOwnerGetShapeIndex(@ownerId, @shapeId);

    /// <inheritdoc cref="CollisionObject2D.ShapeOwnerRemoveShape(uint, int)" />
    public void ShapeOwnerRemoveShape(uint @ownerId, int @shapeId) => ((CollisionObject2D)_host).ShapeOwnerRemoveShape(@ownerId, @shapeId);

    /// <inheritdoc cref="CollisionObject2D.ShapeOwnerClearShapes(uint)" />
    public void ShapeOwnerClearShapes(uint @ownerId) => ((CollisionObject2D)_host).ShapeOwnerClearShapes(@ownerId);

    /// <inheritdoc cref="CollisionObject2D.ShapeFindOwner(int)" />
    public uint ShapeFindOwner(int @shapeIndex) => ((CollisionObject2D)_host).ShapeFindOwner(@shapeIndex);

}
