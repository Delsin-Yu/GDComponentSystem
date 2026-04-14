#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="NavigationObstacle2D" />
[Tool, GlobalClass]
public abstract partial class NavigationObstacle2DComponent : Node2DComponent
{

    /// <inheritdoc cref="NavigationObstacle2D.GetRid()" />
    public Rid GetRid() => ((NavigationObstacle2D)_host).GetRid();

    /// <inheritdoc cref="NavigationObstacle2D.SetAvoidanceEnabled(bool)" />
    public void SetAvoidanceEnabled(bool @enabled) => ((NavigationObstacle2D)_host).SetAvoidanceEnabled(@enabled);

    /// <inheritdoc cref="NavigationObstacle2D.GetAvoidanceEnabled()" />
    public bool GetAvoidanceEnabled() => ((NavigationObstacle2D)_host).GetAvoidanceEnabled();

    /// <inheritdoc cref="NavigationObstacle2D.SetNavigationMap(Rid)" />
    public void SetNavigationMap(Rid @navigationMap) => ((NavigationObstacle2D)_host).SetNavigationMap(@navigationMap);

    /// <inheritdoc cref="NavigationObstacle2D.GetNavigationMap()" />
    public Rid GetNavigationMap() => ((NavigationObstacle2D)_host).GetNavigationMap();

    /// <inheritdoc cref="NavigationObstacle2D.SetRadius(float)" />
    public void SetRadius(float @radius) => ((NavigationObstacle2D)_host).SetRadius(@radius);

    /// <inheritdoc cref="NavigationObstacle2D.GetRadius()" />
    public float GetRadius() => ((NavigationObstacle2D)_host).GetRadius();

    /// <inheritdoc cref="NavigationObstacle2D.SetVelocity(Vector2)" />
    public void SetVelocity(Vector2 @velocity) => ((NavigationObstacle2D)_host).SetVelocity(@velocity);

    /// <inheritdoc cref="NavigationObstacle2D.GetVelocity()" />
    public Vector2 GetVelocity() => ((NavigationObstacle2D)_host).GetVelocity();

    /// <inheritdoc cref="NavigationObstacle2D.SetVertices(Vector2[])" />
    public void SetVertices(Vector2[] @vertices) => ((NavigationObstacle2D)_host).SetVertices(@vertices);

    /// <inheritdoc cref="NavigationObstacle2D.SetVertices(ReadOnlySpan{Vector2})" />
    public void SetVertices(ReadOnlySpan<Vector2> @vertices) => ((NavigationObstacle2D)_host).SetVertices(@vertices);

    /// <inheritdoc cref="NavigationObstacle2D.GetVertices()" />
    public Vector2[] GetVertices() => ((NavigationObstacle2D)_host).GetVertices();

    /// <inheritdoc cref="NavigationObstacle2D.SetAvoidanceLayers(uint)" />
    public void SetAvoidanceLayers(uint @layers) => ((NavigationObstacle2D)_host).SetAvoidanceLayers(@layers);

    /// <inheritdoc cref="NavigationObstacle2D.GetAvoidanceLayers()" />
    public uint GetAvoidanceLayers() => ((NavigationObstacle2D)_host).GetAvoidanceLayers();

    /// <inheritdoc cref="NavigationObstacle2D.SetAvoidanceLayerValue(int, bool)" />
    public void SetAvoidanceLayerValue(int @layerNumber, bool @value) => ((NavigationObstacle2D)_host).SetAvoidanceLayerValue(@layerNumber, @value);

    /// <inheritdoc cref="NavigationObstacle2D.GetAvoidanceLayerValue(int)" />
    public bool GetAvoidanceLayerValue(int @layerNumber) => ((NavigationObstacle2D)_host).GetAvoidanceLayerValue(@layerNumber);

    /// <inheritdoc cref="NavigationObstacle2D.SetAffectNavigationMesh(bool)" />
    public void SetAffectNavigationMesh(bool @enabled) => ((NavigationObstacle2D)_host).SetAffectNavigationMesh(@enabled);

    /// <inheritdoc cref="NavigationObstacle2D.GetAffectNavigationMesh()" />
    public bool GetAffectNavigationMesh() => ((NavigationObstacle2D)_host).GetAffectNavigationMesh();

    /// <inheritdoc cref="NavigationObstacle2D.SetCarveNavigationMesh(bool)" />
    public void SetCarveNavigationMesh(bool @enabled) => ((NavigationObstacle2D)_host).SetCarveNavigationMesh(@enabled);

    /// <inheritdoc cref="NavigationObstacle2D.GetCarveNavigationMesh()" />
    public bool GetCarveNavigationMesh() => ((NavigationObstacle2D)_host).GetCarveNavigationMesh();

}
