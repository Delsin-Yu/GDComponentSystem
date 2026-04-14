#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="RigidBody3D" />
[Tool, GlobalClass]
public abstract partial class RigidBody3DComponent : PhysicsBody3DComponent
{

    /// <inheritdoc cref="RigidBody3D._IntegrateForces(PhysicsDirectBodyState3D)" />
    public virtual void _IntegrateForces(PhysicsDirectBodyState3D @state) { }

    /// <inheritdoc cref="RigidBody3D.SetMass(float)" />
    public void SetMass(float @mass) => ((RigidBody3D)_host).SetMass(@mass);

    /// <inheritdoc cref="RigidBody3D.GetMass()" />
    public float GetMass() => ((RigidBody3D)_host).GetMass();

    /// <inheritdoc cref="RigidBody3D.SetInertia(Vector3)" />
    public void SetInertia(Vector3 @inertia) => ((RigidBody3D)_host).SetInertia(@inertia);

    /// <inheritdoc cref="RigidBody3D.GetInertia()" />
    public Vector3 GetInertia() => ((RigidBody3D)_host).GetInertia();

    /// <inheritdoc cref="RigidBody3D.SetCenterOfMassMode(RigidBody3D.CenterOfMassModeEnum)" />
    public void SetCenterOfMassMode(RigidBody3D.CenterOfMassModeEnum @mode) => ((RigidBody3D)_host).SetCenterOfMassMode(@mode);

    /// <inheritdoc cref="RigidBody3D.GetCenterOfMassMode()" />
    public RigidBody3D.CenterOfMassModeEnum GetCenterOfMassMode() => ((RigidBody3D)_host).GetCenterOfMassMode();

    /// <inheritdoc cref="RigidBody3D.SetCenterOfMass(Vector3)" />
    public void SetCenterOfMass(Vector3 @centerOfMass) => ((RigidBody3D)_host).SetCenterOfMass(@centerOfMass);

    /// <inheritdoc cref="RigidBody3D.GetCenterOfMass()" />
    public Vector3 GetCenterOfMass() => ((RigidBody3D)_host).GetCenterOfMass();

    /// <inheritdoc cref="RigidBody3D.SetPhysicsMaterialOverride(PhysicsMaterial)" />
    public void SetPhysicsMaterialOverride(PhysicsMaterial @physicsMaterialOverride) => ((RigidBody3D)_host).SetPhysicsMaterialOverride(@physicsMaterialOverride);

    /// <inheritdoc cref="RigidBody3D.GetPhysicsMaterialOverride()" />
    public PhysicsMaterial GetPhysicsMaterialOverride() => ((RigidBody3D)_host).GetPhysicsMaterialOverride();

    /// <inheritdoc cref="RigidBody3D.SetLinearVelocity(Vector3)" />
    public void SetLinearVelocity(Vector3 @linearVelocity) => ((RigidBody3D)_host).SetLinearVelocity(@linearVelocity);

    /// <inheritdoc cref="RigidBody3D.GetLinearVelocity()" />
    public Vector3 GetLinearVelocity() => ((RigidBody3D)_host).GetLinearVelocity();

    /// <inheritdoc cref="RigidBody3D.SetAngularVelocity(Vector3)" />
    public void SetAngularVelocity(Vector3 @angularVelocity) => ((RigidBody3D)_host).SetAngularVelocity(@angularVelocity);

    /// <inheritdoc cref="RigidBody3D.GetAngularVelocity()" />
    public Vector3 GetAngularVelocity() => ((RigidBody3D)_host).GetAngularVelocity();

    /// <inheritdoc cref="RigidBody3D.GetInverseInertiaTensor()" />
    public Basis GetInverseInertiaTensor() => ((RigidBody3D)_host).GetInverseInertiaTensor();

    /// <inheritdoc cref="RigidBody3D.SetGravityScale(float)" />
    public void SetGravityScale(float @gravityScale) => ((RigidBody3D)_host).SetGravityScale(@gravityScale);

    /// <inheritdoc cref="RigidBody3D.GetGravityScale()" />
    public float GetGravityScale() => ((RigidBody3D)_host).GetGravityScale();

    /// <inheritdoc cref="RigidBody3D.SetLinearDampMode(RigidBody3D.DampMode)" />
    public void SetLinearDampMode(RigidBody3D.DampMode @linearDampMode) => ((RigidBody3D)_host).SetLinearDampMode(@linearDampMode);

