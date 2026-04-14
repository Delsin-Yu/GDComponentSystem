#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Tree" />
[Tool, GlobalClass]
public abstract partial class TreeComponent : ControlComponent
{

    /// <inheritdoc cref="Tree.EditSelected()" />
    public bool EditSelected() => ((Tree)_host).EditSelected();

    /// <inheritdoc cref="Tree.Clear()" />
    public void Clear() => ((Tree)_host).Clear();

    /// <inheritdoc cref="Tree.CreateItem(TreeItem, int)" />
    public TreeItem CreateItem(TreeItem @parent, int @index) => ((Tree)_host).CreateItem(@parent, @index);

    /// <inheritdoc cref="Tree.GetRoot()" />
    public TreeItem GetRoot() => ((Tree)_host).GetRoot();

    /// <inheritdoc cref="Tree.SetColumnCustomMinimumWidth(int, int)" />
    public void SetColumnCustomMinimumWidth(int @column, int @minWidth) => ((Tree)_host).SetColumnCustomMinimumWidth(@column, @minWidth);

    /// <inheritdoc cref="Tree.SetColumnExpand(int, bool)" />
    public void SetColumnExpand(int @column, bool @expand) => ((Tree)_host).SetColumnExpand(@column, @expand);

    /// <inheritdoc cref="Tree.SetColumnExpandRatio(int, int)" />
    public void SetColumnExpandRatio(int @column, int @ratio) => ((Tree)_host).SetColumnExpandRatio(@column, @ratio);

    /// <inheritdoc cref="Tree.SetColumnClipContent(int, bool)" />
    public void SetColumnClipContent(int @column, bool @enable) => ((Tree)_host).SetColumnClipContent(@column, @enable);

    /// <inheritdoc cref="Tree.IsColumnExpanding(int)" />
    public bool IsColumnExpanding(int @column) => ((Tree)_host).IsColumnExpanding(@column);

    /// <inheritdoc cref="Tree.IsColumnClippingContent(int)" />
    public bool IsColumnClippingContent(int @column) => ((Tree)_host).IsColumnClippingContent(@column);

    /// <inheritdoc cref="Tree.GetColumnExpandRatio(int)" />
    public int GetColumnExpandRatio(int @column) => ((Tree)_host).GetColumnExpandRatio(@column);

    /// <inheritdoc cref="Tree.GetColumnWidth(int)" />
    public int GetColumnWidth(int @column) => ((Tree)_host).GetColumnWidth(@column);

    /// <inheritdoc cref="Tree.SetHideRoot(bool)" />
    public void SetHideRoot(bool @enable) => ((Tree)_host).SetHideRoot(@enable);

    /// <inheritdoc cref="Tree.IsRootHidden()" />
    public bool IsRootHidden() => ((Tree)_host).IsRootHidden();

    /// <inheritdoc cref="Tree.GetNextSelected(TreeItem)" />
    public TreeItem GetNextSelected(TreeItem @from) => ((Tree)_host).GetNextSelected(@from);

    /// <inheritdoc cref="Tree.GetSelected()" />
    public TreeItem GetSelected() => ((Tree)_host).GetSelected();

    /// <inheritdoc cref="Tree.SetSelected(TreeItem, int)" />
    public void SetSelected(TreeItem @item, int @column) => ((Tree)_host).SetSelected(@item, @column);

    /// <inheritdoc cref="Tree.GetSelectedColumn()" />
    public int GetSelectedColumn() => ((Tree)_host).GetSelectedColumn();

    /// <inheritdoc cref="Tree.GetPressedButton()" />
    public int GetPressedButton() => ((Tree)_host).GetPressedButton();

    /// <inheritdoc cref="Tree.SetSelectMode(Tree.SelectModeEnum)" />
    public void SetSelectMode(Tree.SelectModeEnum @mode) => ((Tree)_host).SetSelectMode(@mode);

    /// <inheritdoc cref="Tree.GetSelectMode()" />
    public Tree.SelectModeEnum GetSelectMode() => ((Tree)_host).GetSelectMode();

    /// <inheritdoc cref="Tree.DeselectAll()" />
    public void DeselectAll() => ((Tree)_host).DeselectAll();

    /// <inheritdoc cref="Tree.SetColumns(int)" />
    public void SetColumns(int @amount) => ((Tree)_host).SetColumns(@amount);

    /// <inheritdoc cref="Tree.GetColumns()" />
    public int GetColumns() => ((Tree)_host).GetColumns();

    /// <inheritdoc cref="Tree.GetEdited()" />
    public TreeItem GetEdited() => ((Tree)_host).GetEdited();

    /// <inheritdoc cref="Tree.GetEditedColumn()" />
    public int GetEditedColumn() => ((Tree)_host).GetEditedColumn();

