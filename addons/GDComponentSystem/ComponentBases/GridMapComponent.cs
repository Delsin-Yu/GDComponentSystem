#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GridMap" />
[Tool, GlobalClass]
public abstract partial class GridMapComponent : Node3DComponent
{

    /// <inheritdoc cref="GridMap.SetCollisionLayer(uint)" />
    public void SetCollisionLayer(uint @layer) => ((GridMap)_host).SetCollisionLayer(@layer);

    /// <inheritdoc cref="GridMap.GetCollisionLayer()" />
    public uint GetCollisionLayer() => ((GridMap)_host).GetCollisionLayer();

    /// <inheritdoc cref="GridMap.SetCollisionMask(uint)" />
    public void SetCollisionMask(uint @mask) => ((GridMap)_host).SetCollisionMask(@mask);

    /// <inheritdoc cref="GridMap.GetCollisionMask()" />
    public uint GetCollisionMask() => ((GridMap)_host).GetCollisionMask();

    /// <inheritdoc cref="GridMap.SetCollisionMaskValue(int, bool)" />
    public void SetCollisionMaskValue(int @layerNumber, bool @value) => ((GridMap)_host).SetCollisionMaskValue(@layerNumber, @value);

    /// <inheritdoc cref="GridMap.GetCollisionMaskValue(int)" />
    public bool GetCollisionMaskValue(int @layerNumber) => ((GridMap)_host).GetCollisionMaskValue(@layerNumber);

    /// <inheritdoc cref="GridMap.SetCollisionLayerValue(int, bool)" />
    public void SetCollisionLayerValue(int @layerNumber, bool @value) => ((GridMap)_host).SetCollisionLayerValue(@layerNumber, @value);

    /// <inheritdoc cref="GridMap.GetCollisionLayerValue(int)" />
    public bool GetCollisionLayerValue(int @layerNumber) => ((GridMap)_host).GetCollisionLayerValue(@layerNumber);

    /// <inheritdoc cref="GridMap.SetCollisionPriority(float)" />
    public void SetCollisionPriority(float @priority) => ((GridMap)_host).SetCollisionPriority(@priority);

    /// <inheritdoc cref="GridMap.GetCollisionPriority()" />
    public float GetCollisionPriority() => ((GridMap)_host).GetCollisionPriority();

    /// <inheritdoc cref="GridMap.SetPhysicsMaterial(PhysicsMaterial)" />
    public void SetPhysicsMaterial(PhysicsMaterial @material) => ((GridMap)_host).SetPhysicsMaterial(@material);

    /// <inheritdoc cref="GridMap.GetPhysicsMaterial()" />
    public PhysicsMaterial GetPhysicsMaterial() => ((GridMap)_host).GetPhysicsMaterial();

    /// <inheritdoc cref="GridMap.SetBakeNavigation(bool)" />
    public void SetBakeNavigation(bool @bakeNavigation) => ((GridMap)_host).SetBakeNavigation(@bakeNavigation);

    /// <inheritdoc cref="GridMap.IsBakingNavigation()" />
    public bool IsBakingNavigation() => ((GridMap)_host).IsBakingNavigation();

    /// <inheritdoc cref="GridMap.SetNavigationMap(Rid)" />
    public void SetNavigationMap(Rid @navigationMap) => ((GridMap)_host).SetNavigationMap(@navigationMap);

    /// <inheritdoc cref="GridMap.GetNavigationMap()" />
    public Rid GetNavigationMap() => ((GridMap)_host).GetNavigationMap();

    /// <inheritdoc cref="GridMap.SetMeshLibrary(MeshLibrary)" />
    public void SetMeshLibrary(MeshLibrary @meshLibrary) => ((GridMap)_host).SetMeshLibrary(@meshLibrary);

    /// <inheritdoc cref="GridMap.GetMeshLibrary()" />
    public MeshLibrary GetMeshLibrary() => ((GridMap)_host).GetMeshLibrary();

    /// <inheritdoc cref="GridMap.SetCellSize(Vector3)" />
    public void SetCellSize(Vector3 @size) => ((GridMap)_host).SetCellSize(@size);

    /// <inheritdoc cref="GridMap.GetCellSize()" />
    public Vector3 GetCellSize() => ((GridMap)_host).GetCellSize();

    /// <inheritdoc cref="GridMap.SetCellScale(float)" />
    public void SetCellScale(float @scale) => ((GridMap)_host).SetCellScale(@scale);

    /// <inheritdoc cref="GridMap.GetCellScale()" />
    public float GetCellScale() => ((GridMap)_host).GetCellScale();

    /// <inheritdoc cref="GridMap.SetOctantSize(int)" />
    public void SetOctantSize(int @size) => ((GridMap)_host).SetOctantSize(@size);

