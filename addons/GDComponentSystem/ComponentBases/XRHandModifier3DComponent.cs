#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="XRHandModifier3D" />
[Tool, GlobalClass]
public abstract partial class XRHandModifier3DComponent : SkeletonModifier3DComponent
{

    /// <inheritdoc cref="XRHandModifier3D.SetHandTracker(StringName)" />
    public void SetHandTracker(StringName @trackerName) => ((XRHandModifier3D)_host).SetHandTracker(@trackerName);

    /// <inheritdoc cref="XRHandModifier3D.GetHandTracker()" />
    public StringName GetHandTracker() => ((XRHandModifier3D)_host).GetHandTracker();

    /// <inheritdoc cref="XRHandModifier3D.SetBoneUpdate(XRHandModifier3D.BoneUpdateEnum)" />
    public void SetBoneUpdate(XRHandModifier3D.BoneUpdateEnum @boneUpdate) => ((XRHandModifier3D)_host).SetBoneUpdate(@boneUpdate);

    /// <inheritdoc cref="XRHandModifier3D.GetBoneUpdate()" />
    public XRHandModifier3D.BoneUpdateEnum GetBoneUpdate() => ((XRHandModifier3D)_host).GetBoneUpdate();

}
