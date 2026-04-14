#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="SpinBox" />
[Tool, GlobalClass]
public abstract partial class SpinBoxComponent : RangeComponent
{

    /// <inheritdoc cref="SpinBox.SetHorizontalAlignment(HorizontalAlignment)" />
    public void SetHorizontalAlignment(HorizontalAlignment @alignment) => ((SpinBox)_host).SetHorizontalAlignment(@alignment);

    /// <inheritdoc cref="SpinBox.GetHorizontalAlignment()" />
    public HorizontalAlignment GetHorizontalAlignment() => ((SpinBox)_host).GetHorizontalAlignment();

    /// <inheritdoc cref="SpinBox.SetSuffix(string)" />
    public void SetSuffix(string @suffix) => ((SpinBox)_host).SetSuffix(@suffix);

    /// <inheritdoc cref="SpinBox.GetSuffix()" />
    public string GetSuffix() => ((SpinBox)_host).GetSuffix();

    /// <inheritdoc cref="SpinBox.SetPrefix(string)" />
    public void SetPrefix(string @prefix) => ((SpinBox)_host).SetPrefix(@prefix);

    /// <inheritdoc cref="SpinBox.GetPrefix()" />
    public string GetPrefix() => ((SpinBox)_host).GetPrefix();

    /// <inheritdoc cref="SpinBox.SetEditable(bool)" />
    public void SetEditable(bool @enabled) => ((SpinBox)_host).SetEditable(@enabled);

    /// <inheritdoc cref="SpinBox.SetCustomArrowStep(double)" />
    public void SetCustomArrowStep(double @arrowStep) => ((SpinBox)_host).SetCustomArrowStep(@arrowStep);

    /// <inheritdoc cref="SpinBox.GetCustomArrowStep()" />
    public double GetCustomArrowStep() => ((SpinBox)_host).GetCustomArrowStep();

    /// <inheritdoc cref="SpinBox.SetCustomArrowRound(bool)" />
    public void SetCustomArrowRound(bool @round) => ((SpinBox)_host).SetCustomArrowRound(@round);

    /// <inheritdoc cref="SpinBox.IsCustomArrowRounding()" />
    public bool IsCustomArrowRounding() => ((SpinBox)_host).IsCustomArrowRounding();

    /// <inheritdoc cref="SpinBox.IsEditable()" />
    public bool IsEditable() => ((SpinBox)_host).IsEditable();

    /// <inheritdoc cref="SpinBox.SetUpdateOnTextChanged(bool)" />
    public void SetUpdateOnTextChanged(bool @enabled) => ((SpinBox)_host).SetUpdateOnTextChanged(@enabled);

    /// <inheritdoc cref="SpinBox.GetUpdateOnTextChanged()" />
    public bool GetUpdateOnTextChanged() => ((SpinBox)_host).GetUpdateOnTextChanged();

    /// <inheritdoc cref="SpinBox.SetSelectAllOnFocus(bool)" />
    public void SetSelectAllOnFocus(bool @enabled) => ((SpinBox)_host).SetSelectAllOnFocus(@enabled);

    /// <inheritdoc cref="SpinBox.IsSelectAllOnFocus()" />
    public bool IsSelectAllOnFocus() => ((SpinBox)_host).IsSelectAllOnFocus();

    /// <inheritdoc cref="SpinBox.Apply()" />
    public void Apply() => ((SpinBox)_host).Apply();

    /// <inheritdoc cref="SpinBox.GetLineEdit()" />
    public LineEdit GetLineEdit() => ((SpinBox)_host).GetLineEdit();

}
