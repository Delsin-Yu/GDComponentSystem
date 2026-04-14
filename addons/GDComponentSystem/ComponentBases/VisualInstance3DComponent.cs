#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="VisualInstance3D" />
[Tool, GlobalClass]
public abstract partial class VisualInstance3DComponent : Node3DComponent
{

    /// <inheritdoc cref="VisualInstance3D._GetAabb()" />
    public virtual Aabb _GetAabb() => ((VisualInstance3D)_host)._GetAabb();

    /// <inheritdoc cref="VisualInstance3D.SetBase(Rid)" />
    public void SetBase(Rid @base) => ((VisualInstance3D)_host).SetBase(@base);

    /// <inheritdoc cref="VisualInstance3D.GetBase()" />
    public Rid GetBase() => ((VisualInstance3D)_host).GetBase();

    /// <inheritdoc cref="VisualInstance3D.GetInstance()" />
    public Rid GetInstance() => ((VisualInstance3D)_host).GetInstance();

    /// <inheritdoc cref="VisualInstance3D.SetLayerMask(uint)" />
    public void SetLayerMask(uint @mask) => ((VisualInstance3D)_host).SetLayerMask(@mask);

    /// <inheritdoc cref="VisualInstance3D.GetLayerMask()" />
    public uint GetLayerMask() => ((VisualInstance3D)_host).GetLayerMask();

    /// <inheritdoc cref="VisualInstance3D.SetLayerMaskValue(int, bool)" />
    public void SetLayerMaskValue(int @layerNumber, bool @value) => ((VisualInstance3D)_host).SetLayerMaskValue(@layerNumber, @value);

    /// <inheritdoc cref="VisualInstance3D.GetLayerMaskValue(int)" />
    public bool GetLayerMaskValue(int @layerNumber) => ((VisualInstance3D)_host).GetLayerMaskValue(@layerNumber);

    /// <inheritdoc cref="VisualInstance3D.SetSortingOffset(float)" />
    public void SetSortingOffset(float @offset) => ((VisualInstance3D)_host).SetSortingOffset(@offset);

    /// <inheritdoc cref="VisualInstance3D.GetSortingOffset()" />
    public float GetSortingOffset() => ((VisualInstance3D)_host).GetSortingOffset();

    /// <inheritdoc cref="VisualInstance3D.SetSortingUseAabbCenter(bool)" />
    public void SetSortingUseAabbCenter(bool @enabled) => ((VisualInstance3D)_host).SetSortingUseAabbCenter(@enabled);

    /// <inheritdoc cref="VisualInstance3D.IsSortingUseAabbCenter()" />
    public bool IsSortingUseAabbCenter() => ((VisualInstance3D)_host).IsSortingUseAabbCenter();

    /// <inheritdoc cref="VisualInstance3D.GetAabb()" />
    public Aabb GetAabb() => ((VisualInstance3D)_host).GetAabb();

}
