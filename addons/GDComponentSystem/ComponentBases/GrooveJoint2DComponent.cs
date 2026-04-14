#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GrooveJoint2D" />
[Tool, GlobalClass]
public abstract partial class GrooveJoint2DComponent : Joint2DComponent
{

    /// <inheritdoc cref="GrooveJoint2D.SetLength(float)" />
    public void SetLength(float @length) => ((GrooveJoint2D)_host).SetLength(@length);

    /// <inheritdoc cref="GrooveJoint2D.GetLength()" />
    public float GetLength() => ((GrooveJoint2D)_host).GetLength();

    /// <inheritdoc cref="GrooveJoint2D.SetInitialOffset(float)" />
    public void SetInitialOffset(float @offset) => ((GrooveJoint2D)_host).SetInitialOffset(@offset);

    /// <inheritdoc cref="GrooveJoint2D.GetInitialOffset()" />
    public float GetInitialOffset() => ((GrooveJoint2D)_host).GetInitialOffset();

}
