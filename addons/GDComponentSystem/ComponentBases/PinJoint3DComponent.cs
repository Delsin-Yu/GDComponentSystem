#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="PinJoint3D" />
[Tool, GlobalClass]
public abstract partial class PinJoint3DComponent : Joint3DComponent
{

    /// <inheritdoc cref="PinJoint3D.SetParam(PinJoint3D.Param, float)" />
    public void SetParam(PinJoint3D.Param @param, float @value) => ((PinJoint3D)_host).SetParam(@param, @value);

    /// <inheritdoc cref="PinJoint3D.GetParam(PinJoint3D.Param)" />
    public float GetParam(PinJoint3D.Param @param) => ((PinJoint3D)_host).GetParam(@param);

}
