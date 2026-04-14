#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Area2D" />
[Tool, GlobalClass]
public abstract partial class Area2DComponent : CollisionObject2DComponent
{

    /// <inheritdoc cref="Area2D.SetGravitySpaceOverrideMode(Area2D.SpaceOverride)" />
    public void SetGravitySpaceOverrideMode(Area2D.SpaceOverride @spaceOverrideMode) => ((Area2D)_host).SetGravitySpaceOverrideMode(@spaceOverrideMode);

    /// <inheritdoc cref="Area2D.GetGravitySpaceOverrideMode()" />
    public Area2D.SpaceOverride GetGravitySpaceOverrideMode() => ((Area2D)_host).GetGravitySpaceOverrideMode();

    /// <inheritdoc cref="Area2D.SetGravityIsPoint(bool)" />
    public void SetGravityIsPoint(bool @enable) => ((Area2D)_host).SetGravityIsPoint(@enable);

    /// <inheritdoc cref="Area2D.IsGravityAPoint()" />
    public bool IsGravityAPoint() => ((Area2D)_host).IsGravityAPoint();

    /// <inheritdoc cref="Area2D.SetGravityPointUnitDistance(float)" />
    public void SetGravityPointUnitDistance(float @distanceScale) => ((Area2D)_host).SetGravityPointUnitDistance(@distanceScale);

    /// <inheritdoc cref="Area2D.GetGravityPointUnitDistance()" />
    public float GetGravityPointUnitDistance() => ((Area2D)_host).GetGravityPointUnitDistance();

    /// <inheritdoc cref="Area2D.SetGravityPointCenter(Vector2)" />
    public void SetGravityPointCenter(Vector2 @center) => ((Area2D)_host).SetGravityPointCenter(@center);

    /// <inheritdoc cref="Area2D.GetGravityPointCenter()" />
    public Vector2 GetGravityPointCenter() => ((Area2D)_host).GetGravityPointCenter();

    /// <inheritdoc cref="Area2D.SetGravityDirection(Vector2)" />
    public void SetGravityDirection(Vector2 @direction) => ((Area2D)_host).SetGravityDirection(@direction);

    /// <inheritdoc cref="Area2D.GetGravityDirection()" />
    public Vector2 GetGravityDirection() => ((Area2D)_host).GetGravityDirection();

    /// <inheritdoc cref="Area2D.SetGravity(float)" />
    public void SetGravity(float @gravity) => ((Area2D)_host).SetGravity(@gravity);

    /// <inheritdoc cref="Area2D.GetGravity()" />
    public float GetGravity() => ((Area2D)_host).GetGravity();

    /// <inheritdoc cref="Area2D.SetLinearDampSpaceOverrideMode(Area2D.SpaceOverride)" />
    public void SetLinearDampSpaceOverrideMode(Area2D.SpaceOverride @spaceOverrideMode) => ((Area2D)_host).SetLinearDampSpaceOverrideMode(@spaceOverrideMode);

    /// <inheritdoc cref="Area2D.GetLinearDampSpaceOverrideMode()" />
    public Area2D.SpaceOverride GetLinearDampSpaceOverrideMode() => ((Area2D)_host).GetLinearDampSpaceOverrideMode();

    /// <inheritdoc cref="Area2D.SetAngularDampSpaceOverrideMode(Area2D.SpaceOverride)" />
    public void SetAngularDampSpaceOverrideMode(Area2D.SpaceOverride @spaceOverrideMode) => ((Area2D)_host).SetAngularDampSpaceOverrideMode(@spaceOverrideMode);

    /// <inheritdoc cref="Area2D.GetAngularDampSpaceOverrideMode()" />
    public Area2D.SpaceOverride GetAngularDampSpaceOverrideMode() => ((Area2D)_host).GetAngularDampSpaceOverrideMode();

    /// <inheritdoc cref="Area2D.SetLinearDamp(float)" />
    public void SetLinearDamp(float @linearDamp) => ((Area2D)_host).SetLinearDamp(@linearDamp);

    /// <inheritdoc cref="Area2D.GetLinearDamp()" />
    public float GetLinearDamp() => ((Area2D)_host).GetLinearDamp();

    /// <inheritdoc cref="Area2D.SetAngularDamp(float)" />
    public void SetAngularDamp(float @angularDamp) => ((Area2D)_host).SetAngularDamp(@angularDamp);

    /// <inheritdoc cref="Area2D.GetAngularDamp()" />
    public float GetAngularDamp() => ((Area2D)_host).GetAngularDamp();

    /// <inheritdoc cref="Area2D.SetPriority(int)" />
    public void SetPriority(int @priority) => ((Area2D)_host).SetPriority(@priority);

    /// <inheritdoc cref="Area2D.GetPriority()" />
    public int GetPriority() => ((Area2D)_host).GetPriority();

    /// <inheritdoc cref="Area2D.SetMonitoring(bool)" />
    public void SetMonitoring(bool @enable) => ((Area2D)_host).SetMonitoring(@enable);

    /// <inheritdoc cref="Area2D.IsMonitoring()" />
    public bool IsMonitoring() => ((Area2D)_host).IsMonitoring();

    /// <inheritdoc cref="Area2D.SetMonitorable(bool)" />
    public void SetMonitorable(bool @enable) => ((Area2D)_host).SetMonitorable(@enable);

    /// <inheritdoc cref="Area2D.IsMonitorable()" />
    public bool IsMonitorable() => ((Area2D)_host).IsMonitorable();

    /// <inheritdoc cref="Area2D.GetOverlappingBodies()" />
    public Array<Node2D> GetOverlappingBodies() => ((Area2D)_host).GetOverlappingBodies();

    /// <inheritdoc cref="Area2D.GetOverlappingAreas()" />
    public Array<Area2D> GetOverlappingAreas() => ((Area2D)_host).GetOverlappingAreas();

    /// <inheritdoc cref="Area2D.HasOverlappingBodies()" />
    public bool HasOverlappingBodies() => ((Area2D)_host).HasOverlappingBodies();

    /// <inheritdoc cref="Area2D.HasOverlappingAreas()" />
    public bool HasOverlappingAreas() => ((Area2D)_host).HasOverlappingAreas();

    /// <inheritdoc cref="Area2D.OverlapsBody(Node)" />
    public bool OverlapsBody(Node @body) => ((Area2D)_host).OverlapsBody(@body);

    /// <inheritdoc cref="Area2D.OverlapsArea(Node)" />
    public bool OverlapsArea(Node @area) => ((Area2D)_host).OverlapsArea(@area);

    /// <inheritdoc cref="Area2D.SetAudioBusName(StringName)" />
    public void SetAudioBusName(StringName @name) => ((Area2D)_host).SetAudioBusName(@name);

    /// <inheritdoc cref="Area2D.GetAudioBusName()" />
    public StringName GetAudioBusName() => ((Area2D)_host).GetAudioBusName();

    /// <inheritdoc cref="Area2D.SetAudioBusOverride(bool)" />
    public void SetAudioBusOverride(bool @enable) => ((Area2D)_host).SetAudioBusOverride(@enable);

    /// <inheritdoc cref="Area2D.IsOverridingAudioBus()" />
    public bool IsOverridingAudioBus() => ((Area2D)_host).IsOverridingAudioBus();

}
