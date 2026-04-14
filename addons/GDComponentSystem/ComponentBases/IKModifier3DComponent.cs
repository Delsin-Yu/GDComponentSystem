#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="IKModifier3D" />
[Tool, GlobalClass]
public abstract partial class IKModifier3DComponent : SkeletonModifier3DComponent
{

    /// <inheritdoc cref="IKModifier3D.SetSettingCount(int)" />
    public void SetSettingCount(int @count) => ((IKModifier3D)_host).SetSettingCount(@count);

    /// <inheritdoc cref="IKModifier3D.GetSettingCount()" />
    public int GetSettingCount() => ((IKModifier3D)_host).GetSettingCount();

    /// <inheritdoc cref="IKModifier3D.ClearSettings()" />
    public void ClearSettings() => ((IKModifier3D)_host).ClearSettings();

    /// <inheritdoc cref="IKModifier3D.SetMutableBoneAxes(bool)" />
    public void SetMutableBoneAxes(bool @enabled) => ((IKModifier3D)_host).SetMutableBoneAxes(@enabled);

    /// <inheritdoc cref="IKModifier3D.AreBoneAxesMutable()" />
    public bool AreBoneAxesMutable() => ((IKModifier3D)_host).AreBoneAxesMutable();

    /// <inheritdoc cref="IKModifier3D.Reset()" />
    public void Reset() => ((IKModifier3D)_host).Reset();

}
