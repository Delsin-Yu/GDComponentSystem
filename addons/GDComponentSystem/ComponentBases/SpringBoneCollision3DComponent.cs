#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="SpringBoneCollision3D" />
[Tool, GlobalClass]
public abstract partial class SpringBoneCollision3DComponent : Node3DComponent
{

    /// <inheritdoc cref="SpringBoneCollision3D.GetSkeleton()" />
    public Skeleton3D GetSkeleton() => ((SpringBoneCollision3D)_host).GetSkeleton();

    /// <inheritdoc cref="SpringBoneCollision3D.SetBoneName(string)" />
    public void SetBoneName(string @boneName) => ((SpringBoneCollision3D)_host).SetBoneName(@boneName);

    /// <inheritdoc cref="SpringBoneCollision3D.GetBoneName()" />
    public string GetBoneName() => ((SpringBoneCollision3D)_host).GetBoneName();

    /// <inheritdoc cref="SpringBoneCollision3D.SetBone(int)" />
    public void SetBone(int @bone) => ((SpringBoneCollision3D)_host).SetBone(@bone);

    /// <inheritdoc cref="SpringBoneCollision3D.GetBone()" />
    public int GetBone() => ((SpringBoneCollision3D)_host).GetBone();

    /// <inheritdoc cref="SpringBoneCollision3D.SetPositionOffset(Vector3)" />
    public void SetPositionOffset(Vector3 @offset) => ((SpringBoneCollision3D)_host).SetPositionOffset(@offset);

    /// <inheritdoc cref="SpringBoneCollision3D.GetPositionOffset()" />
    public Vector3 GetPositionOffset() => ((SpringBoneCollision3D)_host).GetPositionOffset();

    /// <inheritdoc cref="SpringBoneCollision3D.SetRotationOffset(Quaternion)" />
    public void SetRotationOffset(Quaternion @offset) => ((SpringBoneCollision3D)_host).SetRotationOffset(@offset);

    /// <inheritdoc cref="SpringBoneCollision3D.GetRotationOffset()" />
    public Quaternion GetRotationOffset() => ((SpringBoneCollision3D)_host).GetRotationOffset();

}
