#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="SkeletonModifier3D" />
[Tool, GlobalClass]
public abstract partial class SkeletonModifier3DComponent : Node3DComponent
{

    /// <inheritdoc cref="SkeletonModifier3D._ProcessModification()" />
    public virtual void _ProcessModification() { }

    /// <inheritdoc cref="SkeletonModifier3D._ProcessModificationWithDelta(double)" />
    public virtual void _ProcessModificationWithDelta(double @delta) { }

    /// <inheritdoc cref="SkeletonModifier3D._SkeletonChanged(Skeleton3D, Skeleton3D)" />
    public virtual void _SkeletonChanged(Skeleton3D @oldSkeleton, Skeleton3D @newSkeleton) { }

    /// <inheritdoc cref="SkeletonModifier3D._ValidateBoneNames()" />
    public virtual void _ValidateBoneNames() { }

    /// <inheritdoc cref="SkeletonModifier3D.GetSkeleton()" />
    public Skeleton3D GetSkeleton() => ((SkeletonModifier3D)_host).GetSkeleton();

    /// <inheritdoc cref="SkeletonModifier3D.SetActive(bool)" />
    public void SetActive(bool @active) => ((SkeletonModifier3D)_host).SetActive(@active);

    /// <inheritdoc cref="SkeletonModifier3D.IsActive()" />
    public bool IsActive() => ((SkeletonModifier3D)_host).IsActive();

    /// <inheritdoc cref="SkeletonModifier3D.SetInfluence(float)" />
    public void SetInfluence(float @influence) => ((SkeletonModifier3D)_host).SetInfluence(@influence);

    /// <inheritdoc cref="SkeletonModifier3D.GetInfluence()" />
    public float GetInfluence() => ((SkeletonModifier3D)_host).GetInfluence();

}
