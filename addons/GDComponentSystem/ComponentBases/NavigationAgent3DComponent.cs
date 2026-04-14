#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="NavigationAgent3D" />
[Tool, GlobalClass]
public abstract partial class NavigationAgent3DComponent : NodeComponent
{

    /// <inheritdoc cref="NavigationAgent3D.GetRid()" />
    public Rid GetRid() => ((NavigationAgent3D)_host).GetRid();

    /// <inheritdoc cref="NavigationAgent3D.SetAvoidanceEnabled(bool)" />
    public void SetAvoidanceEnabled(bool @enabled) => ((NavigationAgent3D)_host).SetAvoidanceEnabled(@enabled);

    /// <inheritdoc cref="NavigationAgent3D.GetAvoidanceEnabled()" />
    public bool GetAvoidanceEnabled() => ((NavigationAgent3D)_host).GetAvoidanceEnabled();

    /// <inheritdoc cref="NavigationAgent3D.SetPathDesiredDistance(float)" />
    public void SetPathDesiredDistance(float @desiredDistance) => ((NavigationAgent3D)_host).SetPathDesiredDistance(@desiredDistance);

    /// <inheritdoc cref="NavigationAgent3D.GetPathDesiredDistance()" />
    public float GetPathDesiredDistance() => ((NavigationAgent3D)_host).GetPathDesiredDistance();

    /// <inheritdoc cref="NavigationAgent3D.SetTargetDesiredDistance(float)" />
    public void SetTargetDesiredDistance(float @desiredDistance) => ((NavigationAgent3D)_host).SetTargetDesiredDistance(@desiredDistance);

    /// <inheritdoc cref="NavigationAgent3D.GetTargetDesiredDistance()" />
    public float GetTargetDesiredDistance() => ((NavigationAgent3D)_host).GetTargetDesiredDistance();

    /// <inheritdoc cref="NavigationAgent3D.SetRadius(float)" />
    public void SetRadius(float @radius) => ((NavigationAgent3D)_host).SetRadius(@radius);

    /// <inheritdoc cref="NavigationAgent3D.GetRadius()" />
    public float GetRadius() => ((NavigationAgent3D)_host).GetRadius();

    /// <inheritdoc cref="NavigationAgent3D.SetHeight(float)" />
    public void SetHeight(float @height) => ((NavigationAgent3D)_host).SetHeight(@height);

    /// <inheritdoc cref="NavigationAgent3D.GetHeight()" />
    public float GetHeight() => ((NavigationAgent3D)_host).GetHeight();

    /// <inheritdoc cref="NavigationAgent3D.SetPathHeightOffset(float)" />
    public void SetPathHeightOffset(float @pathHeightOffset) => ((NavigationAgent3D)_host).SetPathHeightOffset(@pathHeightOffset);

    /// <inheritdoc cref="NavigationAgent3D.GetPathHeightOffset()" />
    public float GetPathHeightOffset() => ((NavigationAgent3D)_host).GetPathHeightOffset();

    /// <inheritdoc cref="NavigationAgent3D.SetUse3DAvoidance(bool)" />
    public void SetUse3DAvoidance(bool @enabled) => ((NavigationAgent3D)_host).SetUse3DAvoidance(@enabled);

    /// <inheritdoc cref="NavigationAgent3D.GetUse3DAvoidance()" />
    public bool GetUse3DAvoidance() => ((NavigationAgent3D)_host).GetUse3DAvoidance();

    /// <inheritdoc cref="NavigationAgent3D.SetKeepYVelocity(bool)" />
    public void SetKeepYVelocity(bool @enabled) => ((NavigationAgent3D)_host).SetKeepYVelocity(@enabled);

    /// <inheritdoc cref="NavigationAgent3D.GetKeepYVelocity()" />
    public bool GetKeepYVelocity() => ((NavigationAgent3D)_host).GetKeepYVelocity();

    /// <inheritdoc cref="NavigationAgent3D.SetNeighborDistance(float)" />
    public void SetNeighborDistance(float @neighborDistance) => ((NavigationAgent3D)_host).SetNeighborDistance(@neighborDistance);