    /// <inheritdoc cref="Tree.EditSelected(bool)" />
    public bool EditSelected(bool @forceEdit) => ((Tree)_host).EditSelected(@forceEdit);

    /// <inheritdoc cref="Tree.GetCustomPopupRect()" />
    public Rect2 GetCustomPopupRect() => ((Tree)_host).GetCustomPopupRect();

    /// <inheritdoc cref="Tree.GetItemAreaRect(TreeItem, int, int)" />
    public Rect2 GetItemAreaRect(TreeItem @item, int @column, int @buttonIndex) => ((Tree)_host).GetItemAreaRect(@item, @column, @buttonIndex);

    /// <inheritdoc cref="Tree.GetItemAtPosition(Vector2)" />
    public TreeItem GetItemAtPosition(Vector2 @position) => ((Tree)_host).GetItemAtPosition(@position);

    /// <inheritdoc cref="Tree.GetColumnAtPosition(Vector2)" />
    public int GetColumnAtPosition(Vector2 @position) => ((Tree)_host).GetColumnAtPosition(@position);

    /// <inheritdoc cref="Tree.GetDropSectionAtPosition(Vector2)" />
    public int GetDropSectionAtPosition(Vector2 @position) => ((Tree)_host).GetDropSectionAtPosition(@position);

    /// <inheritdoc cref="Tree.GetButtonIdAtPosition(Vector2)" />
    public int GetButtonIdAtPosition(Vector2 @position) => ((Tree)_host).GetButtonIdAtPosition(@position);

    /// <inheritdoc cref="Tree.EnsureCursorIsVisible()" />
    public void EnsureCursorIsVisible() => ((Tree)_host).EnsureCursorIsVisible();

    /// <inheritdoc cref="Tree.SetColumnTitlesVisible(bool)" />
    public void SetColumnTitlesVisible(bool @visible) => ((Tree)_host).SetColumnTitlesVisible(@visible);

    /// <inheritdoc cref="Tree.AreColumnTitlesVisible()" />
    public bool AreColumnTitlesVisible() => ((Tree)_host).AreColumnTitlesVisible();

    /// <inheritdoc cref="Tree.SetColumnTitle(int, string)" />
    public void SetColumnTitle(int @column, string @title) => ((Tree)_host).SetColumnTitle(@column, @title);

    /// <inheritdoc cref="Tree.GetColumnTitle(int)" />
    public string GetColumnTitle(int @column) => ((Tree)_host).GetColumnTitle(@column);

    /// <inheritdoc cref="Tree.SetColumnTitleTooltipText(int, string)" />
    public void SetColumnTitleTooltipText(int @column, string @tooltipText) => ((Tree)_host).SetColumnTitleTooltipText(@column, @tooltipText);

    /// <inheritdoc cref="Tree.GetColumnTitleTooltipText(int)" />
    public string GetColumnTitleTooltipText(int @column) => ((Tree)_host).GetColumnTitleTooltipText(@column);

    /// <inheritdoc cref="Tree.SetColumnTitleAlignment(int, HorizontalAlignment)" />
    public void SetColumnTitleAlignment(int @column, HorizontalAlignment @titleAlignment) => ((Tree)_host).SetColumnTitleAlignment(@column, @titleAlignment);

    /// <inheritdoc cref="Tree.GetColumnTitleAlignment(int)" />
    public HorizontalAlignment GetColumnTitleAlignment(int @column) => ((Tree)_host).GetColumnTitleAlignment(@column);

    /// <inheritdoc cref="Tree.SetColumnTitleDirection(int, Control.TextDirection)" />
    public void SetColumnTitleDirection(int @column, Control.TextDirection @direction) => ((Tree)_host).SetColumnTitleDirection(@column, @direction);

    /// <inheritdoc cref="Tree.GetColumnTitleDirection(int)" />
    public Control.TextDirection GetColumnTitleDirection(int @column) => ((Tree)_host).GetColumnTitleDirection(@column);

    /// <inheritdoc cref="Tree.SetColumnTitleLanguage(int, string)" />
    public void SetColumnTitleLanguage(int @column, string @language) => ((Tree)_host).SetColumnTitleLanguage(@column, @language);

    /// <inheritdoc cref="Tree.GetColumnTitleLanguage(int)" />
    public string GetColumnTitleLanguage(int @column) => ((Tree)_host).GetColumnTitleLanguage(@column);

    /// <inheritdoc cref="Tree.GetScroll()" />
    public Vector2 GetScroll() => ((Tree)_host).GetScroll();

    /// <inheritdoc cref="Tree.ScrollToItem(TreeItem, bool)" />
    public void ScrollToItem(TreeItem @item, bool @centerOnItem) => ((Tree)_host).ScrollToItem(@item, @centerOnItem);

