#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="SkeletonIK3D" />
[Tool, GlobalClass]
public abstract partial class SkeletonIK3DComponent : SkeletonModifier3DComponent
{

    /// <inheritdoc cref="SkeletonIK3D.SetRootBone(StringName)" />
    public void SetRootBone(StringName @rootBone) => ((SkeletonIK3D)_host).SetRootBone(@rootBone);

    /// <inheritdoc cref="SkeletonIK3D.GetRootBone()" />
    public StringName GetRootBone() => ((SkeletonIK3D)_host).GetRootBone();

    /// <inheritdoc cref="SkeletonIK3D.SetTipBone(StringName)" />
    public void SetTipBone(StringName @tipBone) => ((SkeletonIK3D)_host).SetTipBone(@tipBone);

    /// <inheritdoc cref="SkeletonIK3D.GetTipBone()" />
    public StringName GetTipBone() => ((SkeletonIK3D)_host).GetTipBone();

    /// <inheritdoc cref="SkeletonIK3D.SetTargetTransform(Transform3D)" />
    public void SetTargetTransform(Transform3D @target) => ((SkeletonIK3D)_host).SetTargetTransform(@target);

    /// <inheritdoc cref="SkeletonIK3D.GetTargetTransform()" />
    public Transform3D GetTargetTransform() => ((SkeletonIK3D)_host).GetTargetTransform();

    /// <inheritdoc cref="SkeletonIK3D.SetTargetNode(NodePath)" />
    public void SetTargetNode(NodePath @node) => ((SkeletonIK3D)_host).SetTargetNode(@node);

    /// <inheritdoc cref="SkeletonIK3D.GetTargetNode()" />
    public NodePath GetTargetNode() => ((SkeletonIK3D)_host).GetTargetNode();

    /// <inheritdoc cref="SkeletonIK3D.SetOverrideTipBasis(bool)" />
    public void SetOverrideTipBasis(bool @override) => ((SkeletonIK3D)_host).SetOverrideTipBasis(@override);

    /// <inheritdoc cref="SkeletonIK3D.IsOverrideTipBasis()" />
    public bool IsOverrideTipBasis() => ((SkeletonIK3D)_host).IsOverrideTipBasis();

    /// <inheritdoc cref="SkeletonIK3D.SetUseMagnet(bool)" />
    public void SetUseMagnet(bool @use) => ((SkeletonIK3D)_host).SetUseMagnet(@use);

    /// <inheritdoc cref="SkeletonIK3D.IsUsingMagnet()" />
    public bool IsUsingMagnet() => ((SkeletonIK3D)_host).IsUsingMagnet();

    /// <inheritdoc cref="SkeletonIK3D.SetMagnetPosition(Vector3)" />
    public void SetMagnetPosition(Vector3 @localPosition) => ((SkeletonIK3D)_host).SetMagnetPosition(@localPosition);

    /// <inheritdoc cref="SkeletonIK3D.GetMagnetPosition()" />
    public Vector3 GetMagnetPosition() => ((SkeletonIK3D)_host).GetMagnetPosition();

    /// <inheritdoc cref="SkeletonIK3D.GetParentSkeleton()" />
    public Skeleton3D GetParentSkeleton() => ((SkeletonIK3D)_host).GetParentSkeleton();

    /// <inheritdoc cref="SkeletonIK3D.IsRunning()" />
    public bool IsRunning() => ((SkeletonIK3D)_host).IsRunning();

    /// <inheritdoc cref="SkeletonIK3D.SetMinDistance(float)" />
    public void SetMinDistance(float @minDistance) => ((SkeletonIK3D)_host).SetMinDistance(@minDistance);

    /// <inheritdoc cref="SkeletonIK3D.GetMinDistance()" />
    public float GetMinDistance() => ((SkeletonIK3D)_host).GetMinDistance();

    /// <inheritdoc cref="SkeletonIK3D.SetMaxIterations(int)" />
    public void SetMaxIterations(int @iterations) => ((SkeletonIK3D)_host).SetMaxIterations(@iterations);

    /// <inheritdoc cref="SkeletonIK3D.GetMaxIterations()" />
    public int GetMaxIterations() => ((SkeletonIK3D)_host).GetMaxIterations();

    /// <inheritdoc cref="SkeletonIK3D.Start(bool)" />
    public void Start(bool @oneTime) => ((SkeletonIK3D)_host).Start(@oneTime);

    /// <inheritdoc cref="SkeletonIK3D.Stop()" />
    public void Stop() => ((SkeletonIK3D)_host).Stop();

    /// <inheritdoc cref="SkeletonIK3D.SetInterpolation(float)" />
    public void SetInterpolation(float @interpolation) => ((SkeletonIK3D)_host).SetInterpolation(@interpolation);

    /// <inheritdoc cref="SkeletonIK3D.GetInterpolation()" />
    public float GetInterpolation() => ((SkeletonIK3D)_host).GetInterpolation();

}
