#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ModifierBoneTarget3D" />
[Tool, GlobalClass]
public abstract partial class ModifierBoneTarget3DComponent : SkeletonModifier3DComponent
{

    /// <inheritdoc cref="ModifierBoneTarget3D.SetBoneName(string)" />
    public void SetBoneName(string @boneName) => ((ModifierBoneTarget3D)_host).SetBoneName(@boneName);

    /// <inheritdoc cref="ModifierBoneTarget3D.GetBoneName()" />
    public string GetBoneName() => ((ModifierBoneTarget3D)_host).GetBoneName();

    /// <inheritdoc cref="ModifierBoneTarget3D.SetBone(int)" />
    public void SetBone(int @bone) => ((ModifierBoneTarget3D)_host).SetBone(@bone);

    /// <inheritdoc cref="ModifierBoneTarget3D.GetBone()" />
    public int GetBone() => ((ModifierBoneTarget3D)_host).GetBone();

}
