#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="BoneConstraint3D" />
[Tool, GlobalClass]
public abstract partial class BoneConstraint3DComponent : SkeletonModifier3DComponent
{

    /// <inheritdoc cref="BoneConstraint3D.SetAmount(int, float)" />
    public void SetAmount(int @index, float @amount) => ((BoneConstraint3D)_host).SetAmount(@index, @amount);

    /// <inheritdoc cref="BoneConstraint3D.GetAmount(int)" />
    public float GetAmount(int @index) => ((BoneConstraint3D)_host).GetAmount(@index);

    /// <inheritdoc cref="BoneConstraint3D.SetApplyBoneName(int, string)" />
    public void SetApplyBoneName(int @index, string @boneName) => ((BoneConstraint3D)_host).SetApplyBoneName(@index, @boneName);

    /// <inheritdoc cref="BoneConstraint3D.GetApplyBoneName(int)" />
    public string GetApplyBoneName(int @index) => ((BoneConstraint3D)_host).GetApplyBoneName(@index);

    /// <inheritdoc cref="BoneConstraint3D.SetApplyBone(int, int)" />
    public void SetApplyBone(int @index, int @bone) => ((BoneConstraint3D)_host).SetApplyBone(@index, @bone);

    /// <inheritdoc cref="BoneConstraint3D.GetApplyBone(int)" />
    public int GetApplyBone(int @index) => ((BoneConstraint3D)_host).GetApplyBone(@index);

    /// <inheritdoc cref="BoneConstraint3D.SetReferenceType(int, BoneConstraint3D.ReferenceType)" />
    public void SetReferenceType(int @index, BoneConstraint3D.ReferenceType @type) => ((BoneConstraint3D)_host).SetReferenceType(@index, @type);

    /// <inheritdoc cref="BoneConstraint3D.GetReferenceType(int)" />
    public BoneConstraint3D.ReferenceType GetReferenceType(int @index) => ((BoneConstraint3D)_host).GetReferenceType(@index);

    /// <inheritdoc cref="BoneConstraint3D.SetReferenceBoneName(int, string)" />
    public void SetReferenceBoneName(int @index, string @boneName) => ((BoneConstraint3D)_host).SetReferenceBoneName(@index, @boneName);

    /// <inheritdoc cref="BoneConstraint3D.GetReferenceBoneName(int)" />
    public string GetReferenceBoneName(int @index) => ((BoneConstraint3D)_host).GetReferenceBoneName(@index);

    /// <inheritdoc cref="BoneConstraint3D.SetReferenceBone(int, int)" />
    public void SetReferenceBone(int @index, int @bone) => ((BoneConstraint3D)_host).SetReferenceBone(@index, @bone);

    /// <inheritdoc cref="BoneConstraint3D.GetReferenceBone(int)" />
    public int GetReferenceBone(int @index) => ((BoneConstraint3D)_host).GetReferenceBone(@index);

    /// <inheritdoc cref="BoneConstraint3D.SetReferenceNode(int, NodePath)" />
    public void SetReferenceNode(int @index, NodePath @node) => ((BoneConstraint3D)_host).SetReferenceNode(@index, @node);

    /// <inheritdoc cref="BoneConstraint3D.GetReferenceNode(int)" />
    public NodePath GetReferenceNode(int @index) => ((BoneConstraint3D)_host).GetReferenceNode(@index);

    /// <inheritdoc cref="BoneConstraint3D.SetSettingCount(int)" />
    public void SetSettingCount(int @count) => ((BoneConstraint3D)_host).SetSettingCount(@count);

    /// <inheritdoc cref="BoneConstraint3D.GetSettingCount()" />
    public int GetSettingCount() => ((BoneConstraint3D)_host).GetSettingCount();

    /// <inheritdoc cref="BoneConstraint3D.ClearSetting()" />
    public void ClearSetting() => ((BoneConstraint3D)_host).ClearSetting();

}
