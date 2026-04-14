#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ItemList" />
[Tool, GlobalClass]
public abstract partial class ItemListComponent : ControlComponent
{

    /// <inheritdoc cref="ItemList.AddItem(string, Texture2D, bool)" />
    public int AddItem(string @text, Texture2D @icon, bool @selectable) => ((ItemList)_host).AddItem(@text, @icon, @selectable);

    /// <inheritdoc cref="ItemList.AddIconItem(Texture2D, bool)" />
    public int AddIconItem(Texture2D @icon, bool @selectable) => ((ItemList)_host).AddIconItem(@icon, @selectable);

    /// <inheritdoc cref="ItemList.SetItemText(int, string)" />
    public void SetItemText(int @idx, string @text) => ((ItemList)_host).SetItemText(@idx, @text);

    /// <inheritdoc cref="ItemList.GetItemText(int)" />
    public string GetItemText(int @idx) => ((ItemList)_host).GetItemText(@idx);

    /// <inheritdoc cref="ItemList.SetItemIcon(int, Texture2D)" />
    public void SetItemIcon(int @idx, Texture2D @icon) => ((ItemList)_host).SetItemIcon(@idx, @icon);

    /// <inheritdoc cref="ItemList.GetItemIcon(int)" />
    public Texture2D GetItemIcon(int @idx) => ((ItemList)_host).GetItemIcon(@idx);

    /// <inheritdoc cref="ItemList.SetItemTextDirection(int, Control.TextDirection)" />
    public void SetItemTextDirection(int @idx, Control.TextDirection @direction) => ((ItemList)_host).SetItemTextDirection(@idx, @direction);

    /// <inheritdoc cref="ItemList.GetItemTextDirection(int)" />
    public Control.TextDirection GetItemTextDirection(int @idx) => ((ItemList)_host).GetItemTextDirection(@idx);

    /// <inheritdoc cref="ItemList.SetItemLanguage(int, string)" />
    public void SetItemLanguage(int @idx, string @language) => ((ItemList)_host).SetItemLanguage(@idx, @language);

    /// <inheritdoc cref="ItemList.GetItemLanguage(int)" />
    public string GetItemLanguage(int @idx) => ((ItemList)_host).GetItemLanguage(@idx);

    /// <inheritdoc cref="ItemList.SetItemAutoTranslateMode(int, Node.AutoTranslateModeEnum)" />
    public void SetItemAutoTranslateMode(int @idx, Node.AutoTranslateModeEnum @mode) => ((ItemList)_host).SetItemAutoTranslateMode(@idx, @mode);

    /// <inheritdoc cref="ItemList.GetItemAutoTranslateMode(int)" />
    public Node.AutoTranslateModeEnum GetItemAutoTranslateMode(int @idx) => ((ItemList)_host).GetItemAutoTranslateMode(@idx);

    /// <inheritdoc cref="ItemList.SetItemIconTransposed(int, bool)" />
    public void SetItemIconTransposed(int @idx, bool @transposed) => ((ItemList)_host).SetItemIconTransposed(@idx, @transposed);

    /// <inheritdoc cref="ItemList.IsItemIconTransposed(int)" />
    public bool IsItemIconTransposed(int @idx) => ((ItemList)_host).IsItemIconTransposed(@idx);

    /// <inheritdoc cref="ItemList.SetItemIconRegion(int, Rect2)" />
    public void SetItemIconRegion(int @idx, Rect2 @rect) => ((ItemList)_host).SetItemIconRegion(@idx, @rect);

    /// <inheritdoc cref="ItemList.GetItemIconRegion(int)" />
    public Rect2 GetItemIconRegion(int @idx) => ((ItemList)_host).GetItemIconRegion(@idx);

    /// <inheritdoc cref="ItemList.SetItemIconModulate(int, Color)" />
    public void SetItemIconModulate(int @idx, Color @modulate) => ((ItemList)_host).SetItemIconModulate(@idx, @modulate);

    /// <inheritdoc cref="ItemList.GetItemIconModulate(int)" />
    public Color GetItemIconModulate(int @idx) => ((ItemList)_host).GetItemIconModulate(@idx);

