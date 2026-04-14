#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ScrollContainer" />
[Tool, GlobalClass]
public abstract partial class ScrollContainerComponent : ContainerComponent
{

    /// <inheritdoc cref="ScrollContainer.SetHScroll(int)" />
    public void SetHScroll(int @value) => ((ScrollContainer)_host).SetHScroll(@value);

    /// <inheritdoc cref="ScrollContainer.GetHScroll()" />
    public int GetHScroll() => ((ScrollContainer)_host).GetHScroll();

    /// <inheritdoc cref="ScrollContainer.SetVScroll(int)" />
    public void SetVScroll(int @value) => ((ScrollContainer)_host).SetVScroll(@value);

    /// <inheritdoc cref="ScrollContainer.GetVScroll()" />
    public int GetVScroll() => ((ScrollContainer)_host).GetVScroll();

    /// <inheritdoc cref="ScrollContainer.SetHorizontalCustomStep(float)" />
    public void SetHorizontalCustomStep(float @value) => ((ScrollContainer)_host).SetHorizontalCustomStep(@value);

    /// <inheritdoc cref="ScrollContainer.GetHorizontalCustomStep()" />
    public float GetHorizontalCustomStep() => ((ScrollContainer)_host).GetHorizontalCustomStep();

    /// <inheritdoc cref="ScrollContainer.SetVerticalCustomStep(float)" />
    public void SetVerticalCustomStep(float @value) => ((ScrollContainer)_host).SetVerticalCustomStep(@value);

    /// <inheritdoc cref="ScrollContainer.GetVerticalCustomStep()" />
    public float GetVerticalCustomStep() => ((ScrollContainer)_host).GetVerticalCustomStep();

    /// <inheritdoc cref="ScrollContainer.SetHorizontalScrollMode(ScrollContainer.ScrollMode)" />
    public void SetHorizontalScrollMode(ScrollContainer.ScrollMode @enable) => ((ScrollContainer)_host).SetHorizontalScrollMode(@enable);

    /// <inheritdoc cref="ScrollContainer.GetHorizontalScrollMode()" />
    public ScrollContainer.ScrollMode GetHorizontalScrollMode() => ((ScrollContainer)_host).GetHorizontalScrollMode();

    /// <inheritdoc cref="ScrollContainer.SetVerticalScrollMode(ScrollContainer.ScrollMode)" />
    public void SetVerticalScrollMode(ScrollContainer.ScrollMode @enable) => ((ScrollContainer)_host).SetVerticalScrollMode(@enable);

    /// <inheritdoc cref="ScrollContainer.GetVerticalScrollMode()" />
    public ScrollContainer.ScrollMode GetVerticalScrollMode() => ((ScrollContainer)_host).GetVerticalScrollMode();

    /// <inheritdoc cref="ScrollContainer.SetDeadzone(int)" />
    public void SetDeadzone(int @deadzone) => ((ScrollContainer)_host).SetDeadzone(@deadzone);

    /// <inheritdoc cref="ScrollContainer.GetDeadzone()" />
    public int GetDeadzone() => ((ScrollContainer)_host).GetDeadzone();

    /// <inheritdoc cref="ScrollContainer.SetScrollHintMode(ScrollContainer.ScrollHintModeEnum)" />
    public void SetScrollHintMode(ScrollContainer.ScrollHintModeEnum @scrollHintMode) => ((ScrollContainer)_host).SetScrollHintMode(@scrollHintMode);

    /// <inheritdoc cref="ScrollContainer.GetScrollHintMode()" />
    public ScrollContainer.ScrollHintModeEnum GetScrollHintMode() => ((ScrollContainer)_host).GetScrollHintMode();

    /// <inheritdoc cref="ScrollContainer.SetTileScrollHint(bool)" />
    public void SetTileScrollHint(bool @tileScrollHint) => ((ScrollContainer)_host).SetTileScrollHint(@tileScrollHint);

    /// <inheritdoc cref="ScrollContainer.IsScrollHintTiled()" />
    public bool IsScrollHintTiled() => ((ScrollContainer)_host).IsScrollHintTiled();

    /// <inheritdoc cref="ScrollContainer.SetFollowFocus(bool)" />
    public void SetFollowFocus(bool @enabled) => ((ScrollContainer)_host).SetFollowFocus(@enabled);

    /// <inheritdoc cref="ScrollContainer.IsFollowingFocus()" />
    public bool IsFollowingFocus() => ((ScrollContainer)_host).IsFollowingFocus();

    /// <inheritdoc cref="ScrollContainer.GetHScrollBar()" />
    public HScrollBar GetHScrollBar() => ((ScrollContainer)_host).GetHScrollBar();

    /// <inheritdoc cref="ScrollContainer.GetVScrollBar()" />
    public VScrollBar GetVScrollBar() => ((ScrollContainer)_host).GetVScrollBar();

    /// <inheritdoc cref="ScrollContainer.EnsureControlVisible(Control)" />
    public void EnsureControlVisible(Control @control) => ((ScrollContainer)_host).EnsureControlVisible(@control);

    /// <inheritdoc cref="ScrollContainer.SetDrawFocusBorder(bool)" />
    public void SetDrawFocusBorder(bool @draw) => ((ScrollContainer)_host).SetDrawFocusBorder(@draw);

    /// <inheritdoc cref="ScrollContainer.GetDrawFocusBorder()" />
    public bool GetDrawFocusBorder() => ((ScrollContainer)_host).GetDrawFocusBorder();

}
