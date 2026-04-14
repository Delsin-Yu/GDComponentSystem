#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="VisibleOnScreenNotifier2D" />
[Tool, GlobalClass]
public abstract partial class VisibleOnScreenNotifier2DComponent : Node2DComponent
{

    /// <inheritdoc cref="VisibleOnScreenNotifier2D.SetRect(Rect2)" />
    public void SetRect(Rect2 @rect) => ((VisibleOnScreenNotifier2D)_host).SetRect(@rect);

    /// <inheritdoc cref="VisibleOnScreenNotifier2D.GetRect()" />
    public Rect2 GetRect() => ((VisibleOnScreenNotifier2D)_host).GetRect();

    /// <inheritdoc cref="VisibleOnScreenNotifier2D.SetShowRect(bool)" />
    public void SetShowRect(bool @showRect) => ((VisibleOnScreenNotifier2D)_host).SetShowRect(@showRect);

    /// <inheritdoc cref="VisibleOnScreenNotifier2D.IsShowingRect()" />
    public bool IsShowingRect() => ((VisibleOnScreenNotifier2D)_host).IsShowingRect();

    /// <inheritdoc cref="VisibleOnScreenNotifier2D.IsOnScreen()" />
    public bool IsOnScreen() => ((VisibleOnScreenNotifier2D)_host).IsOnScreen();

}
