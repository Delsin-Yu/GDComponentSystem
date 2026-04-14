#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="BaseButton" />
[Tool, GlobalClass]
public abstract partial class BaseButtonComponent : ControlComponent
{

    /// <inheritdoc cref="BaseButton._Pressed()" />
    public virtual void _Pressed() { }

    /// <inheritdoc cref="BaseButton._Toggled(bool)" />
    public virtual void _Toggled(bool @toggledOn) { }

    /// <inheritdoc cref="BaseButton.SetPressed(bool)" />
    public void SetPressed(bool @pressed) => ((BaseButton)_host).SetPressed(@pressed);

    /// <inheritdoc cref="BaseButton.IsPressed()" />
    public bool IsPressed() => ((BaseButton)_host).IsPressed();

    /// <inheritdoc cref="BaseButton.SetPressedNoSignal(bool)" />
    public void SetPressedNoSignal(bool @pressed) => ((BaseButton)_host).SetPressedNoSignal(@pressed);

    /// <inheritdoc cref="BaseButton.IsHovered()" />
    public bool IsHovered() => ((BaseButton)_host).IsHovered();

    /// <inheritdoc cref="BaseButton.SetToggleMode(bool)" />
    public void SetToggleMode(bool @enabled) => ((BaseButton)_host).SetToggleMode(@enabled);

    /// <inheritdoc cref="BaseButton.IsToggleMode()" />
    public bool IsToggleMode() => ((BaseButton)_host).IsToggleMode();

    /// <inheritdoc cref="BaseButton.SetShortcutInTooltip(bool)" />
    public void SetShortcutInTooltip(bool @enabled) => ((BaseButton)_host).SetShortcutInTooltip(@enabled);

    /// <inheritdoc cref="BaseButton.IsShortcutInTooltipEnabled()" />
    public bool IsShortcutInTooltipEnabled() => ((BaseButton)_host).IsShortcutInTooltipEnabled();

    /// <inheritdoc cref="BaseButton.SetDisabled(bool)" />
    public void SetDisabled(bool @disabled) => ((BaseButton)_host).SetDisabled(@disabled);

    /// <inheritdoc cref="BaseButton.IsDisabled()" />
    public bool IsDisabled() => ((BaseButton)_host).IsDisabled();

    /// <inheritdoc cref="BaseButton.SetActionMode(BaseButton.ActionModeEnum)" />
    public void SetActionMode(BaseButton.ActionModeEnum @mode) => ((BaseButton)_host).SetActionMode(@mode);

    /// <inheritdoc cref="BaseButton.GetActionMode()" />
    public BaseButton.ActionModeEnum GetActionMode() => ((BaseButton)_host).GetActionMode();

    /// <inheritdoc cref="BaseButton.SetButtonMask(MouseButtonMask)" />
    public void SetButtonMask(MouseButtonMask @mask) => ((BaseButton)_host).SetButtonMask(@mask);

    /// <inheritdoc cref="BaseButton.GetButtonMask()" />
    public MouseButtonMask GetButtonMask() => ((BaseButton)_host).GetButtonMask();

    /// <inheritdoc cref="BaseButton.GetDrawMode()" />
    public BaseButton.DrawMode GetDrawMode() => ((BaseButton)_host).GetDrawMode();

    /// <inheritdoc cref="BaseButton.SetKeepPressedOutside(bool)" />
    public void SetKeepPressedOutside(bool @enabled) => ((BaseButton)_host).SetKeepPressedOutside(@enabled);

    /// <inheritdoc cref="BaseButton.IsKeepPressedOutside()" />
    public bool IsKeepPressedOutside() => ((BaseButton)_host).IsKeepPressedOutside();

    /// <inheritdoc cref="BaseButton.SetShortcutFeedback(bool)" />
    public void SetShortcutFeedback(bool @enabled) => ((BaseButton)_host).SetShortcutFeedback(@enabled);

    /// <inheritdoc cref="BaseButton.IsShortcutFeedback()" />
    public bool IsShortcutFeedback() => ((BaseButton)_host).IsShortcutFeedback();

    /// <inheritdoc cref="BaseButton.SetShortcut(Shortcut)" />
    public void SetShortcut(Shortcut @shortcut) => ((BaseButton)_host).SetShortcut(@shortcut);

    /// <inheritdoc cref="BaseButton.GetShortcut()" />
    public Shortcut GetShortcut() => ((BaseButton)_host).GetShortcut();

    /// <inheritdoc cref="BaseButton.SetButtonGroup(ButtonGroup)" />
    public void SetButtonGroup(ButtonGroup @buttonGroup) => ((BaseButton)_host).SetButtonGroup(@buttonGroup);

    /// <inheritdoc cref="BaseButton.GetButtonGroup()" />
    public ButtonGroup GetButtonGroup() => ((BaseButton)_host).GetButtonGroup();

}
