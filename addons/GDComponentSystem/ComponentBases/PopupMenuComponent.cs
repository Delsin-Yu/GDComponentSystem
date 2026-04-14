#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="PopupMenu" />
[Tool, GlobalClass]
public abstract partial class PopupMenuComponent : PopupComponent
{

    /// <inheritdoc cref="PopupMenu.ActivateItemByEvent(InputEvent, bool)" />
    public bool ActivateItemByEvent(InputEvent @event, bool @forGlobalOnly) => ((PopupMenu)_host).ActivateItemByEvent(@event, @forGlobalOnly);

    /// <inheritdoc cref="PopupMenu.SetPreferNativeMenu(bool)" />
    public void SetPreferNativeMenu(bool @enabled) => ((PopupMenu)_host).SetPreferNativeMenu(@enabled);

    /// <inheritdoc cref="PopupMenu.IsPreferNativeMenu()" />
    public bool IsPreferNativeMenu() => ((PopupMenu)_host).IsPreferNativeMenu();

    /// <inheritdoc cref="PopupMenu.IsNativeMenu()" />
    public bool IsNativeMenu() => ((PopupMenu)_host).IsNativeMenu();

    /// <inheritdoc cref="PopupMenu.AddItem(string, int, Key)" />
    public void AddItem(string @label, int @id, Key @accel) => ((PopupMenu)_host).AddItem(@label, @id, @accel);

    /// <inheritdoc cref="PopupMenu.AddIconItem(Texture2D, string, int, Key)" />
    public void AddIconItem(Texture2D @texture, string @label, int @id, Key @accel) => ((PopupMenu)_host).AddIconItem(@texture, @label, @id, @accel);

    /// <inheritdoc cref="PopupMenu.AddCheckItem(string, int, Key)" />
    public void AddCheckItem(string @label, int @id, Key @accel) => ((PopupMenu)_host).AddCheckItem(@label, @id, @accel);

    /// <inheritdoc cref="PopupMenu.AddIconCheckItem(Texture2D, string, int, Key)" />
    public void AddIconCheckItem(Texture2D @texture, string @label, int @id, Key @accel) => ((PopupMenu)_host).AddIconCheckItem(@texture, @label, @id, @accel);

    /// <inheritdoc cref="PopupMenu.AddRadioCheckItem(string, int, Key)" />
    public void AddRadioCheckItem(string @label, int @id, Key @accel) => ((PopupMenu)_host).AddRadioCheckItem(@label, @id, @accel);

    /// <inheritdoc cref="PopupMenu.AddIconRadioCheckItem(Texture2D, string, int, Key)" />
    public void AddIconRadioCheckItem(Texture2D @texture, string @label, int @id, Key @accel) => ((PopupMenu)_host).AddIconRadioCheckItem(@texture, @label, @id, @accel);

    /// <inheritdoc cref="PopupMenu.AddMultistateItem(string, int, int, int, Key)" />
    public void AddMultistateItem(string @label, int @maxStates, int @defaultState, int @id, Key @accel) => ((PopupMenu)_host).AddMultistateItem(@label, @maxStates, @defaultState, @id, @accel);

    /// <inheritdoc cref="PopupMenu.AddShortcut(Shortcut, int, bool, bool)" />
    public void AddShortcut(Shortcut @shortcut, int @id, bool @global, bool @allowEcho) => ((PopupMenu)_host).AddShortcut(@shortcut, @id, @global, @allowEcho);

    /// <inheritdoc cref="PopupMenu.AddIconShortcut(Texture2D, Shortcut, int, bool, bool)" />
    public void AddIconShortcut(Texture2D @texture, Shortcut @shortcut, int @id, bool @global, bool @allowEcho) => ((PopupMenu)_host).AddIconShortcut(@texture, @shortcut, @id, @global, @allowEcho);

    /// <inheritdoc cref="PopupMenu.AddCheckShortcut(Shortcut, int, bool)" />
    public void AddCheckShortcut(Shortcut @shortcut, int @id, bool @global) => ((PopupMenu)_host).AddCheckShortcut(@shortcut, @id, @global);

    /// <inheritdoc cref="PopupMenu.AddIconCheckShortcut(Texture2D, Shortcut, int, bool)" />
    public void AddIconCheckShortcut(Texture2D @texture, Shortcut @shortcut, int @id, bool @global) => ((PopupMenu)_host).AddIconCheckShortcut(@texture, @shortcut, @id, @global);

