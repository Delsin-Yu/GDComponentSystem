#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CsgCylinder3D" />
[Tool, GlobalClass]
public abstract partial class CsgCylinder3DComponent : CsgPrimitive3DComponent
{

    /// <inheritdoc cref="CsgCylinder3D.SetRadius(float)" />
    public void SetRadius(float @radius) => ((CsgCylinder3D)_host).SetRadius(@radius);

    /// <inheritdoc cref="CsgCylinder3D.GetRadius()" />
    public float GetRadius() => ((CsgCylinder3D)_host).GetRadius();

    /// <inheritdoc cref="CsgCylinder3D.SetHeight(float)" />
    public void SetHeight(float @height) => ((CsgCylinder3D)_host).SetHeight(@height);

    /// <inheritdoc cref="CsgCylinder3D.GetHeight()" />
    public float GetHeight() => ((CsgCylinder3D)_host).GetHeight();

    /// <inheritdoc cref="CsgCylinder3D.SetSides(int)" />
    public void SetSides(int @sides) => ((CsgCylinder3D)_host).SetSides(@sides);

    /// <inheritdoc cref="CsgCylinder3D.GetSides()" />
    public int GetSides() => ((CsgCylinder3D)_host).GetSides();

    /// <inheritdoc cref="CsgCylinder3D.SetCone(bool)" />
    public void SetCone(bool @cone) => ((CsgCylinder3D)_host).SetCone(@cone);

    /// <inheritdoc cref="CsgCylinder3D.IsCone()" />
    public bool IsCone() => ((CsgCylinder3D)_host).IsCone();

    /// <inheritdoc cref="CsgCylinder3D.SetMaterial(Material)" />
    public void SetMaterial(Material @material) => ((CsgCylinder3D)_host).SetMaterial(@material);

    /// <inheritdoc cref="CsgCylinder3D.GetMaterial()" />
    public Material GetMaterial() => ((CsgCylinder3D)_host).GetMaterial();

    /// <inheritdoc cref="CsgCylinder3D.SetSmoothFaces(bool)" />
    public void SetSmoothFaces(bool @smoothFaces) => ((CsgCylinder3D)_host).SetSmoothFaces(@smoothFaces);

    /// <inheritdoc cref="CsgCylinder3D.GetSmoothFaces()" />
    public bool GetSmoothFaces() => ((CsgCylinder3D)_host).GetSmoothFaces();

}
