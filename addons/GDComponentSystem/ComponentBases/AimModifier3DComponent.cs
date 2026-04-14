#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="AimModifier3D" />
[Tool, GlobalClass]
public abstract partial class AimModifier3DComponent : BoneConstraint3DComponent
{

    /// <inheritdoc cref="AimModifier3D.SetForwardAxis(int, SkeletonModifier3D.BoneAxis)" />
    public void SetForwardAxis(int @index, SkeletonModifier3D.BoneAxis @axis) => ((AimModifier3D)_host).SetForwardAxis(@index, @axis);

    /// <inheritdoc cref="AimModifier3D.GetForwardAxis(int)" />
    public SkeletonModifier3D.BoneAxis GetForwardAxis(int @index) => ((AimModifier3D)_host).GetForwardAxis(@index);

    /// <inheritdoc cref="AimModifier3D.SetUseEuler(int, bool)" />
    public void SetUseEuler(int @index, bool @enabled) => ((AimModifier3D)_host).SetUseEuler(@index, @enabled);

    /// <inheritdoc cref="AimModifier3D.IsUsingEuler(int)" />
    public bool IsUsingEuler(int @index) => ((AimModifier3D)_host).IsUsingEuler(@index);

    /// <inheritdoc cref="AimModifier3D.SetPrimaryRotationAxis(int, Vector3.Axis)" />
    public void SetPrimaryRotationAxis(int @index, Vector3.Axis @axis) => ((AimModifier3D)_host).SetPrimaryRotationAxis(@index, @axis);

    /// <inheritdoc cref="AimModifier3D.GetPrimaryRotationAxis(int)" />
    public Vector3.Axis GetPrimaryRotationAxis(int @index) => ((AimModifier3D)_host).GetPrimaryRotationAxis(@index);

    /// <inheritdoc cref="AimModifier3D.SetUseSecondaryRotation(int, bool)" />
    public void SetUseSecondaryRotation(int @index, bool @enabled) => ((AimModifier3D)_host).SetUseSecondaryRotation(@index, @enabled);

    /// <inheritdoc cref="AimModifier3D.IsUsingSecondaryRotation(int)" />
    public bool IsUsingSecondaryRotation(int @index) => ((AimModifier3D)_host).IsUsingSecondaryRotation(@index);

    /// <inheritdoc cref="AimModifier3D.SetRelative(int, bool)" />
    public void SetRelative(int @index, bool @enabled) => ((AimModifier3D)_host).SetRelative(@index, @enabled);

    /// <inheritdoc cref="AimModifier3D.IsRelative(int)" />
    public bool IsRelative(int @index) => ((AimModifier3D)_host).IsRelative(@index);

}