    /// <inheritdoc cref="RigidBody3D.GetLinearDampMode()" />
    public RigidBody3D.DampMode GetLinearDampMode() => ((RigidBody3D)_host).GetLinearDampMode();

    /// <inheritdoc cref="RigidBody3D.SetAngularDampMode(RigidBody3D.DampMode)" />
    public void SetAngularDampMode(RigidBody3D.DampMode @angularDampMode) => ((RigidBody3D)_host).SetAngularDampMode(@angularDampMode);

    /// <inheritdoc cref="RigidBody3D.GetAngularDampMode()" />
    public RigidBody3D.DampMode GetAngularDampMode() => ((RigidBody3D)_host).GetAngularDampMode();

    /// <inheritdoc cref="RigidBody3D.SetLinearDamp(float)" />
    public void SetLinearDamp(float @linearDamp) => ((RigidBody3D)_host).SetLinearDamp(@linearDamp);

    /// <inheritdoc cref="RigidBody3D.GetLinearDamp()" />
    public float GetLinearDamp() => ((RigidBody3D)_host).GetLinearDamp();

    /// <inheritdoc cref="RigidBody3D.SetAngularDamp(float)" />
    public void SetAngularDamp(float @angularDamp) => ((RigidBody3D)_host).SetAngularDamp(@angularDamp);

    /// <inheritdoc cref="RigidBody3D.GetAngularDamp()" />
    public float GetAngularDamp() => ((RigidBody3D)_host).GetAngularDamp();

    /// <inheritdoc cref="RigidBody3D.SetMaxContactsReported(int)" />
    public void SetMaxContactsReported(int @amount) => ((RigidBody3D)_host).SetMaxContactsReported(@amount);

    /// <inheritdoc cref="RigidBody3D.GetMaxContactsReported()" />
    public int GetMaxContactsReported() => ((RigidBody3D)_host).GetMaxContactsReported();

    /// <inheritdoc cref="RigidBody3D.GetContactCount()" />
    public int GetContactCount() => ((RigidBody3D)_host).GetContactCount();

    /// <inheritdoc cref="RigidBody3D.SetUseCustomIntegrator(bool)" />
    public void SetUseCustomIntegrator(bool @enable) => ((RigidBody3D)_host).SetUseCustomIntegrator(@enable);

    /// <inheritdoc cref="RigidBody3D.IsUsingCustomIntegrator()" />
    public bool IsUsingCustomIntegrator() => ((RigidBody3D)_host).IsUsingCustomIntegrator();

    /// <inheritdoc cref="RigidBody3D.SetContactMonitor(bool)" />
    public void SetContactMonitor(bool @enabled) => ((RigidBody3D)_host).SetContactMonitor(@enabled);

    /// <inheritdoc cref="RigidBody3D.IsContactMonitorEnabled()" />
    public bool IsContactMonitorEnabled() => ((RigidBody3D)_host).IsContactMonitorEnabled();

    /// <inheritdoc cref="RigidBody3D.SetUseContinuousCollisionDetection(bool)" />
    public void SetUseContinuousCollisionDetection(bool @enable) => ((RigidBody3D)_host).SetUseContinuousCollisionDetection(@enable);

    /// <inheritdoc cref="RigidBody3D.IsUsingContinuousCollisionDetection()" />
    public bool IsUsingContinuousCollisionDetection() => ((RigidBody3D)_host).IsUsingContinuousCollisionDetection();

    /// <inheritdoc cref="RigidBody3D.SetAxisVelocity(Vector3)" />
    public void SetAxisVelocity(Vector3 @axisVelocity) => ((RigidBody3D)_host).SetAxisVelocity(@axisVelocity);

    /// <inheritdoc cref="RigidBody3D.ApplyCentralImpulse(Vector3)" />
    public void ApplyCentralImpulse(Vector3 @impulse) => ((RigidBody3D)_host).ApplyCentralImpulse(@impulse);

    /// <inheritdoc cref="RigidBody3D.ApplyImpulse(Vector3, Vector3?)" />
    public void ApplyImpulse(Vector3 @impulse, Vector3? @position) => ((RigidBody3D)_host).ApplyImpulse(@impulse, @position);

    /// <inheritdoc cref="RigidBody3D.ApplyTorqueImpulse(Vector3)" />
    public void ApplyTorqueImpulse(Vector3 @impulse) => ((RigidBody3D)_host).ApplyTorqueImpulse(@impulse);

