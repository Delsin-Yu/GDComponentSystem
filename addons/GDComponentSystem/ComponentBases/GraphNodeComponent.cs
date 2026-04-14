#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GraphNode" />
[Tool, GlobalClass]
public abstract partial class GraphNodeComponent : GraphElementComponent
{

    /// <inheritdoc cref="GraphNode._DrawPort(int, Vector2I, bool, Color)" />
    public virtual void _DrawPort(int @slotIndex, Vector2I @position, bool @left, Color @color) { }

    /// <inheritdoc cref="GraphNode.SetTitle(string)" />
    public void SetTitle(string @title) => ((GraphNode)_host).SetTitle(@title);

    /// <inheritdoc cref="GraphNode.GetTitle()" />
    public string GetTitle() => ((GraphNode)_host).GetTitle();

    /// <inheritdoc cref="GraphNode.GetTitlebarHBox()" />
    public HBoxContainer GetTitlebarHBox() => ((GraphNode)_host).GetTitlebarHBox();

    /// <inheritdoc cref="GraphNode.SetSlot(int, bool, int, Color, bool, int, Color, Texture2D, Texture2D, bool)" />
    public void SetSlot(int @slotIndex, bool @enableLeftPort, int @typeLeft, Color @colorLeft, bool @enableRightPort, int @typeRight, Color @colorRight, Texture2D @customIconLeft, Texture2D @customIconRight, bool @drawStylebox) => ((GraphNode)_host).SetSlot(@slotIndex, @enableLeftPort, @typeLeft, @colorLeft, @enableRightPort, @typeRight, @colorRight, @customIconLeft, @customIconRight, @drawStylebox);

    /// <inheritdoc cref="GraphNode.ClearSlot(int)" />
    public void ClearSlot(int @slotIndex) => ((GraphNode)_host).ClearSlot(@slotIndex);

    /// <inheritdoc cref="GraphNode.ClearAllSlots()" />
    public void ClearAllSlots() => ((GraphNode)_host).ClearAllSlots();

    /// <inheritdoc cref="GraphNode.IsSlotEnabledLeft(int)" />
    public bool IsSlotEnabledLeft(int @slotIndex) => ((GraphNode)_host).IsSlotEnabledLeft(@slotIndex);

    /// <inheritdoc cref="GraphNode.SetSlotEnabledLeft(int, bool)" />
    public void SetSlotEnabledLeft(int @slotIndex, bool @enable) => ((GraphNode)_host).SetSlotEnabledLeft(@slotIndex, @enable);

    /// <inheritdoc cref="GraphNode.SetSlotTypeLeft(int, int)" />
    public void SetSlotTypeLeft(int @slotIndex, int @type) => ((GraphNode)_host).SetSlotTypeLeft(@slotIndex, @type);

    /// <inheritdoc cref="GraphNode.GetSlotTypeLeft(int)" />
    public int GetSlotTypeLeft(int @slotIndex) => ((GraphNode)_host).GetSlotTypeLeft(@slotIndex);

    /// <inheritdoc cref="GraphNode.SetSlotColorLeft(int, Color)" />
    public void SetSlotColorLeft(int @slotIndex, Color @color) => ((GraphNode)_host).SetSlotColorLeft(@slotIndex, @color);

    /// <inheritdoc cref="GraphNode.GetSlotColorLeft(int)" />
    public Color GetSlotColorLeft(int @slotIndex) => ((GraphNode)_host).GetSlotColorLeft(@slotIndex);

    /// <inheritdoc cref="GraphNode.SetSlotCustomIconLeft(int, Texture2D)" />
    public void SetSlotCustomIconLeft(int @slotIndex, Texture2D @customIcon) => ((GraphNode)_host).SetSlotCustomIconLeft(@slotIndex, @customIcon);

    /// <inheritdoc cref="GraphNode.GetSlotCustomIconLeft(int)" />
    public Texture2D GetSlotCustomIconLeft(int @slotIndex) => ((GraphNode)_host).GetSlotCustomIconLeft(@slotIndex);

    /// <inheritdoc cref="GraphNode.SetSlotMetadataLeft(int, Variant)" />
    public void SetSlotMetadataLeft(int @slotIndex, Variant @value) => ((GraphNode)_host).SetSlotMetadataLeft(@slotIndex, @value);

    /// <inheritdoc cref="GraphNode.GetSlotMetadataLeft(int)" />
    public Variant GetSlotMetadataLeft(int @slotIndex) => ((GraphNode)_host).GetSlotMetadataLeft(@slotIndex);

    /// <inheritdoc cref="GraphNode.IsSlotEnabledRight(int)" />
    public bool IsSlotEnabledRight(int @slotIndex) => ((GraphNode)_host).IsSlotEnabledRight(@slotIndex);

    /// <inheritdoc cref="GraphNode.SetSlotEnabledRight(int, bool)" />
    public void SetSlotEnabledRight(int @slotIndex, bool @enable) => ((GraphNode)_host).SetSlotEnabledRight(@slotIndex, @enable);

    /// <inheritdoc cref="GraphNode.SetSlotTypeRight(int, int)" />
    public void SetSlotTypeRight(int @slotIndex, int @type) => ((GraphNode)_host).SetSlotTypeRight(@slotIndex, @type);

