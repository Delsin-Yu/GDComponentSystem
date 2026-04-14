#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CsgPolygon3D" />
[Tool, GlobalClass]
public abstract partial class CsgPolygon3DComponent : CsgPrimitive3DComponent
{

    /// <inheritdoc cref="CsgPolygon3D.SetPolygon(Vector2[])" />
    public void SetPolygon(Vector2[] @polygon) => ((CsgPolygon3D)_host).SetPolygon(@polygon);

    /// <inheritdoc cref="CsgPolygon3D.SetPolygon(ReadOnlySpan{Vector2})" />
    public void SetPolygon(ReadOnlySpan<Vector2> @polygon) => ((CsgPolygon3D)_host).SetPolygon(@polygon);

    /// <inheritdoc cref="CsgPolygon3D.GetPolygon()" />
    public Vector2[] GetPolygon() => ((CsgPolygon3D)_host).GetPolygon();

    /// <inheritdoc cref="CsgPolygon3D.SetMode(CsgPolygon3D.ModeEnum)" />
    public void SetMode(CsgPolygon3D.ModeEnum @mode) => ((CsgPolygon3D)_host).SetMode(@mode);

    /// <inheritdoc cref="CsgPolygon3D.GetMode()" />
    public CsgPolygon3D.ModeEnum GetMode() => ((CsgPolygon3D)_host).GetMode();

    /// <inheritdoc cref="CsgPolygon3D.SetDepth(float)" />
    public void SetDepth(float @depth) => ((CsgPolygon3D)_host).SetDepth(@depth);

    /// <inheritdoc cref="CsgPolygon3D.GetDepth()" />
    public float GetDepth() => ((CsgPolygon3D)_host).GetDepth();

    /// <inheritdoc cref="CsgPolygon3D.SetSpinDegrees(float)" />
    public void SetSpinDegrees(float @degrees) => ((CsgPolygon3D)_host).SetSpinDegrees(@degrees);

    /// <inheritdoc cref="CsgPolygon3D.GetSpinDegrees()" />
    public float GetSpinDegrees() => ((CsgPolygon3D)_host).GetSpinDegrees();

    /// <inheritdoc cref="CsgPolygon3D.SetSpinSides(int)" />
    public void SetSpinSides(int @spinSides) => ((CsgPolygon3D)_host).SetSpinSides(@spinSides);

    /// <inheritdoc cref="CsgPolygon3D.GetSpinSides()" />
    public int GetSpinSides() => ((CsgPolygon3D)_host).GetSpinSides();

    /// <inheritdoc cref="CsgPolygon3D.SetPathNode(NodePath)" />
    public void SetPathNode(NodePath @path) => ((CsgPolygon3D)_host).SetPathNode(@path);

    /// <inheritdoc cref="CsgPolygon3D.GetPathNode()" />
    public NodePath GetPathNode() => ((CsgPolygon3D)_host).GetPathNode();

    /// <inheritdoc cref="CsgPolygon3D.SetPathIntervalType(CsgPolygon3D.PathIntervalTypeEnum)" />
    public void SetPathIntervalType(CsgPolygon3D.PathIntervalTypeEnum @intervalType) => ((CsgPolygon3D)_host).SetPathIntervalType(@intervalType);

    /// <inheritdoc cref="CsgPolygon3D.GetPathIntervalType()" />
    public CsgPolygon3D.PathIntervalTypeEnum GetPathIntervalType() => ((CsgPolygon3D)_host).GetPathIntervalType();

    /// <inheritdoc cref="CsgPolygon3D.SetPathInterval(float)" />
    public void SetPathInterval(float @interval) => ((CsgPolygon3D)_host).SetPathInterval(@interval);

    /// <inheritdoc cref="CsgPolygon3D.GetPathInterval()" />
    public float GetPathInterval() => ((CsgPolygon3D)_host).GetPathInterval();

    /// <inheritdoc cref="CsgPolygon3D.SetPathSimplifyAngle(float)" />
    public void SetPathSimplifyAngle(float @degrees) => ((CsgPolygon3D)_host).SetPathSimplifyAngle(@degrees);

    /// <inheritdoc cref="CsgPolygon3D.GetPathSimplifyAngle()" />
    public float GetPathSimplifyAngle() => ((CsgPolygon3D)_host).GetPathSimplifyAngle();

    /// <inheritdoc cref="CsgPolygon3D.SetPathRotation(CsgPolygon3D.PathRotationEnum)" />
    public void SetPathRotation(CsgPolygon3D.PathRotationEnum @pathRotation) => ((CsgPolygon3D)_host).SetPathRotation(@pathRotation);

    /// <inheritdoc cref="CsgPolygon3D.GetPathRotation()" />
    public CsgPolygon3D.PathRotationEnum GetPathRotation() => ((CsgPolygon3D)_host).GetPathRotation();

    /// <inheritdoc cref="CsgPolygon3D.SetPathRotationAccurate(bool)" />
    public void SetPathRotationAccurate(bool @enable) => ((CsgPolygon3D)_host).SetPathRotationAccurate(@enable);

    /// <inheritdoc cref="CsgPolygon3D.GetPathRotationAccurate()" />
    public bool GetPathRotationAccurate() => ((CsgPolygon3D)_host).GetPathRotationAccurate();

    /// <inheritdoc cref="CsgPolygon3D.SetPathLocal(bool)" />
    public void SetPathLocal(bool @enable) => ((CsgPolygon3D)_host).SetPathLocal(@enable);

    /// <inheritdoc cref="CsgPolygon3D.IsPathLocal()" />
    public bool IsPathLocal() => ((CsgPolygon3D)_host).IsPathLocal();

    /// <inheritdoc cref="CsgPolygon3D.SetPathContinuousU(bool)" />
    public void SetPathContinuousU(bool @enable) => ((CsgPolygon3D)_host).SetPathContinuousU(@enable);

    /// <inheritdoc cref="CsgPolygon3D.IsPathContinuousU()" />
    public bool IsPathContinuousU() => ((CsgPolygon3D)_host).IsPathContinuousU();

    /// <inheritdoc cref="CsgPolygon3D.SetPathUDistance(float)" />
    public void SetPathUDistance(float @distance) => ((CsgPolygon3D)_host).SetPathUDistance(@distance);

    /// <inheritdoc cref="CsgPolygon3D.GetPathUDistance()" />
    public float GetPathUDistance() => ((CsgPolygon3D)_host).GetPathUDistance();

    /// <inheritdoc cref="CsgPolygon3D.SetPathJoined(bool)" />
    public void SetPathJoined(bool @enable) => ((CsgPolygon3D)_host).SetPathJoined(@enable);

    /// <inheritdoc cref="CsgPolygon3D.IsPathJoined()" />
    public bool IsPathJoined() => ((CsgPolygon3D)_host).IsPathJoined();

    /// <inheritdoc cref="CsgPolygon3D.SetMaterial(Material)" />
    public void SetMaterial(Material @material) => ((CsgPolygon3D)_host).SetMaterial(@material);

    /// <inheritdoc cref="CsgPolygon3D.GetMaterial()" />
    public Material GetMaterial() => ((CsgPolygon3D)_host).GetMaterial();

    /// <inheritdoc cref="CsgPolygon3D.SetSmoothFaces(bool)" />
    public void SetSmoothFaces(bool @smoothFaces) => ((CsgPolygon3D)_host).SetSmoothFaces(@smoothFaces);

    /// <inheritdoc cref="CsgPolygon3D.GetSmoothFaces()" />
    public bool GetSmoothFaces() => ((CsgPolygon3D)_host).GetSmoothFaces();

}
