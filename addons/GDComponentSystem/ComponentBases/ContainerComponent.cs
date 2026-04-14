#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Container" />
[Tool, GlobalClass]
public abstract partial class ContainerComponent : ControlComponent
{

    /// <inheritdoc cref="Container._GetAllowedSizeFlagsHorizontal()" />
    public virtual int[] _GetAllowedSizeFlagsHorizontal() => ((Container)_host)._GetAllowedSizeFlagsHorizontal();

    /// <inheritdoc cref="Container._GetAllowedSizeFlagsVertical()" />
    public virtual int[] _GetAllowedSizeFlagsVertical() => ((Container)_host)._GetAllowedSizeFlagsVertical();

    /// <inheritdoc cref="Container.QueueSort()" />
    public void QueueSort() => ((Container)_host).QueueSort();

    /// <inheritdoc cref="Container.FitChildInRect(Control, Rect2)" />
    public void FitChildInRect(Control @child, Rect2 @rect) => ((Container)_host).FitChildInRect(@child, @rect);

}
