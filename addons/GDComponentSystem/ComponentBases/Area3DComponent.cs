#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Area3D" />
[Tool, GlobalClass]
public abstract partial class Area3DComponent : CollisionObject3DComponent
{

    /// <inheritdoc cref="Area3D.SetGravitySpaceOverrideMode(Area3D.SpaceOverride)" />
    public void SetGravitySpaceOverrideMode(Area3D.SpaceOverride @spaceOverrideMode) => ((Area3D)_host).SetGravitySpaceOverrideMode(@spaceOverrideMode);

    /// <inheritdoc cref="Area3D.GetGravitySpaceOverrideMode()" />
    public Area3D.SpaceOverride GetGravitySpaceOverrideMode() => ((Area3D)_host).GetGravitySpaceOverrideMode();

    /// <inheritdoc cref="Area3D.SetGravityIsPoint(bool)" />
    public void SetGravityIsPoint(bool @enable) => ((Area3D)_host).SetGravityIsPoint(@enable);

    /// <inheritdoc cref="Area3D.IsGravityAPoint()" />
    public bool IsGravityAPoint() => ((Area3D)_host).IsGravityAPoint();

    /// <inheritdoc cref="Area3D.SetGravityPointUnitDistance(float)" />
    public void SetGravityPointUnitDistance(float @distanceScale) => ((Area3D)_host).SetGravityPointUnitDistance(@distanceScale);

    /// <inheritdoc cref="Area3D.GetGravityPointUnitDistance()" />
    public float GetGravityPointUnitDistance() => ((Area3D)_host).GetGravityPointUnitDistance();

    /// <inheritdoc cref="Area3D.SetGravityPointCenter(Vector3)" />
    public void SetGravityPointCenter(Vector3 @center) => ((Area3D)_host).SetGravityPointCenter(@center);

    /// <inheritdoc cref="Area3D.GetGravityPointCenter()" />
    public Vector3 GetGravityPointCenter() => ((Area3D)_host).GetGravityPointCenter();

    /// <inheritdoc cref="Area3D.SetGravityDirection(Vector3)" />
    public void SetGravityDirection(Vector3 @direction) => ((Area3D)_host).SetGravityDirection(@direction);

    /// <inheritdoc cref="Area3D.GetGravityDirection()" />
    public Vector3 GetGravityDirection() => ((Area3D)_host).GetGravityDirection();

    /// <inheritdoc cref="Area3D.SetGravity(float)" />
    public void SetGravity(float @gravity) => ((Area3D)_host).SetGravity(@gravity);

    /// <inheritdoc cref="Area3D.GetGravity()" />
    public float GetGravity() => ((Area3D)_host).GetGravity();

    /// <inheritdoc cref="Area3D.SetLinearDampSpaceOverrideMode(Area3D.SpaceOverride)" />
    public void SetLinearDampSpaceOverrideMode(Area3D.SpaceOverride @spaceOverrideMode) => ((Area3D)_host).SetLinearDampSpaceOverrideMode(@spaceOverrideMode);

    /// <inheritdoc cref="Area3D.GetLinearDampSpaceOverrideMode()" />
    public Area3D.SpaceOverride GetLinearDampSpaceOverrideMode() => ((Area3D)_host).GetLinearDampSpaceOverrideMode();

    /// <inheritdoc cref="Area3D.SetAngularDampSpaceOverrideMode(Area3D.SpaceOverride)" />
    public void SetAngularDampSpaceOverrideMode(Area3D.SpaceOverride @spaceOverrideMode) => ((Area3D)_host).SetAngularDampSpaceOverrideMode(@spaceOverrideMode);

    /// <inheritdoc cref="Area3D.GetAngularDampSpaceOverrideMode()" />
    public Area3D.SpaceOverride GetAngularDampSpaceOverrideMode() => ((Area3D)_host).GetAngularDampSpaceOverrideMode();

    /// <inheritdoc cref="Area3D.SetAngularDamp(float)" />
    public void SetAngularDamp(float @angularDamp) => ((Area3D)_host).SetAngularDamp(@angularDamp);

    /// <inheritdoc cref="Area3D.GetAngularDamp()" />
    public float GetAngularDamp() => ((Area3D)_host).GetAngularDamp();

    /// <inheritdoc cref="Area3D.SetLinearDamp(float)" />
    public void SetLinearDamp(float @linearDamp) => ((Area3D)_host).SetLinearDamp(@linearDamp);

    /// <inheritdoc cref="Area3D.GetLinearDamp()" />
    public float GetLinearDamp() => ((Area3D)_host).GetLinearDamp();

    /// <inheritdoc cref="Area3D.SetPriority(int)" />
    public void SetPriority(int @priority) => ((Area3D)_host).SetPriority(@priority);

    /// <inheritdoc cref="Area3D.GetPriority()" />
    public int GetPriority() => ((Area3D)_host).GetPriority();

    /// <inheritdoc cref="Area3D.SetWindForceMagnitude(float)" />
    public void SetWindForceMagnitude(float @windForceMagnitude) => ((Area3D)_host).SetWindForceMagnitude(@windForceMagnitude);

