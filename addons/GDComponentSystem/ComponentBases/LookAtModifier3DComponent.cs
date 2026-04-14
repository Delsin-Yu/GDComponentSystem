#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="LookAtModifier3D" />
[Tool, GlobalClass]
public abstract partial class LookAtModifier3DComponent : SkeletonModifier3DComponent
{

    /// <inheritdoc cref="LookAtModifier3D.SetTargetNode(NodePath)" />
    public void SetTargetNode(NodePath @targetNode) => ((LookAtModifier3D)_host).SetTargetNode(@targetNode);

    /// <inheritdoc cref="LookAtModifier3D.GetTargetNode()" />
    public NodePath GetTargetNode() => ((LookAtModifier3D)_host).GetTargetNode();

    /// <inheritdoc cref="LookAtModifier3D.SetBoneName(string)" />
    public void SetBoneName(string @boneName) => ((LookAtModifier3D)_host).SetBoneName(@boneName);

    /// <inheritdoc cref="LookAtModifier3D.GetBoneName()" />
    public string GetBoneName() => ((LookAtModifier3D)_host).GetBoneName();

    /// <inheritdoc cref="LookAtModifier3D.SetBone(int)" />
    public void SetBone(int @bone) => ((LookAtModifier3D)_host).SetBone(@bone);

    /// <inheritdoc cref="LookAtModifier3D.GetBone()" />
    public int GetBone() => ((LookAtModifier3D)_host).GetBone();

    /// <inheritdoc cref="LookAtModifier3D.SetForwardAxis(SkeletonModifier3D.BoneAxis)" />
    public void SetForwardAxis(SkeletonModifier3D.BoneAxis @forwardAxis) => ((LookAtModifier3D)_host).SetForwardAxis(@forwardAxis);

    /// <inheritdoc cref="LookAtModifier3D.GetForwardAxis()" />
    public SkeletonModifier3D.BoneAxis GetForwardAxis() => ((LookAtModifier3D)_host).GetForwardAxis();

    /// <inheritdoc cref="LookAtModifier3D.SetPrimaryRotationAxis(Vector3.Axis)" />
    public void SetPrimaryRotationAxis(Vector3.Axis @axis) => ((LookAtModifier3D)_host).SetPrimaryRotationAxis(@axis);

    /// <inheritdoc cref="LookAtModifier3D.GetPrimaryRotationAxis()" />
    public Vector3.Axis GetPrimaryRotationAxis() => ((LookAtModifier3D)_host).GetPrimaryRotationAxis();

    /// <inheritdoc cref="LookAtModifier3D.SetUseSecondaryRotation(bool)" />
    public void SetUseSecondaryRotation(bool @enabled) => ((LookAtModifier3D)_host).SetUseSecondaryRotation(@enabled);

    /// <inheritdoc cref="LookAtModifier3D.IsUsingSecondaryRotation()" />
    public bool IsUsingSecondaryRotation() => ((LookAtModifier3D)_host).IsUsingSecondaryRotation();

    /// <inheritdoc cref="LookAtModifier3D.SetRelative(bool)" />
    public void SetRelative(bool @enabled) => ((LookAtModifier3D)_host).SetRelative(@enabled);

    /// <inheritdoc cref="LookAtModifier3D.IsRelative()" />
    public bool IsRelative() => ((LookAtModifier3D)_host).IsRelative();

    /// <inheritdoc cref="LookAtModifier3D.SetOriginSafeMargin(float)" />
    public void SetOriginSafeMargin(float @margin) => ((LookAtModifier3D)_host).SetOriginSafeMargin(@margin);

    /// <inheritdoc cref="LookAtModifier3D.GetOriginSafeMargin()" />
    public float GetOriginSafeMargin() => ((LookAtModifier3D)_host).GetOriginSafeMargin();

    /// <inheritdoc cref="LookAtModifier3D.SetOriginFrom(LookAtModifier3D.OriginFromEnum)" />
    public void SetOriginFrom(LookAtModifier3D.OriginFromEnum @originFrom) => ((LookAtModifier3D)_host).SetOriginFrom(@originFrom);

    /// <inheritdoc cref="LookAtModifier3D.GetOriginFrom()" />
    public LookAtModifier3D.OriginFromEnum GetOriginFrom() => ((LookAtModifier3D)_host).GetOriginFrom();

    /// <inheritdoc cref="LookAtModifier3D.SetOriginBoneName(string)" />
    public void SetOriginBoneName(string @boneName) => ((LookAtModifier3D)_host).SetOriginBoneName(@boneName);

    /// <inheritdoc cref="LookAtModifier3D.GetOriginBoneName()" />
    public string GetOriginBoneName() => ((LookAtModifier3D)_host).GetOriginBoneName();

    /// <inheritdoc cref="LookAtModifier3D.SetOriginBone(int)" />
    public void SetOriginBone(int @bone) => ((LookAtModifier3D)_host).SetOriginBone(@bone);

