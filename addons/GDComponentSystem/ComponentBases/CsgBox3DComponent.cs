#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CsgBox3D" />
[Tool, GlobalClass]
public abstract partial class CsgBox3DComponent : CsgPrimitive3DComponent
{

    /// <inheritdoc cref="CsgBox3D.SetSize(Vector3)" />
    public void SetSize(Vector3 @size) => ((CsgBox3D)_host).SetSize(@size);

    /// <inheritdoc cref="CsgBox3D.GetSize()" />
    public Vector3 GetSize() => ((CsgBox3D)_host).GetSize();

    /// <inheritdoc cref="CsgBox3D.SetMaterial(Material)" />
    public void SetMaterial(Material @material) => ((CsgBox3D)_host).SetMaterial(@material);

    /// <inheritdoc cref="CsgBox3D.GetMaterial()" />
    public Material GetMaterial() => ((CsgBox3D)_host).GetMaterial();

}
