#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ConvertTransformModifier3D" />
[Tool, GlobalClass]
public abstract partial class ConvertTransformModifier3DComponent : BoneConstraint3DComponent
{

    /// <inheritdoc cref="ConvertTransformModifier3D.SetApplyTransformMode(int, ConvertTransformModifier3D.TransformMode)" />
    public void SetApplyTransformMode(int @index, ConvertTransformModifier3D.TransformMode @transformMode) => ((ConvertTransformModifier3D)_host).SetApplyTransformMode(@index, @transformMode);

    /// <inheritdoc cref="ConvertTransformModifier3D.GetApplyTransformMode(int)" />
    public ConvertTransformModifier3D.TransformMode GetApplyTransformMode(int @index) => ((ConvertTransformModifier3D)_host).GetApplyTransformMode(@index);

    /// <inheritdoc cref="ConvertTransformModifier3D.SetApplyAxis(int, Vector3.Axis)" />
    public void SetApplyAxis(int @index, Vector3.Axis @axis) => ((ConvertTransformModifier3D)_host).SetApplyAxis(@index, @axis);

    /// <inheritdoc cref="ConvertTransformModifier3D.GetApplyAxis(int)" />
    public Vector3.Axis GetApplyAxis(int @index) => ((ConvertTransformModifier3D)_host).GetApplyAxis(@index);

    /// <inheritdoc cref="ConvertTransformModifier3D.SetApplyRangeMin(int, float)" />
    public void SetApplyRangeMin(int @index, float @rangeMin) => ((ConvertTransformModifier3D)_host).SetApplyRangeMin(@index, @rangeMin);

    /// <inheritdoc cref="ConvertTransformModifier3D.GetApplyRangeMin(int)" />
    public float GetApplyRangeMin(int @index) => ((ConvertTransformModifier3D)_host).GetApplyRangeMin(@index);

    /// <inheritdoc cref="ConvertTransformModifier3D.SetApplyRangeMax(int, float)" />
    public void SetApplyRangeMax(int @index, float @rangeMax) => ((ConvertTransformModifier3D)_host).SetApplyRangeMax(@index, @rangeMax);

    /// <inheritdoc cref="ConvertTransformModifier3D.GetApplyRangeMax(int)" />
    public float GetApplyRangeMax(int @index) => ((ConvertTransformModifier3D)_host).GetApplyRangeMax(@index);

    /// <inheritdoc cref="ConvertTransformModifier3D.SetReferenceTransformMode(int, ConvertTransformModifier3D.TransformMode)" />
    public void SetReferenceTransformMode(int @index, ConvertTransformModifier3D.TransformMode @transformMode) => ((ConvertTransformModifier3D)_host).SetReferenceTransformMode(@index, @transformMode);

    /// <inheritdoc cref="ConvertTransformModifier3D.GetReferenceTransformMode(int)" />
    public ConvertTransformModifier3D.TransformMode GetReferenceTransformMode(int @index) => ((ConvertTransformModifier3D)_host).GetReferenceTransformMode(@index);

    /// <inheritdoc cref="ConvertTransformModifier3D.SetReferenceAxis(int, Vector3.Axis)" />
    public void SetReferenceAxis(int @index, Vector3.Axis @axis) => ((ConvertTransformModifier3D)_host).SetReferenceAxis(@index, @axis);

    /// <inheritdoc cref="ConvertTransformModifier3D.GetReferenceAxis(int)" />
    public Vector3.Axis GetReferenceAxis(int @index) => ((ConvertTransformModifier3D)_host).GetReferenceAxis(@index);

    /// <inheritdoc cref="ConvertTransformModifier3D.SetReferenceRangeMin(int, float)" />
    public void SetReferenceRangeMin(int @index, float @rangeMin) => ((ConvertTransformModifier3D)_host).SetReferenceRangeMin(@index, @rangeMin);

    /// <inheritdoc cref="ConvertTransformModifier3D.GetReferenceRangeMin(int)" />
    public float GetReferenceRangeMin(int @index) => ((ConvertTransformModifier3D)_host).GetReferenceRangeMin(@index);

    /// <inheritdoc cref="ConvertTransformModifier3D.SetReferenceRangeMax(int, float)" />
    public void SetReferenceRangeMax(int @index, float @rangeMax) => ((ConvertTransformModifier3D)_host).SetReferenceRangeMax(@index, @rangeMax);

    /// <inheritdoc cref="ConvertTransformModifier3D.GetReferenceRangeMax(int)" />
    public float GetReferenceRangeMax(int @index) => ((ConvertTransformModifier3D)_host).GetReferenceRangeMax(@index);

    /// <inheritdoc cref="ConvertTransformModifier3D.SetRelative(int, bool)" />
    public void SetRelative(int @index, bool @enabled) => ((ConvertTransformModifier3D)_host).SetRelative(@index, @enabled);

    /// <inheritdoc cref="ConvertTransformModifier3D.IsRelative(int)" />
    public bool IsRelative(int @index) => ((ConvertTransformModifier3D)_host).IsRelative(@index);

    /// <inheritdoc cref="ConvertTransformModifier3D.SetAdditive(int, bool)" />
    public void SetAdditive(int @index, bool @enabled) => ((ConvertTransformModifier3D)_host).SetAdditive(@index, @enabled);

    /// <inheritdoc cref="ConvertTransformModifier3D.IsAdditive(int)" />
    public bool IsAdditive(int @index) => ((ConvertTransformModifier3D)_host).IsAdditive(@index);

}