    /// <inheritdoc cref="ItemList.SetItemSelectable(int, bool)" />
    public void SetItemSelectable(int @idx, bool @selectable) => ((ItemList)_host).SetItemSelectable(@idx, @selectable);

    /// <inheritdoc cref="ItemList.IsItemSelectable(int)" />
    public bool IsItemSelectable(int @idx) => ((ItemList)_host).IsItemSelectable(@idx);

    /// <inheritdoc cref="ItemList.SetItemDisabled(int, bool)" />
    public void SetItemDisabled(int @idx, bool @disabled) => ((ItemList)_host).SetItemDisabled(@idx, @disabled);

    /// <inheritdoc cref="ItemList.IsItemDisabled(int)" />
    public bool IsItemDisabled(int @idx) => ((ItemList)_host).IsItemDisabled(@idx);

    /// <inheritdoc cref="ItemList.SetItemMetadata(int, Variant)" />
    public void SetItemMetadata(int @idx, Variant @metadata) => ((ItemList)_host).SetItemMetadata(@idx, @metadata);

    /// <inheritdoc cref="ItemList.GetItemMetadata(int)" />
    public Variant GetItemMetadata(int @idx) => ((ItemList)_host).GetItemMetadata(@idx);

    /// <inheritdoc cref="ItemList.SetItemCustomBgColor(int, Color)" />
    public void SetItemCustomBgColor(int @idx, Color @customBgColor) => ((ItemList)_host).SetItemCustomBgColor(@idx, @customBgColor);

    /// <inheritdoc cref="ItemList.GetItemCustomBgColor(int)" />
    public Color GetItemCustomBgColor(int @idx) => ((ItemList)_host).GetItemCustomBgColor(@idx);

    /// <inheritdoc cref="ItemList.SetItemCustomFgColor(int, Color)" />
    public void SetItemCustomFgColor(int @idx, Color @customFgColor) => ((ItemList)_host).SetItemCustomFgColor(@idx, @customFgColor);

    /// <inheritdoc cref="ItemList.GetItemCustomFgColor(int)" />
    public Color GetItemCustomFgColor(int @idx) => ((ItemList)_host).GetItemCustomFgColor(@idx);

    /// <inheritdoc cref="ItemList.GetItemRect(int, bool)" />
    public Rect2 GetItemRect(int @idx, bool @expand) => ((ItemList)_host).GetItemRect(@idx, @expand);

    /// <inheritdoc cref="ItemList.SetItemTooltipEnabled(int, bool)" />
    public void SetItemTooltipEnabled(int @idx, bool @enable) => ((ItemList)_host).SetItemTooltipEnabled(@idx, @enable);

    /// <inheritdoc cref="ItemList.IsItemTooltipEnabled(int)" />
    public bool IsItemTooltipEnabled(int @idx) => ((ItemList)_host).IsItemTooltipEnabled(@idx);

    /// <inheritdoc cref="ItemList.SetItemTooltip(int, string)" />
    public void SetItemTooltip(int @idx, string @tooltip) => ((ItemList)_host).SetItemTooltip(@idx, @tooltip);

    /// <inheritdoc cref="ItemList.GetItemTooltip(int)" />
    public string GetItemTooltip(int @idx) => ((ItemList)_host).GetItemTooltip(@idx);

    /// <inheritdoc cref="ItemList.Select(int, bool)" />
    public void Select(int @idx, bool @single) => ((ItemList)_host).Select(@idx, @single);

    /// <inheritdoc cref="ItemList.Deselect(int)" />
    public void Deselect(int @idx) => ((ItemList)_host).Deselect(@idx);

    /// <inheritdoc cref="ItemList.DeselectAll()" />
    public void DeselectAll() => ((ItemList)_host).DeselectAll();

    /// <inheritdoc cref="ItemList.IsSelected(int)" />
    public bool IsSelected(int @idx) => ((ItemList)_host).IsSelected(@idx);

    /// <inheritdoc cref="ItemList.GetSelectedItems()" />
    public int[] GetSelectedItems() => ((ItemList)_host).GetSelectedItems();

    /// <inheritdoc cref="ItemList.MoveItem(int, int)" />
    public void MoveItem(int @fromIdx, int @toIdx) => ((ItemList)_host).MoveItem(@fromIdx, @toIdx);