    /// <inheritdoc cref="NavigationAgent3D.GetNeighborDistance()" />
    public float GetNeighborDistance() => ((NavigationAgent3D)_host).GetNeighborDistance();

    /// <inheritdoc cref="NavigationAgent3D.SetMaxNeighbors(int)" />
    public void SetMaxNeighbors(int @maxNeighbors) => ((NavigationAgent3D)_host).SetMaxNeighbors(@maxNeighbors);

    /// <inheritdoc cref="NavigationAgent3D.GetMaxNeighbors()" />
    public int GetMaxNeighbors() => ((NavigationAgent3D)_host).GetMaxNeighbors();

    /// <inheritdoc cref="NavigationAgent3D.SetTimeHorizonAgents(float)" />
    public void SetTimeHorizonAgents(float @timeHorizon) => ((NavigationAgent3D)_host).SetTimeHorizonAgents(@timeHorizon);

    /// <inheritdoc cref="NavigationAgent3D.GetTimeHorizonAgents()" />
    public float GetTimeHorizonAgents() => ((NavigationAgent3D)_host).GetTimeHorizonAgents();

    /// <inheritdoc cref="NavigationAgent3D.SetTimeHorizonObstacles(float)" />
    public void SetTimeHorizonObstacles(float @timeHorizon) => ((NavigationAgent3D)_host).SetTimeHorizonObstacles(@timeHorizon);

    /// <inheritdoc cref="NavigationAgent3D.GetTimeHorizonObstacles()" />
    public float GetTimeHorizonObstacles() => ((NavigationAgent3D)_host).GetTimeHorizonObstacles();

    /// <inheritdoc cref="NavigationAgent3D.SetMaxSpeed(float)" />
    public void SetMaxSpeed(float @maxSpeed) => ((NavigationAgent3D)_host).SetMaxSpeed(@maxSpeed);

    /// <inheritdoc cref="NavigationAgent3D.GetMaxSpeed()" />
    public float GetMaxSpeed() => ((NavigationAgent3D)_host).GetMaxSpeed();

    /// <inheritdoc cref="NavigationAgent3D.SetPathMaxDistance(float)" />
    public void SetPathMaxDistance(float @maxSpeed) => ((NavigationAgent3D)_host).SetPathMaxDistance(@maxSpeed);

    /// <inheritdoc cref="NavigationAgent3D.GetPathMaxDistance()" />
    public float GetPathMaxDistance() => ((NavigationAgent3D)_host).GetPathMaxDistance();

    /// <inheritdoc cref="NavigationAgent3D.SetNavigationLayers(uint)" />
    public void SetNavigationLayers(uint @navigationLayers) => ((NavigationAgent3D)_host).SetNavigationLayers(@navigationLayers);

    /// <inheritdoc cref="NavigationAgent3D.GetNavigationLayers()" />
    public uint GetNavigationLayers() => ((NavigationAgent3D)_host).GetNavigationLayers();

    /// <inheritdoc cref="NavigationAgent3D.SetNavigationLayerValue(int, bool)" />
    public void SetNavigationLayerValue(int @layerNumber, bool @value) => ((NavigationAgent3D)_host).SetNavigationLayerValue(@layerNumber, @value);

    /// <inheritdoc cref="NavigationAgent3D.GetNavigationLayerValue(int)" />
    public bool GetNavigationLayerValue(int @layerNumber) => ((NavigationAgent3D)_host).GetNavigationLayerValue(@layerNumber);

    /// <inheritdoc cref="NavigationAgent3D.SetPathfindingAlgorithm(NavigationPathQueryParameters3D.PathfindingAlgorithmEnum)" />
    public void SetPathfindingAlgorithm(NavigationPathQueryParameters3D.PathfindingAlgorithmEnum @pathfindingAlgorithm) => ((NavigationAgent3D)_host).SetPathfindingAlgorithm(@pathfindingAlgorithm);

