#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="SpringBoneSimulator3D" />
[Tool, GlobalClass]
public abstract partial class SpringBoneSimulator3DComponent : SkeletonModifier3DComponent
{

    /// <inheritdoc cref="SpringBoneSimulator3D.SetRootBoneName(int, string)" />
    public void SetRootBoneName(int @index, string @boneName) => ((SpringBoneSimulator3D)_host).SetRootBoneName(@index, @boneName);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetRootBoneName(int)" />
    public string GetRootBoneName(int @index) => ((SpringBoneSimulator3D)_host).GetRootBoneName(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetRootBone(int, int)" />
    public void SetRootBone(int @index, int @bone) => ((SpringBoneSimulator3D)_host).SetRootBone(@index, @bone);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetRootBone(int)" />
    public int GetRootBone(int @index) => ((SpringBoneSimulator3D)_host).GetRootBone(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetEndBoneName(int, string)" />
    public void SetEndBoneName(int @index, string @boneName) => ((SpringBoneSimulator3D)_host).SetEndBoneName(@index, @boneName);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetEndBoneName(int)" />
    public string GetEndBoneName(int @index) => ((SpringBoneSimulator3D)_host).GetEndBoneName(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetEndBone(int, int)" />
    public void SetEndBone(int @index, int @bone) => ((SpringBoneSimulator3D)_host).SetEndBone(@index, @bone);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetEndBone(int)" />
    public int GetEndBone(int @index) => ((SpringBoneSimulator3D)_host).GetEndBone(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetExtendEndBone(int, bool)" />
    public void SetExtendEndBone(int @index, bool @enabled) => ((SpringBoneSimulator3D)_host).SetExtendEndBone(@index, @enabled);

    /// <inheritdoc cref="SpringBoneSimulator3D.IsEndBoneExtended(int)" />
    public bool IsEndBoneExtended(int @index) => ((SpringBoneSimulator3D)_host).IsEndBoneExtended(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetEndBoneDirection(int, SkeletonModifier3D.BoneDirection)" />
    public void SetEndBoneDirection(int @index, SkeletonModifier3D.BoneDirection @boneDirection) => ((SpringBoneSimulator3D)_host).SetEndBoneDirection(@index, @boneDirection);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetEndBoneDirection(int)" />
    public SkeletonModifier3D.BoneDirection GetEndBoneDirection(int @index) => ((SpringBoneSimulator3D)_host).GetEndBoneDirection(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetEndBoneLength(int, float)" />
    public void SetEndBoneLength(int @index, float @length) => ((SpringBoneSimulator3D)_host).SetEndBoneLength(@index, @length);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetEndBoneLength(int)" />
    public float GetEndBoneLength(int @index) => ((SpringBoneSimulator3D)_host).GetEndBoneLength(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetCenterFrom(int, SpringBoneSimulator3D.CenterFrom)" />
    public void SetCenterFrom(int @index, SpringBoneSimulator3D.CenterFrom @centerFrom) => ((SpringBoneSimulator3D)_host).SetCenterFrom(@index, @centerFrom);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetCenterFrom(int)" />
    public SpringBoneSimulator3D.CenterFrom GetCenterFrom(int @index) => ((SpringBoneSimulator3D)_host).GetCenterFrom(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetCenterNode(int, NodePath)" />
    public void SetCenterNode(int @index, NodePath @nodePath) => ((SpringBoneSimulator3D)_host).SetCenterNode(@index, @nodePath);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetCenterNode(int)" />
    public NodePath GetCenterNode(int @index) => ((SpringBoneSimulator3D)_host).GetCenterNode(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetCenterBoneName(int, string)" />
    public void SetCenterBoneName(int @index, string @boneName) => ((SpringBoneSimulator3D)_host).SetCenterBoneName(@index, @boneName);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetCenterBoneName(int)" />
    public string GetCenterBoneName(int @index) => ((SpringBoneSimulator3D)_host).GetCenterBoneName(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetCenterBone(int, int)" />
    public void SetCenterBone(int @index, int @bone) => ((SpringBoneSimulator3D)_host).SetCenterBone(@index, @bone);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetCenterBone(int)" />
    public int GetCenterBone(int @index) => ((SpringBoneSimulator3D)_host).GetCenterBone(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetRadius(int, float)" />
    public void SetRadius(int @index, float @radius) => ((SpringBoneSimulator3D)_host).SetRadius(@index, @radius);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetRadius(int)" />
    public float GetRadius(int @index) => ((SpringBoneSimulator3D)_host).GetRadius(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetRotationAxis(int, SkeletonModifier3D.RotationAxis)" />
    public void SetRotationAxis(int @index, SkeletonModifier3D.RotationAxis @axis) => ((SpringBoneSimulator3D)_host).SetRotationAxis(@index, @axis);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetRotationAxis(int)" />
    public SkeletonModifier3D.RotationAxis GetRotationAxis(int @index) => ((SpringBoneSimulator3D)_host).GetRotationAxis(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetRotationAxisVector(int, Vector3)" />
    public void SetRotationAxisVector(int @index, Vector3 @vector) => ((SpringBoneSimulator3D)_host).SetRotationAxisVector(@index, @vector);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetRotationAxisVector(int)" />
    public Vector3 GetRotationAxisVector(int @index) => ((SpringBoneSimulator3D)_host).GetRotationAxisVector(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetRadiusDampingCurve(int, Curve)" />
    public void SetRadiusDampingCurve(int @index, Curve @curve) => ((SpringBoneSimulator3D)_host).SetRadiusDampingCurve(@index, @curve);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetRadiusDampingCurve(int)" />
    public Curve GetRadiusDampingCurve(int @index) => ((SpringBoneSimulator3D)_host).GetRadiusDampingCurve(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetStiffness(int, float)" />
    public void SetStiffness(int @index, float @stiffness) => ((SpringBoneSimulator3D)_host).SetStiffness(@index, @stiffness);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetStiffness(int)" />
    public float GetStiffness(int @index) => ((SpringBoneSimulator3D)_host).GetStiffness(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetStiffnessDampingCurve(int, Curve)" />
    public void SetStiffnessDampingCurve(int @index, Curve @curve) => ((SpringBoneSimulator3D)_host).SetStiffnessDampingCurve(@index, @curve);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetStiffnessDampingCurve(int)" />
    public Curve GetStiffnessDampingCurve(int @index) => ((SpringBoneSimulator3D)_host).GetStiffnessDampingCurve(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetDrag(int, float)" />
    public void SetDrag(int @index, float @drag) => ((SpringBoneSimulator3D)_host).SetDrag(@index, @drag);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetDrag(int)" />
    public float GetDrag(int @index) => ((SpringBoneSimulator3D)_host).GetDrag(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetDragDampingCurve(int, Curve)" />
    public void SetDragDampingCurve(int @index, Curve @curve) => ((SpringBoneSimulator3D)_host).SetDragDampingCurve(@index, @curve);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetDragDampingCurve(int)" />
    public Curve GetDragDampingCurve(int @index) => ((SpringBoneSimulator3D)_host).GetDragDampingCurve(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetGravity(int, float)" />
    public void SetGravity(int @index, float @gravity) => ((SpringBoneSimulator3D)_host).SetGravity(@index, @gravity);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetGravity(int)" />
    public float GetGravity(int @index) => ((SpringBoneSimulator3D)_host).GetGravity(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetGravityDampingCurve(int, Curve)" />
    public void SetGravityDampingCurve(int @index, Curve @curve) => ((SpringBoneSimulator3D)_host).SetGravityDampingCurve(@index, @curve);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetGravityDampingCurve(int)" />
    public Curve GetGravityDampingCurve(int @index) => ((SpringBoneSimulator3D)_host).GetGravityDampingCurve(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetGravityDirection(int, Vector3)" />
    public void SetGravityDirection(int @index, Vector3 @gravityDirection) => ((SpringBoneSimulator3D)_host).SetGravityDirection(@index, @gravityDirection);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetGravityDirection(int)" />
    public Vector3 GetGravityDirection(int @index) => ((SpringBoneSimulator3D)_host).GetGravityDirection(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetSettingCount(int)" />
    public void SetSettingCount(int @count) => ((SpringBoneSimulator3D)_host).SetSettingCount(@count);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetSettingCount()" />
    public int GetSettingCount() => ((SpringBoneSimulator3D)_host).GetSettingCount();

    /// <inheritdoc cref="SpringBoneSimulator3D.ClearSettings()" />
    public void ClearSettings() => ((SpringBoneSimulator3D)_host).ClearSettings();

    /// <inheritdoc cref="SpringBoneSimulator3D.SetIndividualConfig(int, bool)" />
    public void SetIndividualConfig(int @index, bool @enabled) => ((SpringBoneSimulator3D)_host).SetIndividualConfig(@index, @enabled);

    /// <inheritdoc cref="SpringBoneSimulator3D.IsConfigIndividual(int)" />
    public bool IsConfigIndividual(int @index) => ((SpringBoneSimulator3D)_host).IsConfigIndividual(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetJointBoneName(int, int)" />
    public string GetJointBoneName(int @index, int @joint) => ((SpringBoneSimulator3D)_host).GetJointBoneName(@index, @joint);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetJointBone(int, int)" />
    public int GetJointBone(int @index, int @joint) => ((SpringBoneSimulator3D)_host).GetJointBone(@index, @joint);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetJointRotationAxis(int, int, SkeletonModifier3D.RotationAxis)" />
    public void SetJointRotationAxis(int @index, int @joint, SkeletonModifier3D.RotationAxis @axis) => ((SpringBoneSimulator3D)_host).SetJointRotationAxis(@index, @joint, @axis);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetJointRotationAxis(int, int)" />
    public SkeletonModifier3D.RotationAxis GetJointRotationAxis(int @index, int @joint) => ((SpringBoneSimulator3D)_host).GetJointRotationAxis(@index, @joint);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetJointRotationAxisVector(int, int, Vector3)" />
    public void SetJointRotationAxisVector(int @index, int @joint, Vector3 @vector) => ((SpringBoneSimulator3D)_host).SetJointRotationAxisVector(@index, @joint, @vector);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetJointRotationAxisVector(int, int)" />
    public Vector3 GetJointRotationAxisVector(int @index, int @joint) => ((SpringBoneSimulator3D)_host).GetJointRotationAxisVector(@index, @joint);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetJointRadius(int, int, float)" />
    public void SetJointRadius(int @index, int @joint, float @radius) => ((SpringBoneSimulator3D)_host).SetJointRadius(@index, @joint, @radius);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetJointRadius(int, int)" />
    public float GetJointRadius(int @index, int @joint) => ((SpringBoneSimulator3D)_host).GetJointRadius(@index, @joint);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetJointStiffness(int, int, float)" />
    public void SetJointStiffness(int @index, int @joint, float @stiffness) => ((SpringBoneSimulator3D)_host).SetJointStiffness(@index, @joint, @stiffness);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetJointStiffness(int, int)" />
    public float GetJointStiffness(int @index, int @joint) => ((SpringBoneSimulator3D)_host).GetJointStiffness(@index, @joint);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetJointDrag(int, int, float)" />
    public void SetJointDrag(int @index, int @joint, float @drag) => ((SpringBoneSimulator3D)_host).SetJointDrag(@index, @joint, @drag);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetJointDrag(int, int)" />
    public float GetJointDrag(int @index, int @joint) => ((SpringBoneSimulator3D)_host).GetJointDrag(@index, @joint);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetJointGravity(int, int, float)" />
    public void SetJointGravity(int @index, int @joint, float @gravity) => ((SpringBoneSimulator3D)_host).SetJointGravity(@index, @joint, @gravity);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetJointGravity(int, int)" />
    public float GetJointGravity(int @index, int @joint) => ((SpringBoneSimulator3D)_host).GetJointGravity(@index, @joint);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetJointGravityDirection(int, int, Vector3)" />
    public void SetJointGravityDirection(int @index, int @joint, Vector3 @gravityDirection) => ((SpringBoneSimulator3D)_host).SetJointGravityDirection(@index, @joint, @gravityDirection);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetJointGravityDirection(int, int)" />
    public Vector3 GetJointGravityDirection(int @index, int @joint) => ((SpringBoneSimulator3D)_host).GetJointGravityDirection(@index, @joint);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetJointCount(int)" />
    public int GetJointCount(int @index) => ((SpringBoneSimulator3D)_host).GetJointCount(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetEnableAllChildCollisions(int, bool)" />
    public void SetEnableAllChildCollisions(int @index, bool @enabled) => ((SpringBoneSimulator3D)_host).SetEnableAllChildCollisions(@index, @enabled);

    /// <inheritdoc cref="SpringBoneSimulator3D.AreAllChildCollisionsEnabled(int)" />
    public bool AreAllChildCollisionsEnabled(int @index) => ((SpringBoneSimulator3D)_host).AreAllChildCollisionsEnabled(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetExcludeCollisionPath(int, int, NodePath)" />
    public void SetExcludeCollisionPath(int @index, int @collision, NodePath @nodePath) => ((SpringBoneSimulator3D)_host).SetExcludeCollisionPath(@index, @collision, @nodePath);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetExcludeCollisionPath(int, int)" />
    public NodePath GetExcludeCollisionPath(int @index, int @collision) => ((SpringBoneSimulator3D)_host).GetExcludeCollisionPath(@index, @collision);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetExcludeCollisionCount(int, int)" />
    public void SetExcludeCollisionCount(int @index, int @count) => ((SpringBoneSimulator3D)_host).SetExcludeCollisionCount(@index, @count);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetExcludeCollisionCount(int)" />
    public int GetExcludeCollisionCount(int @index) => ((SpringBoneSimulator3D)_host).GetExcludeCollisionCount(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.ClearExcludeCollisions(int)" />
    public void ClearExcludeCollisions(int @index) => ((SpringBoneSimulator3D)_host).ClearExcludeCollisions(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetCollisionPath(int, int, NodePath)" />
    public void SetCollisionPath(int @index, int @collision, NodePath @nodePath) => ((SpringBoneSimulator3D)_host).SetCollisionPath(@index, @collision, @nodePath);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetCollisionPath(int, int)" />
    public NodePath GetCollisionPath(int @index, int @collision) => ((SpringBoneSimulator3D)_host).GetCollisionPath(@index, @collision);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetCollisionCount(int, int)" />
    public void SetCollisionCount(int @index, int @count) => ((SpringBoneSimulator3D)_host).SetCollisionCount(@index, @count);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetCollisionCount(int)" />
    public int GetCollisionCount(int @index) => ((SpringBoneSimulator3D)_host).GetCollisionCount(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.ClearCollisions(int)" />
    public void ClearCollisions(int @index) => ((SpringBoneSimulator3D)_host).ClearCollisions(@index);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetExternalForce(Vector3)" />
    public void SetExternalForce(Vector3 @force) => ((SpringBoneSimulator3D)_host).SetExternalForce(@force);

    /// <inheritdoc cref="SpringBoneSimulator3D.GetExternalForce()" />
    public Vector3 GetExternalForce() => ((SpringBoneSimulator3D)_host).GetExternalForce();

    /// <inheritdoc cref="SpringBoneSimulator3D.SetMutableBoneAxes(bool)" />
    public void SetMutableBoneAxes(bool @enabled) => ((SpringBoneSimulator3D)_host).SetMutableBoneAxes(@enabled);

    /// <inheritdoc cref="SpringBoneSimulator3D.AreBoneAxesMutable()" />
    public bool AreBoneAxesMutable() => ((SpringBoneSimulator3D)_host).AreBoneAxesMutable();

    /// <inheritdoc cref="SpringBoneSimulator3D.Reset()" />
    public void Reset() => ((SpringBoneSimulator3D)_host).Reset();

    /// <inheritdoc cref="SpringBoneSimulator3D.SetJointRotationAxis(int, int, int)" />
    public void SetJointRotationAxis(int @index, int @joint, int @axis) => ((SpringBoneSimulator3D)_host).SetJointRotationAxis(@index, @joint, @axis);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetRotationAxis(int, int)" />
    public void SetRotationAxis(int @index, int @axis) => ((SpringBoneSimulator3D)_host).SetRotationAxis(@index, @axis);

    /// <inheritdoc cref="SpringBoneSimulator3D.SetEndBoneDirection(int, int)" />
    public void SetEndBoneDirection(int @index, int @boneDirection) => ((SpringBoneSimulator3D)_host).SetEndBoneDirection(@index, @boneDirection);

}