    /// <inheritdoc cref="ItemList.SetItemCount(int)" />
    public void SetItemCount(int @count) => ((ItemList)_host).SetItemCount(@count);

    /// <inheritdoc cref="ItemList.GetItemCount()" />
    public int GetItemCount() => ((ItemList)_host).GetItemCount();

    /// <inheritdoc cref="ItemList.RemoveItem(int)" />
    public void RemoveItem(int @idx) => ((ItemList)_host).RemoveItem(@idx);

    /// <inheritdoc cref="ItemList.Clear()" />
    public void Clear() => ((ItemList)_host).Clear();

    /// <inheritdoc cref="ItemList.SortItemsByText()" />
    public void SortItemsByText() => ((ItemList)_host).SortItemsByText();

    /// <inheritdoc cref="ItemList.SetFixedColumnWidth(int)" />
    public void SetFixedColumnWidth(int @width) => ((ItemList)_host).SetFixedColumnWidth(@width);

    /// <inheritdoc cref="ItemList.GetFixedColumnWidth()" />
    public int GetFixedColumnWidth() => ((ItemList)_host).GetFixedColumnWidth();

    /// <inheritdoc cref="ItemList.SetSameColumnWidth(bool)" />
    public void SetSameColumnWidth(bool @enable) => ((ItemList)_host).SetSameColumnWidth(@enable);

    /// <inheritdoc cref="ItemList.IsSameColumnWidth()" />
    public bool IsSameColumnWidth() => ((ItemList)_host).IsSameColumnWidth();

    /// <inheritdoc cref="ItemList.SetMaxTextLines(int)" />
    public void SetMaxTextLines(int @lines) => ((ItemList)_host).SetMaxTextLines(@lines);

    /// <inheritdoc cref="ItemList.GetMaxTextLines()" />
    public int GetMaxTextLines() => ((ItemList)_host).GetMaxTextLines();

    /// <inheritdoc cref="ItemList.SetMaxColumns(int)" />
    public void SetMaxColumns(int @amount) => ((ItemList)_host).SetMaxColumns(@amount);

    /// <inheritdoc cref="ItemList.GetMaxColumns()" />
    public int GetMaxColumns() => ((ItemList)_host).GetMaxColumns();

    /// <inheritdoc cref="ItemList.SetSelectMode(ItemList.SelectModeEnum)" />
    public void SetSelectMode(ItemList.SelectModeEnum @mode) => ((ItemList)_host).SetSelectMode(@mode);

    /// <inheritdoc cref="ItemList.GetSelectMode()" />
    public ItemList.SelectModeEnum GetSelectMode() => ((ItemList)_host).GetSelectMode();

    /// <inheritdoc cref="ItemList.SetIconMode(ItemList.IconModeEnum)" />
    public void SetIconMode(ItemList.IconModeEnum @mode) => ((ItemList)_host).SetIconMode(@mode);

    /// <inheritdoc cref="ItemList.GetIconMode()" />
    public ItemList.IconModeEnum GetIconMode() => ((ItemList)_host).GetIconMode();

    /// <inheritdoc cref="ItemList.SetFixedIconSize(Vector2I)" />
    public void SetFixedIconSize(Vector2I @size) => ((ItemList)_host).SetFixedIconSize(@size);

    /// <inheritdoc cref="ItemList.GetFixedIconSize()" />
    public Vector2I GetFixedIconSize() => ((ItemList)_host).GetFixedIconSize();

    /// <inheritdoc cref="ItemList.SetIconScale(float)" />
    public void SetIconScale(float @scale) => ((ItemList)_host).SetIconScale(@scale);

    /// <inheritdoc cref="ItemList.GetIconScale()" />
    public float GetIconScale() => ((ItemList)_host).GetIconScale();

    /// <inheritdoc cref="ItemList.SetAllowRmbSelect(bool)" />
    public void SetAllowRmbSelect(bool @allow) => ((ItemList)_host).SetAllowRmbSelect(@allow);

    /// <inheritdoc cref="ItemList.GetAllowRmbSelect()" />
    public bool GetAllowRmbSelect() => ((ItemList)_host).GetAllowRmbSelect();

    /// <inheritdoc cref="ItemList.SetAllowReselect(bool)" />
    public void SetAllowReselect(bool @allow) => ((ItemList)_host).SetAllowReselect(@allow);