    /// <inheritdoc cref="PopupMenu.AddRadioCheckShortcut(Shortcut, int, bool)" />
    public void AddRadioCheckShortcut(Shortcut @shortcut, int @id, bool @global) => ((PopupMenu)_host).AddRadioCheckShortcut(@shortcut, @id, @global);

    /// <inheritdoc cref="PopupMenu.AddIconRadioCheckShortcut(Texture2D, Shortcut, int, bool)" />
    public void AddIconRadioCheckShortcut(Texture2D @texture, Shortcut @shortcut, int @id, bool @global) => ((PopupMenu)_host).AddIconRadioCheckShortcut(@texture, @shortcut, @id, @global);

    /// <inheritdoc cref="PopupMenu.AddSubmenuItem(string, string, int)" />
    public void AddSubmenuItem(string @label, string @submenu, int @id) => ((PopupMenu)_host).AddSubmenuItem(@label, @submenu, @id);

    /// <inheritdoc cref="PopupMenu.AddSubmenuNodeItem(string, PopupMenu, int)" />
    public void AddSubmenuNodeItem(string @label, PopupMenu @submenu, int @id) => ((PopupMenu)_host).AddSubmenuNodeItem(@label, @submenu, @id);

    /// <inheritdoc cref="PopupMenu.SetItemText(int, string)" />
    public void SetItemText(int @index, string @text) => ((PopupMenu)_host).SetItemText(@index, @text);

    /// <inheritdoc cref="PopupMenu.SetItemTextDirection(int, Control.TextDirection)" />
    public void SetItemTextDirection(int @index, Control.TextDirection @direction) => ((PopupMenu)_host).SetItemTextDirection(@index, @direction);

    /// <inheritdoc cref="PopupMenu.SetItemLanguage(int, string)" />
    public void SetItemLanguage(int @index, string @language) => ((PopupMenu)_host).SetItemLanguage(@index, @language);

    /// <inheritdoc cref="PopupMenu.SetItemAutoTranslateMode(int, Node.AutoTranslateModeEnum)" />
    public void SetItemAutoTranslateMode(int @index, Node.AutoTranslateModeEnum @mode) => ((PopupMenu)_host).SetItemAutoTranslateMode(@index, @mode);

    /// <inheritdoc cref="PopupMenu.SetItemIcon(int, Texture2D)" />
    public void SetItemIcon(int @index, Texture2D @icon) => ((PopupMenu)_host).SetItemIcon(@index, @icon);

    /// <inheritdoc cref="PopupMenu.SetItemIconMaxWidth(int, int)" />
    public void SetItemIconMaxWidth(int @index, int @width) => ((PopupMenu)_host).SetItemIconMaxWidth(@index, @width);

    /// <inheritdoc cref="PopupMenu.SetItemIconModulate(int, Color)" />
    public void SetItemIconModulate(int @index, Color @modulate) => ((PopupMenu)_host).SetItemIconModulate(@index, @modulate);

    /// <inheritdoc cref="PopupMenu.SetItemChecked(int, bool)" />
    public void SetItemChecked(int @index, bool @checked) => ((PopupMenu)_host).SetItemChecked(@index, @checked);

    /// <inheritdoc cref="PopupMenu.SetItemId(int, int)" />
    public void SetItemId(int @index, int @id) => ((PopupMenu)_host).SetItemId(@index, @id);

    /// <inheritdoc cref="PopupMenu.SetItemAccelerator(int, Key)" />
    public void SetItemAccelerator(int @index, Key @accel) => ((PopupMenu)_host).SetItemAccelerator(@index, @accel);

    /// <inheritdoc cref="PopupMenu.SetItemMetadata(int, Variant)" />
    public void SetItemMetadata(int @index, Variant @metadata) => ((PopupMenu)_host).SetItemMetadata(@index, @metadata);

    /// <inheritdoc cref="PopupMenu.SetItemDisabled(int, bool)" />
    public void SetItemDisabled(int @index, bool @disabled) => ((PopupMenu)_host).SetItemDisabled(@index, @disabled);

    /// <inheritdoc cref="PopupMenu.SetItemSubmenu(int, string)" />
    public void SetItemSubmenu(int @index, string @submenu) => ((PopupMenu)_host).SetItemSubmenu(@index, @submenu);

    /// <inheritdoc cref="PopupMenu.SetItemSubmenuNode(int, PopupMenu)" />
    public void SetItemSubmenuNode(int @index, PopupMenu @submenu) => ((PopupMenu)_host).SetItemSubmenuNode(@index, @submenu);

