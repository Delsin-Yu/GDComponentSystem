#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CanvasModulate" />
[Tool, GlobalClass]
public abstract partial class CanvasModulateComponent : Node2DComponent
{

    /// <inheritdoc cref="CanvasModulate.SetColor(Color)" />
    public void SetColor(Color @color) => ((CanvasModulate)_host).SetColor(@color);

    /// <inheritdoc cref="CanvasModulate.GetColor()" />
    public Color GetColor() => ((CanvasModulate)_host).GetColor();

}
