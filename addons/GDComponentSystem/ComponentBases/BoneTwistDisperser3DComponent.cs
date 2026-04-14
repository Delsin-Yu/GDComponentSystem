#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="BoneTwistDisperser3D" />
[Tool, GlobalClass]
public abstract partial class BoneTwistDisperser3DComponent : SkeletonModifier3DComponent
{

    /// <inheritdoc cref="BoneTwistDisperser3D.SetSettingCount(int)" />
    public void SetSettingCount(int @count) => ((BoneTwistDisperser3D)_host).SetSettingCount(@count);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetSettingCount()" />
    public int GetSettingCount() => ((BoneTwistDisperser3D)_host).GetSettingCount();

    /// <inheritdoc cref="BoneTwistDisperser3D.ClearSettings()" />
    public void ClearSettings() => ((BoneTwistDisperser3D)_host).ClearSettings();

    /// <inheritdoc cref="BoneTwistDisperser3D.SetMutableBoneAxes(bool)" />
    public void SetMutableBoneAxes(bool @enabled) => ((BoneTwistDisperser3D)_host).SetMutableBoneAxes(@enabled);

    /// <inheritdoc cref="BoneTwistDisperser3D.AreBoneAxesMutable()" />
    public bool AreBoneAxesMutable() => ((BoneTwistDisperser3D)_host).AreBoneAxesMutable();

    /// <inheritdoc cref="BoneTwistDisperser3D.SetRootBoneName(int, string)" />
    public void SetRootBoneName(int @index, string @boneName) => ((BoneTwistDisperser3D)_host).SetRootBoneName(@index, @boneName);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetRootBoneName(int)" />
    public string GetRootBoneName(int @index) => ((BoneTwistDisperser3D)_host).GetRootBoneName(@index);

    /// <inheritdoc cref="BoneTwistDisperser3D.SetRootBone(int, int)" />
    public void SetRootBone(int @index, int @bone) => ((BoneTwistDisperser3D)_host).SetRootBone(@index, @bone);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetRootBone(int)" />
    public int GetRootBone(int @index) => ((BoneTwistDisperser3D)_host).GetRootBone(@index);

    /// <inheritdoc cref="BoneTwistDisperser3D.SetEndBoneName(int, string)" />
    public void SetEndBoneName(int @index, string @boneName) => ((BoneTwistDisperser3D)_host).SetEndBoneName(@index, @boneName);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetEndBoneName(int)" />
    public string GetEndBoneName(int @index) => ((BoneTwistDisperser3D)_host).GetEndBoneName(@index);

    /// <inheritdoc cref="BoneTwistDisperser3D.SetEndBone(int, int)" />
    public void SetEndBone(int @index, int @bone) => ((BoneTwistDisperser3D)_host).SetEndBone(@index, @bone);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetEndBone(int)" />
    public int GetEndBone(int @index) => ((BoneTwistDisperser3D)_host).GetEndBone(@index);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetReferenceBoneName(int)" />
    public string GetReferenceBoneName(int @index) => ((BoneTwistDisperser3D)_host).GetReferenceBoneName(@index);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetReferenceBone(int)" />
    public int GetReferenceBone(int @index) => ((BoneTwistDisperser3D)_host).GetReferenceBone(@index);

    /// <inheritdoc cref="BoneTwistDisperser3D.SetExtendEndBone(int, bool)" />
    public void SetExtendEndBone(int @index, bool @enabled) => ((BoneTwistDisperser3D)_host).SetExtendEndBone(@index, @enabled);

    /// <inheritdoc cref="BoneTwistDisperser3D.IsEndBoneExtended(int)" />
    public bool IsEndBoneExtended(int @index) => ((BoneTwistDisperser3D)_host).IsEndBoneExtended(@index);

    /// <inheritdoc cref="BoneTwistDisperser3D.SetEndBoneDirection(int, SkeletonModifier3D.BoneDirection)" />
    public void SetEndBoneDirection(int @index, SkeletonModifier3D.BoneDirection @boneDirection) => ((BoneTwistDisperser3D)_host).SetEndBoneDirection(@index, @boneDirection);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetEndBoneDirection(int)" />
    public SkeletonModifier3D.BoneDirection GetEndBoneDirection(int @index) => ((BoneTwistDisperser3D)_host).GetEndBoneDirection(@index);

    /// <inheritdoc cref="BoneTwistDisperser3D.SetTwistFromRest(int, bool)" />
    public void SetTwistFromRest(int @index, bool @enabled) => ((BoneTwistDisperser3D)_host).SetTwistFromRest(@index, @enabled);

    /// <inheritdoc cref="BoneTwistDisperser3D.IsTwistFromRest(int)" />
    public bool IsTwistFromRest(int @index) => ((BoneTwistDisperser3D)_host).IsTwistFromRest(@index);

    /// <inheritdoc cref="BoneTwistDisperser3D.SetTwistFrom(int, Quaternion)" />
    public void SetTwistFrom(int @index, Quaternion @from) => ((BoneTwistDisperser3D)_host).SetTwistFrom(@index, @from);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetTwistFrom(int)" />
    public Quaternion GetTwistFrom(int @index) => ((BoneTwistDisperser3D)_host).GetTwistFrom(@index);

    /// <inheritdoc cref="BoneTwistDisperser3D.SetDisperseMode(int, BoneTwistDisperser3D.DisperseMode)" />
    public void SetDisperseMode(int @index, BoneTwistDisperser3D.DisperseMode @disperseMode) => ((BoneTwistDisperser3D)_host).SetDisperseMode(@index, @disperseMode);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetDisperseMode(int)" />
    public BoneTwistDisperser3D.DisperseMode GetDisperseMode(int @index) => ((BoneTwistDisperser3D)_host).GetDisperseMode(@index);

    /// <inheritdoc cref="BoneTwistDisperser3D.SetWeightPosition(int, float)" />
    public void SetWeightPosition(int @index, float @weightPosition) => ((BoneTwistDisperser3D)_host).SetWeightPosition(@index, @weightPosition);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetWeightPosition(int)" />
    public float GetWeightPosition(int @index) => ((BoneTwistDisperser3D)_host).GetWeightPosition(@index);

    /// <inheritdoc cref="BoneTwistDisperser3D.SetDampingCurve(int, Curve)" />
    public void SetDampingCurve(int @index, Curve @curve) => ((BoneTwistDisperser3D)_host).SetDampingCurve(@index, @curve);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetDampingCurve(int)" />
    public Curve GetDampingCurve(int @index) => ((BoneTwistDisperser3D)_host).GetDampingCurve(@index);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetJointBoneName(int, int)" />
    public string GetJointBoneName(int @index, int @joint) => ((BoneTwistDisperser3D)_host).GetJointBoneName(@index, @joint);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetJointBone(int, int)" />
    public int GetJointBone(int @index, int @joint) => ((BoneTwistDisperser3D)_host).GetJointBone(@index, @joint);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetJointTwistAmount(int, int)" />
    public float GetJointTwistAmount(int @index, int @joint) => ((BoneTwistDisperser3D)_host).GetJointTwistAmount(@index, @joint);

    /// <inheritdoc cref="BoneTwistDisperser3D.SetJointTwistAmount(int, int, float)" />
    public void SetJointTwistAmount(int @index, int @joint, float @twistAmount) => ((BoneTwistDisperser3D)_host).SetJointTwistAmount(@index, @joint, @twistAmount);

    /// <inheritdoc cref="BoneTwistDisperser3D.GetJointCount(int)" />
    public int GetJointCount(int @index) => ((BoneTwistDisperser3D)_host).GetJointCount(@index);

}
