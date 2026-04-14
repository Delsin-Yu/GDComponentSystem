#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="TwoBoneIK3D" />
[Tool, GlobalClass]
public abstract partial class TwoBoneIK3DComponent : IKModifier3DComponent
{

    /// <inheritdoc cref="TwoBoneIK3D.SetTargetNode(int, NodePath)" />
    public void SetTargetNode(int @index, NodePath @targetNode) => ((TwoBoneIK3D)_host).SetTargetNode(@index, @targetNode);

    /// <inheritdoc cref="TwoBoneIK3D.GetTargetNode(int)" />
    public NodePath GetTargetNode(int @index) => ((TwoBoneIK3D)_host).GetTargetNode(@index);

    /// <inheritdoc cref="TwoBoneIK3D.SetPoleNode(int, NodePath)" />
    public void SetPoleNode(int @index, NodePath @poleNode) => ((TwoBoneIK3D)_host).SetPoleNode(@index, @poleNode);

    /// <inheritdoc cref="TwoBoneIK3D.GetPoleNode(int)" />
    public NodePath GetPoleNode(int @index) => ((TwoBoneIK3D)_host).GetPoleNode(@index);

    /// <inheritdoc cref="TwoBoneIK3D.SetRootBoneName(int, string)" />
    public void SetRootBoneName(int @index, string @boneName) => ((TwoBoneIK3D)_host).SetRootBoneName(@index, @boneName);

    /// <inheritdoc cref="TwoBoneIK3D.GetRootBoneName(int)" />
    public string GetRootBoneName(int @index) => ((TwoBoneIK3D)_host).GetRootBoneName(@index);

    /// <inheritdoc cref="TwoBoneIK3D.SetRootBone(int, int)" />
    public void SetRootBone(int @index, int @bone) => ((TwoBoneIK3D)_host).SetRootBone(@index, @bone);

    /// <inheritdoc cref="TwoBoneIK3D.GetRootBone(int)" />
    public int GetRootBone(int @index) => ((TwoBoneIK3D)_host).GetRootBone(@index);

    /// <inheritdoc cref="TwoBoneIK3D.SetMiddleBoneName(int, string)" />
    public void SetMiddleBoneName(int @index, string @boneName) => ((TwoBoneIK3D)_host).SetMiddleBoneName(@index, @boneName);

    /// <inheritdoc cref="TwoBoneIK3D.GetMiddleBoneName(int)" />
    public string GetMiddleBoneName(int @index) => ((TwoBoneIK3D)_host).GetMiddleBoneName(@index);

    /// <inheritdoc cref="TwoBoneIK3D.SetMiddleBone(int, int)" />
    public void SetMiddleBone(int @index, int @bone) => ((TwoBoneIK3D)_host).SetMiddleBone(@index, @bone);

    /// <inheritdoc cref="TwoBoneIK3D.GetMiddleBone(int)" />
    public int GetMiddleBone(int @index) => ((TwoBoneIK3D)_host).GetMiddleBone(@index);

    /// <inheritdoc cref="TwoBoneIK3D.SetPoleDirection(int, SkeletonModifier3D.SecondaryDirection)" />
    public void SetPoleDirection(int @index, SkeletonModifier3D.SecondaryDirection @direction) => ((TwoBoneIK3D)_host).SetPoleDirection(@index, @direction);

    /// <inheritdoc cref="TwoBoneIK3D.GetPoleDirection(int)" />
    public SkeletonModifier3D.SecondaryDirection GetPoleDirection(int @index) => ((TwoBoneIK3D)_host).GetPoleDirection(@index);

    /// <inheritdoc cref="TwoBoneIK3D.SetPoleDirectionVector(int, Vector3)" />
    public void SetPoleDirectionVector(int @index, Vector3 @vector) => ((TwoBoneIK3D)_host).SetPoleDirectionVector(@index, @vector);

    /// <inheritdoc cref="TwoBoneIK3D.GetPoleDirectionVector(int)" />
    public Vector3 GetPoleDirectionVector(int @index) => ((TwoBoneIK3D)_host).GetPoleDirectionVector(@index);

    /// <inheritdoc cref="TwoBoneIK3D.SetEndBoneName(int, string)" />
    public void SetEndBoneName(int @index, string @boneName) => ((TwoBoneIK3D)_host).SetEndBoneName(@index, @boneName);

    /// <inheritdoc cref="TwoBoneIK3D.GetEndBoneName(int)" />
    public string GetEndBoneName(int @index) => ((TwoBoneIK3D)_host).GetEndBoneName(@index);

    /// <inheritdoc cref="TwoBoneIK3D.SetEndBone(int, int)" />
    public void SetEndBone(int @index, int @bone) => ((TwoBoneIK3D)_host).SetEndBone(@index, @bone);

    /// <inheritdoc cref="TwoBoneIK3D.GetEndBone(int)" />
    public int GetEndBone(int @index) => ((TwoBoneIK3D)_host).GetEndBone(@index);

    /// <inheritdoc cref="TwoBoneIK3D.SetUseVirtualEnd(int, bool)" />
    public void SetUseVirtualEnd(int @index, bool @enabled) => ((TwoBoneIK3D)_host).SetUseVirtualEnd(@index, @enabled);

    /// <inheritdoc cref="TwoBoneIK3D.IsUsingVirtualEnd(int)" />
    public bool IsUsingVirtualEnd(int @index) => ((TwoBoneIK3D)_host).IsUsingVirtualEnd(@index);

    /// <inheritdoc cref="TwoBoneIK3D.SetExtendEndBone(int, bool)" />
    public void SetExtendEndBone(int @index, bool @enabled) => ((TwoBoneIK3D)_host).SetExtendEndBone(@index, @enabled);

    /// <inheritdoc cref="TwoBoneIK3D.IsEndBoneExtended(int)" />
    public bool IsEndBoneExtended(int @index) => ((TwoBoneIK3D)_host).IsEndBoneExtended(@index);

    /// <inheritdoc cref="TwoBoneIK3D.SetEndBoneDirection(int, SkeletonModifier3D.BoneDirection)" />
    public void SetEndBoneDirection(int @index, SkeletonModifier3D.BoneDirection @boneDirection) => ((TwoBoneIK3D)_host).SetEndBoneDirection(@index, @boneDirection);

    /// <inheritdoc cref="TwoBoneIK3D.GetEndBoneDirection(int)" />
    public SkeletonModifier3D.BoneDirection GetEndBoneDirection(int @index) => ((TwoBoneIK3D)_host).GetEndBoneDirection(@index);

    /// <inheritdoc cref="TwoBoneIK3D.SetEndBoneLength(int, float)" />
    public void SetEndBoneLength(int @index, float @length) => ((TwoBoneIK3D)_host).SetEndBoneLength(@index, @length);

    /// <inheritdoc cref="TwoBoneIK3D.GetEndBoneLength(int)" />
    public float GetEndBoneLength(int @index) => ((TwoBoneIK3D)_host).GetEndBoneLength(@index);

}
