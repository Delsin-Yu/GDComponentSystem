#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CsgPrimitive3D" />
[Tool, GlobalClass]
public abstract partial class CsgPrimitive3DComponent : CsgShape3DComponent
{

    /// <inheritdoc cref="CsgPrimitive3D.SetFlipFaces(bool)" />
    public void SetFlipFaces(bool @flipFaces) => ((CsgPrimitive3D)_host).SetFlipFaces(@flipFaces);

    /// <inheritdoc cref="CsgPrimitive3D.GetFlipFaces()" />
    public bool GetFlipFaces() => ((CsgPrimitive3D)_host).GetFlipFaces();

}
