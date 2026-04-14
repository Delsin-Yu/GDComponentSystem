#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Slider" />
[Tool, GlobalClass]
public abstract partial class SliderComponent : RangeComponent
{

    /// <inheritdoc cref="Slider.SetTicks(int)" />
    public void SetTicks(int @count) => ((Slider)_host).SetTicks(@count);

    /// <inheritdoc cref="Slider.GetTicks()" />
    public int GetTicks() => ((Slider)_host).GetTicks();

    /// <inheritdoc cref="Slider.GetTicksOnBorders()" />
    public bool GetTicksOnBorders() => ((Slider)_host).GetTicksOnBorders();

    /// <inheritdoc cref="Slider.SetTicksOnBorders(bool)" />
    public void SetTicksOnBorders(bool @ticksOnBorder) => ((Slider)_host).SetTicksOnBorders(@ticksOnBorder);

    /// <inheritdoc cref="Slider.GetTicksPosition()" />
    public Slider.TickPosition GetTicksPosition() => ((Slider)_host).GetTicksPosition();

    /// <inheritdoc cref="Slider.SetTicksPosition(Slider.TickPosition)" />
    public void SetTicksPosition(Slider.TickPosition @ticksOnBorder) => ((Slider)_host).SetTicksPosition(@ticksOnBorder);

    /// <inheritdoc cref="Slider.SetEditable(bool)" />
    public void SetEditable(bool @editable) => ((Slider)_host).SetEditable(@editable);

    /// <inheritdoc cref="Slider.IsEditable()" />
    public bool IsEditable() => ((Slider)_host).IsEditable();

    /// <inheritdoc cref="Slider.SetScrollable(bool)" />
    public void SetScrollable(bool @scrollable) => ((Slider)_host).SetScrollable(@scrollable);

    /// <inheritdoc cref="Slider.IsScrollable()" />
    public bool IsScrollable() => ((Slider)_host).IsScrollable();

}
