#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="OptionButton" />
[Tool, GlobalClass]
public abstract partial class OptionButtonComponent : ButtonComponent
{

    /// <inheritdoc cref="OptionButton.AddItem(string, int)" />
    public void AddItem(string @label, int @id) => ((OptionButton)_host).AddItem(@label, @id);

    /// <inheritdoc cref="OptionButton.AddIconItem(Texture2D, string, int)" />
    public void AddIconItem(Texture2D @texture, string @label, int @id) => ((OptionButton)_host).AddIconItem(@texture, @label, @id);

    /// <inheritdoc cref="OptionButton.SetItemText(int, string)" />
    public void SetItemText(int @idx, string @text) => ((OptionButton)_host).SetItemText(@idx, @text);

    /// <inheritdoc cref="OptionButton.SetItemIcon(int, Texture2D)" />
    public void SetItemIcon(int @idx, Texture2D @texture) => ((OptionButton)_host).SetItemIcon(@idx, @texture);

    /// <inheritdoc cref="OptionButton.SetItemDisabled(int, bool)" />
    public void SetItemDisabled(int @idx, bool @disabled) => ((OptionButton)_host).SetItemDisabled(@idx, @disabled);

    /// <inheritdoc cref="OptionButton.SetItemId(int, int)" />
    public void SetItemId(int @idx, int @id) => ((OptionButton)_host).SetItemId(@idx, @id);

    /// <inheritdoc cref="OptionButton.SetItemMetadata(int, Variant)" />
    public void SetItemMetadata(int @idx, Variant @metadata) => ((OptionButton)_host).SetItemMetadata(@idx, @metadata);

    /// <inheritdoc cref="OptionButton.SetItemTooltip(int, string)" />
    public void SetItemTooltip(int @idx, string @tooltip) => ((OptionButton)_host).SetItemTooltip(@idx, @tooltip);

    /// <inheritdoc cref="OptionButton.SetItemAutoTranslateMode(int, Node.AutoTranslateModeEnum)" />
    public void SetItemAutoTranslateMode(int @idx, Node.AutoTranslateModeEnum @mode) => ((OptionButton)_host).SetItemAutoTranslateMode(@idx, @mode);

    /// <inheritdoc cref="OptionButton.GetItemText(int)" />
    public string GetItemText(int @idx) => ((OptionButton)_host).GetItemText(@idx);

    /// <inheritdoc cref="OptionButton.GetItemIcon(int)" />
    public Texture2D GetItemIcon(int @idx) => ((OptionButton)_host).GetItemIcon(@idx);

    /// <inheritdoc cref="OptionButton.GetItemId(int)" />
    public int GetItemId(int @idx) => ((OptionButton)_host).GetItemId(@idx);

    /// <inheritdoc cref="OptionButton.GetItemIndex(int)" />
    public int GetItemIndex(int @id) => ((OptionButton)_host).GetItemIndex(@id);

    /// <inheritdoc cref="OptionButton.GetItemMetadata(int)" />
    public Variant GetItemMetadata(int @idx) => ((OptionButton)_host).GetItemMetadata(@idx);

    /// <inheritdoc cref="OptionButton.GetItemTooltip(int)" />
    public string GetItemTooltip(int @idx) => ((OptionButton)_host).GetItemTooltip(@idx);

    /// <inheritdoc cref="OptionButton.GetItemAutoTranslateMode(int)" />
    public Node.AutoTranslateModeEnum GetItemAutoTranslateMode(int @idx) => ((OptionButton)_host).GetItemAutoTranslateMode(@idx);

    /// <inheritdoc cref="OptionButton.IsItemDisabled(int)" />
    public bool IsItemDisabled(int @idx) => ((OptionButton)_host).IsItemDisabled(@idx);

    /// <inheritdoc cref="OptionButton.IsItemSeparator(int)" />
    public bool IsItemSeparator(int @idx) => ((OptionButton)_host).IsItemSeparator(@idx);

    /// <inheritdoc cref="OptionButton.AddSeparator(string)" />
    public void AddSeparator(string @text) => ((OptionButton)_host).AddSeparator(@text);

    /// <inheritdoc cref="OptionButton.Clear()" />
    public void Clear() => ((OptionButton)_host).Clear();

    /// <inheritdoc cref="OptionButton.Select(int)" />
    public void Select(int @idx) => ((OptionButton)_host).Select(@idx);

    /// <inheritdoc cref="OptionButton.GetSelected()" />
    public int GetSelected() => ((OptionButton)_host).GetSelected();

    /// <inheritdoc cref="OptionButton.GetSelectedId()" />
    public int GetSelectedId() => ((OptionButton)_host).GetSelectedId();

    /// <inheritdoc cref="OptionButton.GetSelectedMetadata()" />
    public Variant GetSelectedMetadata() => ((OptionButton)_host).GetSelectedMetadata();

    /// <inheritdoc cref="OptionButton.RemoveItem(int)" />
    public void RemoveItem(int @idx) => ((OptionButton)_host).RemoveItem(@idx);

    /// <inheritdoc cref="OptionButton.GetPopup()" />
    public PopupMenu GetPopup() => ((OptionButton)_host).GetPopup();

    /// <inheritdoc cref="OptionButton.ShowPopup()" />
    public void ShowPopup() => ((OptionButton)_host).ShowPopup();

    /// <inheritdoc cref="OptionButton.SetItemCount(int)" />
    public void SetItemCount(int @count) => ((OptionButton)_host).SetItemCount(@count);

    /// <inheritdoc cref="OptionButton.GetItemCount()" />
    public int GetItemCount() => ((OptionButton)_host).GetItemCount();

    /// <inheritdoc cref="OptionButton.HasSelectableItems()" />
    public bool HasSelectableItems() => ((OptionButton)_host).HasSelectableItems();

    /// <inheritdoc cref="OptionButton.GetSelectableItem(bool)" />
    public int GetSelectableItem(bool @fromLast) => ((OptionButton)_host).GetSelectableItem(@fromLast);

    /// <inheritdoc cref="OptionButton.SetFitToLongestItem(bool)" />
    public void SetFitToLongestItem(bool @fit) => ((OptionButton)_host).SetFitToLongestItem(@fit);

    /// <inheritdoc cref="OptionButton.IsFitToLongestItem()" />
    public bool IsFitToLongestItem() => ((OptionButton)_host).IsFitToLongestItem();

    /// <inheritdoc cref="OptionButton.SetAllowReselect(bool)" />
    public void SetAllowReselect(bool @allow) => ((OptionButton)_host).SetAllowReselect(@allow);

    /// <inheritdoc cref="OptionButton.GetAllowReselect()" />
    public bool GetAllowReselect() => ((OptionButton)_host).GetAllowReselect();

    /// <inheritdoc cref="OptionButton.SetDisableShortcuts(bool)" />
    public void SetDisableShortcuts(bool @disabled) => ((OptionButton)_host).SetDisableShortcuts(@disabled);

}