    /// <inheritdoc cref="NavigationAgent3D.GetPathfindingAlgorithm()" />
    public NavigationPathQueryParameters3D.PathfindingAlgorithmEnum GetPathfindingAlgorithm() => ((NavigationAgent3D)_host).GetPathfindingAlgorithm();

    /// <inheritdoc cref="NavigationAgent3D.SetPathPostprocessing(NavigationPathQueryParameters3D.PathPostProcessing)" />
    public void SetPathPostprocessing(NavigationPathQueryParameters3D.PathPostProcessing @pathPostprocessing) => ((NavigationAgent3D)_host).SetPathPostprocessing(@pathPostprocessing);

    /// <inheritdoc cref="NavigationAgent3D.GetPathPostprocessing()" />
    public NavigationPathQueryParameters3D.PathPostProcessing GetPathPostprocessing() => ((NavigationAgent3D)_host).GetPathPostprocessing();

    /// <inheritdoc cref="NavigationAgent3D.SetPathMetadataFlags(NavigationPathQueryParameters3D.PathMetadataFlags)" />
    public void SetPathMetadataFlags(NavigationPathQueryParameters3D.PathMetadataFlags @flags) => ((NavigationAgent3D)_host).SetPathMetadataFlags(@flags);

    /// <inheritdoc cref="NavigationAgent3D.GetPathMetadataFlags()" />
    public NavigationPathQueryParameters3D.PathMetadataFlags GetPathMetadataFlags() => ((NavigationAgent3D)_host).GetPathMetadataFlags();

    /// <inheritdoc cref="NavigationAgent3D.SetNavigationMap(Rid)" />
    public void SetNavigationMap(Rid @navigationMap) => ((NavigationAgent3D)_host).SetNavigationMap(@navigationMap);

    /// <inheritdoc cref="NavigationAgent3D.GetNavigationMap()" />
    public Rid GetNavigationMap() => ((NavigationAgent3D)_host).GetNavigationMap();

    /// <inheritdoc cref="NavigationAgent3D.SetTargetPosition(Vector3)" />
    public void SetTargetPosition(Vector3 @position) => ((NavigationAgent3D)_host).SetTargetPosition(@position);

    /// <inheritdoc cref="NavigationAgent3D.GetTargetPosition()" />
    public Vector3 GetTargetPosition() => ((NavigationAgent3D)_host).GetTargetPosition();

    /// <inheritdoc cref="NavigationAgent3D.SetSimplifyPath(bool)" />
    public void SetSimplifyPath(bool @enabled) => ((NavigationAgent3D)_host).SetSimplifyPath(@enabled);

    /// <inheritdoc cref="NavigationAgent3D.GetSimplifyPath()" />
    public bool GetSimplifyPath() => ((NavigationAgent3D)_host).GetSimplifyPath();

    /// <inheritdoc cref="NavigationAgent3D.SetSimplifyEpsilon(float)" />
    public void SetSimplifyEpsilon(float @epsilon) => ((NavigationAgent3D)_host).SetSimplifyEpsilon(@epsilon);

    /// <inheritdoc cref="NavigationAgent3D.GetSimplifyEpsilon()" />
    public float GetSimplifyEpsilon() => ((NavigationAgent3D)_host).GetSimplifyEpsilon();

    /// <inheritdoc cref="NavigationAgent3D.SetPathReturnMaxLength(float)" />
    public void SetPathReturnMaxLength(float @length) => ((NavigationAgent3D)_host).SetPathReturnMaxLength(@length);

    /// <inheritdoc cref="NavigationAgent3D.GetPathReturnMaxLength()" />
    public float GetPathReturnMaxLength() => ((NavigationAgent3D)_host).GetPathReturnMaxLength();

    /// <inheritdoc cref="NavigationAgent3D.SetPathReturnMaxRadius(float)" />
    public void SetPathReturnMaxRadius(float @radius) => ((NavigationAgent3D)_host).SetPathReturnMaxRadius(@radius);