    /// <inheritdoc cref="PopupMenu.SetItemAsSeparator(int, bool)" />
    public void SetItemAsSeparator(int @index, bool @enable) => ((PopupMenu)_host).SetItemAsSeparator(@index, @enable);

    /// <inheritdoc cref="PopupMenu.SetItemAsCheckable(int, bool)" />
    public void SetItemAsCheckable(int @index, bool @enable) => ((PopupMenu)_host).SetItemAsCheckable(@index, @enable);

    /// <inheritdoc cref="PopupMenu.SetItemAsRadioCheckable(int, bool)" />
    public void SetItemAsRadioCheckable(int @index, bool @enable) => ((PopupMenu)_host).SetItemAsRadioCheckable(@index, @enable);

    /// <inheritdoc cref="PopupMenu.SetItemTooltip(int, string)" />
    public void SetItemTooltip(int @index, string @tooltip) => ((PopupMenu)_host).SetItemTooltip(@index, @tooltip);

    /// <inheritdoc cref="PopupMenu.SetItemShortcut(int, Shortcut, bool)" />
    public void SetItemShortcut(int @index, Shortcut @shortcut, bool @global) => ((PopupMenu)_host).SetItemShortcut(@index, @shortcut, @global);

    /// <inheritdoc cref="PopupMenu.SetItemIndent(int, int)" />
    public void SetItemIndent(int @index, int @indent) => ((PopupMenu)_host).SetItemIndent(@index, @indent);

    /// <inheritdoc cref="PopupMenu.SetItemMultistate(int, int)" />
    public void SetItemMultistate(int @index, int @state) => ((PopupMenu)_host).SetItemMultistate(@index, @state);

    /// <inheritdoc cref="PopupMenu.SetItemMultistateMax(int, int)" />
    public void SetItemMultistateMax(int @index, int @maxStates) => ((PopupMenu)_host).SetItemMultistateMax(@index, @maxStates);

    /// <inheritdoc cref="PopupMenu.SetItemShortcutDisabled(int, bool)" />
    public void SetItemShortcutDisabled(int @index, bool @disabled) => ((PopupMenu)_host).SetItemShortcutDisabled(@index, @disabled);

    /// <inheritdoc cref="PopupMenu.ToggleItemChecked(int)" />
    public void ToggleItemChecked(int @index) => ((PopupMenu)_host).ToggleItemChecked(@index);

    /// <inheritdoc cref="PopupMenu.ToggleItemMultistate(int)" />
    public void ToggleItemMultistate(int @index) => ((PopupMenu)_host).ToggleItemMultistate(@index);

    /// <inheritdoc cref="PopupMenu.GetItemText(int)" />
    public string GetItemText(int @index) => ((PopupMenu)_host).GetItemText(@index);

    /// <inheritdoc cref="PopupMenu.GetItemTextDirection(int)" />
    public Control.TextDirection GetItemTextDirection(int @index) => ((PopupMenu)_host).GetItemTextDirection(@index);

    /// <inheritdoc cref="PopupMenu.GetItemLanguage(int)" />
    public string GetItemLanguage(int @index) => ((PopupMenu)_host).GetItemLanguage(@index);

    /// <inheritdoc cref="PopupMenu.GetItemAutoTranslateMode(int)" />
    public Node.AutoTranslateModeEnum GetItemAutoTranslateMode(int @index) => ((PopupMenu)_host).GetItemAutoTranslateMode(@index);

    /// <inheritdoc cref="PopupMenu.GetItemIcon(int)" />
    public Texture2D GetItemIcon(int @index) => ((PopupMenu)_host).GetItemIcon(@index);

    /// <inheritdoc cref="PopupMenu.GetItemIconMaxWidth(int)" />
    public int GetItemIconMaxWidth(int @index) => ((PopupMenu)_host).GetItemIconMaxWidth(@index);

    /// <inheritdoc cref="PopupMenu.GetItemIconModulate(int)" />
    public Color GetItemIconModulate(int @index) => ((PopupMenu)_host).GetItemIconModulate(@index);

    /// <inheritdoc cref="PopupMenu.IsItemChecked(int)" />
    public bool IsItemChecked(int @index) => ((PopupMenu)_host).IsItemChecked(@index);

    /// <inheritdoc cref="PopupMenu.GetItemId(int)" />
    public int GetItemId(int @index) => ((PopupMenu)_host).GetItemId(@index);

    /// <inheritdoc cref="PopupMenu.GetItemIndex(int)" />
    public int GetItemIndex(int @id) => ((PopupMenu)_host).GetItemIndex(@id);

