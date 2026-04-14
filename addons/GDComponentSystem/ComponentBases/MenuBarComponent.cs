#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="MenuBar" />
[Tool, GlobalClass]
public abstract partial class MenuBarComponent : ControlComponent
{

    /// <inheritdoc cref="MenuBar.SetSwitchOnHover(bool)" />
    public void SetSwitchOnHover(bool @enable) => ((MenuBar)_host).SetSwitchOnHover(@enable);

    /// <inheritdoc cref="MenuBar.IsSwitchOnHover()" />
    public bool IsSwitchOnHover() => ((MenuBar)_host).IsSwitchOnHover();

    /// <inheritdoc cref="MenuBar.SetDisableShortcuts(bool)" />
    public void SetDisableShortcuts(bool @disabled) => ((MenuBar)_host).SetDisableShortcuts(@disabled);

    /// <inheritdoc cref="MenuBar.SetPreferGlobalMenu(bool)" />
    public void SetPreferGlobalMenu(bool @enabled) => ((MenuBar)_host).SetPreferGlobalMenu(@enabled);

    /// <inheritdoc cref="MenuBar.IsPreferGlobalMenu()" />
    public bool IsPreferGlobalMenu() => ((MenuBar)_host).IsPreferGlobalMenu();

    /// <inheritdoc cref="MenuBar.IsNativeMenu()" />
    public bool IsNativeMenu() => ((MenuBar)_host).IsNativeMenu();

    /// <inheritdoc cref="MenuBar.GetMenuCount()" />
    public int GetMenuCount() => ((MenuBar)_host).GetMenuCount();

    /// <inheritdoc cref="MenuBar.SetTextDirection(Control.TextDirection)" />
    public void SetTextDirection(Control.TextDirection @direction) => ((MenuBar)_host).SetTextDirection(@direction);

    /// <inheritdoc cref="MenuBar.GetTextDirection()" />
    public Control.TextDirection GetTextDirection() => ((MenuBar)_host).GetTextDirection();

    /// <inheritdoc cref="MenuBar.SetLanguage(string)" />
    public void SetLanguage(string @language) => ((MenuBar)_host).SetLanguage(@language);

    /// <inheritdoc cref="MenuBar.GetLanguage()" />
    public string GetLanguage() => ((MenuBar)_host).GetLanguage();

    /// <inheritdoc cref="MenuBar.SetFlat(bool)" />
    public void SetFlat(bool @enabled) => ((MenuBar)_host).SetFlat(@enabled);

    /// <inheritdoc cref="MenuBar.IsFlat()" />
    public bool IsFlat() => ((MenuBar)_host).IsFlat();

    /// <inheritdoc cref="MenuBar.SetStartIndex(int)" />
    public void SetStartIndex(int @enabled) => ((MenuBar)_host).SetStartIndex(@enabled);

    /// <inheritdoc cref="MenuBar.GetStartIndex()" />
    public int GetStartIndex() => ((MenuBar)_host).GetStartIndex();

    /// <inheritdoc cref="MenuBar.SetMenuTitle(int, string)" />
    public void SetMenuTitle(int @menu, string @title) => ((MenuBar)_host).SetMenuTitle(@menu, @title);

    /// <inheritdoc cref="MenuBar.GetMenuTitle(int)" />
    public string GetMenuTitle(int @menu) => ((MenuBar)_host).GetMenuTitle(@menu);

    /// <inheritdoc cref="MenuBar.SetMenuTooltip(int, string)" />
    public void SetMenuTooltip(int @menu, string @tooltip) => ((MenuBar)_host).SetMenuTooltip(@menu, @tooltip);

    /// <inheritdoc cref="MenuBar.GetMenuTooltip(int)" />
    public string GetMenuTooltip(int @menu) => ((MenuBar)_host).GetMenuTooltip(@menu);

    /// <inheritdoc cref="MenuBar.SetMenuDisabled(int, bool)" />
    public void SetMenuDisabled(int @menu, bool @disabled) => ((MenuBar)_host).SetMenuDisabled(@menu, @disabled);

    /// <inheritdoc cref="MenuBar.IsMenuDisabled(int)" />
    public bool IsMenuDisabled(int @menu) => ((MenuBar)_host).IsMenuDisabled(@menu);

    /// <inheritdoc cref="MenuBar.SetMenuHidden(int, bool)" />
    public void SetMenuHidden(int @menu, bool @hidden) => ((MenuBar)_host).SetMenuHidden(@menu, @hidden);

    /// <inheritdoc cref="MenuBar.IsMenuHidden(int)" />
    public bool IsMenuHidden(int @menu) => ((MenuBar)_host).IsMenuHidden(@menu);

    /// <inheritdoc cref="MenuBar.GetMenuPopup(int)" />
    public PopupMenu GetMenuPopup(int @menu) => ((MenuBar)_host).GetMenuPopup(@menu);

}
