#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="IterateIK3D" />
[Tool, GlobalClass]
public abstract partial class IterateIK3DComponent : ChainIK3DComponent
{

    /// <inheritdoc cref="IterateIK3D.SetMaxIterations(int)" />
    public void SetMaxIterations(int @maxIterations) => ((IterateIK3D)_host).SetMaxIterations(@maxIterations);

    /// <inheritdoc cref="IterateIK3D.GetMaxIterations()" />
    public int GetMaxIterations() => ((IterateIK3D)_host).GetMaxIterations();

    /// <inheritdoc cref="IterateIK3D.SetMinDistance(double)" />
    public void SetMinDistance(double @minDistance) => ((IterateIK3D)_host).SetMinDistance(@minDistance);

    /// <inheritdoc cref="IterateIK3D.GetMinDistance()" />
    public double GetMinDistance() => ((IterateIK3D)_host).GetMinDistance();

    /// <inheritdoc cref="IterateIK3D.SetAngularDeltaLimit(double)" />
    public void SetAngularDeltaLimit(double @angularDeltaLimit) => ((IterateIK3D)_host).SetAngularDeltaLimit(@angularDeltaLimit);

    /// <inheritdoc cref="IterateIK3D.GetAngularDeltaLimit()" />
    public double GetAngularDeltaLimit() => ((IterateIK3D)_host).GetAngularDeltaLimit();

    /// <inheritdoc cref="IterateIK3D.SetDeterministic(bool)" />
    public void SetDeterministic(bool @deterministic) => ((IterateIK3D)_host).SetDeterministic(@deterministic);

    /// <inheritdoc cref="IterateIK3D.IsDeterministic()" />
    public bool IsDeterministic() => ((IterateIK3D)_host).IsDeterministic();

    /// <inheritdoc cref="IterateIK3D.SetTargetNode(int, NodePath)" />
    public void SetTargetNode(int @index, NodePath @targetNode) => ((IterateIK3D)_host).SetTargetNode(@index, @targetNode);

    /// <inheritdoc cref="IterateIK3D.GetTargetNode(int)" />
    public NodePath GetTargetNode(int @index) => ((IterateIK3D)_host).GetTargetNode(@index);

    /// <inheritdoc cref="IterateIK3D.SetJointRotationAxis(int, int, SkeletonModifier3D.RotationAxis)" />
    public void SetJointRotationAxis(int @index, int @joint, SkeletonModifier3D.RotationAxis @axis) => ((IterateIK3D)_host).SetJointRotationAxis(@index, @joint, @axis);

    /// <inheritdoc cref="IterateIK3D.GetJointRotationAxis(int, int)" />
    public SkeletonModifier3D.RotationAxis GetJointRotationAxis(int @index, int @joint) => ((IterateIK3D)_host).GetJointRotationAxis(@index, @joint);

    /// <inheritdoc cref="IterateIK3D.SetJointRotationAxisVector(int, int, Vector3)" />
    public void SetJointRotationAxisVector(int @index, int @joint, Vector3 @axisVector) => ((IterateIK3D)_host).SetJointRotationAxisVector(@index, @joint, @axisVector);

    /// <inheritdoc cref="IterateIK3D.GetJointRotationAxisVector(int, int)" />
    public Vector3 GetJointRotationAxisVector(int @index, int @joint) => ((IterateIK3D)_host).GetJointRotationAxisVector(@index, @joint);

    /// <inheritdoc cref="IterateIK3D.SetJointLimitation(int, int, JointLimitation3D)" />
    public void SetJointLimitation(int @index, int @joint, JointLimitation3D @limitation) => ((IterateIK3D)_host).SetJointLimitation(@index, @joint, @limitation);

    /// <inheritdoc cref="IterateIK3D.GetJointLimitation(int, int)" />
    public JointLimitation3D GetJointLimitation(int @index, int @joint) => ((IterateIK3D)_host).GetJointLimitation(@index, @joint);

    /// <inheritdoc cref="IterateIK3D.SetJointLimitationRightAxis(int, int, SkeletonModifier3D.SecondaryDirection)" />
    public void SetJointLimitationRightAxis(int @index, int @joint, SkeletonModifier3D.SecondaryDirection @direction) => ((IterateIK3D)_host).SetJointLimitationRightAxis(@index, @joint, @direction);

    /// <inheritdoc cref="IterateIK3D.GetJointLimitationRightAxis(int, int)" />
    public SkeletonModifier3D.SecondaryDirection GetJointLimitationRightAxis(int @index, int @joint) => ((IterateIK3D)_host).GetJointLimitationRightAxis(@index, @joint);

    /// <inheritdoc cref="IterateIK3D.SetJointLimitationRightAxisVector(int, int, Vector3)" />
    public void SetJointLimitationRightAxisVector(int @index, int @joint, Vector3 @vector) => ((IterateIK3D)_host).SetJointLimitationRightAxisVector(@index, @joint, @vector);

    /// <inheritdoc cref="IterateIK3D.GetJointLimitationRightAxisVector(int, int)" />
    public Vector3 GetJointLimitationRightAxisVector(int @index, int @joint) => ((IterateIK3D)_host).GetJointLimitationRightAxisVector(@index, @joint);

    /// <inheritdoc cref="IterateIK3D.SetJointLimitationRotationOffset(int, int, Quaternion)" />
    public void SetJointLimitationRotationOffset(int @index, int @joint, Quaternion @offset) => ((IterateIK3D)_host).SetJointLimitationRotationOffset(@index, @joint, @offset);

    /// <inheritdoc cref="IterateIK3D.GetJointLimitationRotationOffset(int, int)" />
    public Quaternion GetJointLimitationRotationOffset(int @index, int @joint) => ((IterateIK3D)_host).GetJointLimitationRotationOffset(@index, @joint);

}
