#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ConeTwistJoint3D" />
[Tool, GlobalClass]
public abstract partial class ConeTwistJoint3DComponent : Joint3DComponent
{

    /// <inheritdoc cref="ConeTwistJoint3D.SetParam(ConeTwistJoint3D.Param, float)" />
    public void SetParam(ConeTwistJoint3D.Param @param, float @value) => ((ConeTwistJoint3D)_host).SetParam(@param, @value);

    /// <inheritdoc cref="ConeTwistJoint3D.GetParam(ConeTwistJoint3D.Param)" />
    public float GetParam(ConeTwistJoint3D.Param @param) => ((ConeTwistJoint3D)_host).GetParam(@param);

}
