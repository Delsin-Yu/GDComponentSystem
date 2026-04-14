#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="TabBar" />
[Tool, GlobalClass]
public abstract partial class TabBarComponent : ControlComponent
{

    /// <inheritdoc cref="TabBar.SetTabCount(int)" />
    public void SetTabCount(int @count) => ((TabBar)_host).SetTabCount(@count);

    /// <inheritdoc cref="TabBar.GetTabCount()" />
    public int GetTabCount() => ((TabBar)_host).GetTabCount();

    /// <inheritdoc cref="TabBar.SetCurrentTab(int)" />
    public void SetCurrentTab(int @tabIdx) => ((TabBar)_host).SetCurrentTab(@tabIdx);

    /// <inheritdoc cref="TabBar.GetCurrentTab()" />
    public int GetCurrentTab() => ((TabBar)_host).GetCurrentTab();

    /// <inheritdoc cref="TabBar.GetPreviousTab()" />
    public int GetPreviousTab() => ((TabBar)_host).GetPreviousTab();

    /// <inheritdoc cref="TabBar.SelectPreviousAvailable()" />
    public bool SelectPreviousAvailable() => ((TabBar)_host).SelectPreviousAvailable();

    /// <inheritdoc cref="TabBar.SelectNextAvailable()" />
    public bool SelectNextAvailable() => ((TabBar)_host).SelectNextAvailable();

    /// <inheritdoc cref="TabBar.SetTabTitle(int, string)" />
    public void SetTabTitle(int @tabIdx, string @title) => ((TabBar)_host).SetTabTitle(@tabIdx, @title);

    /// <inheritdoc cref="TabBar.GetTabTitle(int)" />
    public string GetTabTitle(int @tabIdx) => ((TabBar)_host).GetTabTitle(@tabIdx);

    /// <inheritdoc cref="TabBar.SetTabTooltip(int, string)" />
    public void SetTabTooltip(int @tabIdx, string @tooltip) => ((TabBar)_host).SetTabTooltip(@tabIdx, @tooltip);

    /// <inheritdoc cref="TabBar.GetTabTooltip(int)" />
    public string GetTabTooltip(int @tabIdx) => ((TabBar)_host).GetTabTooltip(@tabIdx);

    /// <inheritdoc cref="TabBar.SetTabTextDirection(int, Control.TextDirection)" />
    public void SetTabTextDirection(int @tabIdx, Control.TextDirection @direction) => ((TabBar)_host).SetTabTextDirection(@tabIdx, @direction);

    /// <inheritdoc cref="TabBar.GetTabTextDirection(int)" />
    public Control.TextDirection GetTabTextDirection(int @tabIdx) => ((TabBar)_host).GetTabTextDirection(@tabIdx);

    /// <inheritdoc cref="TabBar.SetTabLanguage(int, string)" />
    public void SetTabLanguage(int @tabIdx, string @language) => ((TabBar)_host).SetTabLanguage(@tabIdx, @language);

    /// <inheritdoc cref="TabBar.GetTabLanguage(int)" />
    public string GetTabLanguage(int @tabIdx) => ((TabBar)_host).GetTabLanguage(@tabIdx);

    /// <inheritdoc cref="TabBar.SetTabIcon(int, Texture2D)" />
    public void SetTabIcon(int @tabIdx, Texture2D @icon) => ((TabBar)_host).SetTabIcon(@tabIdx, @icon);

    /// <inheritdoc cref="TabBar.GetTabIcon(int)" />
    public Texture2D GetTabIcon(int @tabIdx) => ((TabBar)_host).GetTabIcon(@tabIdx);

    /// <inheritdoc cref="TabBar.SetTabIconMaxWidth(int, int)" />
    public void SetTabIconMaxWidth(int @tabIdx, int @width) => ((TabBar)_host).SetTabIconMaxWidth(@tabIdx, @width);

    /// <inheritdoc cref="TabBar.GetTabIconMaxWidth(int)" />
    public int GetTabIconMaxWidth(int @tabIdx) => ((TabBar)_host).GetTabIconMaxWidth(@tabIdx);