    /// <inheritdoc cref="PopupMenu.GetItemAccelerator(int)" />
    public Key GetItemAccelerator(int @index) => ((PopupMenu)_host).GetItemAccelerator(@index);

    /// <inheritdoc cref="PopupMenu.GetItemMetadata(int)" />
    public Variant GetItemMetadata(int @index) => ((PopupMenu)_host).GetItemMetadata(@index);

    /// <inheritdoc cref="PopupMenu.IsItemDisabled(int)" />
    public bool IsItemDisabled(int @index) => ((PopupMenu)_host).IsItemDisabled(@index);

    /// <inheritdoc cref="PopupMenu.GetItemSubmenu(int)" />
    public string GetItemSubmenu(int @index) => ((PopupMenu)_host).GetItemSubmenu(@index);

    /// <inheritdoc cref="PopupMenu.GetItemSubmenuNode(int)" />
    public PopupMenu GetItemSubmenuNode(int @index) => ((PopupMenu)_host).GetItemSubmenuNode(@index);

    /// <inheritdoc cref="PopupMenu.IsItemSeparator(int)" />
    public bool IsItemSeparator(int @index) => ((PopupMenu)_host).IsItemSeparator(@index);

    /// <inheritdoc cref="PopupMenu.IsItemCheckable(int)" />
    public bool IsItemCheckable(int @index) => ((PopupMenu)_host).IsItemCheckable(@index);

    /// <inheritdoc cref="PopupMenu.IsItemRadioCheckable(int)" />
    public bool IsItemRadioCheckable(int @index) => ((PopupMenu)_host).IsItemRadioCheckable(@index);

    /// <inheritdoc cref="PopupMenu.IsItemShortcutDisabled(int)" />
    public bool IsItemShortcutDisabled(int @index) => ((PopupMenu)_host).IsItemShortcutDisabled(@index);

    /// <inheritdoc cref="PopupMenu.GetItemTooltip(int)" />
    public string GetItemTooltip(int @index) => ((PopupMenu)_host).GetItemTooltip(@index);

    /// <inheritdoc cref="PopupMenu.GetItemShortcut(int)" />
    public Shortcut GetItemShortcut(int @index) => ((PopupMenu)_host).GetItemShortcut(@index);

    /// <inheritdoc cref="PopupMenu.GetItemIndent(int)" />
    public int GetItemIndent(int @index) => ((PopupMenu)_host).GetItemIndent(@index);

    /// <inheritdoc cref="PopupMenu.GetItemMultistateMax(int)" />
    public int GetItemMultistateMax(int @index) => ((PopupMenu)_host).GetItemMultistateMax(@index);

    /// <inheritdoc cref="PopupMenu.GetItemMultistate(int)" />
    public int GetItemMultistate(int @index) => ((PopupMenu)_host).GetItemMultistate(@index);

    /// <inheritdoc cref="PopupMenu.SetFocusedItem(int)" />
    public void SetFocusedItem(int @index) => ((PopupMenu)_host).SetFocusedItem(@index);

    /// <inheritdoc cref="PopupMenu.GetFocusedItem()" />
    public int GetFocusedItem() => ((PopupMenu)_host).GetFocusedItem();

    /// <inheritdoc cref="PopupMenu.SetItemCount(int)" />
    public void SetItemCount(int @count) => ((PopupMenu)_host).SetItemCount(@count);

    /// <inheritdoc cref="PopupMenu.GetItemCount()" />
    public int GetItemCount() => ((PopupMenu)_host).GetItemCount();

    /// <inheritdoc cref="PopupMenu.ScrollToItem(int)" />
    public void ScrollToItem(int @index) => ((PopupMenu)_host).ScrollToItem(@index);

    /// <inheritdoc cref="PopupMenu.RemoveItem(int)" />
    public void RemoveItem(int @index) => ((PopupMenu)_host).RemoveItem(@index);

    /// <inheritdoc cref="PopupMenu.AddSeparator(string, int)" />
    public void AddSeparator(string @label, int @id) => ((PopupMenu)_host).AddSeparator(@label, @id);

    /// <inheritdoc cref="PopupMenu.Clear(bool)" />
    public void Clear(bool @freeSubmenus) => ((PopupMenu)_host).Clear(@freeSubmenus);

    /// <inheritdoc cref="PopupMenu.SetHideOnItemSelection(bool)" />
    public void SetHideOnItemSelection(bool @enable) => ((PopupMenu)_host).SetHideOnItemSelection(@enable);