    /// <inheritdoc cref="RigidBody3D.ApplyCentralForce(Vector3)" />
    public void ApplyCentralForce(Vector3 @force) => ((RigidBody3D)_host).ApplyCentralForce(@force);

    /// <inheritdoc cref="RigidBody3D.ApplyForce(Vector3, Vector3?)" />
    public void ApplyForce(Vector3 @force, Vector3? @position) => ((RigidBody3D)_host).ApplyForce(@force, @position);

    /// <inheritdoc cref="RigidBody3D.ApplyTorque(Vector3)" />
    public void ApplyTorque(Vector3 @torque) => ((RigidBody3D)_host).ApplyTorque(@torque);

    /// <inheritdoc cref="RigidBody3D.AddConstantCentralForce(Vector3)" />
    public void AddConstantCentralForce(Vector3 @force) => ((RigidBody3D)_host).AddConstantCentralForce(@force);

    /// <inheritdoc cref="RigidBody3D.AddConstantForce(Vector3, Vector3?)" />
    public void AddConstantForce(Vector3 @force, Vector3? @position) => ((RigidBody3D)_host).AddConstantForce(@force, @position);

    /// <inheritdoc cref="RigidBody3D.AddConstantTorque(Vector3)" />
    public void AddConstantTorque(Vector3 @torque) => ((RigidBody3D)_host).AddConstantTorque(@torque);

    /// <inheritdoc cref="RigidBody3D.SetConstantForce(Vector3)" />
    public void SetConstantForce(Vector3 @force) => ((RigidBody3D)_host).SetConstantForce(@force);

    /// <inheritdoc cref="RigidBody3D.GetConstantForce()" />
    public Vector3 GetConstantForce() => ((RigidBody3D)_host).GetConstantForce();

    /// <inheritdoc cref="RigidBody3D.SetConstantTorque(Vector3)" />
    public void SetConstantTorque(Vector3 @torque) => ((RigidBody3D)_host).SetConstantTorque(@torque);

    /// <inheritdoc cref="RigidBody3D.GetConstantTorque()" />
    public Vector3 GetConstantTorque() => ((RigidBody3D)_host).GetConstantTorque();

    /// <inheritdoc cref="RigidBody3D.SetSleeping(bool)" />
    public void SetSleeping(bool @sleeping) => ((RigidBody3D)_host).SetSleeping(@sleeping);

    /// <inheritdoc cref="RigidBody3D.IsSleeping()" />
    public bool IsSleeping() => ((RigidBody3D)_host).IsSleeping();

    /// <inheritdoc cref="RigidBody3D.SetCanSleep(bool)" />
    public void SetCanSleep(bool @ableToSleep) => ((RigidBody3D)_host).SetCanSleep(@ableToSleep);

    /// <inheritdoc cref="RigidBody3D.IsAbleToSleep()" />
    public bool IsAbleToSleep() => ((RigidBody3D)_host).IsAbleToSleep();

    /// <inheritdoc cref="RigidBody3D.SetLockRotationEnabled(bool)" />
    public void SetLockRotationEnabled(bool @lockRotation) => ((RigidBody3D)_host).SetLockRotationEnabled(@lockRotation);

    /// <inheritdoc cref="RigidBody3D.IsLockRotationEnabled()" />
    public bool IsLockRotationEnabled() => ((RigidBody3D)_host).IsLockRotationEnabled();

    /// <inheritdoc cref="RigidBody3D.SetFreezeEnabled(bool)" />
    public void SetFreezeEnabled(bool @freezeMode) => ((RigidBody3D)_host).SetFreezeEnabled(@freezeMode);

    /// <inheritdoc cref="RigidBody3D.IsFreezeEnabled()" />
    public bool IsFreezeEnabled() => ((RigidBody3D)_host).IsFreezeEnabled();

    /// <inheritdoc cref="RigidBody3D.SetFreezeMode(RigidBody3D.FreezeModeEnum)" />
    public void SetFreezeMode(RigidBody3D.FreezeModeEnum @freezeMode) => ((RigidBody3D)_host).SetFreezeMode(@freezeMode);

    /// <inheritdoc cref="RigidBody3D.GetFreezeMode()" />
    public RigidBody3D.FreezeModeEnum GetFreezeMode() => ((RigidBody3D)_host).GetFreezeMode();

    /// <inheritdoc cref="RigidBody3D.GetCollidingBodies()" />
    public Array<Node3D> GetCollidingBodies() => ((RigidBody3D)_host).GetCollidingBodies();

}
