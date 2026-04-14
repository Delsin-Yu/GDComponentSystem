#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="TabContainer" />
[Tool, GlobalClass]
public abstract partial class TabContainerComponent : ContainerComponent
{

    /// <inheritdoc cref="TabContainer.GetTabCount()" />
    public int GetTabCount() => ((TabContainer)_host).GetTabCount();

    /// <inheritdoc cref="TabContainer.SetCurrentTab(int)" />
    public void SetCurrentTab(int @tabIdx) => ((TabContainer)_host).SetCurrentTab(@tabIdx);

    /// <inheritdoc cref="TabContainer.GetCurrentTab()" />
    public int GetCurrentTab() => ((TabContainer)_host).GetCurrentTab();

    /// <inheritdoc cref="TabContainer.GetPreviousTab()" />
    public int GetPreviousTab() => ((TabContainer)_host).GetPreviousTab();

    /// <inheritdoc cref="TabContainer.SelectPreviousAvailable()" />
    public bool SelectPreviousAvailable() => ((TabContainer)_host).SelectPreviousAvailable();

    /// <inheritdoc cref="TabContainer.SelectNextAvailable()" />
    public bool SelectNextAvailable() => ((TabContainer)_host).SelectNextAvailable();

    /// <inheritdoc cref="TabContainer.GetCurrentTabControl()" />
    public Control GetCurrentTabControl() => ((TabContainer)_host).GetCurrentTabControl();

    /// <inheritdoc cref="TabContainer.GetTabBar()" />
    public TabBar GetTabBar() => ((TabContainer)_host).GetTabBar();

    /// <inheritdoc cref="TabContainer.GetTabControl(int)" />
    public Control GetTabControl(int @tabIdx) => ((TabContainer)_host).GetTabControl(@tabIdx);

    /// <inheritdoc cref="TabContainer.SetTabAlignment(TabBar.AlignmentMode)" />
    public void SetTabAlignment(TabBar.AlignmentMode @alignment) => ((TabContainer)_host).SetTabAlignment(@alignment);

    /// <inheritdoc cref="TabContainer.GetTabAlignment()" />
    public TabBar.AlignmentMode GetTabAlignment() => ((TabContainer)_host).GetTabAlignment();

    /// <inheritdoc cref="TabContainer.SetTabsPosition(TabContainer.TabPosition)" />
    public void SetTabsPosition(TabContainer.TabPosition @tabsPosition) => ((TabContainer)_host).SetTabsPosition(@tabsPosition);

    /// <inheritdoc cref="TabContainer.GetTabsPosition()" />
    public TabContainer.TabPosition GetTabsPosition() => ((TabContainer)_host).GetTabsPosition();

    /// <inheritdoc cref="TabContainer.SetClipTabs(bool)" />
    public void SetClipTabs(bool @clipTabs) => ((TabContainer)_host).SetClipTabs(@clipTabs);

    /// <inheritdoc cref="TabContainer.GetClipTabs()" />
    public bool GetClipTabs() => ((TabContainer)_host).GetClipTabs();

    /// <inheritdoc cref="TabContainer.SetTabsVisible(bool)" />
    public void SetTabsVisible(bool @visible) => ((TabContainer)_host).SetTabsVisible(@visible);

    /// <inheritdoc cref="TabContainer.AreTabsVisible()" />
    public bool AreTabsVisible() => ((TabContainer)_host).AreTabsVisible();

    /// <inheritdoc cref="TabContainer.SetAllTabsInFront(bool)" />
    public void SetAllTabsInFront(bool @isFront) => ((TabContainer)_host).SetAllTabsInFront(@isFront);

    /// <inheritdoc cref="TabContainer.IsAllTabsInFront()" />
    public bool IsAllTabsInFront() => ((TabContainer)_host).IsAllTabsInFront();

    /// <inheritdoc cref="TabContainer.SetTabTitle(int, string)" />
    public void SetTabTitle(int @tabIdx, string @title) => ((TabContainer)_host).SetTabTitle(@tabIdx, @title);

    /// <inheritdoc cref="TabContainer.GetTabTitle(int)" />
    public string GetTabTitle(int @tabIdx) => ((TabContainer)_host).GetTabTitle(@tabIdx);

    /// <inheritdoc cref="TabContainer.SetTabTooltip(int, string)" />
    public void SetTabTooltip(int @tabIdx, string @tooltip) => ((TabContainer)_host).SetTabTooltip(@tabIdx, @tooltip);

    /// <inheritdoc cref="TabContainer.GetTabTooltip(int)" />
    public string GetTabTooltip(int @tabIdx) => ((TabContainer)_host).GetTabTooltip(@tabIdx);

    /// <inheritdoc cref="TabContainer.SetTabIcon(int, Texture2D)" />
    public void SetTabIcon(int @tabIdx, Texture2D @icon) => ((TabContainer)_host).SetTabIcon(@tabIdx, @icon);

    /// <inheritdoc cref="TabContainer.GetTabIcon(int)" />
    public Texture2D GetTabIcon(int @tabIdx) => ((TabContainer)_host).GetTabIcon(@tabIdx);

    /// <inheritdoc cref="TabContainer.SetTabIconMaxWidth(int, int)" />
    public void SetTabIconMaxWidth(int @tabIdx, int @width) => ((TabContainer)_host).SetTabIconMaxWidth(@tabIdx, @width);