    /// <inheritdoc cref="Tree.SetHScrollEnabled(bool)" />
    public void SetHScrollEnabled(bool @hScroll) => ((Tree)_host).SetHScrollEnabled(@hScroll);

    /// <inheritdoc cref="Tree.IsHScrollEnabled()" />
    public bool IsHScrollEnabled() => ((Tree)_host).IsHScrollEnabled();

    /// <inheritdoc cref="Tree.SetVScrollEnabled(bool)" />
    public void SetVScrollEnabled(bool @hScroll) => ((Tree)_host).SetVScrollEnabled(@hScroll);

    /// <inheritdoc cref="Tree.IsVScrollEnabled()" />
    public bool IsVScrollEnabled() => ((Tree)_host).IsVScrollEnabled();

    /// <inheritdoc cref="Tree.SetScrollHintMode(Tree.ScrollHintModeEnum)" />
    public void SetScrollHintMode(Tree.ScrollHintModeEnum @scrollHintMode) => ((Tree)_host).SetScrollHintMode(@scrollHintMode);

    /// <inheritdoc cref="Tree.GetScrollHintMode()" />
    public Tree.ScrollHintModeEnum GetScrollHintMode() => ((Tree)_host).GetScrollHintMode();

    /// <inheritdoc cref="Tree.SetTileScrollHint(bool)" />
    public void SetTileScrollHint(bool @tileScrollHint) => ((Tree)_host).SetTileScrollHint(@tileScrollHint);

    /// <inheritdoc cref="Tree.IsScrollHintTiled()" />
    public bool IsScrollHintTiled() => ((Tree)_host).IsScrollHintTiled();

    /// <inheritdoc cref="Tree.SetHideFolding(bool)" />
    public void SetHideFolding(bool @hide) => ((Tree)_host).SetHideFolding(@hide);

    /// <inheritdoc cref="Tree.IsFoldingHidden()" />
    public bool IsFoldingHidden() => ((Tree)_host).IsFoldingHidden();

    /// <inheritdoc cref="Tree.SetEnableRecursiveFolding(bool)" />
    public void SetEnableRecursiveFolding(bool @enable) => ((Tree)_host).SetEnableRecursiveFolding(@enable);

    /// <inheritdoc cref="Tree.IsRecursiveFoldingEnabled()" />
    public bool IsRecursiveFoldingEnabled() => ((Tree)_host).IsRecursiveFoldingEnabled();

    /// <inheritdoc cref="Tree.SetEnableDragUnfolding(bool)" />
    public void SetEnableDragUnfolding(bool @enable) => ((Tree)_host).SetEnableDragUnfolding(@enable);

    /// <inheritdoc cref="Tree.IsDragUnfoldingEnabled()" />
    public bool IsDragUnfoldingEnabled() => ((Tree)_host).IsDragUnfoldingEnabled();

    /// <inheritdoc cref="Tree.SetDropModeFlags(int)" />
    public void SetDropModeFlags(int @flags) => ((Tree)_host).SetDropModeFlags(@flags);

    /// <inheritdoc cref="Tree.GetDropModeFlags()" />
    public int GetDropModeFlags() => ((Tree)_host).GetDropModeFlags();

    /// <inheritdoc cref="Tree.SetAllowRmbSelect(bool)" />
    public void SetAllowRmbSelect(bool @allow) => ((Tree)_host).SetAllowRmbSelect(@allow);

    /// <inheritdoc cref="Tree.GetAllowRmbSelect()" />
    public bool GetAllowRmbSelect() => ((Tree)_host).GetAllowRmbSelect();

    /// <inheritdoc cref="Tree.SetAllowReselect(bool)" />
    public void SetAllowReselect(bool @allow) => ((Tree)_host).SetAllowReselect(@allow);

    /// <inheritdoc cref="Tree.GetAllowReselect()" />
    public bool GetAllowReselect() => ((Tree)_host).GetAllowReselect();

    /// <inheritdoc cref="Tree.SetAllowSearch(bool)" />
    public void SetAllowSearch(bool @allow) => ((Tree)_host).SetAllowSearch(@allow);

    /// <inheritdoc cref="Tree.GetAllowSearch()" />
    public bool GetAllowSearch() => ((Tree)_host).GetAllowSearch();

    /// <inheritdoc cref="Tree.SetAutoTooltip(bool)" />
    public void SetAutoTooltip(bool @enable) => ((Tree)_host).SetAutoTooltip(@enable);

    /// <inheritdoc cref="Tree.IsAutoTooltipEnabled()" />
    public bool IsAutoTooltipEnabled() => ((Tree)_host).IsAutoTooltipEnabled();

}
