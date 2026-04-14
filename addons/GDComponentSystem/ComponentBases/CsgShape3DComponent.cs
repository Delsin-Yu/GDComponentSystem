#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CsgShape3D" />
[Tool, GlobalClass]
public abstract partial class CsgShape3DComponent : GeometryInstance3DComponent
{

    /// <inheritdoc cref="CsgShape3D.IsRootShape()" />
    public bool IsRootShape() => ((CsgShape3D)_host).IsRootShape();

    /// <inheritdoc cref="CsgShape3D.SetOperation(CsgShape3D.OperationEnum)" />
    public void SetOperation(CsgShape3D.OperationEnum @operation) => ((CsgShape3D)_host).SetOperation(@operation);

    /// <inheritdoc cref="CsgShape3D.GetOperation()" />
    public CsgShape3D.OperationEnum GetOperation() => ((CsgShape3D)_host).GetOperation();

    /// <inheritdoc cref="CsgShape3D.SetSnap(float)" />
    public void SetSnap(float @snap) => ((CsgShape3D)_host).SetSnap(@snap);

    /// <inheritdoc cref="CsgShape3D.GetSnap()" />
    public float GetSnap() => ((CsgShape3D)_host).GetSnap();

    /// <inheritdoc cref="CsgShape3D.SetUseCollision(bool)" />
    public void SetUseCollision(bool @operation) => ((CsgShape3D)_host).SetUseCollision(@operation);

    /// <inheritdoc cref="CsgShape3D.IsUsingCollision()" />
    public bool IsUsingCollision() => ((CsgShape3D)_host).IsUsingCollision();

    /// <inheritdoc cref="CsgShape3D.SetCollisionLayer(uint)" />
    public void SetCollisionLayer(uint @layer) => ((CsgShape3D)_host).SetCollisionLayer(@layer);

    /// <inheritdoc cref="CsgShape3D.GetCollisionLayer()" />
    public uint GetCollisionLayer() => ((CsgShape3D)_host).GetCollisionLayer();

    /// <inheritdoc cref="CsgShape3D.SetCollisionMask(uint)" />
    public void SetCollisionMask(uint @mask) => ((CsgShape3D)_host).SetCollisionMask(@mask);

    /// <inheritdoc cref="CsgShape3D.GetCollisionMask()" />
    public uint GetCollisionMask() => ((CsgShape3D)_host).GetCollisionMask();

    /// <inheritdoc cref="CsgShape3D.SetCollisionMaskValue(int, bool)" />
    public void SetCollisionMaskValue(int @layerNumber, bool @value) => ((CsgShape3D)_host).SetCollisionMaskValue(@layerNumber, @value);

    /// <inheritdoc cref="CsgShape3D.GetCollisionMaskValue(int)" />
    public bool GetCollisionMaskValue(int @layerNumber) => ((CsgShape3D)_host).GetCollisionMaskValue(@layerNumber);

    /// <inheritdoc cref="CsgShape3D.SetCollisionLayerValue(int, bool)" />
    public void SetCollisionLayerValue(int @layerNumber, bool @value) => ((CsgShape3D)_host).SetCollisionLayerValue(@layerNumber, @value);

    /// <inheritdoc cref="CsgShape3D.GetCollisionLayerValue(int)" />
    public bool GetCollisionLayerValue(int @layerNumber) => ((CsgShape3D)_host).GetCollisionLayerValue(@layerNumber);

    /// <inheritdoc cref="CsgShape3D.SetCollisionPriority(float)" />
    public void SetCollisionPriority(float @priority) => ((CsgShape3D)_host).SetCollisionPriority(@priority);

    /// <inheritdoc cref="CsgShape3D.GetCollisionPriority()" />
    public float GetCollisionPriority() => ((CsgShape3D)_host).GetCollisionPriority();

    /// <inheritdoc cref="CsgShape3D.BakeCollisionShape()" />
    public ConcavePolygonShape3D BakeCollisionShape() => ((CsgShape3D)_host).BakeCollisionShape();

    /// <inheritdoc cref="CsgShape3D.SetCalculateTangents(bool)" />
    public void SetCalculateTangents(bool @enabled) => ((CsgShape3D)_host).SetCalculateTangents(@enabled);

    /// <inheritdoc cref="CsgShape3D.IsCalculatingTangents()" />
    public bool IsCalculatingTangents() => ((CsgShape3D)_host).IsCalculatingTangents();

    /// <inheritdoc cref="CsgShape3D.GetMeshes()" />
    public Array GetMeshes() => ((CsgShape3D)_host).GetMeshes();

    /// <inheritdoc cref="CsgShape3D.BakeStaticMesh()" />
    public ArrayMesh BakeStaticMesh() => ((CsgShape3D)_host).BakeStaticMesh();

}
