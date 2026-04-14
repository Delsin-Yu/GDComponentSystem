#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="SliderJoint3D" />
[Tool, GlobalClass]
public abstract partial class SliderJoint3DComponent : Joint3DComponent
{

    /// <inheritdoc cref="SliderJoint3D.SetParam(SliderJoint3D.Param, float)" />
    public void SetParam(SliderJoint3D.Param @param, float @value) => ((SliderJoint3D)_host).SetParam(@param, @value);

    /// <inheritdoc cref="SliderJoint3D.GetParam(SliderJoint3D.Param)" />
    public float GetParam(SliderJoint3D.Param @param) => ((SliderJoint3D)_host).GetParam(@param);

}
