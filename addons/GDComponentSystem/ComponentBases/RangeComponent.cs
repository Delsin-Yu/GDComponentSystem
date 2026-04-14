#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Range" />
[Tool, GlobalClass]
public abstract partial class RangeComponent : ControlComponent
{

    /// <inheritdoc cref="Range._ValueChanged(double)" />
    public virtual void _ValueChanged(double @newValue) { }

    /// <inheritdoc cref="Range.GetValue()" />
    public double GetValue() => ((Range)_host).GetValue();

    /// <inheritdoc cref="Range.GetMin()" />
    public double GetMin() => ((Range)_host).GetMin();

    /// <inheritdoc cref="Range.GetMax()" />
    public double GetMax() => ((Range)_host).GetMax();

    /// <inheritdoc cref="Range.GetStep()" />
    public double GetStep() => ((Range)_host).GetStep();

    /// <inheritdoc cref="Range.GetPage()" />
    public double GetPage() => ((Range)_host).GetPage();

    /// <inheritdoc cref="Range.GetAsRatio()" />
    public double GetAsRatio() => ((Range)_host).GetAsRatio();

    /// <inheritdoc cref="Range.SetValue(double)" />
    public void SetValue(double @value) => ((Range)_host).SetValue(@value);

    /// <inheritdoc cref="Range.SetValueNoSignal(double)" />
    public void SetValueNoSignal(double @value) => ((Range)_host).SetValueNoSignal(@value);

    /// <inheritdoc cref="Range.SetMin(double)" />
    public void SetMin(double @minimum) => ((Range)_host).SetMin(@minimum);

    /// <inheritdoc cref="Range.SetMax(double)" />
    public void SetMax(double @maximum) => ((Range)_host).SetMax(@maximum);

    /// <inheritdoc cref="Range.SetStep(double)" />
    public void SetStep(double @step) => ((Range)_host).SetStep(@step);

    /// <inheritdoc cref="Range.SetPage(double)" />
    public void SetPage(double @pagesize) => ((Range)_host).SetPage(@pagesize);

    /// <inheritdoc cref="Range.SetAsRatio(double)" />
    public void SetAsRatio(double @value) => ((Range)_host).SetAsRatio(@value);

    /// <inheritdoc cref="Range.SetUseRoundedValues(bool)" />
    public void SetUseRoundedValues(bool @enabled) => ((Range)_host).SetUseRoundedValues(@enabled);

    /// <inheritdoc cref="Range.IsUsingRoundedValues()" />
    public bool IsUsingRoundedValues() => ((Range)_host).IsUsingRoundedValues();

    /// <inheritdoc cref="Range.SetExpRatio(bool)" />
    public void SetExpRatio(bool @enabled) => ((Range)_host).SetExpRatio(@enabled);

    /// <inheritdoc cref="Range.IsRatioExp()" />
    public bool IsRatioExp() => ((Range)_host).IsRatioExp();

    /// <inheritdoc cref="Range.SetAllowGreater(bool)" />
    public void SetAllowGreater(bool @allow) => ((Range)_host).SetAllowGreater(@allow);

    /// <inheritdoc cref="Range.IsGreaterAllowed()" />
    public bool IsGreaterAllowed() => ((Range)_host).IsGreaterAllowed();

    /// <inheritdoc cref="Range.SetAllowLesser(bool)" />
    public void SetAllowLesser(bool @allow) => ((Range)_host).SetAllowLesser(@allow);

    /// <inheritdoc cref="Range.IsLesserAllowed()" />
    public bool IsLesserAllowed() => ((Range)_host).IsLesserAllowed();

    /// <inheritdoc cref="Range.Share(Node)" />
    public void Share(Node @with) => ((Range)_host).Share(@with);

    /// <inheritdoc cref="Range.Unshare()" />
    public void Unshare() => ((Range)_host).Unshare();

}
