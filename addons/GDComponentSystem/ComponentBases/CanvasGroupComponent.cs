#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CanvasGroup" />
[Tool, GlobalClass]
public abstract partial class CanvasGroupComponent : Node2DComponent
{

    /// <inheritdoc cref="CanvasGroup.SetFitMargin(float)" />
    public void SetFitMargin(float @fitMargin) => ((CanvasGroup)_host).SetFitMargin(@fitMargin);

    /// <inheritdoc cref="CanvasGroup.GetFitMargin()" />
    public float GetFitMargin() => ((CanvasGroup)_host).GetFitMargin();

    /// <inheritdoc cref="CanvasGroup.SetClearMargin(float)" />
    public void SetClearMargin(float @clearMargin) => ((CanvasGroup)_host).SetClearMargin(@clearMargin);

    /// <inheritdoc cref="CanvasGroup.GetClearMargin()" />
    public float GetClearMargin() => ((CanvasGroup)_host).GetClearMargin();

    /// <inheritdoc cref="CanvasGroup.SetUseMipmaps(bool)" />
    public void SetUseMipmaps(bool @useMipmaps) => ((CanvasGroup)_host).SetUseMipmaps(@useMipmaps);

    /// <inheritdoc cref="CanvasGroup.IsUsingMipmaps()" />
    public bool IsUsingMipmaps() => ((CanvasGroup)_host).IsUsingMipmaps();

}
