#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="PhysicalBone3D" />
[Tool, GlobalClass]
public abstract partial class PhysicalBone3DComponent : PhysicsBody3DComponent
{

    /// <inheritdoc cref="PhysicalBone3D._IntegrateForces(PhysicsDirectBodyState3D)" />
    public virtual void _IntegrateForces(PhysicsDirectBodyState3D @state) { }

    /// <inheritdoc cref="PhysicalBone3D.ApplyCentralImpulse(Vector3)" />
    public void ApplyCentralImpulse(Vector3 @impulse) => ((PhysicalBone3D)_host).ApplyCentralImpulse(@impulse);

    /// <inheritdoc cref="PhysicalBone3D.ApplyImpulse(Vector3, Vector3?)" />
    public void ApplyImpulse(Vector3 @impulse, Vector3? @position) => ((PhysicalBone3D)_host).ApplyImpulse(@impulse, @position);

    /// <inheritdoc cref="PhysicalBone3D.SetJointType(PhysicalBone3D.JointTypeEnum)" />
    public void SetJointType(PhysicalBone3D.JointTypeEnum @jointType) => ((PhysicalBone3D)_host).SetJointType(@jointType);

    /// <inheritdoc cref="PhysicalBone3D.GetJointType()" />
    public PhysicalBone3D.JointTypeEnum GetJointType() => ((PhysicalBone3D)_host).GetJointType();

    /// <inheritdoc cref="PhysicalBone3D.SetJointOffset(Transform3D)" />
    public void SetJointOffset(Transform3D @offset) => ((PhysicalBone3D)_host).SetJointOffset(@offset);

    /// <inheritdoc cref="PhysicalBone3D.GetJointOffset()" />
    public Transform3D GetJointOffset() => ((PhysicalBone3D)_host).GetJointOffset();

    /// <inheritdoc cref="PhysicalBone3D.SetJointRotation(Vector3)" />
    public void SetJointRotation(Vector3 @euler) => ((PhysicalBone3D)_host).SetJointRotation(@euler);

    /// <inheritdoc cref="PhysicalBone3D.GetJointRotation()" />
    public Vector3 GetJointRotation() => ((PhysicalBone3D)_host).GetJointRotation();

    /// <inheritdoc cref="PhysicalBone3D.SetBodyOffset(Transform3D)" />
    public void SetBodyOffset(Transform3D @offset) => ((PhysicalBone3D)_host).SetBodyOffset(@offset);

    /// <inheritdoc cref="PhysicalBone3D.GetBodyOffset()" />
    public Transform3D GetBodyOffset() => ((PhysicalBone3D)_host).GetBodyOffset();

    /// <inheritdoc cref="PhysicalBone3D.GetSimulatePhysics()" />
    public bool GetSimulatePhysics() => ((PhysicalBone3D)_host).GetSimulatePhysics();

    /// <inheritdoc cref="PhysicalBone3D.IsSimulatingPhysics()" />
    public bool IsSimulatingPhysics() => ((PhysicalBone3D)_host).IsSimulatingPhysics();

    /// <inheritdoc cref="PhysicalBone3D.GetBoneId()" />
    public int GetBoneId() => ((PhysicalBone3D)_host).GetBoneId();

    /// <inheritdoc cref="PhysicalBone3D.SetMass(float)" />
    public void SetMass(float @mass) => ((PhysicalBone3D)_host).SetMass(@mass);

    /// <inheritdoc cref="PhysicalBone3D.GetMass()" />
    public float GetMass() => ((PhysicalBone3D)_host).GetMass();

    /// <inheritdoc cref="PhysicalBone3D.SetFriction(float)" />
    public void SetFriction(float @friction) => ((PhysicalBone3D)_host).SetFriction(@friction);

    /// <inheritdoc cref="PhysicalBone3D.GetFriction()" />
    public float GetFriction() => ((PhysicalBone3D)_host).GetFriction();

    /// <inheritdoc cref="PhysicalBone3D.SetBounce(float)" />
    public void SetBounce(float @bounce) => ((PhysicalBone3D)_host).SetBounce(@bounce);