    /// <inheritdoc cref="NavigationAgent3D.GetPathReturnMaxRadius()" />
    public float GetPathReturnMaxRadius() => ((NavigationAgent3D)_host).GetPathReturnMaxRadius();

    /// <inheritdoc cref="NavigationAgent3D.SetPathSearchMaxPolygons(int)" />
    public void SetPathSearchMaxPolygons(int @maxPolygons) => ((NavigationAgent3D)_host).SetPathSearchMaxPolygons(@maxPolygons);

    /// <inheritdoc cref="NavigationAgent3D.GetPathSearchMaxPolygons()" />
    public int GetPathSearchMaxPolygons() => ((NavigationAgent3D)_host).GetPathSearchMaxPolygons();

    /// <inheritdoc cref="NavigationAgent3D.SetPathSearchMaxDistance(float)" />
    public void SetPathSearchMaxDistance(float @distance) => ((NavigationAgent3D)_host).SetPathSearchMaxDistance(@distance);

    /// <inheritdoc cref="NavigationAgent3D.GetPathSearchMaxDistance()" />
    public float GetPathSearchMaxDistance() => ((NavigationAgent3D)_host).GetPathSearchMaxDistance();

    /// <inheritdoc cref="NavigationAgent3D.GetPathLength()" />
    public float GetPathLength() => ((NavigationAgent3D)_host).GetPathLength();

    /// <inheritdoc cref="NavigationAgent3D.GetNextPathPosition()" />
    public Vector3 GetNextPathPosition() => ((NavigationAgent3D)_host).GetNextPathPosition();

    /// <inheritdoc cref="NavigationAgent3D.SetVelocityForced(Vector3)" />
    public void SetVelocityForced(Vector3 @velocity) => ((NavigationAgent3D)_host).SetVelocityForced(@velocity);

    /// <inheritdoc cref="NavigationAgent3D.SetVelocity(Vector3)" />
    public void SetVelocity(Vector3 @velocity) => ((NavigationAgent3D)_host).SetVelocity(@velocity);

    /// <inheritdoc cref="NavigationAgent3D.GetVelocity()" />
    public Vector3 GetVelocity() => ((NavigationAgent3D)_host).GetVelocity();

    /// <inheritdoc cref="NavigationAgent3D.DistanceToTarget()" />
    public float DistanceToTarget() => ((NavigationAgent3D)_host).DistanceToTarget();

    /// <inheritdoc cref="NavigationAgent3D.GetCurrentNavigationResult()" />
    public NavigationPathQueryResult3D GetCurrentNavigationResult() => ((NavigationAgent3D)_host).GetCurrentNavigationResult();

    /// <inheritdoc cref="NavigationAgent3D.GetCurrentNavigationPath()" />
    public Vector3[] GetCurrentNavigationPath() => ((NavigationAgent3D)_host).GetCurrentNavigationPath();

    /// <inheritdoc cref="NavigationAgent3D.GetCurrentNavigationPathIndex()" />
    public int GetCurrentNavigationPathIndex() => ((NavigationAgent3D)_host).GetCurrentNavigationPathIndex();

    /// <inheritdoc cref="NavigationAgent3D.IsTargetReached()" />
    public bool IsTargetReached() => ((NavigationAgent3D)_host).IsTargetReached();

    /// <inheritdoc cref="NavigationAgent3D.IsTargetReachable()" />
    public bool IsTargetReachable() => ((NavigationAgent3D)_host).IsTargetReachable();

    /// <inheritdoc cref="NavigationAgent3D.IsNavigationFinished()" />
    public bool IsNavigationFinished() => ((NavigationAgent3D)_host).IsNavigationFinished();

    /// <inheritdoc cref="NavigationAgent3D.GetFinalPosition()" />
    public Vector3 GetFinalPosition() => ((NavigationAgent3D)_host).GetFinalPosition();

    /// <inheritdoc cref="NavigationAgent3D.SetAvoidanceLayers(uint)" />
    public void SetAvoidanceLayers(uint @layers) => ((NavigationAgent3D)_host).SetAvoidanceLayers(@layers);