    /// <inheritdoc cref="TabBar.SetTabButtonIcon(int, Texture2D)" />
    public void SetTabButtonIcon(int @tabIdx, Texture2D @icon) => ((TabBar)_host).SetTabButtonIcon(@tabIdx, @icon);

    /// <inheritdoc cref="TabBar.GetTabButtonIcon(int)" />
    public Texture2D GetTabButtonIcon(int @tabIdx) => ((TabBar)_host).GetTabButtonIcon(@tabIdx);

    /// <inheritdoc cref="TabBar.SetTabDisabled(int, bool)" />
    public void SetTabDisabled(int @tabIdx, bool @disabled) => ((TabBar)_host).SetTabDisabled(@tabIdx, @disabled);

    /// <inheritdoc cref="TabBar.IsTabDisabled(int)" />
    public bool IsTabDisabled(int @tabIdx) => ((TabBar)_host).IsTabDisabled(@tabIdx);

    /// <inheritdoc cref="TabBar.SetTabHidden(int, bool)" />
    public void SetTabHidden(int @tabIdx, bool @hidden) => ((TabBar)_host).SetTabHidden(@tabIdx, @hidden);

    /// <inheritdoc cref="TabBar.IsTabHidden(int)" />
    public bool IsTabHidden(int @tabIdx) => ((TabBar)_host).IsTabHidden(@tabIdx);

    /// <inheritdoc cref="TabBar.SetTabMetadata(int, Variant)" />
    public void SetTabMetadata(int @tabIdx, Variant @metadata) => ((TabBar)_host).SetTabMetadata(@tabIdx, @metadata);

    /// <inheritdoc cref="TabBar.GetTabMetadata(int)" />
    public Variant GetTabMetadata(int @tabIdx) => ((TabBar)_host).GetTabMetadata(@tabIdx);

    /// <inheritdoc cref="TabBar.RemoveTab(int)" />
    public void RemoveTab(int @tabIdx) => ((TabBar)_host).RemoveTab(@tabIdx);

    /// <inheritdoc cref="TabBar.AddTab(string, Texture2D)" />
    public void AddTab(string @title, Texture2D @icon) => ((TabBar)_host).AddTab(@title, @icon);

    /// <inheritdoc cref="TabBar.GetTabIdxAtPoint(Vector2)" />
    public int GetTabIdxAtPoint(Vector2 @point) => ((TabBar)_host).GetTabIdxAtPoint(@point);

    /// <inheritdoc cref="TabBar.SetTabAlignment(TabBar.AlignmentMode)" />
    public void SetTabAlignment(TabBar.AlignmentMode @alignment) => ((TabBar)_host).SetTabAlignment(@alignment);

    /// <inheritdoc cref="TabBar.GetTabAlignment()" />
    public TabBar.AlignmentMode GetTabAlignment() => ((TabBar)_host).GetTabAlignment();

    /// <inheritdoc cref="TabBar.SetClipTabs(bool)" />
    public void SetClipTabs(bool @clipTabs) => ((TabBar)_host).SetClipTabs(@clipTabs);

    /// <inheritdoc cref="TabBar.GetClipTabs()" />
    public bool GetClipTabs() => ((TabBar)_host).GetClipTabs();

    /// <inheritdoc cref="TabBar.GetTabOffset()" />
    public int GetTabOffset() => ((TabBar)_host).GetTabOffset();

    /// <inheritdoc cref="TabBar.GetOffsetButtonsVisible()" />
    public bool GetOffsetButtonsVisible() => ((TabBar)_host).GetOffsetButtonsVisible();

    /// <inheritdoc cref="TabBar.EnsureTabVisible(int)" />
    public void EnsureTabVisible(int @idx) => ((TabBar)_host).EnsureTabVisible(@idx);

    /// <inheritdoc cref="TabBar.GetTabRect(int)" />
    public Rect2 GetTabRect(int @tabIdx) => ((TabBar)_host).GetTabRect(@tabIdx);

    /// <inheritdoc cref="TabBar.MoveTab(int, int)" />
    public void MoveTab(int @from, int @to) => ((TabBar)_host).MoveTab(@from, @to);

    /// <inheritdoc cref="TabBar.SetCloseWithMiddleMouse(bool)" />
    public void SetCloseWithMiddleMouse(bool @enabled) => ((TabBar)_host).SetCloseWithMiddleMouse(@enabled);