    /// <inheritdoc cref="GraphNode.GetSlotTypeRight(int)" />
    public int GetSlotTypeRight(int @slotIndex) => ((GraphNode)_host).GetSlotTypeRight(@slotIndex);

    /// <inheritdoc cref="GraphNode.SetSlotColorRight(int, Color)" />
    public void SetSlotColorRight(int @slotIndex, Color @color) => ((GraphNode)_host).SetSlotColorRight(@slotIndex, @color);

    /// <inheritdoc cref="GraphNode.GetSlotColorRight(int)" />
    public Color GetSlotColorRight(int @slotIndex) => ((GraphNode)_host).GetSlotColorRight(@slotIndex);

    /// <inheritdoc cref="GraphNode.SetSlotCustomIconRight(int, Texture2D)" />
    public void SetSlotCustomIconRight(int @slotIndex, Texture2D @customIcon) => ((GraphNode)_host).SetSlotCustomIconRight(@slotIndex, @customIcon);

    /// <inheritdoc cref="GraphNode.GetSlotCustomIconRight(int)" />
    public Texture2D GetSlotCustomIconRight(int @slotIndex) => ((GraphNode)_host).GetSlotCustomIconRight(@slotIndex);

    /// <inheritdoc cref="GraphNode.SetSlotMetadataRight(int, Variant)" />
    public void SetSlotMetadataRight(int @slotIndex, Variant @value) => ((GraphNode)_host).SetSlotMetadataRight(@slotIndex, @value);

    /// <inheritdoc cref="GraphNode.GetSlotMetadataRight(int)" />
    public Variant GetSlotMetadataRight(int @slotIndex) => ((GraphNode)_host).GetSlotMetadataRight(@slotIndex);

    /// <inheritdoc cref="GraphNode.IsSlotDrawStylebox(int)" />
    public bool IsSlotDrawStylebox(int @slotIndex) => ((GraphNode)_host).IsSlotDrawStylebox(@slotIndex);

    /// <inheritdoc cref="GraphNode.SetSlotDrawStylebox(int, bool)" />
    public void SetSlotDrawStylebox(int @slotIndex, bool @enable) => ((GraphNode)_host).SetSlotDrawStylebox(@slotIndex, @enable);

    /// <inheritdoc cref="GraphNode.SetIgnoreInvalidConnectionType(bool)" />
    public void SetIgnoreInvalidConnectionType(bool @ignore) => ((GraphNode)_host).SetIgnoreInvalidConnectionType(@ignore);

    /// <inheritdoc cref="GraphNode.IsIgnoringValidConnectionType()" />
    public bool IsIgnoringValidConnectionType() => ((GraphNode)_host).IsIgnoringValidConnectionType();

    /// <inheritdoc cref="GraphNode.SetSlotsFocusMode(Control.FocusModeEnum)" />
    public void SetSlotsFocusMode(Control.FocusModeEnum @focusMode) => ((GraphNode)_host).SetSlotsFocusMode(@focusMode);

    /// <inheritdoc cref="GraphNode.GetSlotsFocusMode()" />
    public Control.FocusModeEnum GetSlotsFocusMode() => ((GraphNode)_host).GetSlotsFocusMode();

    /// <inheritdoc cref="GraphNode.GetInputPortCount()" />
    public int GetInputPortCount() => ((GraphNode)_host).GetInputPortCount();

    /// <inheritdoc cref="GraphNode.GetInputPortPosition(int)" />
    public Vector2 GetInputPortPosition(int @portIdx) => ((GraphNode)_host).GetInputPortPosition(@portIdx);

    /// <inheritdoc cref="GraphNode.GetInputPortType(int)" />
    public int GetInputPortType(int @portIdx) => ((GraphNode)_host).GetInputPortType(@portIdx);

    /// <inheritdoc cref="GraphNode.GetInputPortColor(int)" />
    public Color GetInputPortColor(int @portIdx) => ((GraphNode)_host).GetInputPortColor(@portIdx);

    /// <inheritdoc cref="GraphNode.GetInputPortSlot(int)" />
    public int GetInputPortSlot(int @portIdx) => ((GraphNode)_host).GetInputPortSlot(@portIdx);

    /// <inheritdoc cref="GraphNode.GetOutputPortCount()" />
    public int GetOutputPortCount() => ((GraphNode)_host).GetOutputPortCount();

    /// <inheritdoc cref="GraphNode.GetOutputPortPosition(int)" />
    public Vector2 GetOutputPortPosition(int @portIdx) => ((GraphNode)_host).GetOutputPortPosition(@portIdx);

    /// <inheritdoc cref="GraphNode.GetOutputPortType(int)" />
    public int GetOutputPortType(int @portIdx) => ((GraphNode)_host).GetOutputPortType(@portIdx);

    /// <inheritdoc cref="GraphNode.GetOutputPortColor(int)" />
    public Color GetOutputPortColor(int @portIdx) => ((GraphNode)_host).GetOutputPortColor(@portIdx);

    /// <inheritdoc cref="GraphNode.GetOutputPortSlot(int)" />
    public int GetOutputPortSlot(int @portIdx) => ((GraphNode)_host).GetOutputPortSlot(@portIdx);

}
