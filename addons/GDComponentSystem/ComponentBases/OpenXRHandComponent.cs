#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="OpenXRHand" />
[Tool, GlobalClass]
public abstract partial class OpenXRHandComponent : Node3DComponent
{

    /// <inheritdoc cref="OpenXRHand.SetHand(OpenXRHand.Hands)" />
    public void SetHand(OpenXRHand.Hands @hand) => ((OpenXRHand)_host).SetHand(@hand);

    /// <inheritdoc cref="OpenXRHand.GetHand()" />
    public OpenXRHand.Hands GetHand() => ((OpenXRHand)_host).GetHand();

    /// <inheritdoc cref="OpenXRHand.SetHandSkeleton(NodePath)" />
    public void SetHandSkeleton(NodePath @handSkeleton) => ((OpenXRHand)_host).SetHandSkeleton(@handSkeleton);

    /// <inheritdoc cref="OpenXRHand.GetHandSkeleton()" />
    public NodePath GetHandSkeleton() => ((OpenXRHand)_host).GetHandSkeleton();

    /// <inheritdoc cref="OpenXRHand.SetMotionRange(OpenXRHand.MotionRangeEnum)" />
    public void SetMotionRange(OpenXRHand.MotionRangeEnum @motionRange) => ((OpenXRHand)_host).SetMotionRange(@motionRange);

    /// <inheritdoc cref="OpenXRHand.GetMotionRange()" />
    public OpenXRHand.MotionRangeEnum GetMotionRange() => ((OpenXRHand)_host).GetMotionRange();

    /// <inheritdoc cref="OpenXRHand.SetSkeletonRig(OpenXRHand.SkeletonRigEnum)" />
    public void SetSkeletonRig(OpenXRHand.SkeletonRigEnum @skeletonRig) => ((OpenXRHand)_host).SetSkeletonRig(@skeletonRig);

    /// <inheritdoc cref="OpenXRHand.GetSkeletonRig()" />
    public OpenXRHand.SkeletonRigEnum GetSkeletonRig() => ((OpenXRHand)_host).GetSkeletonRig();

    /// <inheritdoc cref="OpenXRHand.SetBoneUpdate(OpenXRHand.BoneUpdateEnum)" />
    public void SetBoneUpdate(OpenXRHand.BoneUpdateEnum @boneUpdate) => ((OpenXRHand)_host).SetBoneUpdate(@boneUpdate);

    /// <inheritdoc cref="OpenXRHand.GetBoneUpdate()" />
    public OpenXRHand.BoneUpdateEnum GetBoneUpdate() => ((OpenXRHand)_host).GetBoneUpdate();

}
