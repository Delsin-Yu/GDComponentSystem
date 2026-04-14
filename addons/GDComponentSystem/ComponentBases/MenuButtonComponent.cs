#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="MenuButton" />
[Tool, GlobalClass]
public abstract partial class MenuButtonComponent : ButtonComponent
{

    /// <inheritdoc cref="MenuButton.GetPopup()" />
    public PopupMenu GetPopup() => ((MenuButton)_host).GetPopup();

    /// <inheritdoc cref="MenuButton.ShowPopup()" />
    public void ShowPopup() => ((MenuButton)_host).ShowPopup();

    /// <inheritdoc cref="MenuButton.SetSwitchOnHover(bool)" />
    public void SetSwitchOnHover(bool @enable) => ((MenuButton)_host).SetSwitchOnHover(@enable);

    /// <inheritdoc cref="MenuButton.IsSwitchOnHover()" />
    public bool IsSwitchOnHover() => ((MenuButton)_host).IsSwitchOnHover();

    /// <inheritdoc cref="MenuButton.SetDisableShortcuts(bool)" />
    public void SetDisableShortcuts(bool @disabled) => ((MenuButton)_host).SetDisableShortcuts(@disabled);

    /// <inheritdoc cref="MenuButton.SetItemCount(int)" />
    public void SetItemCount(int @count) => ((MenuButton)_host).SetItemCount(@count);

    /// <inheritdoc cref="MenuButton.GetItemCount()" />
    public int GetItemCount() => ((MenuButton)_host).GetItemCount();

}
