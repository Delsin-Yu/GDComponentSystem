#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CopyTransformModifier3D" />
[Tool, GlobalClass]
public abstract partial class CopyTransformModifier3DComponent : BoneConstraint3DComponent
{

    /// <inheritdoc cref="CopyTransformModifier3D.SetCopyFlags(int, CopyTransformModifier3D.TransformFlag)" />
    public void SetCopyFlags(int @index, CopyTransformModifier3D.TransformFlag @copyFlags) => ((CopyTransformModifier3D)_host).SetCopyFlags(@index, @copyFlags);

    /// <inheritdoc cref="CopyTransformModifier3D.GetCopyFlags(int)" />
    public CopyTransformModifier3D.TransformFlag GetCopyFlags(int @index) => ((CopyTransformModifier3D)_host).GetCopyFlags(@index);

    /// <inheritdoc cref="CopyTransformModifier3D.SetAxisFlags(int, CopyTransformModifier3D.AxisFlag)" />
    public void SetAxisFlags(int @index, CopyTransformModifier3D.AxisFlag @axisFlags) => ((CopyTransformModifier3D)_host).SetAxisFlags(@index, @axisFlags);

    /// <inheritdoc cref="CopyTransformModifier3D.GetAxisFlags(int)" />
    public CopyTransformModifier3D.AxisFlag GetAxisFlags(int @index) => ((CopyTransformModifier3D)_host).GetAxisFlags(@index);

    /// <inheritdoc cref="CopyTransformModifier3D.SetInvertFlags(int, CopyTransformModifier3D.AxisFlag)" />
    public void SetInvertFlags(int @index, CopyTransformModifier3D.AxisFlag @axisFlags) => ((CopyTransformModifier3D)_host).SetInvertFlags(@index, @axisFlags);

    /// <inheritdoc cref="CopyTransformModifier3D.GetInvertFlags(int)" />
    public CopyTransformModifier3D.AxisFlag GetInvertFlags(int @index) => ((CopyTransformModifier3D)_host).GetInvertFlags(@index);

    /// <inheritdoc cref="CopyTransformModifier3D.SetCopyPosition(int, bool)" />
    public void SetCopyPosition(int @index, bool @enabled) => ((CopyTransformModifier3D)_host).SetCopyPosition(@index, @enabled);

    /// <inheritdoc cref="CopyTransformModifier3D.IsPositionCopying(int)" />
    public bool IsPositionCopying(int @index) => ((CopyTransformModifier3D)_host).IsPositionCopying(@index);

    /// <inheritdoc cref="CopyTransformModifier3D.SetCopyRotation(int, bool)" />
    public void SetCopyRotation(int @index, bool @enabled) => ((CopyTransformModifier3D)_host).SetCopyRotation(@index, @enabled);

    /// <inheritdoc cref="CopyTransformModifier3D.IsRotationCopying(int)" />
    public bool IsRotationCopying(int @index) => ((CopyTransformModifier3D)_host).IsRotationCopying(@index);

    /// <inheritdoc cref="CopyTransformModifier3D.SetCopyScale(int, bool)" />
    public void SetCopyScale(int @index, bool @enabled) => ((CopyTransformModifier3D)_host).SetCopyScale(@index, @enabled);

    /// <inheritdoc cref="CopyTransformModifier3D.IsScaleCopying(int)" />
    public bool IsScaleCopying(int @index) => ((CopyTransformModifier3D)_host).IsScaleCopying(@index);

    /// <inheritdoc cref="CopyTransformModifier3D.SetAxisXEnabled(int, bool)" />
    public void SetAxisXEnabled(int @index, bool @enabled) => ((CopyTransformModifier3D)_host).SetAxisXEnabled(@index, @enabled);

    /// <inheritdoc cref="CopyTransformModifier3D.IsAxisXEnabled(int)" />
    public bool IsAxisXEnabled(int @index) => ((CopyTransformModifier3D)_host).IsAxisXEnabled(@index);

    /// <inheritdoc cref="CopyTransformModifier3D.SetAxisYEnabled(int, bool)" />
    public void SetAxisYEnabled(int @index, bool @enabled) => ((CopyTransformModifier3D)_host).SetAxisYEnabled(@index, @enabled);

    /// <inheritdoc cref="CopyTransformModifier3D.IsAxisYEnabled(int)" />
    public bool IsAxisYEnabled(int @index) => ((CopyTransformModifier3D)_host).IsAxisYEnabled(@index);

    /// <inheritdoc cref="CopyTransformModifier3D.SetAxisZEnabled(int, bool)" />
    public void SetAxisZEnabled(int @index, bool @enabled) => ((CopyTransformModifier3D)_host).SetAxisZEnabled(@index, @enabled);

    /// <inheritdoc cref="CopyTransformModifier3D.IsAxisZEnabled(int)" />
    public bool IsAxisZEnabled(int @index) => ((CopyTransformModifier3D)_host).IsAxisZEnabled(@index);

    /// <inheritdoc cref="CopyTransformModifier3D.SetAxisXInverted(int, bool)" />
    public void SetAxisXInverted(int @index, bool @enabled) => ((CopyTransformModifier3D)_host).SetAxisXInverted(@index, @enabled);

    /// <inheritdoc cref="CopyTransformModifier3D.IsAxisXInverted(int)" />
    public bool IsAxisXInverted(int @index) => ((CopyTransformModifier3D)_host).IsAxisXInverted(@index);

    /// <inheritdoc cref="CopyTransformModifier3D.SetAxisYInverted(int, bool)" />
    public void SetAxisYInverted(int @index, bool @enabled) => ((CopyTransformModifier3D)_host).SetAxisYInverted(@index, @enabled);

    /// <inheritdoc cref="CopyTransformModifier3D.IsAxisYInverted(int)" />
    public bool IsAxisYInverted(int @index) => ((CopyTransformModifier3D)_host).IsAxisYInverted(@index);

    /// <inheritdoc cref="CopyTransformModifier3D.SetAxisZInverted(int, bool)" />
    public void SetAxisZInverted(int @index, bool @enabled) => ((CopyTransformModifier3D)_host).SetAxisZInverted(@index, @enabled);

    /// <inheritdoc cref="CopyTransformModifier3D.IsAxisZInverted(int)" />
    public bool IsAxisZInverted(int @index) => ((CopyTransformModifier3D)_host).IsAxisZInverted(@index);

    /// <inheritdoc cref="CopyTransformModifier3D.SetRelative(int, bool)" />
    public void SetRelative(int @index, bool @enabled) => ((CopyTransformModifier3D)_host).SetRelative(@index, @enabled);

    /// <inheritdoc cref="CopyTransformModifier3D.IsRelative(int)" />
    public bool IsRelative(int @index) => ((CopyTransformModifier3D)_host).IsRelative(@index);

    /// <inheritdoc cref="CopyTransformModifier3D.SetAdditive(int, bool)" />
    public void SetAdditive(int @index, bool @enabled) => ((CopyTransformModifier3D)_host).SetAdditive(@index, @enabled);

    /// <inheritdoc cref="CopyTransformModifier3D.IsAdditive(int)" />
    public bool IsAdditive(int @index) => ((CopyTransformModifier3D)_host).IsAdditive(@index);

}
