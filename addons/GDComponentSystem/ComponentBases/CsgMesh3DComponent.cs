#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CsgMesh3D" />
[Tool, GlobalClass]
public abstract partial class CsgMesh3DComponent : CsgPrimitive3DComponent
{

    /// <inheritdoc cref="CsgMesh3D.SetMesh(Mesh)" />
    public void SetMesh(Mesh @mesh) => ((CsgMesh3D)_host).SetMesh(@mesh);

    /// <inheritdoc cref="CsgMesh3D.GetMesh()" />
    public Mesh GetMesh() => ((CsgMesh3D)_host).GetMesh();

    /// <inheritdoc cref="CsgMesh3D.SetMaterial(Material)" />
    public void SetMaterial(Material @material) => ((CsgMesh3D)_host).SetMaterial(@material);

    /// <inheritdoc cref="CsgMesh3D.GetMaterial()" />
    public Material GetMaterial() => ((CsgMesh3D)_host).GetMaterial();

}
