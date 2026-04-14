#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="NavigationObstacle3D" />
[Tool, GlobalClass]
public abstract partial class NavigationObstacle3DComponent : Node3DComponent
{

    /// <inheritdoc cref="NavigationObstacle3D.GetRid()" />
    public Rid GetRid() => ((NavigationObstacle3D)_host).GetRid();

    /// <inheritdoc cref="NavigationObstacle3D.SetAvoidanceEnabled(bool)" />
    public void SetAvoidanceEnabled(bool @enabled) => ((NavigationObstacle3D)_host).SetAvoidanceEnabled(@enabled);

    /// <inheritdoc cref="NavigationObstacle3D.GetAvoidanceEnabled()" />
    public bool GetAvoidanceEnabled() => ((NavigationObstacle3D)_host).GetAvoidanceEnabled();

    /// <inheritdoc cref="NavigationObstacle3D.SetNavigationMap(Rid)" />
    public void SetNavigationMap(Rid @navigationMap) => ((NavigationObstacle3D)_host).SetNavigationMap(@navigationMap);

    /// <inheritdoc cref="NavigationObstacle3D.GetNavigationMap()" />
    public Rid GetNavigationMap() => ((NavigationObstacle3D)_host).GetNavigationMap();

    /// <inheritdoc cref="NavigationObstacle3D.SetRadius(float)" />
    public void SetRadius(float @radius) => ((NavigationObstacle3D)_host).SetRadius(@radius);

    /// <inheritdoc cref="NavigationObstacle3D.GetRadius()" />
    public float GetRadius() => ((NavigationObstacle3D)_host).GetRadius();

    /// <inheritdoc cref="NavigationObstacle3D.SetHeight(float)" />
    public void SetHeight(float @height) => ((NavigationObstacle3D)_host).SetHeight(@height);

    /// <inheritdoc cref="NavigationObstacle3D.GetHeight()" />
    public float GetHeight() => ((NavigationObstacle3D)_host).GetHeight();

    /// <inheritdoc cref="NavigationObstacle3D.SetVelocity(Vector3)" />
    public void SetVelocity(Vector3 @velocity) => ((NavigationObstacle3D)_host).SetVelocity(@velocity);

    /// <inheritdoc cref="NavigationObstacle3D.GetVelocity()" />
    public Vector3 GetVelocity() => ((NavigationObstacle3D)_host).GetVelocity();

    /// <inheritdoc cref="NavigationObstacle3D.SetVertices(Vector3[])" />
    public void SetVertices(Vector3[] @vertices) => ((NavigationObstacle3D)_host).SetVertices(@vertices);

    /// <inheritdoc cref="NavigationObstacle3D.SetVertices(ReadOnlySpan{Vector3})" />
    public void SetVertices(ReadOnlySpan<Vector3> @vertices) => ((NavigationObstacle3D)_host).SetVertices(@vertices);

    /// <inheritdoc cref="NavigationObstacle3D.GetVertices()" />
    public Vector3[] GetVertices() => ((NavigationObstacle3D)_host).GetVertices();

    /// <inheritdoc cref="NavigationObstacle3D.SetAvoidanceLayers(uint)" />
    public void SetAvoidanceLayers(uint @layers) => ((NavigationObstacle3D)_host).SetAvoidanceLayers(@layers);

    /// <inheritdoc cref="NavigationObstacle3D.GetAvoidanceLayers()" />
    public uint GetAvoidanceLayers() => ((NavigationObstacle3D)_host).GetAvoidanceLayers();

    /// <inheritdoc cref="NavigationObstacle3D.SetAvoidanceLayerValue(int, bool)" />
    public void SetAvoidanceLayerValue(int @layerNumber, bool @value) => ((NavigationObstacle3D)_host).SetAvoidanceLayerValue(@layerNumber, @value);

    /// <inheritdoc cref="NavigationObstacle3D.GetAvoidanceLayerValue(int)" />
    public bool GetAvoidanceLayerValue(int @layerNumber) => ((NavigationObstacle3D)_host).GetAvoidanceLayerValue(@layerNumber);

    /// <inheritdoc cref="NavigationObstacle3D.SetUse3DAvoidance(bool)" />
    public void SetUse3DAvoidance(bool @enabled) => ((NavigationObstacle3D)_host).SetUse3DAvoidance(@enabled);

    /// <inheritdoc cref="NavigationObstacle3D.GetUse3DAvoidance()" />
    public bool GetUse3DAvoidance() => ((NavigationObstacle3D)_host).GetUse3DAvoidance();

    /// <inheritdoc cref="NavigationObstacle3D.SetAffectNavigationMesh(bool)" />
    public void SetAffectNavigationMesh(bool @enabled) => ((NavigationObstacle3D)_host).SetAffectNavigationMesh(@enabled);

    /// <inheritdoc cref="NavigationObstacle3D.GetAffectNavigationMesh()" />
    public bool GetAffectNavigationMesh() => ((NavigationObstacle3D)_host).GetAffectNavigationMesh();

    /// <inheritdoc cref="NavigationObstacle3D.SetCarveNavigationMesh(bool)" />
    public void SetCarveNavigationMesh(bool @enabled) => ((NavigationObstacle3D)_host).SetCarveNavigationMesh(@enabled);

    /// <inheritdoc cref="NavigationObstacle3D.GetCarveNavigationMesh()" />
    public bool GetCarveNavigationMesh() => ((NavigationObstacle3D)_host).GetCarveNavigationMesh();

}
