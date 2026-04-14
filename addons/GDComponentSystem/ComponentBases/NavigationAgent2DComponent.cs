#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="NavigationAgent2D" />
[Tool, GlobalClass]
public abstract partial class NavigationAgent2DComponent : NodeComponent
{

    /// <inheritdoc cref="NavigationAgent2D.GetRid()" />
    public Rid GetRid() => ((NavigationAgent2D)_host).GetRid();

    /// <inheritdoc cref="NavigationAgent2D.SetAvoidanceEnabled(bool)" />
    public void SetAvoidanceEnabled(bool @enabled) => ((NavigationAgent2D)_host).SetAvoidanceEnabled(@enabled);

    /// <inheritdoc cref="NavigationAgent2D.GetAvoidanceEnabled()" />
    public bool GetAvoidanceEnabled() => ((NavigationAgent2D)_host).GetAvoidanceEnabled();

    /// <inheritdoc cref="NavigationAgent2D.SetPathDesiredDistance(float)" />
    public void SetPathDesiredDistance(float @desiredDistance) => ((NavigationAgent2D)_host).SetPathDesiredDistance(@desiredDistance);

    /// <inheritdoc cref="NavigationAgent2D.GetPathDesiredDistance()" />
    public float GetPathDesiredDistance() => ((NavigationAgent2D)_host).GetPathDesiredDistance();

    /// <inheritdoc cref="NavigationAgent2D.SetTargetDesiredDistance(float)" />
    public void SetTargetDesiredDistance(float @desiredDistance) => ((NavigationAgent2D)_host).SetTargetDesiredDistance(@desiredDistance);

    /// <inheritdoc cref="NavigationAgent2D.GetTargetDesiredDistance()" />
    public float GetTargetDesiredDistance() => ((NavigationAgent2D)_host).GetTargetDesiredDistance();

    /// <inheritdoc cref="NavigationAgent2D.SetRadius(float)" />
    public void SetRadius(float @radius) => ((NavigationAgent2D)_host).SetRadius(@radius);

    /// <inheritdoc cref="NavigationAgent2D.GetRadius()" />
    public float GetRadius() => ((NavigationAgent2D)_host).GetRadius();

    /// <inheritdoc cref="NavigationAgent2D.SetNeighborDistance(float)" />
    public void SetNeighborDistance(float @neighborDistance) => ((NavigationAgent2D)_host).SetNeighborDistance(@neighborDistance);

    /// <inheritdoc cref="NavigationAgent2D.GetNeighborDistance()" />
    public float GetNeighborDistance() => ((NavigationAgent2D)_host).GetNeighborDistance();

    /// <inheritdoc cref="NavigationAgent2D.SetMaxNeighbors(int)" />
    public void SetMaxNeighbors(int @maxNeighbors) => ((NavigationAgent2D)_host).SetMaxNeighbors(@maxNeighbors);

    /// <inheritdoc cref="NavigationAgent2D.GetMaxNeighbors()" />
    public int GetMaxNeighbors() => ((NavigationAgent2D)_host).GetMaxNeighbors();

    /// <inheritdoc cref="NavigationAgent2D.SetTimeHorizonAgents(float)" />
    public void SetTimeHorizonAgents(float @timeHorizon) => ((NavigationAgent2D)_host).SetTimeHorizonAgents(@timeHorizon);

    /// <inheritdoc cref="NavigationAgent2D.GetTimeHorizonAgents()" />
    public float GetTimeHorizonAgents() => ((NavigationAgent2D)_host).GetTimeHorizonAgents();

    /// <inheritdoc cref="NavigationAgent2D.SetTimeHorizonObstacles(float)" />
    public void SetTimeHorizonObstacles(float @timeHorizon) => ((NavigationAgent2D)_host).SetTimeHorizonObstacles(@timeHorizon);

    /// <inheritdoc cref="NavigationAgent2D.GetTimeHorizonObstacles()" />
    public float GetTimeHorizonObstacles() => ((NavigationAgent2D)_host).GetTimeHorizonObstacles();

    /// <inheritdoc cref="NavigationAgent2D.SetMaxSpeed(float)" />
    public void SetMaxSpeed(float @maxSpeed) => ((NavigationAgent2D)_host).SetMaxSpeed(@maxSpeed);

    /// <inheritdoc cref="NavigationAgent2D.GetMaxSpeed()" />
    public float GetMaxSpeed() => ((NavigationAgent2D)_host).GetMaxSpeed();

    /// <inheritdoc cref="NavigationAgent2D.SetPathMaxDistance(float)" />
    public void SetPathMaxDistance(float @maxSpeed) => ((NavigationAgent2D)_host).SetPathMaxDistance(@maxSpeed);

