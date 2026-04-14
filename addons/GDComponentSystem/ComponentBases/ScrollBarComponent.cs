#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ScrollBar" />
[Tool, GlobalClass]
public abstract partial class ScrollBarComponent : RangeComponent
{

    /// <inheritdoc cref="ScrollBar.SetCustomStep(float)" />
    public void SetCustomStep(float @step) => ((ScrollBar)_host).SetCustomStep(@step);

    /// <inheritdoc cref="ScrollBar.GetCustomStep()" />
    public float GetCustomStep() => ((ScrollBar)_host).GetCustomStep();

}
