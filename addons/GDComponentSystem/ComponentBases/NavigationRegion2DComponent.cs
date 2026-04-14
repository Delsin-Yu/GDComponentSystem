#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="NavigationRegion2D" />
[Tool, GlobalClass]
public abstract partial class NavigationRegion2DComponent : Node2DComponent
{

    /// <inheritdoc cref="NavigationRegion2D.GetRid()" />
    public Rid GetRid() => ((NavigationRegion2D)_host).GetRid();

    /// <inheritdoc cref="NavigationRegion2D.SetNavigationPolygon(NavigationPolygon)" />
    public void SetNavigationPolygon(NavigationPolygon @navigationPolygon) => ((NavigationRegion2D)_host).SetNavigationPolygon(@navigationPolygon);

    /// <inheritdoc cref="NavigationRegion2D.GetNavigationPolygon()" />
    public NavigationPolygon GetNavigationPolygon() => ((NavigationRegion2D)_host).GetNavigationPolygon();

    /// <inheritdoc cref="NavigationRegion2D.SetEnabled(bool)" />
    public void SetEnabled(bool @enabled) => ((NavigationRegion2D)_host).SetEnabled(@enabled);

    /// <inheritdoc cref="NavigationRegion2D.IsEnabled()" />
    public bool IsEnabled() => ((NavigationRegion2D)_host).IsEnabled();

    /// <inheritdoc cref="NavigationRegion2D.SetNavigationMap(Rid)" />
    public void SetNavigationMap(Rid @navigationMap) => ((NavigationRegion2D)_host).SetNavigationMap(@navigationMap);

    /// <inheritdoc cref="NavigationRegion2D.GetNavigationMap()" />
    public Rid GetNavigationMap() => ((NavigationRegion2D)_host).GetNavigationMap();

    /// <inheritdoc cref="NavigationRegion2D.SetUseEdgeConnections(bool)" />
    public void SetUseEdgeConnections(bool @enabled) => ((NavigationRegion2D)_host).SetUseEdgeConnections(@enabled);

    /// <inheritdoc cref="NavigationRegion2D.GetUseEdgeConnections()" />
    public bool GetUseEdgeConnections() => ((NavigationRegion2D)_host).GetUseEdgeConnections();

    /// <inheritdoc cref="NavigationRegion2D.SetNavigationLayers(uint)" />
    public void SetNavigationLayers(uint @navigationLayers) => ((NavigationRegion2D)_host).SetNavigationLayers(@navigationLayers);

    /// <inheritdoc cref="NavigationRegion2D.GetNavigationLayers()" />
    public uint GetNavigationLayers() => ((NavigationRegion2D)_host).GetNavigationLayers();

    /// <inheritdoc cref="NavigationRegion2D.SetNavigationLayerValue(int, bool)" />
    public void SetNavigationLayerValue(int @layerNumber, bool @value) => ((NavigationRegion2D)_host).SetNavigationLayerValue(@layerNumber, @value);

    /// <inheritdoc cref="NavigationRegion2D.GetNavigationLayerValue(int)" />
    public bool GetNavigationLayerValue(int @layerNumber) => ((NavigationRegion2D)_host).GetNavigationLayerValue(@layerNumber);

    /// <inheritdoc cref="NavigationRegion2D.GetRegionRid()" />
    public Rid GetRegionRid() => ((NavigationRegion2D)_host).GetRegionRid();

    /// <inheritdoc cref="NavigationRegion2D.SetEnterCost(float)" />
    public void SetEnterCost(float @enterCost) => ((NavigationRegion2D)_host).SetEnterCost(@enterCost);

    /// <inheritdoc cref="NavigationRegion2D.GetEnterCost()" />
    public float GetEnterCost() => ((NavigationRegion2D)_host).GetEnterCost();

    /// <inheritdoc cref="NavigationRegion2D.SetTravelCost(float)" />
    public void SetTravelCost(float @travelCost) => ((NavigationRegion2D)_host).SetTravelCost(@travelCost);

    /// <inheritdoc cref="NavigationRegion2D.GetTravelCost()" />
    public float GetTravelCost() => ((NavigationRegion2D)_host).GetTravelCost();

    /// <inheritdoc cref="NavigationRegion2D.BakeNavigationPolygon(bool)" />
    public void BakeNavigationPolygon(bool @onThread) => ((NavigationRegion2D)_host).BakeNavigationPolygon(@onThread);

    /// <inheritdoc cref="NavigationRegion2D.IsBaking()" />
    public bool IsBaking() => ((NavigationRegion2D)_host).IsBaking();

    /// <inheritdoc cref="NavigationRegion2D.GetBounds()" />
    public Rect2 GetBounds() => ((NavigationRegion2D)_host).GetBounds();

}