    /// <inheritdoc cref="NavigationAgent2D.GetPathMaxDistance()" />
    public float GetPathMaxDistance() => ((NavigationAgent2D)_host).GetPathMaxDistance();

    /// <inheritdoc cref="NavigationAgent2D.SetNavigationLayers(uint)" />
    public void SetNavigationLayers(uint @navigationLayers) => ((NavigationAgent2D)_host).SetNavigationLayers(@navigationLayers);

    /// <inheritdoc cref="NavigationAgent2D.GetNavigationLayers()" />
    public uint GetNavigationLayers() => ((NavigationAgent2D)_host).GetNavigationLayers();

    /// <inheritdoc cref="NavigationAgent2D.SetNavigationLayerValue(int, bool)" />
    public void SetNavigationLayerValue(int @layerNumber, bool @value) => ((NavigationAgent2D)_host).SetNavigationLayerValue(@layerNumber, @value);

    /// <inheritdoc cref="NavigationAgent2D.GetNavigationLayerValue(int)" />
    public bool GetNavigationLayerValue(int @layerNumber) => ((NavigationAgent2D)_host).GetNavigationLayerValue(@layerNumber);

    /// <inheritdoc cref="NavigationAgent2D.SetPathfindingAlgorithm(NavigationPathQueryParameters2D.PathfindingAlgorithmEnum)" />
    public void SetPathfindingAlgorithm(NavigationPathQueryParameters2D.PathfindingAlgorithmEnum @pathfindingAlgorithm) => ((NavigationAgent2D)_host).SetPathfindingAlgorithm(@pathfindingAlgorithm);

    /// <inheritdoc cref="NavigationAgent2D.GetPathfindingAlgorithm()" />
    public NavigationPathQueryParameters2D.PathfindingAlgorithmEnum GetPathfindingAlgorithm() => ((NavigationAgent2D)_host).GetPathfindingAlgorithm();

    /// <inheritdoc cref="NavigationAgent2D.SetPathPostprocessing(NavigationPathQueryParameters2D.PathPostProcessing)" />
    public void SetPathPostprocessing(NavigationPathQueryParameters2D.PathPostProcessing @pathPostprocessing) => ((NavigationAgent2D)_host).SetPathPostprocessing(@pathPostprocessing);

    /// <inheritdoc cref="NavigationAgent2D.GetPathPostprocessing()" />
    public NavigationPathQueryParameters2D.PathPostProcessing GetPathPostprocessing() => ((NavigationAgent2D)_host).GetPathPostprocessing();

    /// <inheritdoc cref="NavigationAgent2D.SetPathMetadataFlags(NavigationPathQueryParameters2D.PathMetadataFlags)" />
    public void SetPathMetadataFlags(NavigationPathQueryParameters2D.PathMetadataFlags @flags) => ((NavigationAgent2D)_host).SetPathMetadataFlags(@flags);

    /// <inheritdoc cref="NavigationAgent2D.GetPathMetadataFlags()" />
    public NavigationPathQueryParameters2D.PathMetadataFlags GetPathMetadataFlags() => ((NavigationAgent2D)_host).GetPathMetadataFlags();

    /// <inheritdoc cref="NavigationAgent2D.SetNavigationMap(Rid)" />
    public void SetNavigationMap(Rid @navigationMap) => ((NavigationAgent2D)_host).SetNavigationMap(@navigationMap);

    /// <inheritdoc cref="NavigationAgent2D.GetNavigationMap()" />
    public Rid GetNavigationMap() => ((NavigationAgent2D)_host).GetNavigationMap();

    /// <inheritdoc cref="NavigationAgent2D.SetTargetPosition(Vector2)" />
    public void SetTargetPosition(Vector2 @position) => ((NavigationAgent2D)_host).SetTargetPosition(@position);

    /// <inheritdoc cref="NavigationAgent2D.GetTargetPosition()" />
    public Vector2 GetTargetPosition() => ((NavigationAgent2D)_host).GetTargetPosition();

    /// <inheritdoc cref="NavigationAgent2D.SetSimplifyPath(bool)" />
    public void SetSimplifyPath(bool @enabled) => ((NavigationAgent2D)_host).SetSimplifyPath(@enabled);

    /// <inheritdoc cref="NavigationAgent2D.GetSimplifyPath()" />
    public bool GetSimplifyPath() => ((NavigationAgent2D)_host).GetSimplifyPath();

    /// <inheritdoc cref="NavigationAgent2D.SetSimplifyEpsilon(float)" />
    public void SetSimplifyEpsilon(float @epsilon) => ((NavigationAgent2D)_host).SetSimplifyEpsilon(@epsilon);

