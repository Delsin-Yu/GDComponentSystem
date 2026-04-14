#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="NavigationLink2D" />
[Tool, GlobalClass]
public abstract partial class NavigationLink2DComponent : Node2DComponent
{

    /// <inheritdoc cref="NavigationLink2D.GetRid()" />
    public Rid GetRid() => ((NavigationLink2D)_host).GetRid();

    /// <inheritdoc cref="NavigationLink2D.SetEnabled(bool)" />
    public void SetEnabled(bool @enabled) => ((NavigationLink2D)_host).SetEnabled(@enabled);

    /// <inheritdoc cref="NavigationLink2D.IsEnabled()" />
    public bool IsEnabled() => ((NavigationLink2D)_host).IsEnabled();

    /// <inheritdoc cref="NavigationLink2D.SetNavigationMap(Rid)" />
    public void SetNavigationMap(Rid @navigationMap) => ((NavigationLink2D)_host).SetNavigationMap(@navigationMap);

    /// <inheritdoc cref="NavigationLink2D.GetNavigationMap()" />
    public Rid GetNavigationMap() => ((NavigationLink2D)_host).GetNavigationMap();

    /// <inheritdoc cref="NavigationLink2D.SetBidirectional(bool)" />
    public void SetBidirectional(bool @bidirectional) => ((NavigationLink2D)_host).SetBidirectional(@bidirectional);

    /// <inheritdoc cref="NavigationLink2D.IsBidirectional()" />
    public bool IsBidirectional() => ((NavigationLink2D)_host).IsBidirectional();

    /// <inheritdoc cref="NavigationLink2D.SetNavigationLayers(uint)" />
    public void SetNavigationLayers(uint @navigationLayers) => ((NavigationLink2D)_host).SetNavigationLayers(@navigationLayers);

    /// <inheritdoc cref="NavigationLink2D.GetNavigationLayers()" />
    public uint GetNavigationLayers() => ((NavigationLink2D)_host).GetNavigationLayers();

    /// <inheritdoc cref="NavigationLink2D.SetNavigationLayerValue(int, bool)" />
    public void SetNavigationLayerValue(int @layerNumber, bool @value) => ((NavigationLink2D)_host).SetNavigationLayerValue(@layerNumber, @value);

    /// <inheritdoc cref="NavigationLink2D.GetNavigationLayerValue(int)" />
    public bool GetNavigationLayerValue(int @layerNumber) => ((NavigationLink2D)_host).GetNavigationLayerValue(@layerNumber);

    /// <inheritdoc cref="NavigationLink2D.SetStartPosition(Vector2)" />
    public void SetStartPosition(Vector2 @position) => ((NavigationLink2D)_host).SetStartPosition(@position);

    /// <inheritdoc cref="NavigationLink2D.GetStartPosition()" />
    public Vector2 GetStartPosition() => ((NavigationLink2D)_host).GetStartPosition();

    /// <inheritdoc cref="NavigationLink2D.SetEndPosition(Vector2)" />
    public void SetEndPosition(Vector2 @position) => ((NavigationLink2D)_host).SetEndPosition(@position);

    /// <inheritdoc cref="NavigationLink2D.GetEndPosition()" />
    public Vector2 GetEndPosition() => ((NavigationLink2D)_host).GetEndPosition();

    /// <inheritdoc cref="NavigationLink2D.SetGlobalStartPosition(Vector2)" />
    public void SetGlobalStartPosition(Vector2 @position) => ((NavigationLink2D)_host).SetGlobalStartPosition(@position);

    /// <inheritdoc cref="NavigationLink2D.GetGlobalStartPosition()" />
    public Vector2 GetGlobalStartPosition() => ((NavigationLink2D)_host).GetGlobalStartPosition();

    /// <inheritdoc cref="NavigationLink2D.SetGlobalEndPosition(Vector2)" />
    public void SetGlobalEndPosition(Vector2 @position) => ((NavigationLink2D)_host).SetGlobalEndPosition(@position);

    /// <inheritdoc cref="NavigationLink2D.GetGlobalEndPosition()" />
    public Vector2 GetGlobalEndPosition() => ((NavigationLink2D)_host).GetGlobalEndPosition();

    /// <inheritdoc cref="NavigationLink2D.SetEnterCost(float)" />
    public void SetEnterCost(float @enterCost) => ((NavigationLink2D)_host).SetEnterCost(@enterCost);

    /// <inheritdoc cref="NavigationLink2D.GetEnterCost()" />
    public float GetEnterCost() => ((NavigationLink2D)_host).GetEnterCost();

    /// <inheritdoc cref="NavigationLink2D.SetTravelCost(float)" />
    public void SetTravelCost(float @travelCost) => ((NavigationLink2D)_host).SetTravelCost(@travelCost);

    /// <inheritdoc cref="NavigationLink2D.GetTravelCost()" />
    public float GetTravelCost() => ((NavigationLink2D)_host).GetTravelCost();

}