    /// <inheritdoc cref="LookAtModifier3D.GetOriginBone()" />
    public int GetOriginBone() => ((LookAtModifier3D)_host).GetOriginBone();

    /// <inheritdoc cref="LookAtModifier3D.SetOriginExternalNode(NodePath)" />
    public void SetOriginExternalNode(NodePath @externalNode) => ((LookAtModifier3D)_host).SetOriginExternalNode(@externalNode);

    /// <inheritdoc cref="LookAtModifier3D.GetOriginExternalNode()" />
    public NodePath GetOriginExternalNode() => ((LookAtModifier3D)_host).GetOriginExternalNode();

    /// <inheritdoc cref="LookAtModifier3D.SetOriginOffset(Vector3)" />
    public void SetOriginOffset(Vector3 @offset) => ((LookAtModifier3D)_host).SetOriginOffset(@offset);

    /// <inheritdoc cref="LookAtModifier3D.GetOriginOffset()" />
    public Vector3 GetOriginOffset() => ((LookAtModifier3D)_host).GetOriginOffset();

    /// <inheritdoc cref="LookAtModifier3D.SetDuration(float)" />
    public void SetDuration(float @duration) => ((LookAtModifier3D)_host).SetDuration(@duration);

    /// <inheritdoc cref="LookAtModifier3D.GetDuration()" />
    public float GetDuration() => ((LookAtModifier3D)_host).GetDuration();

    /// <inheritdoc cref="LookAtModifier3D.SetTransitionType(Tween.TransitionType)" />
    public void SetTransitionType(Tween.TransitionType @transitionType) => ((LookAtModifier3D)_host).SetTransitionType(@transitionType);

    /// <inheritdoc cref="LookAtModifier3D.GetTransitionType()" />
    public Tween.TransitionType GetTransitionType() => ((LookAtModifier3D)_host).GetTransitionType();

    /// <inheritdoc cref="LookAtModifier3D.SetEaseType(Tween.EaseType)" />
    public void SetEaseType(Tween.EaseType @easeType) => ((LookAtModifier3D)_host).SetEaseType(@easeType);

    /// <inheritdoc cref="LookAtModifier3D.GetEaseType()" />
    public Tween.EaseType GetEaseType() => ((LookAtModifier3D)_host).GetEaseType();

    /// <inheritdoc cref="LookAtModifier3D.SetUseAngleLimitation(bool)" />
    public void SetUseAngleLimitation(bool @enabled) => ((LookAtModifier3D)_host).SetUseAngleLimitation(@enabled);

    /// <inheritdoc cref="LookAtModifier3D.IsUsingAngleLimitation()" />
    public bool IsUsingAngleLimitation() => ((LookAtModifier3D)_host).IsUsingAngleLimitation();

    /// <inheritdoc cref="LookAtModifier3D.SetSymmetryLimitation(bool)" />
    public void SetSymmetryLimitation(bool @enabled) => ((LookAtModifier3D)_host).SetSymmetryLimitation(@enabled);

    /// <inheritdoc cref="LookAtModifier3D.IsLimitationSymmetry()" />
    public bool IsLimitationSymmetry() => ((LookAtModifier3D)_host).IsLimitationSymmetry();

    /// <inheritdoc cref="LookAtModifier3D.SetPrimaryLimitAngle(float)" />
    public void SetPrimaryLimitAngle(float @angle) => ((LookAtModifier3D)_host).SetPrimaryLimitAngle(@angle);

    /// <inheritdoc cref="LookAtModifier3D.GetPrimaryLimitAngle()" />
    public float GetPrimaryLimitAngle() => ((LookAtModifier3D)_host).GetPrimaryLimitAngle();

    /// <inheritdoc cref="LookAtModifier3D.SetPrimaryDampThreshold(float)" />
    public void SetPrimaryDampThreshold(float @power) => ((LookAtModifier3D)_host).SetPrimaryDampThreshold(@power);

    /// <inheritdoc cref="LookAtModifier3D.GetPrimaryDampThreshold()" />
    public float GetPrimaryDampThreshold() => ((LookAtModifier3D)_host).GetPrimaryDampThreshold();

    /// <inheritdoc cref="LookAtModifier3D.SetPrimaryPositiveLimitAngle(float)" />
    public void SetPrimaryPositiveLimitAngle(float @angle) => ((LookAtModifier3D)_host).SetPrimaryPositiveLimitAngle(@angle);

    /// <inheritdoc cref="LookAtModifier3D.GetPrimaryPositiveLimitAngle()" />
    public float GetPrimaryPositiveLimitAngle() => ((LookAtModifier3D)_host).GetPrimaryPositiveLimitAngle();

    /// <inheritdoc cref="LookAtModifier3D.SetPrimaryPositiveDampThreshold(float)" />
    public void SetPrimaryPositiveDampThreshold(float @power) => ((LookAtModifier3D)_host).SetPrimaryPositiveDampThreshold(@power);

