#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="XRBodyModifier3D" />
[Tool, GlobalClass]
public abstract partial class XRBodyModifier3DComponent : SkeletonModifier3DComponent
{

    /// <inheritdoc cref="XRBodyModifier3D.SetBodyTracker(StringName)" />
    public void SetBodyTracker(StringName @trackerName) => ((XRBodyModifier3D)_host).SetBodyTracker(@trackerName);

    /// <inheritdoc cref="XRBodyModifier3D.GetBodyTracker()" />
    public StringName GetBodyTracker() => ((XRBodyModifier3D)_host).GetBodyTracker();

    /// <inheritdoc cref="XRBodyModifier3D.SetBodyUpdate(XRBodyModifier3D.BodyUpdateEnum)" />
    public void SetBodyUpdate(XRBodyModifier3D.BodyUpdateEnum @bodyUpdate) => ((XRBodyModifier3D)_host).SetBodyUpdate(@bodyUpdate);

    /// <inheritdoc cref="XRBodyModifier3D.GetBodyUpdate()" />
    public XRBodyModifier3D.BodyUpdateEnum GetBodyUpdate() => ((XRBodyModifier3D)_host).GetBodyUpdate();

    /// <inheritdoc cref="XRBodyModifier3D.SetBoneUpdate(XRBodyModifier3D.BoneUpdateEnum)" />
    public void SetBoneUpdate(XRBodyModifier3D.BoneUpdateEnum @boneUpdate) => ((XRBodyModifier3D)_host).SetBoneUpdate(@boneUpdate);

    /// <inheritdoc cref="XRBodyModifier3D.GetBoneUpdate()" />
    public XRBodyModifier3D.BoneUpdateEnum GetBoneUpdate() => ((XRBodyModifier3D)_host).GetBoneUpdate();

}
