#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="PinJoint2D" />
[Tool, GlobalClass]
public abstract partial class PinJoint2DComponent : Joint2DComponent
{

    /// <inheritdoc cref="PinJoint2D.SetSoftness(float)" />
    public void SetSoftness(float @softness) => ((PinJoint2D)_host).SetSoftness(@softness);

    /// <inheritdoc cref="PinJoint2D.GetSoftness()" />
    public float GetSoftness() => ((PinJoint2D)_host).GetSoftness();

    /// <inheritdoc cref="PinJoint2D.SetAngularLimitLower(float)" />
    public void SetAngularLimitLower(float @angularLimitLower) => ((PinJoint2D)_host).SetAngularLimitLower(@angularLimitLower);

    /// <inheritdoc cref="PinJoint2D.GetAngularLimitLower()" />
    public float GetAngularLimitLower() => ((PinJoint2D)_host).GetAngularLimitLower();

    /// <inheritdoc cref="PinJoint2D.SetAngularLimitUpper(float)" />
    public void SetAngularLimitUpper(float @angularLimitUpper) => ((PinJoint2D)_host).SetAngularLimitUpper(@angularLimitUpper);

    /// <inheritdoc cref="PinJoint2D.GetAngularLimitUpper()" />
    public float GetAngularLimitUpper() => ((PinJoint2D)_host).GetAngularLimitUpper();

    /// <inheritdoc cref="PinJoint2D.SetMotorTargetVelocity(float)" />
    public void SetMotorTargetVelocity(float @motorTargetVelocity) => ((PinJoint2D)_host).SetMotorTargetVelocity(@motorTargetVelocity);

    /// <inheritdoc cref="PinJoint2D.GetMotorTargetVelocity()" />
    public float GetMotorTargetVelocity() => ((PinJoint2D)_host).GetMotorTargetVelocity();

    /// <inheritdoc cref="PinJoint2D.SetMotorEnabled(bool)" />
    public void SetMotorEnabled(bool @enabled) => ((PinJoint2D)_host).SetMotorEnabled(@enabled);

    /// <inheritdoc cref="PinJoint2D.IsMotorEnabled()" />
    public bool IsMotorEnabled() => ((PinJoint2D)_host).IsMotorEnabled();

    /// <inheritdoc cref="PinJoint2D.SetAngularLimitEnabled(bool)" />
    public void SetAngularLimitEnabled(bool @enabled) => ((PinJoint2D)_host).SetAngularLimitEnabled(@enabled);

    /// <inheritdoc cref="PinJoint2D.IsAngularLimitEnabled()" />
    public bool IsAngularLimitEnabled() => ((PinJoint2D)_host).IsAngularLimitEnabled();

}