    /// <inheritdoc cref="NavigationAgent3D.GetAvoidanceLayers()" />
    public uint GetAvoidanceLayers() => ((NavigationAgent3D)_host).GetAvoidanceLayers();

    /// <inheritdoc cref="NavigationAgent3D.SetAvoidanceMask(uint)" />
    public void SetAvoidanceMask(uint @mask) => ((NavigationAgent3D)_host).SetAvoidanceMask(@mask);

    /// <inheritdoc cref="NavigationAgent3D.GetAvoidanceMask()" />
    public uint GetAvoidanceMask() => ((NavigationAgent3D)_host).GetAvoidanceMask();

    /// <inheritdoc cref="NavigationAgent3D.SetAvoidanceLayerValue(int, bool)" />
    public void SetAvoidanceLayerValue(int @layerNumber, bool @value) => ((NavigationAgent3D)_host).SetAvoidanceLayerValue(@layerNumber, @value);

    /// <inheritdoc cref="NavigationAgent3D.GetAvoidanceLayerValue(int)" />
    public bool GetAvoidanceLayerValue(int @layerNumber) => ((NavigationAgent3D)_host).GetAvoidanceLayerValue(@layerNumber);

    /// <inheritdoc cref="NavigationAgent3D.SetAvoidanceMaskValue(int, bool)" />
    public void SetAvoidanceMaskValue(int @maskNumber, bool @value) => ((NavigationAgent3D)_host).SetAvoidanceMaskValue(@maskNumber, @value);

    /// <inheritdoc cref="NavigationAgent3D.GetAvoidanceMaskValue(int)" />
    public bool GetAvoidanceMaskValue(int @maskNumber) => ((NavigationAgent3D)_host).GetAvoidanceMaskValue(@maskNumber);

    /// <inheritdoc cref="NavigationAgent3D.SetAvoidancePriority(float)" />
    public void SetAvoidancePriority(float @priority) => ((NavigationAgent3D)_host).SetAvoidancePriority(@priority);

    /// <inheritdoc cref="NavigationAgent3D.GetAvoidancePriority()" />
    public float GetAvoidancePriority() => ((NavigationAgent3D)_host).GetAvoidancePriority();

    /// <inheritdoc cref="NavigationAgent3D.SetDebugEnabled(bool)" />
    public void SetDebugEnabled(bool @enabled) => ((NavigationAgent3D)_host).SetDebugEnabled(@enabled);

    /// <inheritdoc cref="NavigationAgent3D.GetDebugEnabled()" />
    public bool GetDebugEnabled() => ((NavigationAgent3D)_host).GetDebugEnabled();

    /// <inheritdoc cref="NavigationAgent3D.SetDebugUseCustom(bool)" />
    public void SetDebugUseCustom(bool @enabled) => ((NavigationAgent3D)_host).SetDebugUseCustom(@enabled);

    /// <inheritdoc cref="NavigationAgent3D.GetDebugUseCustom()" />
    public bool GetDebugUseCustom() => ((NavigationAgent3D)_host).GetDebugUseCustom();

    /// <inheritdoc cref="NavigationAgent3D.SetDebugPathCustomColor(Color)" />
    public void SetDebugPathCustomColor(Color @color) => ((NavigationAgent3D)_host).SetDebugPathCustomColor(@color);

    /// <inheritdoc cref="NavigationAgent3D.GetDebugPathCustomColor()" />
    public Color GetDebugPathCustomColor() => ((NavigationAgent3D)_host).GetDebugPathCustomColor();

    /// <inheritdoc cref="NavigationAgent3D.SetDebugPathCustomPointSize(float)" />
    public void SetDebugPathCustomPointSize(float @pointSize) => ((NavigationAgent3D)_host).SetDebugPathCustomPointSize(@pointSize);

    /// <inheritdoc cref="NavigationAgent3D.GetDebugPathCustomPointSize()" />
    public float GetDebugPathCustomPointSize() => ((NavigationAgent3D)_host).GetDebugPathCustomPointSize();

}
