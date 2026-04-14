#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="NavigationRegion3D" />
[Tool, GlobalClass]
public abstract partial class NavigationRegion3DComponent : Node3DComponent
{

    /// <inheritdoc cref="NavigationRegion3D.GetRid()" />
    public Rid GetRid() => ((NavigationRegion3D)_host).GetRid();

    /// <inheritdoc cref="NavigationRegion3D.SetNavigationMesh(NavigationMesh)" />
    public void SetNavigationMesh(NavigationMesh @navigationMesh) => ((NavigationRegion3D)_host).SetNavigationMesh(@navigationMesh);

    /// <inheritdoc cref="NavigationRegion3D.GetNavigationMesh()" />
    public NavigationMesh GetNavigationMesh() => ((NavigationRegion3D)_host).GetNavigationMesh();

    /// <inheritdoc cref="NavigationRegion3D.SetEnabled(bool)" />
    public void SetEnabled(bool @enabled) => ((NavigationRegion3D)_host).SetEnabled(@enabled);

    /// <inheritdoc cref="NavigationRegion3D.IsEnabled()" />
    public bool IsEnabled() => ((NavigationRegion3D)_host).IsEnabled();

    /// <inheritdoc cref="NavigationRegion3D.SetNavigationMap(Rid)" />
    public void SetNavigationMap(Rid @navigationMap) => ((NavigationRegion3D)_host).SetNavigationMap(@navigationMap);

    /// <inheritdoc cref="NavigationRegion3D.GetNavigationMap()" />
    public Rid GetNavigationMap() => ((NavigationRegion3D)_host).GetNavigationMap();

    /// <inheritdoc cref="NavigationRegion3D.SetUseEdgeConnections(bool)" />
    public void SetUseEdgeConnections(bool @enabled) => ((NavigationRegion3D)_host).SetUseEdgeConnections(@enabled);

    /// <inheritdoc cref="NavigationRegion3D.GetUseEdgeConnections()" />
    public bool GetUseEdgeConnections() => ((NavigationRegion3D)_host).GetUseEdgeConnections();

    /// <inheritdoc cref="NavigationRegion3D.SetNavigationLayers(uint)" />
    public void SetNavigationLayers(uint @navigationLayers) => ((NavigationRegion3D)_host).SetNavigationLayers(@navigationLayers);

    /// <inheritdoc cref="NavigationRegion3D.GetNavigationLayers()" />
    public uint GetNavigationLayers() => ((NavigationRegion3D)_host).GetNavigationLayers();

    /// <inheritdoc cref="NavigationRegion3D.SetNavigationLayerValue(int, bool)" />
    public void SetNavigationLayerValue(int @layerNumber, bool @value) => ((NavigationRegion3D)_host).SetNavigationLayerValue(@layerNumber, @value);

    /// <inheritdoc cref="NavigationRegion3D.GetNavigationLayerValue(int)" />
    public bool GetNavigationLayerValue(int @layerNumber) => ((NavigationRegion3D)_host).GetNavigationLayerValue(@layerNumber);

    /// <inheritdoc cref="NavigationRegion3D.GetRegionRid()" />
    public Rid GetRegionRid() => ((NavigationRegion3D)_host).GetRegionRid();

    /// <inheritdoc cref="NavigationRegion3D.SetEnterCost(float)" />
    public void SetEnterCost(float @enterCost) => ((NavigationRegion3D)_host).SetEnterCost(@enterCost);

    /// <inheritdoc cref="NavigationRegion3D.GetEnterCost()" />
    public float GetEnterCost() => ((NavigationRegion3D)_host).GetEnterCost();

    /// <inheritdoc cref="NavigationRegion3D.SetTravelCost(float)" />
    public void SetTravelCost(float @travelCost) => ((NavigationRegion3D)_host).SetTravelCost(@travelCost);

    /// <inheritdoc cref="NavigationRegion3D.GetTravelCost()" />
    public float GetTravelCost() => ((NavigationRegion3D)_host).GetTravelCost();

    /// <inheritdoc cref="NavigationRegion3D.BakeNavigationMesh(bool)" />
    public void BakeNavigationMesh(bool @onThread) => ((NavigationRegion3D)_host).BakeNavigationMesh(@onThread);

    /// <inheritdoc cref="NavigationRegion3D.IsBaking()" />
    public bool IsBaking() => ((NavigationRegion3D)_host).IsBaking();

    /// <inheritdoc cref="NavigationRegion3D.GetBounds()" />
    public Aabb GetBounds() => ((NavigationRegion3D)_host).GetBounds();

}
