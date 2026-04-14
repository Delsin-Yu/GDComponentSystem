#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ChainIK3D" />
[Tool, GlobalClass]
public abstract partial class ChainIK3DComponent : IKModifier3DComponent
{

    /// <inheritdoc cref="ChainIK3D.SetRootBoneName(int, string)" />
    public void SetRootBoneName(int @index, string @boneName) => ((ChainIK3D)_host).SetRootBoneName(@index, @boneName);

    /// <inheritdoc cref="ChainIK3D.GetRootBoneName(int)" />
    public string GetRootBoneName(int @index) => ((ChainIK3D)_host).GetRootBoneName(@index);

    /// <inheritdoc cref="ChainIK3D.SetRootBone(int, int)" />
    public void SetRootBone(int @index, int @bone) => ((ChainIK3D)_host).SetRootBone(@index, @bone);

    /// <inheritdoc cref="ChainIK3D.GetRootBone(int)" />
    public int GetRootBone(int @index) => ((ChainIK3D)_host).GetRootBone(@index);

    /// <inheritdoc cref="ChainIK3D.SetEndBoneName(int, string)" />
    public void SetEndBoneName(int @index, string @boneName) => ((ChainIK3D)_host).SetEndBoneName(@index, @boneName);

    /// <inheritdoc cref="ChainIK3D.GetEndBoneName(int)" />
    public string GetEndBoneName(int @index) => ((ChainIK3D)_host).GetEndBoneName(@index);

    /// <inheritdoc cref="ChainIK3D.SetEndBone(int, int)" />
    public void SetEndBone(int @index, int @bone) => ((ChainIK3D)_host).SetEndBone(@index, @bone);

    /// <inheritdoc cref="ChainIK3D.GetEndBone(int)" />
    public int GetEndBone(int @index) => ((ChainIK3D)_host).GetEndBone(@index);

    /// <inheritdoc cref="ChainIK3D.SetExtendEndBone(int, bool)" />
    public void SetExtendEndBone(int @index, bool @enabled) => ((ChainIK3D)_host).SetExtendEndBone(@index, @enabled);

    /// <inheritdoc cref="ChainIK3D.IsEndBoneExtended(int)" />
    public bool IsEndBoneExtended(int @index) => ((ChainIK3D)_host).IsEndBoneExtended(@index);

    /// <inheritdoc cref="ChainIK3D.SetEndBoneDirection(int, SkeletonModifier3D.BoneDirection)" />
    public void SetEndBoneDirection(int @index, SkeletonModifier3D.BoneDirection @boneDirection) => ((ChainIK3D)_host).SetEndBoneDirection(@index, @boneDirection);

    /// <inheritdoc cref="ChainIK3D.GetEndBoneDirection(int)" />
    public SkeletonModifier3D.BoneDirection GetEndBoneDirection(int @index) => ((ChainIK3D)_host).GetEndBoneDirection(@index);

    /// <inheritdoc cref="ChainIK3D.SetEndBoneLength(int, float)" />
    public void SetEndBoneLength(int @index, float @length) => ((ChainIK3D)_host).SetEndBoneLength(@index, @length);

    /// <inheritdoc cref="ChainIK3D.GetEndBoneLength(int)" />
    public float GetEndBoneLength(int @index) => ((ChainIK3D)_host).GetEndBoneLength(@index);

    /// <inheritdoc cref="ChainIK3D.GetJointBoneName(int, int)" />
    public string GetJointBoneName(int @index, int @joint) => ((ChainIK3D)_host).GetJointBoneName(@index, @joint);

    /// <inheritdoc cref="ChainIK3D.GetJointBone(int, int)" />
    public int GetJointBone(int @index, int @joint) => ((ChainIK3D)_host).GetJointBone(@index, @joint);

    /// <inheritdoc cref="ChainIK3D.GetJointCount(int)" />
    public int GetJointCount(int @index) => ((ChainIK3D)_host).GetJointCount(@index);

}