    /// <inheritdoc cref="PopupMenu.IsHideOnItemSelection()" />
    public bool IsHideOnItemSelection() => ((PopupMenu)_host).IsHideOnItemSelection();

    /// <inheritdoc cref="PopupMenu.SetHideOnCheckableItemSelection(bool)" />
    public void SetHideOnCheckableItemSelection(bool @enable) => ((PopupMenu)_host).SetHideOnCheckableItemSelection(@enable);

    /// <inheritdoc cref="PopupMenu.IsHideOnCheckableItemSelection()" />
    public bool IsHideOnCheckableItemSelection() => ((PopupMenu)_host).IsHideOnCheckableItemSelection();

    /// <inheritdoc cref="PopupMenu.SetHideOnStateItemSelection(bool)" />
    public void SetHideOnStateItemSelection(bool @enable) => ((PopupMenu)_host).SetHideOnStateItemSelection(@enable);

    /// <inheritdoc cref="PopupMenu.IsHideOnStateItemSelection()" />
    public bool IsHideOnStateItemSelection() => ((PopupMenu)_host).IsHideOnStateItemSelection();

    /// <inheritdoc cref="PopupMenu.SetSubmenuPopupDelay(float)" />
    public void SetSubmenuPopupDelay(float @seconds) => ((PopupMenu)_host).SetSubmenuPopupDelay(@seconds);

    /// <inheritdoc cref="PopupMenu.GetSubmenuPopupDelay()" />
    public float GetSubmenuPopupDelay() => ((PopupMenu)_host).GetSubmenuPopupDelay();

    /// <inheritdoc cref="PopupMenu.SetAllowSearch(bool)" />
    public void SetAllowSearch(bool @allow) => ((PopupMenu)_host).SetAllowSearch(@allow);

    /// <inheritdoc cref="PopupMenu.GetAllowSearch()" />
    public bool GetAllowSearch() => ((PopupMenu)_host).GetAllowSearch();

    /// <inheritdoc cref="PopupMenu.IsSystemMenu()" />
    public bool IsSystemMenu() => ((PopupMenu)_host).IsSystemMenu();

    /// <inheritdoc cref="PopupMenu.SetSystemMenu(NativeMenu.SystemMenus)" />
    public void SetSystemMenu(NativeMenu.SystemMenus @systemMenuId) => ((PopupMenu)_host).SetSystemMenu(@systemMenuId);

    /// <inheritdoc cref="PopupMenu.GetSystemMenu()" />
    public NativeMenu.SystemMenus GetSystemMenu() => ((PopupMenu)_host).GetSystemMenu();

    /// <inheritdoc cref="PopupMenu.SetShrinkHeight(bool)" />
    public void SetShrinkHeight(bool @shrink) => ((PopupMenu)_host).SetShrinkHeight(@shrink);

    /// <inheritdoc cref="PopupMenu.GetShrinkHeight()" />
    public bool GetShrinkHeight() => ((PopupMenu)_host).GetShrinkHeight();

    /// <inheritdoc cref="PopupMenu.SetShrinkWidth(bool)" />
    public void SetShrinkWidth(bool @shrink) => ((PopupMenu)_host).SetShrinkWidth(@shrink);

    /// <inheritdoc cref="PopupMenu.GetShrinkWidth()" />
    public bool GetShrinkWidth() => ((PopupMenu)_host).GetShrinkWidth();

    /// <inheritdoc cref="PopupMenu.GetSystemMenuRoot()" />
    public string GetSystemMenuRoot() => ((PopupMenu)_host).GetSystemMenuRoot();

    /// <inheritdoc cref="PopupMenu.SetSystemMenuRoot(string)" />
    public void SetSystemMenuRoot(string @special) => ((PopupMenu)_host).SetSystemMenuRoot(@special);

    /// <inheritdoc cref="PopupMenu.Clear()" />
    public void Clear() => ((PopupMenu)_host).Clear();

    /// <inheritdoc cref="PopupMenu.AddIconShortcut(Texture2D, Shortcut, int, bool)" />
    public void AddIconShortcut(Texture2D @texture, Shortcut @shortcut, int @id, bool @global) => ((PopupMenu)_host).AddIconShortcut(@texture, @shortcut, @id, @global);

    /// <inheritdoc cref="PopupMenu.AddShortcut(Shortcut, int, bool)" />
    public void AddShortcut(Shortcut @shortcut, int @id, bool @global) => ((PopupMenu)_host).AddShortcut(@shortcut, @id, @global);

}