    /// <inheritdoc cref="Area3D.GetWindForceMagnitude()" />
    public float GetWindForceMagnitude() => ((Area3D)_host).GetWindForceMagnitude();

    /// <inheritdoc cref="Area3D.SetWindAttenuationFactor(float)" />
    public void SetWindAttenuationFactor(float @windAttenuationFactor) => ((Area3D)_host).SetWindAttenuationFactor(@windAttenuationFactor);

    /// <inheritdoc cref="Area3D.GetWindAttenuationFactor()" />
    public float GetWindAttenuationFactor() => ((Area3D)_host).GetWindAttenuationFactor();

    /// <inheritdoc cref="Area3D.SetWindSourcePath(NodePath)" />
    public void SetWindSourcePath(NodePath @windSourcePath) => ((Area3D)_host).SetWindSourcePath(@windSourcePath);

    /// <inheritdoc cref="Area3D.GetWindSourcePath()" />
    public NodePath GetWindSourcePath() => ((Area3D)_host).GetWindSourcePath();

    /// <inheritdoc cref="Area3D.SetMonitorable(bool)" />
    public void SetMonitorable(bool @enable) => ((Area3D)_host).SetMonitorable(@enable);

    /// <inheritdoc cref="Area3D.IsMonitorable()" />
    public bool IsMonitorable() => ((Area3D)_host).IsMonitorable();

    /// <inheritdoc cref="Area3D.SetMonitoring(bool)" />
    public void SetMonitoring(bool @enable) => ((Area3D)_host).SetMonitoring(@enable);

    /// <inheritdoc cref="Area3D.IsMonitoring()" />
    public bool IsMonitoring() => ((Area3D)_host).IsMonitoring();

    /// <inheritdoc cref="Area3D.GetOverlappingBodies()" />
    public Array<Node3D> GetOverlappingBodies() => ((Area3D)_host).GetOverlappingBodies();

    /// <inheritdoc cref="Area3D.GetOverlappingAreas()" />
    public Array<Area3D> GetOverlappingAreas() => ((Area3D)_host).GetOverlappingAreas();

    /// <inheritdoc cref="Area3D.HasOverlappingBodies()" />
    public bool HasOverlappingBodies() => ((Area3D)_host).HasOverlappingBodies();

    /// <inheritdoc cref="Area3D.HasOverlappingAreas()" />
    public bool HasOverlappingAreas() => ((Area3D)_host).HasOverlappingAreas();

    /// <inheritdoc cref="Area3D.OverlapsBody(Node)" />
    public bool OverlapsBody(Node @body) => ((Area3D)_host).OverlapsBody(@body);

    /// <inheritdoc cref="Area3D.OverlapsArea(Node)" />
    public bool OverlapsArea(Node @area) => ((Area3D)_host).OverlapsArea(@area);

    /// <inheritdoc cref="Area3D.SetAudioBusOverride(bool)" />
    public void SetAudioBusOverride(bool @enable) => ((Area3D)_host).SetAudioBusOverride(@enable);

    /// <inheritdoc cref="Area3D.IsOverridingAudioBus()" />
    public bool IsOverridingAudioBus() => ((Area3D)_host).IsOverridingAudioBus();

    /// <inheritdoc cref="Area3D.SetAudioBusName(StringName)" />
    public void SetAudioBusName(StringName @name) => ((Area3D)_host).SetAudioBusName(@name);

    /// <inheritdoc cref="Area3D.GetAudioBusName()" />
    public StringName GetAudioBusName() => ((Area3D)_host).GetAudioBusName();

    /// <inheritdoc cref="Area3D.SetUseReverbBus(bool)" />
    public void SetUseReverbBus(bool @enable) => ((Area3D)_host).SetUseReverbBus(@enable);

    /// <inheritdoc cref="Area3D.IsUsingReverbBus()" />
    public bool IsUsingReverbBus() => ((Area3D)_host).IsUsingReverbBus();

    /// <inheritdoc cref="Area3D.SetReverbBusName(StringName)" />
    public void SetReverbBusName(StringName @name) => ((Area3D)_host).SetReverbBusName(@name);

    /// <inheritdoc cref="Area3D.GetReverbBusName()" />
    public StringName GetReverbBusName() => ((Area3D)_host).GetReverbBusName();

    /// <inheritdoc cref="Area3D.SetReverbAmount(float)" />
    public void SetReverbAmount(float @amount) => ((Area3D)_host).SetReverbAmount(@amount);

    /// <inheritdoc cref="Area3D.GetReverbAmount()" />
    public float GetReverbAmount() => ((Area3D)_host).GetReverbAmount();

    /// <inheritdoc cref="Area3D.SetReverbUniformity(float)" />
    public void SetReverbUniformity(float @amount) => ((Area3D)_host).SetReverbUniformity(@amount);

    /// <inheritdoc cref="Area3D.GetReverbUniformity()" />
    public float GetReverbUniformity() => ((Area3D)_host).GetReverbUniformity();

}
