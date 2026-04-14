#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ColorPicker" />
[Tool, GlobalClass]
public abstract partial class ColorPickerComponent : VBoxContainerComponent
{

    /// <inheritdoc cref="ColorPicker.SetPickColor(Color)" />
    public void SetPickColor(Color @color) => ((ColorPicker)_host).SetPickColor(@color);

    /// <inheritdoc cref="ColorPicker.GetPickColor()" />
    public Color GetPickColor() => ((ColorPicker)_host).GetPickColor();

    /// <inheritdoc cref="ColorPicker.SetDeferredMode(bool)" />
    public void SetDeferredMode(bool @mode) => ((ColorPicker)_host).SetDeferredMode(@mode);

    /// <inheritdoc cref="ColorPicker.IsDeferredMode()" />
    public bool IsDeferredMode() => ((ColorPicker)_host).IsDeferredMode();

    /// <inheritdoc cref="ColorPicker.SetColorMode(ColorPicker.ColorModeType)" />
    public void SetColorMode(ColorPicker.ColorModeType @colorMode) => ((ColorPicker)_host).SetColorMode(@colorMode);

    /// <inheritdoc cref="ColorPicker.GetColorMode()" />
    public ColorPicker.ColorModeType GetColorMode() => ((ColorPicker)_host).GetColorMode();

    /// <inheritdoc cref="ColorPicker.SetEditAlpha(bool)" />
    public void SetEditAlpha(bool @show) => ((ColorPicker)_host).SetEditAlpha(@show);

    /// <inheritdoc cref="ColorPicker.IsEditingAlpha()" />
    public bool IsEditingAlpha() => ((ColorPicker)_host).IsEditingAlpha();

    /// <inheritdoc cref="ColorPicker.SetEditIntensity(bool)" />
    public void SetEditIntensity(bool @show) => ((ColorPicker)_host).SetEditIntensity(@show);

    /// <inheritdoc cref="ColorPicker.IsEditingIntensity()" />
    public bool IsEditingIntensity() => ((ColorPicker)_host).IsEditingIntensity();

    /// <inheritdoc cref="ColorPicker.SetCanAddSwatches(bool)" />
    public void SetCanAddSwatches(bool @enabled) => ((ColorPicker)_host).SetCanAddSwatches(@enabled);

    /// <inheritdoc cref="ColorPicker.AreSwatchesEnabled()" />
    public bool AreSwatchesEnabled() => ((ColorPicker)_host).AreSwatchesEnabled();

    /// <inheritdoc cref="ColorPicker.SetPresetsVisible(bool)" />
    public void SetPresetsVisible(bool @visible) => ((ColorPicker)_host).SetPresetsVisible(@visible);

    /// <inheritdoc cref="ColorPicker.ArePresetsVisible()" />
    public bool ArePresetsVisible() => ((ColorPicker)_host).ArePresetsVisible();

    /// <inheritdoc cref="ColorPicker.SetModesVisible(bool)" />
    public void SetModesVisible(bool @visible) => ((ColorPicker)_host).SetModesVisible(@visible);

    /// <inheritdoc cref="ColorPicker.AreModesVisible()" />
    public bool AreModesVisible() => ((ColorPicker)_host).AreModesVisible();

    /// <inheritdoc cref="ColorPicker.SetSamplerVisible(bool)" />
    public void SetSamplerVisible(bool @visible) => ((ColorPicker)_host).SetSamplerVisible(@visible);

    /// <inheritdoc cref="ColorPicker.IsSamplerVisible()" />
    public bool IsSamplerVisible() => ((ColorPicker)_host).IsSamplerVisible();

    /// <inheritdoc cref="ColorPicker.SetSlidersVisible(bool)" />
    public void SetSlidersVisible(bool @visible) => ((ColorPicker)_host).SetSlidersVisible(@visible);

    /// <inheritdoc cref="ColorPicker.AreSlidersVisible()" />
    public bool AreSlidersVisible() => ((ColorPicker)_host).AreSlidersVisible();

    /// <inheritdoc cref="ColorPicker.SetHexVisible(bool)" />
    public void SetHexVisible(bool @visible) => ((ColorPicker)_host).SetHexVisible(@visible);

    /// <inheritdoc cref="ColorPicker.IsHexVisible()" />
    public bool IsHexVisible() => ((ColorPicker)_host).IsHexVisible();

    /// <inheritdoc cref="ColorPicker.AddPreset(Color)" />
    public void AddPreset(Color @color) => ((ColorPicker)_host).AddPreset(@color);

    /// <inheritdoc cref="ColorPicker.ErasePreset(Color)" />
    public void ErasePreset(Color @color) => ((ColorPicker)_host).ErasePreset(@color);

    /// <inheritdoc cref="ColorPicker.GetPresets()" />
    public Color[] GetPresets() => ((ColorPicker)_host).GetPresets();

    /// <inheritdoc cref="ColorPicker.AddRecentPreset(Color)" />
    public void AddRecentPreset(Color @color) => ((ColorPicker)_host).AddRecentPreset(@color);

    /// <inheritdoc cref="ColorPicker.EraseRecentPreset(Color)" />
    public void EraseRecentPreset(Color @color) => ((ColorPicker)_host).EraseRecentPreset(@color);

    /// <inheritdoc cref="ColorPicker.GetRecentPresets()" />
    public Color[] GetRecentPresets() => ((ColorPicker)_host).GetRecentPresets();

    /// <inheritdoc cref="ColorPicker.SetPickerShape(ColorPicker.PickerShapeType)" />
    public void SetPickerShape(ColorPicker.PickerShapeType @shape) => ((ColorPicker)_host).SetPickerShape(@shape);

    /// <inheritdoc cref="ColorPicker.GetPickerShape()" />
    public ColorPicker.PickerShapeType GetPickerShape() => ((ColorPicker)_host).GetPickerShape();

}