    /// <inheritdoc cref="LookAtModifier3D.GetPrimaryPositiveDampThreshold()" />
    public float GetPrimaryPositiveDampThreshold() => ((LookAtModifier3D)_host).GetPrimaryPositiveDampThreshold();

    /// <inheritdoc cref="LookAtModifier3D.SetPrimaryNegativeLimitAngle(float)" />
    public void SetPrimaryNegativeLimitAngle(float @angle) => ((LookAtModifier3D)_host).SetPrimaryNegativeLimitAngle(@angle);

    /// <inheritdoc cref="LookAtModifier3D.GetPrimaryNegativeLimitAngle()" />
    public float GetPrimaryNegativeLimitAngle() => ((LookAtModifier3D)_host).GetPrimaryNegativeLimitAngle();

    /// <inheritdoc cref="LookAtModifier3D.SetPrimaryNegativeDampThreshold(float)" />
    public void SetPrimaryNegativeDampThreshold(float @power) => ((LookAtModifier3D)_host).SetPrimaryNegativeDampThreshold(@power);

    /// <inheritdoc cref="LookAtModifier3D.GetPrimaryNegativeDampThreshold()" />
    public float GetPrimaryNegativeDampThreshold() => ((LookAtModifier3D)_host).GetPrimaryNegativeDampThreshold();

    /// <inheritdoc cref="LookAtModifier3D.SetSecondaryLimitAngle(float)" />
    public void SetSecondaryLimitAngle(float @angle) => ((LookAtModifier3D)_host).SetSecondaryLimitAngle(@angle);

    /// <inheritdoc cref="LookAtModifier3D.GetSecondaryLimitAngle()" />
    public float GetSecondaryLimitAngle() => ((LookAtModifier3D)_host).GetSecondaryLimitAngle();

    /// <inheritdoc cref="LookAtModifier3D.SetSecondaryDampThreshold(float)" />
    public void SetSecondaryDampThreshold(float @power) => ((LookAtModifier3D)_host).SetSecondaryDampThreshold(@power);

    /// <inheritdoc cref="LookAtModifier3D.GetSecondaryDampThreshold()" />
    public float GetSecondaryDampThreshold() => ((LookAtModifier3D)_host).GetSecondaryDampThreshold();

    /// <inheritdoc cref="LookAtModifier3D.SetSecondaryPositiveLimitAngle(float)" />
    public void SetSecondaryPositiveLimitAngle(float @angle) => ((LookAtModifier3D)_host).SetSecondaryPositiveLimitAngle(@angle);

    /// <inheritdoc cref="LookAtModifier3D.GetSecondaryPositiveLimitAngle()" />
    public float GetSecondaryPositiveLimitAngle() => ((LookAtModifier3D)_host).GetSecondaryPositiveLimitAngle();

    /// <inheritdoc cref="LookAtModifier3D.SetSecondaryPositiveDampThreshold(float)" />
    public void SetSecondaryPositiveDampThreshold(float @power) => ((LookAtModifier3D)_host).SetSecondaryPositiveDampThreshold(@power);

    /// <inheritdoc cref="LookAtModifier3D.GetSecondaryPositiveDampThreshold()" />
    public float GetSecondaryPositiveDampThreshold() => ((LookAtModifier3D)_host).GetSecondaryPositiveDampThreshold();

    /// <inheritdoc cref="LookAtModifier3D.SetSecondaryNegativeLimitAngle(float)" />
    public void SetSecondaryNegativeLimitAngle(float @angle) => ((LookAtModifier3D)_host).SetSecondaryNegativeLimitAngle(@angle);

    /// <inheritdoc cref="LookAtModifier3D.GetSecondaryNegativeLimitAngle()" />
    public float GetSecondaryNegativeLimitAngle() => ((LookAtModifier3D)_host).GetSecondaryNegativeLimitAngle();

    /// <inheritdoc cref="LookAtModifier3D.SetSecondaryNegativeDampThreshold(float)" />
    public void SetSecondaryNegativeDampThreshold(float @power) => ((LookAtModifier3D)_host).SetSecondaryNegativeDampThreshold(@power);

    /// <inheritdoc cref="LookAtModifier3D.GetSecondaryNegativeDampThreshold()" />
    public float GetSecondaryNegativeDampThreshold() => ((LookAtModifier3D)_host).GetSecondaryNegativeDampThreshold();

    /// <inheritdoc cref="LookAtModifier3D.GetInterpolationRemaining()" />
    public float GetInterpolationRemaining() => ((LookAtModifier3D)_host).GetInterpolationRemaining();

    /// <inheritdoc cref="LookAtModifier3D.IsInterpolating()" />
    public bool IsInterpolating() => ((LookAtModifier3D)_host).IsInterpolating();

    /// <inheritdoc cref="LookAtModifier3D.IsTargetWithinLimitation()" />
    public bool IsTargetWithinLimitation() => ((LookAtModifier3D)_host).IsTargetWithinLimitation();

}
