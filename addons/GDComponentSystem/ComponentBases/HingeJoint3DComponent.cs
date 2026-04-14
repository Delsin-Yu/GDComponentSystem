#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="HingeJoint3D" />
[Tool, GlobalClass]
public abstract partial class HingeJoint3DComponent : Joint3DComponent
{

    /// <inheritdoc cref="HingeJoint3D.SetParam(HingeJoint3D.Param, float)" />
    public void SetParam(HingeJoint3D.Param @param, float @value) => ((HingeJoint3D)_host).SetParam(@param, @value);

    /// <inheritdoc cref="HingeJoint3D.GetParam(HingeJoint3D.Param)" />
    public float GetParam(HingeJoint3D.Param @param) => ((HingeJoint3D)_host).GetParam(@param);

    /// <inheritdoc cref="HingeJoint3D.SetFlag(HingeJoint3D.Flag, bool)" />
    public void SetFlag(HingeJoint3D.Flag @flag, bool @enabled) => ((HingeJoint3D)_host).SetFlag(@flag, @enabled);

    /// <inheritdoc cref="HingeJoint3D.GetFlag(HingeJoint3D.Flag)" />
    public bool GetFlag(HingeJoint3D.Flag @flag) => ((HingeJoint3D)_host).GetFlag(@flag);

}