    /// <inheritdoc cref="NavigationAgent2D.GetSimplifyEpsilon()" />
    public float GetSimplifyEpsilon() => ((NavigationAgent2D)_host).GetSimplifyEpsilon();

    /// <inheritdoc cref="NavigationAgent2D.SetPathReturnMaxLength(float)" />
    public void SetPathReturnMaxLength(float @length) => ((NavigationAgent2D)_host).SetPathReturnMaxLength(@length);

    /// <inheritdoc cref="NavigationAgent2D.GetPathReturnMaxLength()" />
    public float GetPathReturnMaxLength() => ((NavigationAgent2D)_host).GetPathReturnMaxLength();

    /// <inheritdoc cref="NavigationAgent2D.SetPathReturnMaxRadius(float)" />
    public void SetPathReturnMaxRadius(float @radius) => ((NavigationAgent2D)_host).SetPathReturnMaxRadius(@radius);

    /// <inheritdoc cref="NavigationAgent2D.GetPathReturnMaxRadius()" />
    public float GetPathReturnMaxRadius() => ((NavigationAgent2D)_host).GetPathReturnMaxRadius();

    /// <inheritdoc cref="NavigationAgent2D.SetPathSearchMaxPolygons(int)" />
    public void SetPathSearchMaxPolygons(int @maxPolygons) => ((NavigationAgent2D)_host).SetPathSearchMaxPolygons(@maxPolygons);

    /// <inheritdoc cref="NavigationAgent2D.GetPathSearchMaxPolygons()" />
    public int GetPathSearchMaxPolygons() => ((NavigationAgent2D)_host).GetPathSearchMaxPolygons();

    /// <inheritdoc cref="NavigationAgent2D.SetPathSearchMaxDistance(float)" />
    public void SetPathSearchMaxDistance(float @distance) => ((NavigationAgent2D)_host).SetPathSearchMaxDistance(@distance);

    /// <inheritdoc cref="NavigationAgent2D.GetPathSearchMaxDistance()" />
    public float GetPathSearchMaxDistance() => ((NavigationAgent2D)_host).GetPathSearchMaxDistance();

    /// <inheritdoc cref="NavigationAgent2D.GetPathLength()" />
    public float GetPathLength() => ((NavigationAgent2D)_host).GetPathLength();

    /// <inheritdoc cref="NavigationAgent2D.GetNextPathPosition()" />
    public Vector2 GetNextPathPosition() => ((NavigationAgent2D)_host).GetNextPathPosition();

    /// <inheritdoc cref="NavigationAgent2D.SetVelocityForced(Vector2)" />
    public void SetVelocityForced(Vector2 @velocity) => ((NavigationAgent2D)_host).SetVelocityForced(@velocity);

    /// <inheritdoc cref="NavigationAgent2D.SetVelocity(Vector2)" />
    public void SetVelocity(Vector2 @velocity) => ((NavigationAgent2D)_host).SetVelocity(@velocity);

    /// <inheritdoc cref="NavigationAgent2D.GetVelocity()" />
    public Vector2 GetVelocity() => ((NavigationAgent2D)_host).GetVelocity();

    /// <inheritdoc cref="NavigationAgent2D.DistanceToTarget()" />
    public float DistanceToTarget() => ((NavigationAgent2D)_host).DistanceToTarget();

    /// <inheritdoc cref="NavigationAgent2D.GetCurrentNavigationResult()" />
    public NavigationPathQueryResult2D GetCurrentNavigationResult() => ((NavigationAgent2D)_host).GetCurrentNavigationResult();

    /// <inheritdoc cref="NavigationAgent2D.GetCurrentNavigationPath()" />
    public Vector2[] GetCurrentNavigationPath() => ((NavigationAgent2D)_host).GetCurrentNavigationPath();

    /// <inheritdoc cref="NavigationAgent2D.GetCurrentNavigationPathIndex()" />
    public int GetCurrentNavigationPathIndex() => ((NavigationAgent2D)_host).GetCurrentNavigationPathIndex();

    /// <inheritdoc cref="NavigationAgent2D.IsTargetReached()" />
    public bool IsTargetReached() => ((NavigationAgent2D)_host).IsTargetReached();

    /// <inheritdoc cref="NavigationAgent2D.IsTargetReachable()" />
    public bool IsTargetReachable() => ((NavigationAgent2D)_host).IsTargetReachable();

    /// <inheritdoc cref="NavigationAgent2D.IsNavigationFinished()" />
    public bool IsNavigationFinished() => ((NavigationAgent2D)_host).IsNavigationFinished();

    /// <inheritdoc cref="NavigationAgent2D.GetFinalPosition()" />
    public Vector2 GetFinalPosition() => ((NavigationAgent2D)_host).GetFinalPosition();

