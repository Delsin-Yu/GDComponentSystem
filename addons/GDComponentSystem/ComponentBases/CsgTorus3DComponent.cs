#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CsgTorus3D" />
[Tool, GlobalClass]
public abstract partial class CsgTorus3DComponent : CsgPrimitive3DComponent
{

    /// <inheritdoc cref="CsgTorus3D.SetInnerRadius(float)" />
    public void SetInnerRadius(float @radius) => ((CsgTorus3D)_host).SetInnerRadius(@radius);

    /// <inheritdoc cref="CsgTorus3D.GetInnerRadius()" />
    public float GetInnerRadius() => ((CsgTorus3D)_host).GetInnerRadius();

    /// <inheritdoc cref="CsgTorus3D.SetOuterRadius(float)" />
    public void SetOuterRadius(float @radius) => ((CsgTorus3D)_host).SetOuterRadius(@radius);

    /// <inheritdoc cref="CsgTorus3D.GetOuterRadius()" />
    public float GetOuterRadius() => ((CsgTorus3D)_host).GetOuterRadius();

    /// <inheritdoc cref="CsgTorus3D.SetSides(int)" />
    public void SetSides(int @sides) => ((CsgTorus3D)_host).SetSides(@sides);

    /// <inheritdoc cref="CsgTorus3D.GetSides()" />
    public int GetSides() => ((CsgTorus3D)_host).GetSides();

    /// <inheritdoc cref="CsgTorus3D.SetRingSides(int)" />
    public void SetRingSides(int @sides) => ((CsgTorus3D)_host).SetRingSides(@sides);

    /// <inheritdoc cref="CsgTorus3D.GetRingSides()" />
    public int GetRingSides() => ((CsgTorus3D)_host).GetRingSides();

    /// <inheritdoc cref="CsgTorus3D.SetMaterial(Material)" />
    public void SetMaterial(Material @material) => ((CsgTorus3D)_host).SetMaterial(@material);

    /// <inheritdoc cref="CsgTorus3D.GetMaterial()" />
    public Material GetMaterial() => ((CsgTorus3D)_host).GetMaterial();

    /// <inheritdoc cref="CsgTorus3D.SetSmoothFaces(bool)" />
    public void SetSmoothFaces(bool @smoothFaces) => ((CsgTorus3D)_host).SetSmoothFaces(@smoothFaces);

    /// <inheritdoc cref="CsgTorus3D.GetSmoothFaces()" />
    public bool GetSmoothFaces() => ((CsgTorus3D)_host).GetSmoothFaces();

}
