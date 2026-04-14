#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="LimitAngularVelocityModifier3D" />
[Tool, GlobalClass]
public abstract partial class LimitAngularVelocityModifier3DComponent : SkeletonModifier3DComponent
{

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.SetRootBoneName(int, string)" />
    public void SetRootBoneName(int @index, string @boneName) => ((LimitAngularVelocityModifier3D)_host).SetRootBoneName(@index, @boneName);

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.GetRootBoneName(int)" />
    public string GetRootBoneName(int @index) => ((LimitAngularVelocityModifier3D)_host).GetRootBoneName(@index);

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.SetRootBone(int, int)" />
    public void SetRootBone(int @index, int @bone) => ((LimitAngularVelocityModifier3D)_host).SetRootBone(@index, @bone);

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.GetRootBone(int)" />
    public int GetRootBone(int @index) => ((LimitAngularVelocityModifier3D)_host).GetRootBone(@index);

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.SetEndBoneName(int, string)" />
    public void SetEndBoneName(int @index, string @boneName) => ((LimitAngularVelocityModifier3D)_host).SetEndBoneName(@index, @boneName);

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.GetEndBoneName(int)" />
    public string GetEndBoneName(int @index) => ((LimitAngularVelocityModifier3D)_host).GetEndBoneName(@index);

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.SetEndBone(int, int)" />
    public void SetEndBone(int @index, int @bone) => ((LimitAngularVelocityModifier3D)_host).SetEndBone(@index, @bone);

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.GetEndBone(int)" />
    public int GetEndBone(int @index) => ((LimitAngularVelocityModifier3D)_host).GetEndBone(@index);

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.SetChainCount(int)" />
    public void SetChainCount(int @count) => ((LimitAngularVelocityModifier3D)_host).SetChainCount(@count);

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.GetChainCount()" />
    public int GetChainCount() => ((LimitAngularVelocityModifier3D)_host).GetChainCount();

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.ClearChains()" />
    public void ClearChains() => ((LimitAngularVelocityModifier3D)_host).ClearChains();

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.SetMaxAngularVelocity(double)" />
    public void SetMaxAngularVelocity(double @angularVelocity) => ((LimitAngularVelocityModifier3D)_host).SetMaxAngularVelocity(@angularVelocity);

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.GetMaxAngularVelocity()" />
    public double GetMaxAngularVelocity() => ((LimitAngularVelocityModifier3D)_host).GetMaxAngularVelocity();

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.SetExclude(bool)" />
    public void SetExclude(bool @exclude) => ((LimitAngularVelocityModifier3D)_host).SetExclude(@exclude);

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.IsExclude()" />
    public bool IsExclude() => ((LimitAngularVelocityModifier3D)_host).IsExclude();

    /// <inheritdoc cref="LimitAngularVelocityModifier3D.Reset()" />
    public void Reset() => ((LimitAngularVelocityModifier3D)_host).Reset();

}
