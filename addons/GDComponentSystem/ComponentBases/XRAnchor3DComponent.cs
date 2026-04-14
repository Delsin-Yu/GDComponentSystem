#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="XRAnchor3D" />
[Tool, GlobalClass]
public abstract partial class XRAnchor3DComponent : XRNode3DComponent
{

    /// <inheritdoc cref="XRAnchor3D.GetSize()" />
    public Vector3 GetSize() => ((XRAnchor3D)_host).GetSize();

    /// <inheritdoc cref="XRAnchor3D.GetPlane()" />
    public Plane GetPlane() => ((XRAnchor3D)_host).GetPlane();

}
