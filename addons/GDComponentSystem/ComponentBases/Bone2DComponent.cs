#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Bone2D" />
[Tool, GlobalClass]
public abstract partial class Bone2DComponent : Node2DComponent
{

    /// <inheritdoc cref="Bone2D.SetRest(Transform2D)" />
    public void SetRest(Transform2D @rest) => ((Bone2D)_host).SetRest(@rest);

    /// <inheritdoc cref="Bone2D.GetRest()" />
    public Transform2D GetRest() => ((Bone2D)_host).GetRest();

    /// <inheritdoc cref="Bone2D.ApplyRest()" />
    public void ApplyRest() => ((Bone2D)_host).ApplyRest();

    /// <inheritdoc cref="Bone2D.GetSkeletonRest()" />
    public Transform2D GetSkeletonRest() => ((Bone2D)_host).GetSkeletonRest();

    /// <inheritdoc cref="Bone2D.GetIndexInSkeleton()" />
    public int GetIndexInSkeleton() => ((Bone2D)_host).GetIndexInSkeleton();

    /// <inheritdoc cref="Bone2D.SetAutocalculateLengthAndAngle(bool)" />
    public void SetAutocalculateLengthAndAngle(bool @autoCalculate) => ((Bone2D)_host).SetAutocalculateLengthAndAngle(@autoCalculate);

    /// <inheritdoc cref="Bone2D.GetAutocalculateLengthAndAngle()" />
    public bool GetAutocalculateLengthAndAngle() => ((Bone2D)_host).GetAutocalculateLengthAndAngle();

    /// <inheritdoc cref="Bone2D.SetLength(float)" />
    public void SetLength(float @length) => ((Bone2D)_host).SetLength(@length);

    /// <inheritdoc cref="Bone2D.GetLength()" />
    public float GetLength() => ((Bone2D)_host).GetLength();

    /// <inheritdoc cref="Bone2D.SetBoneAngle(float)" />
    public void SetBoneAngle(float @angle) => ((Bone2D)_host).SetBoneAngle(@angle);

    /// <inheritdoc cref="Bone2D.GetBoneAngle()" />
    public float GetBoneAngle() => ((Bone2D)_host).GetBoneAngle();

}
