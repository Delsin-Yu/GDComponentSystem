#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="NavigationLink3D" />
[Tool, GlobalClass]
public abstract partial class NavigationLink3DComponent : Node3DComponent
{

    /// <inheritdoc cref="NavigationLink3D.GetRid()" />
    public Rid GetRid() => ((NavigationLink3D)_host).GetRid();

    /// <inheritdoc cref="NavigationLink3D.SetEnabled(bool)" />
    public void SetEnabled(bool @enabled) => ((NavigationLink3D)_host).SetEnabled(@enabled);

    /// <inheritdoc cref="NavigationLink3D.IsEnabled()" />
    public bool IsEnabled() => ((NavigationLink3D)_host).IsEnabled();

    /// <inheritdoc cref="NavigationLink3D.SetNavigationMap(Rid)" />
    public void SetNavigationMap(Rid @navigationMap) => ((NavigationLink3D)_host).SetNavigationMap(@navigationMap);

    /// <inheritdoc cref="NavigationLink3D.GetNavigationMap()" />
    public Rid GetNavigationMap() => ((NavigationLink3D)_host).GetNavigationMap();

    /// <inheritdoc cref="NavigationLink3D.SetBidirectional(bool)" />
    public void SetBidirectional(bool @bidirectional) => ((NavigationLink3D)_host).SetBidirectional(@bidirectional);

    /// <inheritdoc cref="NavigationLink3D.IsBidirectional()" />
    public bool IsBidirectional() => ((NavigationLink3D)_host).IsBidirectional();

    /// <inheritdoc cref="NavigationLink3D.SetNavigationLayers(uint)" />
    public void SetNavigationLayers(uint @navigationLayers) => ((NavigationLink3D)_host).SetNavigationLayers(@navigationLayers);

    /// <inheritdoc cref="NavigationLink3D.GetNavigationLayers()" />
    public uint GetNavigationLayers() => ((NavigationLink3D)_host).GetNavigationLayers();

    /// <inheritdoc cref="NavigationLink3D.SetNavigationLayerValue(int, bool)" />
    public void SetNavigationLayerValue(int @layerNumber, bool @value) => ((NavigationLink3D)_host).SetNavigationLayerValue(@layerNumber, @value);

    /// <inheritdoc cref="NavigationLink3D.GetNavigationLayerValue(int)" />
    public bool GetNavigationLayerValue(int @layerNumber) => ((NavigationLink3D)_host).GetNavigationLayerValue(@layerNumber);

    /// <inheritdoc cref="NavigationLink3D.SetStartPosition(Vector3)" />
    public void SetStartPosition(Vector3 @position) => ((NavigationLink3D)_host).SetStartPosition(@position);

    /// <inheritdoc cref="NavigationLink3D.GetStartPosition()" />
    public Vector3 GetStartPosition() => ((NavigationLink3D)_host).GetStartPosition();

    /// <inheritdoc cref="NavigationLink3D.SetEndPosition(Vector3)" />
    public void SetEndPosition(Vector3 @position) => ((NavigationLink3D)_host).SetEndPosition(@position);

    /// <inheritdoc cref="NavigationLink3D.GetEndPosition()" />
    public Vector3 GetEndPosition() => ((NavigationLink3D)_host).GetEndPosition();

    /// <inheritdoc cref="NavigationLink3D.SetGlobalStartPosition(Vector3)" />
    public void SetGlobalStartPosition(Vector3 @position) => ((NavigationLink3D)_host).SetGlobalStartPosition(@position);

    /// <inheritdoc cref="NavigationLink3D.GetGlobalStartPosition()" />
    public Vector3 GetGlobalStartPosition() => ((NavigationLink3D)_host).GetGlobalStartPosition();

    /// <inheritdoc cref="NavigationLink3D.SetGlobalEndPosition(Vector3)" />
    public void SetGlobalEndPosition(Vector3 @position) => ((NavigationLink3D)_host).SetGlobalEndPosition(@position);

    /// <inheritdoc cref="NavigationLink3D.GetGlobalEndPosition()" />
    public Vector3 GetGlobalEndPosition() => ((NavigationLink3D)_host).GetGlobalEndPosition();

    /// <inheritdoc cref="NavigationLink3D.SetEnterCost(float)" />
    public void SetEnterCost(float @enterCost) => ((NavigationLink3D)_host).SetEnterCost(@enterCost);

    /// <inheritdoc cref="NavigationLink3D.GetEnterCost()" />
    public float GetEnterCost() => ((NavigationLink3D)_host).GetEnterCost();

    /// <inheritdoc cref="NavigationLink3D.SetTravelCost(float)" />
    public void SetTravelCost(float @travelCost) => ((NavigationLink3D)_host).SetTravelCost(@travelCost);

    /// <inheritdoc cref="NavigationLink3D.GetTravelCost()" />
    public float GetTravelCost() => ((NavigationLink3D)_host).GetTravelCost();

}
