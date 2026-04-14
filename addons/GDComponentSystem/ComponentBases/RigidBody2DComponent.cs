#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="RigidBody2D" />
[Tool, GlobalClass]
public abstract partial class RigidBody2DComponent : PhysicsBody2DComponent
{

    /// <inheritdoc cref="RigidBody2D._IntegrateForces(PhysicsDirectBodyState2D)" />
    public virtual void _IntegrateForces(PhysicsDirectBodyState2D @state) { }

    /// <inheritdoc cref="RigidBody2D.SetMass(float)" />
    public void SetMass(float @mass) => ((RigidBody2D)_host).SetMass(@mass);

    /// <inheritdoc cref="RigidBody2D.GetMass()" />
    public float GetMass() => ((RigidBody2D)_host).GetMass();

    /// <inheritdoc cref="RigidBody2D.GetInertia()" />
    public float GetInertia() => ((RigidBody2D)_host).GetInertia();

    /// <inheritdoc cref="RigidBody2D.SetInertia(float)" />
    public void SetInertia(float @inertia) => ((RigidBody2D)_host).SetInertia(@inertia);

    /// <inheritdoc cref="RigidBody2D.SetCenterOfMassMode(RigidBody2D.CenterOfMassModeEnum)" />
    public void SetCenterOfMassMode(RigidBody2D.CenterOfMassModeEnum @mode) => ((RigidBody2D)_host).SetCenterOfMassMode(@mode);

    /// <inheritdoc cref="RigidBody2D.GetCenterOfMassMode()" />
    public RigidBody2D.CenterOfMassModeEnum GetCenterOfMassMode() => ((RigidBody2D)_host).GetCenterOfMassMode();

    /// <inheritdoc cref="RigidBody2D.SetCenterOfMass(Vector2)" />
    public void SetCenterOfMass(Vector2 @centerOfMass) => ((RigidBody2D)_host).SetCenterOfMass(@centerOfMass);

    /// <inheritdoc cref="RigidBody2D.GetCenterOfMass()" />
    public Vector2 GetCenterOfMass() => ((RigidBody2D)_host).GetCenterOfMass();

    /// <inheritdoc cref="RigidBody2D.SetPhysicsMaterialOverride(PhysicsMaterial)" />
    public void SetPhysicsMaterialOverride(PhysicsMaterial @physicsMaterialOverride) => ((RigidBody2D)_host).SetPhysicsMaterialOverride(@physicsMaterialOverride);

    /// <inheritdoc cref="RigidBody2D.GetPhysicsMaterialOverride()" />
    public PhysicsMaterial GetPhysicsMaterialOverride() => ((RigidBody2D)_host).GetPhysicsMaterialOverride();

    /// <inheritdoc cref="RigidBody2D.SetGravityScale(float)" />
    public void SetGravityScale(float @gravityScale) => ((RigidBody2D)_host).SetGravityScale(@gravityScale);

    /// <inheritdoc cref="RigidBody2D.GetGravityScale()" />
    public float GetGravityScale() => ((RigidBody2D)_host).GetGravityScale();

    /// <inheritdoc cref="RigidBody2D.SetLinearDampMode(RigidBody2D.DampMode)" />
    public void SetLinearDampMode(RigidBody2D.DampMode @linearDampMode) => ((RigidBody2D)_host).SetLinearDampMode(@linearDampMode);

    /// <inheritdoc cref="RigidBody2D.GetLinearDampMode()" />
    public RigidBody2D.DampMode GetLinearDampMode() => ((RigidBody2D)_host).GetLinearDampMode();

    /// <inheritdoc cref="RigidBody2D.SetAngularDampMode(RigidBody2D.DampMode)" />
    public void SetAngularDampMode(RigidBody2D.DampMode @angularDampMode) => ((RigidBody2D)_host).SetAngularDampMode(@angularDampMode);

    /// <inheritdoc cref="RigidBody2D.GetAngularDampMode()" />
    public RigidBody2D.DampMode GetAngularDampMode() => ((RigidBody2D)_host).GetAngularDampMode();

    /// <inheritdoc cref="RigidBody2D.SetLinearDamp(float)" />
    public void SetLinearDamp(float @linearDamp) => ((RigidBody2D)_host).SetLinearDamp(@linearDamp);

    /// <inheritdoc cref="RigidBody2D.GetLinearDamp()" />
    public float GetLinearDamp() => ((RigidBody2D)_host).GetLinearDamp();

