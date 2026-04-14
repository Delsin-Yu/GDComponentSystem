#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ColorPickerButton" />
[Tool, GlobalClass]
public abstract partial class ColorPickerButtonComponent : ButtonComponent
{

    /// <inheritdoc cref="ColorPickerButton.SetPickColor(Color)" />
    public void SetPickColor(Color @color) => ((ColorPickerButton)_host).SetPickColor(@color);

    /// <inheritdoc cref="ColorPickerButton.GetPickColor()" />
    public Color GetPickColor() => ((ColorPickerButton)_host).GetPickColor();

    /// <inheritdoc cref="ColorPickerButton.GetPicker()" />
    public ColorPicker GetPicker() => ((ColorPickerButton)_host).GetPicker();

    /// <inheritdoc cref="ColorPickerButton.GetPopup()" />
    public PopupPanel GetPopup() => ((ColorPickerButton)_host).GetPopup();

    /// <inheritdoc cref="ColorPickerButton.SetEditAlpha(bool)" />
    public void SetEditAlpha(bool @show) => ((ColorPickerButton)_host).SetEditAlpha(@show);

    /// <inheritdoc cref="ColorPickerButton.IsEditingAlpha()" />
    public bool IsEditingAlpha() => ((ColorPickerButton)_host).IsEditingAlpha();

    /// <inheritdoc cref="ColorPickerButton.SetEditIntensity(bool)" />
    public void SetEditIntensity(bool @show) => ((ColorPickerButton)_host).SetEditIntensity(@show);

    /// <inheritdoc cref="ColorPickerButton.IsEditingIntensity()" />
    public bool IsEditingIntensity() => ((ColorPickerButton)_host).IsEditingIntensity();

}
