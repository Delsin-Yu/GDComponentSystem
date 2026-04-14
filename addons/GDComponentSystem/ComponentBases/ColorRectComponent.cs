#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ColorRect" />
[Tool, GlobalClass]
public abstract partial class ColorRectComponent : ControlComponent
{

    /// <inheritdoc cref="ColorRect.SetColor(Color)" />
    public void SetColor(Color @color) => ((ColorRect)_host).SetColor(@color);

    /// <inheritdoc cref="ColorRect.GetColor()" />
    public Color GetColor() => ((ColorRect)_host).GetColor();

}