    /// <inheritdoc cref="PhysicalBone3D.GetBounce()" />
    public float GetBounce() => ((PhysicalBone3D)_host).GetBounce();

    /// <inheritdoc cref="PhysicalBone3D.SetGravityScale(float)" />
    public void SetGravityScale(float @gravityScale) => ((PhysicalBone3D)_host).SetGravityScale(@gravityScale);

    /// <inheritdoc cref="PhysicalBone3D.GetGravityScale()" />
    public float GetGravityScale() => ((PhysicalBone3D)_host).GetGravityScale();

    /// <inheritdoc cref="PhysicalBone3D.SetLinearDampMode(PhysicalBone3D.DampMode)" />
    public void SetLinearDampMode(PhysicalBone3D.DampMode @linearDampMode) => ((PhysicalBone3D)_host).SetLinearDampMode(@linearDampMode);

    /// <inheritdoc cref="PhysicalBone3D.GetLinearDampMode()" />
    public PhysicalBone3D.DampMode GetLinearDampMode() => ((PhysicalBone3D)_host).GetLinearDampMode();

    /// <inheritdoc cref="PhysicalBone3D.SetAngularDampMode(PhysicalBone3D.DampMode)" />
    public void SetAngularDampMode(PhysicalBone3D.DampMode @angularDampMode) => ((PhysicalBone3D)_host).SetAngularDampMode(@angularDampMode);

    /// <inheritdoc cref="PhysicalBone3D.GetAngularDampMode()" />
    public PhysicalBone3D.DampMode GetAngularDampMode() => ((PhysicalBone3D)_host).GetAngularDampMode();

    /// <inheritdoc cref="PhysicalBone3D.SetLinearDamp(float)" />
    public void SetLinearDamp(float @linearDamp) => ((PhysicalBone3D)_host).SetLinearDamp(@linearDamp);

    /// <inheritdoc cref="PhysicalBone3D.GetLinearDamp()" />
    public float GetLinearDamp() => ((PhysicalBone3D)_host).GetLinearDamp();

    /// <inheritdoc cref="PhysicalBone3D.SetAngularDamp(float)" />
    public void SetAngularDamp(float @angularDamp) => ((PhysicalBone3D)_host).SetAngularDamp(@angularDamp);

    /// <inheritdoc cref="PhysicalBone3D.GetAngularDamp()" />
    public float GetAngularDamp() => ((PhysicalBone3D)_host).GetAngularDamp();

    /// <inheritdoc cref="PhysicalBone3D.SetLinearVelocity(Vector3)" />
    public void SetLinearVelocity(Vector3 @linearVelocity) => ((PhysicalBone3D)_host).SetLinearVelocity(@linearVelocity);

    /// <inheritdoc cref="PhysicalBone3D.GetLinearVelocity()" />
    public Vector3 GetLinearVelocity() => ((PhysicalBone3D)_host).GetLinearVelocity();

    /// <inheritdoc cref="PhysicalBone3D.SetAngularVelocity(Vector3)" />
    public void SetAngularVelocity(Vector3 @angularVelocity) => ((PhysicalBone3D)_host).SetAngularVelocity(@angularVelocity);

    /// <inheritdoc cref="PhysicalBone3D.GetAngularVelocity()" />
    public Vector3 GetAngularVelocity() => ((PhysicalBone3D)_host).GetAngularVelocity();

    /// <inheritdoc cref="PhysicalBone3D.SetUseCustomIntegrator(bool)" />
    public void SetUseCustomIntegrator(bool @enable) => ((PhysicalBone3D)_host).SetUseCustomIntegrator(@enable);

    /// <inheritdoc cref="PhysicalBone3D.IsUsingCustomIntegrator()" />
    public bool IsUsingCustomIntegrator() => ((PhysicalBone3D)_host).IsUsingCustomIntegrator();

    /// <inheritdoc cref="PhysicalBone3D.SetCanSleep(bool)" />
    public void SetCanSleep(bool @ableToSleep) => ((PhysicalBone3D)_host).SetCanSleep(@ableToSleep);

    /// <inheritdoc cref="PhysicalBone3D.IsAbleToSleep()" />
    public bool IsAbleToSleep() => ((PhysicalBone3D)_host).IsAbleToSleep();

}