    /// <inheritdoc cref="TabBar.GetCloseWithMiddleMouse()" />
    public bool GetCloseWithMiddleMouse() => ((TabBar)_host).GetCloseWithMiddleMouse();

    /// <inheritdoc cref="TabBar.SetTabCloseDisplayPolicy(TabBar.CloseButtonDisplayPolicy)" />
    public void SetTabCloseDisplayPolicy(TabBar.CloseButtonDisplayPolicy @policy) => ((TabBar)_host).SetTabCloseDisplayPolicy(@policy);

    /// <inheritdoc cref="TabBar.GetTabCloseDisplayPolicy()" />
    public TabBar.CloseButtonDisplayPolicy GetTabCloseDisplayPolicy() => ((TabBar)_host).GetTabCloseDisplayPolicy();

    /// <inheritdoc cref="TabBar.SetMaxTabWidth(int)" />
    public void SetMaxTabWidth(int @width) => ((TabBar)_host).SetMaxTabWidth(@width);

    /// <inheritdoc cref="TabBar.GetMaxTabWidth()" />
    public int GetMaxTabWidth() => ((TabBar)_host).GetMaxTabWidth();

    /// <inheritdoc cref="TabBar.SetScrollingEnabled(bool)" />
    public void SetScrollingEnabled(bool @enabled) => ((TabBar)_host).SetScrollingEnabled(@enabled);

    /// <inheritdoc cref="TabBar.GetScrollingEnabled()" />
    public bool GetScrollingEnabled() => ((TabBar)_host).GetScrollingEnabled();

    /// <inheritdoc cref="TabBar.SetDragToRearrangeEnabled(bool)" />
    public void SetDragToRearrangeEnabled(bool @enabled) => ((TabBar)_host).SetDragToRearrangeEnabled(@enabled);

    /// <inheritdoc cref="TabBar.GetDragToRearrangeEnabled()" />
    public bool GetDragToRearrangeEnabled() => ((TabBar)_host).GetDragToRearrangeEnabled();

    /// <inheritdoc cref="TabBar.SetSwitchOnDragHover(bool)" />
    public void SetSwitchOnDragHover(bool @enabled) => ((TabBar)_host).SetSwitchOnDragHover(@enabled);

    /// <inheritdoc cref="TabBar.GetSwitchOnDragHover()" />
    public bool GetSwitchOnDragHover() => ((TabBar)_host).GetSwitchOnDragHover();

    /// <inheritdoc cref="TabBar.SetTabsRearrangeGroup(int)" />
    public void SetTabsRearrangeGroup(int @groupId) => ((TabBar)_host).SetTabsRearrangeGroup(@groupId);

    /// <inheritdoc cref="TabBar.GetTabsRearrangeGroup()" />
    public int GetTabsRearrangeGroup() => ((TabBar)_host).GetTabsRearrangeGroup();

    /// <inheritdoc cref="TabBar.SetScrollToSelected(bool)" />
    public void SetScrollToSelected(bool @enabled) => ((TabBar)_host).SetScrollToSelected(@enabled);

    /// <inheritdoc cref="TabBar.GetScrollToSelected()" />
    public bool GetScrollToSelected() => ((TabBar)_host).GetScrollToSelected();

    /// <inheritdoc cref="TabBar.SetSelectWithRmb(bool)" />
    public void SetSelectWithRmb(bool @enabled) => ((TabBar)_host).SetSelectWithRmb(@enabled);

    /// <inheritdoc cref="TabBar.GetSelectWithRmb()" />
    public bool GetSelectWithRmb() => ((TabBar)_host).GetSelectWithRmb();

    /// <inheritdoc cref="TabBar.SetDeselectEnabled(bool)" />
    public void SetDeselectEnabled(bool @enabled) => ((TabBar)_host).SetDeselectEnabled(@enabled);

    /// <inheritdoc cref="TabBar.GetDeselectEnabled()" />
    public bool GetDeselectEnabled() => ((TabBar)_host).GetDeselectEnabled();

    /// <inheritdoc cref="TabBar.ClearTabs()" />
    public void ClearTabs() => ((TabBar)_host).ClearTabs();

}
