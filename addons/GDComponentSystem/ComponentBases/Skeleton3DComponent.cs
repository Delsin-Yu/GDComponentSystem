#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Skeleton3D" />
[Tool, GlobalClass]
public abstract partial class Skeleton3DComponent : Node3DComponent
{

    /// <inheritdoc cref="Skeleton3D.AddBone(string)" />
    public int AddBone(string @name) => ((Skeleton3D)_host).AddBone(@name);

    /// <inheritdoc cref="Skeleton3D.FindBone(string)" />
    public int FindBone(string @name) => ((Skeleton3D)_host).FindBone(@name);

    /// <inheritdoc cref="Skeleton3D.GetBoneName(int)" />
    public string GetBoneName(int @boneIdx) => ((Skeleton3D)_host).GetBoneName(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.SetBoneName(int, string)" />
    public void SetBoneName(int @boneIdx, string @name) => ((Skeleton3D)_host).SetBoneName(@boneIdx, @name);

    /// <inheritdoc cref="Skeleton3D.GetBoneMeta(int, StringName)" />
    public Variant GetBoneMeta(int @boneIdx, StringName @key) => ((Skeleton3D)_host).GetBoneMeta(@boneIdx, @key);

    /// <inheritdoc cref="Skeleton3D.GetBoneMetaList(int)" />
    public Array<StringName> GetBoneMetaList(int @boneIdx) => ((Skeleton3D)_host).GetBoneMetaList(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.HasBoneMeta(int, StringName)" />
    public bool HasBoneMeta(int @boneIdx, StringName @key) => ((Skeleton3D)_host).HasBoneMeta(@boneIdx, @key);

    /// <inheritdoc cref="Skeleton3D.SetBoneMeta(int, StringName, Variant)" />
    public void SetBoneMeta(int @boneIdx, StringName @key, Variant @value) => ((Skeleton3D)_host).SetBoneMeta(@boneIdx, @key, @value);

    /// <inheritdoc cref="Skeleton3D.GetConcatenatedBoneNames()" />
    public StringName GetConcatenatedBoneNames() => ((Skeleton3D)_host).GetConcatenatedBoneNames();

    /// <inheritdoc cref="Skeleton3D.GetBoneParent(int)" />
    public int GetBoneParent(int @boneIdx) => ((Skeleton3D)_host).GetBoneParent(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.SetBoneParent(int, int)" />
    public void SetBoneParent(int @boneIdx, int @parentIdx) => ((Skeleton3D)_host).SetBoneParent(@boneIdx, @parentIdx);

    /// <inheritdoc cref="Skeleton3D.GetBoneCount()" />
    public int GetBoneCount() => ((Skeleton3D)_host).GetBoneCount();

    /// <inheritdoc cref="Skeleton3D.GetVersion()" />
    public ulong GetVersion() => ((Skeleton3D)_host).GetVersion();

    /// <inheritdoc cref="Skeleton3D.UnparentBoneAndRest(int)" />
    public void UnparentBoneAndRest(int @boneIdx) => ((Skeleton3D)_host).UnparentBoneAndRest(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.GetBoneChildren(int)" />
    public int[] GetBoneChildren(int @boneIdx) => ((Skeleton3D)_host).GetBoneChildren(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.GetParentlessBones()" />
    public int[] GetParentlessBones() => ((Skeleton3D)_host).GetParentlessBones();

    /// <inheritdoc cref="Skeleton3D.GetBoneRest(int)" />
    public Transform3D GetBoneRest(int @boneIdx) => ((Skeleton3D)_host).GetBoneRest(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.SetBoneRest(int, Transform3D)" />
    public void SetBoneRest(int @boneIdx, Transform3D @rest) => ((Skeleton3D)_host).SetBoneRest(@boneIdx, @rest);

    /// <inheritdoc cref="Skeleton3D.GetBoneGlobalRest(int)" />
    public Transform3D GetBoneGlobalRest(int @boneIdx) => ((Skeleton3D)_host).GetBoneGlobalRest(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.CreateSkinFromRestTransforms()" />
    public Skin CreateSkinFromRestTransforms() => ((Skeleton3D)_host).CreateSkinFromRestTransforms();

    /// <inheritdoc cref="Skeleton3D.RegisterSkin(Skin)" />
    public SkinReference RegisterSkin(Skin @skin) => ((Skeleton3D)_host).RegisterSkin(@skin);

    /// <inheritdoc cref="Skeleton3D.LocalizeRests()" />
    public void LocalizeRests() => ((Skeleton3D)_host).LocalizeRests();

    /// <inheritdoc cref="Skeleton3D.ClearBones()" />
    public void ClearBones() => ((Skeleton3D)_host).ClearBones();

    /// <inheritdoc cref="Skeleton3D.GetBonePose(int)" />
    public Transform3D GetBonePose(int @boneIdx) => ((Skeleton3D)_host).GetBonePose(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.SetBonePose(int, Transform3D)" />
    public void SetBonePose(int @boneIdx, Transform3D @pose) => ((Skeleton3D)_host).SetBonePose(@boneIdx, @pose);

    /// <inheritdoc cref="Skeleton3D.SetBonePosePosition(int, Vector3)" />
    public void SetBonePosePosition(int @boneIdx, Vector3 @position) => ((Skeleton3D)_host).SetBonePosePosition(@boneIdx, @position);

    /// <inheritdoc cref="Skeleton3D.SetBonePoseRotation(int, Quaternion)" />
    public void SetBonePoseRotation(int @boneIdx, Quaternion @rotation) => ((Skeleton3D)_host).SetBonePoseRotation(@boneIdx, @rotation);

    /// <inheritdoc cref="Skeleton3D.SetBonePoseScale(int, Vector3)" />
    public void SetBonePoseScale(int @boneIdx, Vector3 @scale) => ((Skeleton3D)_host).SetBonePoseScale(@boneIdx, @scale);

    /// <inheritdoc cref="Skeleton3D.GetBonePosePosition(int)" />
    public Vector3 GetBonePosePosition(int @boneIdx) => ((Skeleton3D)_host).GetBonePosePosition(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.GetBonePoseRotation(int)" />
    public Quaternion GetBonePoseRotation(int @boneIdx) => ((Skeleton3D)_host).GetBonePoseRotation(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.GetBonePoseScale(int)" />
    public Vector3 GetBonePoseScale(int @boneIdx) => ((Skeleton3D)_host).GetBonePoseScale(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.ResetBonePose(int)" />
    public void ResetBonePose(int @boneIdx) => ((Skeleton3D)_host).ResetBonePose(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.ResetBonePoses()" />
    public void ResetBonePoses() => ((Skeleton3D)_host).ResetBonePoses();

    /// <inheritdoc cref="Skeleton3D.IsBoneEnabled(int)" />
    public bool IsBoneEnabled(int @boneIdx) => ((Skeleton3D)_host).IsBoneEnabled(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.SetBoneEnabled(int, bool)" />
    public void SetBoneEnabled(int @boneIdx, bool @enabled) => ((Skeleton3D)_host).SetBoneEnabled(@boneIdx, @enabled);

    /// <inheritdoc cref="Skeleton3D.GetBoneGlobalPose(int)" />
    public Transform3D GetBoneGlobalPose(int @boneIdx) => ((Skeleton3D)_host).GetBoneGlobalPose(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.SetBoneGlobalPose(int, Transform3D)" />
    public void SetBoneGlobalPose(int @boneIdx, Transform3D @pose) => ((Skeleton3D)_host).SetBoneGlobalPose(@boneIdx, @pose);

    /// <inheritdoc cref="Skeleton3D.ForceUpdateAllBoneTransforms()" />
    public void ForceUpdateAllBoneTransforms() => ((Skeleton3D)_host).ForceUpdateAllBoneTransforms();

    /// <inheritdoc cref="Skeleton3D.ForceUpdateBoneChildTransform(int)" />
    public void ForceUpdateBoneChildTransform(int @boneIdx) => ((Skeleton3D)_host).ForceUpdateBoneChildTransform(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.SetMotionScale(float)" />
    public void SetMotionScale(float @motionScale) => ((Skeleton3D)_host).SetMotionScale(@motionScale);

    /// <inheritdoc cref="Skeleton3D.GetMotionScale()" />
    public float GetMotionScale() => ((Skeleton3D)_host).GetMotionScale();

    /// <inheritdoc cref="Skeleton3D.SetShowRestOnly(bool)" />
    public void SetShowRestOnly(bool @enabled) => ((Skeleton3D)_host).SetShowRestOnly(@enabled);

    /// <inheritdoc cref="Skeleton3D.IsShowRestOnly()" />
    public bool IsShowRestOnly() => ((Skeleton3D)_host).IsShowRestOnly();

    /// <inheritdoc cref="Skeleton3D.SetModifierCallbackModeProcess(Skeleton3D.ModifierCallbackModeProcessEnum)" />
    public void SetModifierCallbackModeProcess(Skeleton3D.ModifierCallbackModeProcessEnum @mode) => ((Skeleton3D)_host).SetModifierCallbackModeProcess(@mode);

    /// <inheritdoc cref="Skeleton3D.GetModifierCallbackModeProcess()" />
    public Skeleton3D.ModifierCallbackModeProcessEnum GetModifierCallbackModeProcess() => ((Skeleton3D)_host).GetModifierCallbackModeProcess();

    /// <inheritdoc cref="Skeleton3D.Advance(double)" />
    public void Advance(double @delta) => ((Skeleton3D)_host).Advance(@delta);

    /// <inheritdoc cref="Skeleton3D.ClearBonesGlobalPoseOverride()" />
    public void ClearBonesGlobalPoseOverride() => ((Skeleton3D)_host).ClearBonesGlobalPoseOverride();

    /// <inheritdoc cref="Skeleton3D.SetBoneGlobalPoseOverride(int, Transform3D, float, bool)" />
    public void SetBoneGlobalPoseOverride(int @boneIdx, Transform3D @pose, float @amount, bool @persistent) => ((Skeleton3D)_host).SetBoneGlobalPoseOverride(@boneIdx, @pose, @amount, @persistent);

    /// <inheritdoc cref="Skeleton3D.GetBoneGlobalPoseOverride(int)" />
    public Transform3D GetBoneGlobalPoseOverride(int @boneIdx) => ((Skeleton3D)_host).GetBoneGlobalPoseOverride(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.GetBoneGlobalPoseNoOverride(int)" />
    public Transform3D GetBoneGlobalPoseNoOverride(int @boneIdx) => ((Skeleton3D)_host).GetBoneGlobalPoseNoOverride(@boneIdx);

    /// <inheritdoc cref="Skeleton3D.SetAnimatePhysicalBones(bool)" />
    public void SetAnimatePhysicalBones(bool @enabled) => ((Skeleton3D)_host).SetAnimatePhysicalBones(@enabled);

    /// <inheritdoc cref="Skeleton3D.GetAnimatePhysicalBones()" />
    public bool GetAnimatePhysicalBones() => ((Skeleton3D)_host).GetAnimatePhysicalBones();

    /// <inheritdoc cref="Skeleton3D.PhysicalBonesStopSimulation()" />
    public void PhysicalBonesStopSimulation() => ((Skeleton3D)_host).PhysicalBonesStopSimulation();

    /// <inheritdoc cref="Skeleton3D.PhysicalBonesStartSimulation(Array{StringName})" />
    public void PhysicalBonesStartSimulation(Array<StringName> @bones) => ((Skeleton3D)_host).PhysicalBonesStartSimulation(@bones);

    /// <inheritdoc cref="Skeleton3D.PhysicalBonesAddCollisionException(Rid)" />
    public void PhysicalBonesAddCollisionException(Rid @exception) => ((Skeleton3D)_host).PhysicalBonesAddCollisionException(@exception);

    /// <inheritdoc cref="Skeleton3D.PhysicalBonesRemoveCollisionException(Rid)" />
    public void PhysicalBonesRemoveCollisionException(Rid @exception) => ((Skeleton3D)_host).PhysicalBonesRemoveCollisionException(@exception);

}
