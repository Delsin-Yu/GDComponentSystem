#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Skeleton2D" />
[Tool, GlobalClass]
public abstract partial class Skeleton2DComponent : Node2DComponent
{

    /// <inheritdoc cref="Skeleton2D.GetBoneCount()" />
    public int GetBoneCount() => ((Skeleton2D)_host).GetBoneCount();

    /// <inheritdoc cref="Skeleton2D.GetBone(int)" />
    public Bone2D GetBone(int @idx) => ((Skeleton2D)_host).GetBone(@idx);

    /// <inheritdoc cref="Skeleton2D.GetSkeleton()" />
    public Rid GetSkeleton() => ((Skeleton2D)_host).GetSkeleton();

    /// <inheritdoc cref="Skeleton2D.SetModificationStack(SkeletonModificationStack2D)" />
    public void SetModificationStack(SkeletonModificationStack2D @modificationStack) => ((Skeleton2D)_host).SetModificationStack(@modificationStack);

    /// <inheritdoc cref="Skeleton2D.GetModificationStack()" />
    public SkeletonModificationStack2D GetModificationStack() => ((Skeleton2D)_host).GetModificationStack();

    /// <inheritdoc cref="Skeleton2D.ExecuteModifications(float, int)" />
    public void ExecuteModifications(float @delta, int @executionMode) => ((Skeleton2D)_host).ExecuteModifications(@delta, @executionMode);

    /// <inheritdoc cref="Skeleton2D.SetBoneLocalPoseOverride(int, Transform2D, float, bool)" />
    public void SetBoneLocalPoseOverride(int @boneIdx, Transform2D @overridePose, float @strength, bool @persistent) => ((Skeleton2D)_host).SetBoneLocalPoseOverride(@boneIdx, @overridePose, @strength, @persistent);

    /// <inheritdoc cref="Skeleton2D.GetBoneLocalPoseOverride(int)" />
    public Transform2D GetBoneLocalPoseOverride(int @boneIdx) => ((Skeleton2D)_host).GetBoneLocalPoseOverride(@boneIdx);

}