    /// <inheritdoc cref="GridMap.GetOctantSize()" />
    public int GetOctantSize() => ((GridMap)_host).GetOctantSize();

    /// <inheritdoc cref="GridMap.SetCellItem(Vector3I, int, int)" />
    public void SetCellItem(Vector3I @position, int @item, int @orientation) => ((GridMap)_host).SetCellItem(@position, @item, @orientation);

    /// <inheritdoc cref="GridMap.GetCellItem(Vector3I)" />
    public int GetCellItem(Vector3I @position) => ((GridMap)_host).GetCellItem(@position);

    /// <inheritdoc cref="GridMap.GetCellItemOrientation(Vector3I)" />
    public int GetCellItemOrientation(Vector3I @position) => ((GridMap)_host).GetCellItemOrientation(@position);

    /// <inheritdoc cref="GridMap.GetCellItemBasis(Vector3I)" />
    public Basis GetCellItemBasis(Vector3I @position) => ((GridMap)_host).GetCellItemBasis(@position);

    /// <inheritdoc cref="GridMap.GetBasisWithOrthogonalIndex(int)" />
    public Basis GetBasisWithOrthogonalIndex(int @index) => ((GridMap)_host).GetBasisWithOrthogonalIndex(@index);

    /// <inheritdoc cref="GridMap.GetOrthogonalIndexFromBasis(Basis)" />
    public int GetOrthogonalIndexFromBasis(Basis @basis) => ((GridMap)_host).GetOrthogonalIndexFromBasis(@basis);

    /// <inheritdoc cref="GridMap.LocalToMap(Vector3)" />
    public Vector3I LocalToMap(Vector3 @localPosition) => ((GridMap)_host).LocalToMap(@localPosition);

    /// <inheritdoc cref="GridMap.MapToLocal(Vector3I)" />
    public Vector3 MapToLocal(Vector3I @mapPosition) => ((GridMap)_host).MapToLocal(@mapPosition);

    /// <inheritdoc cref="GridMap.ResourceChanged(Resource)" />
    public void ResourceChanged(Resource @resource) => ((GridMap)_host).ResourceChanged(@resource);

    /// <inheritdoc cref="GridMap.SetCenterX(bool)" />
    public void SetCenterX(bool @enable) => ((GridMap)_host).SetCenterX(@enable);

    /// <inheritdoc cref="GridMap.GetCenterX()" />
    public bool GetCenterX() => ((GridMap)_host).GetCenterX();

    /// <inheritdoc cref="GridMap.SetCenterY(bool)" />
    public void SetCenterY(bool @enable) => ((GridMap)_host).SetCenterY(@enable);

    /// <inheritdoc cref="GridMap.GetCenterY()" />
    public bool GetCenterY() => ((GridMap)_host).GetCenterY();

    /// <inheritdoc cref="GridMap.SetCenterZ(bool)" />
    public void SetCenterZ(bool @enable) => ((GridMap)_host).SetCenterZ(@enable);

    /// <inheritdoc cref="GridMap.GetCenterZ()" />
    public bool GetCenterZ() => ((GridMap)_host).GetCenterZ();

    /// <inheritdoc cref="GridMap.Clear()" />
    public void Clear() => ((GridMap)_host).Clear();

    /// <inheritdoc cref="GridMap.GetUsedCells()" />
    public Array<Vector3I> GetUsedCells() => ((GridMap)_host).GetUsedCells();

    /// <inheritdoc cref="GridMap.GetUsedCellsByItem(int)" />
    public Array<Vector3I> GetUsedCellsByItem(int @item) => ((GridMap)_host).GetUsedCellsByItem(@item);

    /// <inheritdoc cref="GridMap.GetMeshes()" />
    public Array GetMeshes() => ((GridMap)_host).GetMeshes();

    /// <inheritdoc cref="GridMap.GetBakeMeshes()" />
    public Array GetBakeMeshes() => ((GridMap)_host).GetBakeMeshes();

    /// <inheritdoc cref="GridMap.GetBakeMeshInstance(int)" />
    public Rid GetBakeMeshInstance(int @idx) => ((GridMap)_host).GetBakeMeshInstance(@idx);

    /// <inheritdoc cref="GridMap.ClearBakedMeshes()" />
    public void ClearBakedMeshes() => ((GridMap)_host).ClearBakedMeshes();

    /// <inheritdoc cref="GridMap.MakeBakedMeshes(bool, float)" />
    public void MakeBakedMeshes(bool @genLightmapUV, float @lightmapUVTexelSize) => ((GridMap)_host).MakeBakedMeshes(@genLightmapUV, @lightmapUVTexelSize);

}