    /// <inheritdoc cref="TabContainer.GetTabIconMaxWidth(int)" />
    public int GetTabIconMaxWidth(int @tabIdx) => ((TabContainer)_host).GetTabIconMaxWidth(@tabIdx);

    /// <inheritdoc cref="TabContainer.SetTabDisabled(int, bool)" />
    public void SetTabDisabled(int @tabIdx, bool @disabled) => ((TabContainer)_host).SetTabDisabled(@tabIdx, @disabled);

    /// <inheritdoc cref="TabContainer.IsTabDisabled(int)" />
    public bool IsTabDisabled(int @tabIdx) => ((TabContainer)_host).IsTabDisabled(@tabIdx);

    /// <inheritdoc cref="TabContainer.SetTabHidden(int, bool)" />
    public void SetTabHidden(int @tabIdx, bool @hidden) => ((TabContainer)_host).SetTabHidden(@tabIdx, @hidden);

    /// <inheritdoc cref="TabContainer.IsTabHidden(int)" />
    public bool IsTabHidden(int @tabIdx) => ((TabContainer)_host).IsTabHidden(@tabIdx);

    /// <inheritdoc cref="TabContainer.SetTabMetadata(int, Variant)" />
    public void SetTabMetadata(int @tabIdx, Variant @metadata) => ((TabContainer)_host).SetTabMetadata(@tabIdx, @metadata);

    /// <inheritdoc cref="TabContainer.GetTabMetadata(int)" />
    public Variant GetTabMetadata(int @tabIdx) => ((TabContainer)_host).GetTabMetadata(@tabIdx);

    /// <inheritdoc cref="TabContainer.SetTabButtonIcon(int, Texture2D)" />
    public void SetTabButtonIcon(int @tabIdx, Texture2D @icon) => ((TabContainer)_host).SetTabButtonIcon(@tabIdx, @icon);

    /// <inheritdoc cref="TabContainer.GetTabButtonIcon(int)" />
    public Texture2D GetTabButtonIcon(int @tabIdx) => ((TabContainer)_host).GetTabButtonIcon(@tabIdx);

    /// <inheritdoc cref="TabContainer.GetTabIdxAtPoint(Vector2)" />
    public int GetTabIdxAtPoint(Vector2 @point) => ((TabContainer)_host).GetTabIdxAtPoint(@point);

    /// <inheritdoc cref="TabContainer.GetTabIdxFromControl(Control)" />
    public int GetTabIdxFromControl(Control @control) => ((TabContainer)_host).GetTabIdxFromControl(@control);

    /// <inheritdoc cref="TabContainer.SetPopup(Node)" />
    public void SetPopup(Node @popup) => ((TabContainer)_host).SetPopup(@popup);

    /// <inheritdoc cref="TabContainer.GetPopup()" />
    public Popup GetPopup() => ((TabContainer)_host).GetPopup();

    /// <inheritdoc cref="TabContainer.SetSwitchOnDragHover(bool)" />
    public void SetSwitchOnDragHover(bool @enabled) => ((TabContainer)_host).SetSwitchOnDragHover(@enabled);

    /// <inheritdoc cref="TabContainer.GetSwitchOnDragHover()" />
    public bool GetSwitchOnDragHover() => ((TabContainer)_host).GetSwitchOnDragHover();

    /// <inheritdoc cref="TabContainer.SetDragToRearrangeEnabled(bool)" />
    public void SetDragToRearrangeEnabled(bool @enabled) => ((TabContainer)_host).SetDragToRearrangeEnabled(@enabled);

    /// <inheritdoc cref="TabContainer.GetDragToRearrangeEnabled()" />
    public bool GetDragToRearrangeEnabled() => ((TabContainer)_host).GetDragToRearrangeEnabled();

    /// <inheritdoc cref="TabContainer.SetTabsRearrangeGroup(int)" />
    public void SetTabsRearrangeGroup(int @groupId) => ((TabContainer)_host).SetTabsRearrangeGroup(@groupId);

    /// <inheritdoc cref="TabContainer.GetTabsRearrangeGroup()" />
    public int GetTabsRearrangeGroup() => ((TabContainer)_host).GetTabsRearrangeGroup();

    /// <inheritdoc cref="TabContainer.SetUseHiddenTabsForMinSize(bool)" />
    public void SetUseHiddenTabsForMinSize(bool @enabled) => ((TabContainer)_host).SetUseHiddenTabsForMinSize(@enabled);

    /// <inheritdoc cref="TabContainer.GetUseHiddenTabsForMinSize()" />
    public bool GetUseHiddenTabsForMinSize() => ((TabContainer)_host).GetUseHiddenTabsForMinSize();

    /// <inheritdoc cref="TabContainer.SetTabFocusMode(Control.FocusModeEnum)" />
    public void SetTabFocusMode(Control.FocusModeEnum @focusMode) => ((TabContainer)_host).SetTabFocusMode(@focusMode);

    /// <inheritdoc cref="TabContainer.GetTabFocusMode()" />
    public Control.FocusModeEnum GetTabFocusMode() => ((TabContainer)_host).GetTabFocusMode();

    /// <inheritdoc cref="TabContainer.SetDeselectEnabled(bool)" />
    public void SetDeselectEnabled(bool @enabled) => ((TabContainer)_host).SetDeselectEnabled(@enabled);

    /// <inheritdoc cref="TabContainer.GetDeselectEnabled()" />
    public bool GetDeselectEnabled() => ((TabContainer)_host).GetDeselectEnabled();

}
