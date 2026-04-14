#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="BoneAttachment3D" />
[Tool, GlobalClass]
public abstract partial class BoneAttachment3DComponent : Node3DComponent
{

    /// <inheritdoc cref="BoneAttachment3D.GetSkeleton()" />
    public Skeleton3D GetSkeleton() => ((BoneAttachment3D)_host).GetSkeleton();

    /// <inheritdoc cref="BoneAttachment3D.SetBoneName(string)" />
    public void SetBoneName(string @boneName) => ((BoneAttachment3D)_host).SetBoneName(@boneName);

    /// <inheritdoc cref="BoneAttachment3D.GetBoneName()" />
    public string GetBoneName() => ((BoneAttachment3D)_host).GetBoneName();

    /// <inheritdoc cref="BoneAttachment3D.SetBoneIdx(int)" />
    public void SetBoneIdx(int @boneIdx) => ((BoneAttachment3D)_host).SetBoneIdx(@boneIdx);

    /// <inheritdoc cref="BoneAttachment3D.GetBoneIdx()" />
    public int GetBoneIdx() => ((BoneAttachment3D)_host).GetBoneIdx();

    /// <inheritdoc cref="BoneAttachment3D.OnSkeletonUpdate()" />
    public void OnSkeletonUpdate() => ((BoneAttachment3D)_host).OnSkeletonUpdate();

    /// <inheritdoc cref="BoneAttachment3D.SetOverridePose(bool)" />
    public void SetOverridePose(bool @overridePose) => ((BoneAttachment3D)_host).SetOverridePose(@overridePose);

    /// <inheritdoc cref="BoneAttachment3D.GetOverridePose()" />
    public bool GetOverridePose() => ((BoneAttachment3D)_host).GetOverridePose();

    /// <inheritdoc cref="BoneAttachment3D.SetUseExternalSkeleton(bool)" />
    public void SetUseExternalSkeleton(bool @useExternalSkeleton) => ((BoneAttachment3D)_host).SetUseExternalSkeleton(@useExternalSkeleton);

    /// <inheritdoc cref="BoneAttachment3D.GetUseExternalSkeleton()" />
    public bool GetUseExternalSkeleton() => ((BoneAttachment3D)_host).GetUseExternalSkeleton();

    /// <inheritdoc cref="BoneAttachment3D.SetExternalSkeleton(NodePath)" />
    public void SetExternalSkeleton(NodePath @externalSkeleton) => ((BoneAttachment3D)_host).SetExternalSkeleton(@externalSkeleton);

    /// <inheritdoc cref="BoneAttachment3D.GetExternalSkeleton()" />
    public NodePath GetExternalSkeleton() => ((BoneAttachment3D)_host).GetExternalSkeleton();

    /// <inheritdoc cref="BoneAttachment3D.OnBonePoseUpdate(int)" />
    public void OnBonePoseUpdate(int @boneIndex) => ((BoneAttachment3D)_host).OnBonePoseUpdate(@boneIndex);

}