    /// <inheritdoc cref="RigidBody2D.SetAngularDamp(float)" />
    public void SetAngularDamp(float @angularDamp) => ((RigidBody2D)_host).SetAngularDamp(@angularDamp);

    /// <inheritdoc cref="RigidBody2D.GetAngularDamp()" />
    public float GetAngularDamp() => ((RigidBody2D)_host).GetAngularDamp();

    /// <inheritdoc cref="RigidBody2D.SetLinearVelocity(Vector2)" />
    public void SetLinearVelocity(Vector2 @linearVelocity) => ((RigidBody2D)_host).SetLinearVelocity(@linearVelocity);

    /// <inheritdoc cref="RigidBody2D.GetLinearVelocity()" />
    public Vector2 GetLinearVelocity() => ((RigidBody2D)_host).GetLinearVelocity();

    /// <inheritdoc cref="RigidBody2D.SetAngularVelocity(float)" />
    public void SetAngularVelocity(float @angularVelocity) => ((RigidBody2D)_host).SetAngularVelocity(@angularVelocity);

    /// <inheritdoc cref="RigidBody2D.GetAngularVelocity()" />
    public float GetAngularVelocity() => ((RigidBody2D)_host).GetAngularVelocity();

    /// <inheritdoc cref="RigidBody2D.SetMaxContactsReported(int)" />
    public void SetMaxContactsReported(int @amount) => ((RigidBody2D)_host).SetMaxContactsReported(@amount);

    /// <inheritdoc cref="RigidBody2D.GetMaxContactsReported()" />
    public int GetMaxContactsReported() => ((RigidBody2D)_host).GetMaxContactsReported();

    /// <inheritdoc cref="RigidBody2D.GetContactCount()" />
    public int GetContactCount() => ((RigidBody2D)_host).GetContactCount();

    /// <inheritdoc cref="RigidBody2D.SetUseCustomIntegrator(bool)" />
    public void SetUseCustomIntegrator(bool @enable) => ((RigidBody2D)_host).SetUseCustomIntegrator(@enable);

    /// <inheritdoc cref="RigidBody2D.IsUsingCustomIntegrator()" />
    public bool IsUsingCustomIntegrator() => ((RigidBody2D)_host).IsUsingCustomIntegrator();

    /// <inheritdoc cref="RigidBody2D.SetContactMonitor(bool)" />
    public void SetContactMonitor(bool @enabled) => ((RigidBody2D)_host).SetContactMonitor(@enabled);

    /// <inheritdoc cref="RigidBody2D.IsContactMonitorEnabled()" />
    public bool IsContactMonitorEnabled() => ((RigidBody2D)_host).IsContactMonitorEnabled();

    /// <inheritdoc cref="RigidBody2D.SetContinuousCollisionDetectionMode(RigidBody2D.CcdMode)" />
    public void SetContinuousCollisionDetectionMode(RigidBody2D.CcdMode @mode) => ((RigidBody2D)_host).SetContinuousCollisionDetectionMode(@mode);

    /// <inheritdoc cref="RigidBody2D.GetContinuousCollisionDetectionMode()" />
    public RigidBody2D.CcdMode GetContinuousCollisionDetectionMode() => ((RigidBody2D)_host).GetContinuousCollisionDetectionMode();

    /// <inheritdoc cref="RigidBody2D.SetAxisVelocity(Vector2)" />
    public void SetAxisVelocity(Vector2 @axisVelocity) => ((RigidBody2D)_host).SetAxisVelocity(@axisVelocity);

    /// <inheritdoc cref="RigidBody2D.ApplyCentralImpulse(Vector2?)" />
    public void ApplyCentralImpulse(Vector2? @impulse) => ((RigidBody2D)_host).ApplyCentralImpulse(@impulse);

    /// <inheritdoc cref="RigidBody2D.ApplyImpulse(Vector2, Vector2?)" />
    public void ApplyImpulse(Vector2 @impulse, Vector2? @position) => ((RigidBody2D)_host).ApplyImpulse(@impulse, @position);

    /// <inheritdoc cref="RigidBody2D.ApplyTorqueImpulse(float)" />
    public void ApplyTorqueImpulse(float @torque) => ((RigidBody2D)_host).ApplyTorqueImpulse(@torque);