    /// <inheritdoc cref="NavigationAgent2D.SetAvoidanceLayers(uint)" />
    public void SetAvoidanceLayers(uint @layers) => ((NavigationAgent2D)_host).SetAvoidanceLayers(@layers);

    /// <inheritdoc cref="NavigationAgent2D.GetAvoidanceLayers()" />
    public uint GetAvoidanceLayers() => ((NavigationAgent2D)_host).GetAvoidanceLayers();

    /// <inheritdoc cref="NavigationAgent2D.SetAvoidanceMask(uint)" />
    public void SetAvoidanceMask(uint @mask) => ((NavigationAgent2D)_host).SetAvoidanceMask(@mask);

    /// <inheritdoc cref="NavigationAgent2D.GetAvoidanceMask()" />
    public uint GetAvoidanceMask() => ((NavigationAgent2D)_host).GetAvoidanceMask();

    /// <inheritdoc cref="NavigationAgent2D.SetAvoidanceLayerValue(int, bool)" />
    public void SetAvoidanceLayerValue(int @layerNumber, bool @value) => ((NavigationAgent2D)_host).SetAvoidanceLayerValue(@layerNumber, @value);

    /// <inheritdoc cref="NavigationAgent2D.GetAvoidanceLayerValue(int)" />
    public bool GetAvoidanceLayerValue(int @layerNumber) => ((NavigationAgent2D)_host).GetAvoidanceLayerValue(@layerNumber);

    /// <inheritdoc cref="NavigationAgent2D.SetAvoidanceMaskValue(int, bool)" />
    public void SetAvoidanceMaskValue(int @maskNumber, bool @value) => ((NavigationAgent2D)_host).SetAvoidanceMaskValue(@maskNumber, @value);

    /// <inheritdoc cref="NavigationAgent2D.GetAvoidanceMaskValue(int)" />
    public bool GetAvoidanceMaskValue(int @maskNumber) => ((NavigationAgent2D)_host).GetAvoidanceMaskValue(@maskNumber);

    /// <inheritdoc cref="NavigationAgent2D.SetAvoidancePriority(float)" />
    public void SetAvoidancePriority(float @priority) => ((NavigationAgent2D)_host).SetAvoidancePriority(@priority);

    /// <inheritdoc cref="NavigationAgent2D.GetAvoidancePriority()" />
    public float GetAvoidancePriority() => ((NavigationAgent2D)_host).GetAvoidancePriority();

    /// <inheritdoc cref="NavigationAgent2D.SetDebugEnabled(bool)" />
    public void SetDebugEnabled(bool @enabled) => ((NavigationAgent2D)_host).SetDebugEnabled(@enabled);

    /// <inheritdoc cref="NavigationAgent2D.GetDebugEnabled()" />
    public bool GetDebugEnabled() => ((NavigationAgent2D)_host).GetDebugEnabled();

    /// <inheritdoc cref="NavigationAgent2D.SetDebugUseCustom(bool)" />
    public void SetDebugUseCustom(bool @enabled) => ((NavigationAgent2D)_host).SetDebugUseCustom(@enabled);

    /// <inheritdoc cref="NavigationAgent2D.GetDebugUseCustom()" />
    public bool GetDebugUseCustom() => ((NavigationAgent2D)_host).GetDebugUseCustom();

    /// <inheritdoc cref="NavigationAgent2D.SetDebugPathCustomColor(Color)" />
    public void SetDebugPathCustomColor(Color @color) => ((NavigationAgent2D)_host).SetDebugPathCustomColor(@color);

    /// <inheritdoc cref="NavigationAgent2D.GetDebugPathCustomColor()" />
    public Color GetDebugPathCustomColor() => ((NavigationAgent2D)_host).GetDebugPathCustomColor();

    /// <inheritdoc cref="NavigationAgent2D.SetDebugPathCustomPointSize(float)" />
    public void SetDebugPathCustomPointSize(float @pointSize) => ((NavigationAgent2D)_host).SetDebugPathCustomPointSize(@pointSize);

    /// <inheritdoc cref="NavigationAgent2D.GetDebugPathCustomPointSize()" />
    public float GetDebugPathCustomPointSize() => ((NavigationAgent2D)_host).GetDebugPathCustomPointSize();

    /// <inheritdoc cref="NavigationAgent2D.SetDebugPathCustomLineWidth(float)" />
    public void SetDebugPathCustomLineWidth(float @lineWidth) => ((NavigationAgent2D)_host).SetDebugPathCustomLineWidth(@lineWidth);

    /// <inheritdoc cref="NavigationAgent2D.GetDebugPathCustomLineWidth()" />
    public float GetDebugPathCustomLineWidth() => ((NavigationAgent2D)_host).GetDebugPathCustomLineWidth();

}
