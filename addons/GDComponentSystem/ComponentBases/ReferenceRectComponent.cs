#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ReferenceRect" />
[Tool, GlobalClass]
public abstract partial class ReferenceRectComponent : ControlComponent
{

    /// <inheritdoc cref="ReferenceRect.GetBorderColor()" />
    public Color GetBorderColor() => ((ReferenceRect)_host).GetBorderColor();

    /// <inheritdoc cref="ReferenceRect.SetBorderColor(Color)" />
    public void SetBorderColor(Color @color) => ((ReferenceRect)_host).SetBorderColor(@color);

    /// <inheritdoc cref="ReferenceRect.GetBorderWidth()" />
    public float GetBorderWidth() => ((ReferenceRect)_host).GetBorderWidth();

    /// <inheritdoc cref="ReferenceRect.SetBorderWidth(float)" />
    public void SetBorderWidth(float @width) => ((ReferenceRect)_host).SetBorderWidth(@width);

    /// <inheritdoc cref="ReferenceRect.GetEditorOnly()" />
    public bool GetEditorOnly() => ((ReferenceRect)_host).GetEditorOnly();

    /// <inheritdoc cref="ReferenceRect.SetEditorOnly(bool)" />
    public void SetEditorOnly(bool @enabled) => ((ReferenceRect)_host).SetEditorOnly(@enabled);

}