    /// <inheritdoc cref="RigidBody2D.ApplyCentralForce(Vector2)" />
    public void ApplyCentralForce(Vector2 @force) => ((RigidBody2D)_host).ApplyCentralForce(@force);

    /// <inheritdoc cref="RigidBody2D.ApplyForce(Vector2, Vector2?)" />
    public void ApplyForce(Vector2 @force, Vector2? @position) => ((RigidBody2D)_host).ApplyForce(@force, @position);

    /// <inheritdoc cref="RigidBody2D.ApplyTorque(float)" />
    public void ApplyTorque(float @torque) => ((RigidBody2D)_host).ApplyTorque(@torque);

    /// <inheritdoc cref="RigidBody2D.AddConstantCentralForce(Vector2)" />
    public void AddConstantCentralForce(Vector2 @force) => ((RigidBody2D)_host).AddConstantCentralForce(@force);

    /// <inheritdoc cref="RigidBody2D.AddConstantForce(Vector2, Vector2?)" />
    public void AddConstantForce(Vector2 @force, Vector2? @position) => ((RigidBody2D)_host).AddConstantForce(@force, @position);

    /// <inheritdoc cref="RigidBody2D.AddConstantTorque(float)" />
    public void AddConstantTorque(float @torque) => ((RigidBody2D)_host).AddConstantTorque(@torque);

    /// <inheritdoc cref="RigidBody2D.SetConstantForce(Vector2)" />
    public void SetConstantForce(Vector2 @force) => ((RigidBody2D)_host).SetConstantForce(@force);

    /// <inheritdoc cref="RigidBody2D.GetConstantForce()" />
    public Vector2 GetConstantForce() => ((RigidBody2D)_host).GetConstantForce();

    /// <inheritdoc cref="RigidBody2D.SetConstantTorque(float)" />
    public void SetConstantTorque(float @torque) => ((RigidBody2D)_host).SetConstantTorque(@torque);

    /// <inheritdoc cref="RigidBody2D.GetConstantTorque()" />
    public float GetConstantTorque() => ((RigidBody2D)_host).GetConstantTorque();

    /// <inheritdoc cref="RigidBody2D.SetSleeping(bool)" />
    public void SetSleeping(bool @sleeping) => ((RigidBody2D)_host).SetSleeping(@sleeping);

    /// <inheritdoc cref="RigidBody2D.IsSleeping()" />
    public bool IsSleeping() => ((RigidBody2D)_host).IsSleeping();

    /// <inheritdoc cref="RigidBody2D.SetCanSleep(bool)" />
    public void SetCanSleep(bool @ableToSleep) => ((RigidBody2D)_host).SetCanSleep(@ableToSleep);

    /// <inheritdoc cref="RigidBody2D.IsAbleToSleep()" />
    public bool IsAbleToSleep() => ((RigidBody2D)_host).IsAbleToSleep();

    /// <inheritdoc cref="RigidBody2D.SetLockRotationEnabled(bool)" />
    public void SetLockRotationEnabled(bool @lockRotation) => ((RigidBody2D)_host).SetLockRotationEnabled(@lockRotation);

    /// <inheritdoc cref="RigidBody2D.IsLockRotationEnabled()" />
    public bool IsLockRotationEnabled() => ((RigidBody2D)_host).IsLockRotationEnabled();

    /// <inheritdoc cref="RigidBody2D.SetFreezeEnabled(bool)" />
    public void SetFreezeEnabled(bool @freezeMode) => ((RigidBody2D)_host).SetFreezeEnabled(@freezeMode);

    /// <inheritdoc cref="RigidBody2D.IsFreezeEnabled()" />
    public bool IsFreezeEnabled() => ((RigidBody2D)_host).IsFreezeEnabled();

    /// <inheritdoc cref="RigidBody2D.SetFreezeMode(RigidBody2D.FreezeModeEnum)" />
    public void SetFreezeMode(RigidBody2D.FreezeModeEnum @freezeMode) => ((RigidBody2D)_host).SetFreezeMode(@freezeMode);

    /// <inheritdoc cref="RigidBody2D.GetFreezeMode()" />
    public RigidBody2D.FreezeModeEnum GetFreezeMode() => ((RigidBody2D)_host).GetFreezeMode();

    /// <inheritdoc cref="RigidBody2D.GetCollidingBodies()" />
    public Array<Node2D> GetCollidingBodies() => ((RigidBody2D)_host).GetCollidingBodies();

}
