#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CsgSphere3D" />
[Tool, GlobalClass]
public abstract partial class CsgSphere3DComponent : CsgPrimitive3DComponent
{

    /// <inheritdoc cref="CsgSphere3D.SetRadius(float)" />
    public void SetRadius(float @radius) => ((CsgSphere3D)_host).SetRadius(@radius);

    /// <inheritdoc cref="CsgSphere3D.GetRadius()" />
    public float GetRadius() => ((CsgSphere3D)_host).GetRadius();

    /// <inheritdoc cref="CsgSphere3D.SetRadialSegments(int)" />
    public void SetRadialSegments(int @radialSegments) => ((CsgSphere3D)_host).SetRadialSegments(@radialSegments);

    /// <inheritdoc cref="CsgSphere3D.GetRadialSegments()" />
    public int GetRadialSegments() => ((CsgSphere3D)_host).GetRadialSegments();

    /// <inheritdoc cref="CsgSphere3D.SetRings(int)" />
    public void SetRings(int @rings) => ((CsgSphere3D)_host).SetRings(@rings);

    /// <inheritdoc cref="CsgSphere3D.GetRings()" />
    public int GetRings() => ((CsgSphere3D)_host).GetRings();

    /// <inheritdoc cref="CsgSphere3D.SetSmoothFaces(bool)" />
    public void SetSmoothFaces(bool @smoothFaces) => ((CsgSphere3D)_host).SetSmoothFaces(@smoothFaces);

    /// <inheritdoc cref="CsgSphere3D.GetSmoothFaces()" />
    public bool GetSmoothFaces() => ((CsgSphere3D)_host).GetSmoothFaces();

    /// <inheritdoc cref="CsgSphere3D.SetMaterial(Material)" />
    public void SetMaterial(Material @material) => ((CsgSphere3D)_host).SetMaterial(@material);

    /// <inheritdoc cref="CsgSphere3D.GetMaterial()" />
    public Material GetMaterial() => ((CsgSphere3D)_host).GetMaterial();

}