    /// <inheritdoc cref="ItemList.GetAllowReselect()" />
    public bool GetAllowReselect() => ((ItemList)_host).GetAllowReselect();

    /// <inheritdoc cref="ItemList.SetAllowSearch(bool)" />
    public void SetAllowSearch(bool @allow) => ((ItemList)_host).SetAllowSearch(@allow);

    /// <inheritdoc cref="ItemList.GetAllowSearch()" />
    public bool GetAllowSearch() => ((ItemList)_host).GetAllowSearch();

    /// <inheritdoc cref="ItemList.SetAutoWidth(bool)" />
    public void SetAutoWidth(bool @enable) => ((ItemList)_host).SetAutoWidth(@enable);

    /// <inheritdoc cref="ItemList.HasAutoWidth()" />
    public bool HasAutoWidth() => ((ItemList)_host).HasAutoWidth();

    /// <inheritdoc cref="ItemList.SetAutoHeight(bool)" />
    public void SetAutoHeight(bool @enable) => ((ItemList)_host).SetAutoHeight(@enable);

    /// <inheritdoc cref="ItemList.HasAutoHeight()" />
    public bool HasAutoHeight() => ((ItemList)_host).HasAutoHeight();

    /// <inheritdoc cref="ItemList.IsAnythingSelected()" />
    public bool IsAnythingSelected() => ((ItemList)_host).IsAnythingSelected();

    /// <inheritdoc cref="ItemList.GetItemAtPosition(Vector2, bool)" />
    public int GetItemAtPosition(Vector2 @position, bool @exact) => ((ItemList)_host).GetItemAtPosition(@position, @exact);

    /// <inheritdoc cref="ItemList.EnsureCurrentIsVisible()" />
    public void EnsureCurrentIsVisible() => ((ItemList)_host).EnsureCurrentIsVisible();

    /// <inheritdoc cref="ItemList.GetVScrollBar()" />
    public VScrollBar GetVScrollBar() => ((ItemList)_host).GetVScrollBar();

    /// <inheritdoc cref="ItemList.GetHScrollBar()" />
    public HScrollBar GetHScrollBar() => ((ItemList)_host).GetHScrollBar();

    /// <inheritdoc cref="ItemList.SetScrollHintMode(ItemList.ScrollHintModeEnum)" />
    public void SetScrollHintMode(ItemList.ScrollHintModeEnum @scrollHintMode) => ((ItemList)_host).SetScrollHintMode(@scrollHintMode);

    /// <inheritdoc cref="ItemList.GetScrollHintMode()" />
    public ItemList.ScrollHintModeEnum GetScrollHintMode() => ((ItemList)_host).GetScrollHintMode();

    /// <inheritdoc cref="ItemList.SetTileScrollHint(bool)" />
    public void SetTileScrollHint(bool @tileScrollHint) => ((ItemList)_host).SetTileScrollHint(@tileScrollHint);

    /// <inheritdoc cref="ItemList.IsScrollHintTiled()" />
    public bool IsScrollHintTiled() => ((ItemList)_host).IsScrollHintTiled();

    /// <inheritdoc cref="ItemList.SetTextOverrunBehavior(TextServer.OverrunBehavior)" />
    public void SetTextOverrunBehavior(TextServer.OverrunBehavior @overrunBehavior) => ((ItemList)_host).SetTextOverrunBehavior(@overrunBehavior);

    /// <inheritdoc cref="ItemList.GetTextOverrunBehavior()" />
    public TextServer.OverrunBehavior GetTextOverrunBehavior() => ((ItemList)_host).GetTextOverrunBehavior();

    /// <inheritdoc cref="ItemList.SetWraparoundItems(bool)" />
    public void SetWraparoundItems(bool @enable) => ((ItemList)_host).SetWraparoundItems(@enable);

    /// <inheritdoc cref="ItemList.HasWraparoundItems()" />
    public bool HasWraparoundItems() => ((ItemList)_host).HasWraparoundItems();

    /// <inheritdoc cref="ItemList.ForceUpdateListSize()" />
    public void ForceUpdateListSize() => ((ItemList)_host).ForceUpdateListSize();

}
