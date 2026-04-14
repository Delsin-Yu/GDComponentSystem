#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="SplitContainer" />
[Tool, GlobalClass]
public abstract partial class SplitContainerComponent : ContainerComponent
{

    /// <inheritdoc cref="SplitContainer.SetSplitOffsets(int[])" />
    public void SetSplitOffsets(int[] @offsets) => ((SplitContainer)_host).SetSplitOffsets(@offsets);

    /// <inheritdoc cref="SplitContainer.SetSplitOffsets(ReadOnlySpan{int})" />
    public void SetSplitOffsets(ReadOnlySpan<int> @offsets) => ((SplitContainer)_host).SetSplitOffsets(@offsets);

    /// <inheritdoc cref="SplitContainer.GetSplitOffsets()" />
    public int[] GetSplitOffsets() => ((SplitContainer)_host).GetSplitOffsets();

    /// <inheritdoc cref="SplitContainer.ClampSplitOffset(int)" />
    public void ClampSplitOffset(int @priorityIndex) => ((SplitContainer)_host).ClampSplitOffset(@priorityIndex);

    /// <inheritdoc cref="SplitContainer.SetCollapsed(bool)" />
    public void SetCollapsed(bool @collapsed) => ((SplitContainer)_host).SetCollapsed(@collapsed);

    /// <inheritdoc cref="SplitContainer.IsCollapsed()" />
    public bool IsCollapsed() => ((SplitContainer)_host).IsCollapsed();

    /// <inheritdoc cref="SplitContainer.SetDraggerVisibility(SplitContainer.DraggerVisibilityEnum)" />
    public void SetDraggerVisibility(SplitContainer.DraggerVisibilityEnum @mode) => ((SplitContainer)_host).SetDraggerVisibility(@mode);

    /// <inheritdoc cref="SplitContainer.GetDraggerVisibility()" />
    public SplitContainer.DraggerVisibilityEnum GetDraggerVisibility() => ((SplitContainer)_host).GetDraggerVisibility();

    /// <inheritdoc cref="SplitContainer.SetVertical(bool)" />
    public void SetVertical(bool @vertical) => ((SplitContainer)_host).SetVertical(@vertical);

    /// <inheritdoc cref="SplitContainer.IsVertical()" />
    public bool IsVertical() => ((SplitContainer)_host).IsVertical();

    /// <inheritdoc cref="SplitContainer.SetDraggingEnabled(bool)" />
    public void SetDraggingEnabled(bool @draggingEnabled) => ((SplitContainer)_host).SetDraggingEnabled(@draggingEnabled);

    /// <inheritdoc cref="SplitContainer.IsDraggingEnabled()" />
    public bool IsDraggingEnabled() => ((SplitContainer)_host).IsDraggingEnabled();

    /// <inheritdoc cref="SplitContainer.SetDragAreaMarginBegin(int)" />
    public void SetDragAreaMarginBegin(int @margin) => ((SplitContainer)_host).SetDragAreaMarginBegin(@margin);

    /// <inheritdoc cref="SplitContainer.GetDragAreaMarginBegin()" />
    public int GetDragAreaMarginBegin() => ((SplitContainer)_host).GetDragAreaMarginBegin();

    /// <inheritdoc cref="SplitContainer.SetDragAreaMarginEnd(int)" />
    public void SetDragAreaMarginEnd(int @margin) => ((SplitContainer)_host).SetDragAreaMarginEnd(@margin);

    /// <inheritdoc cref="SplitContainer.GetDragAreaMarginEnd()" />
    public int GetDragAreaMarginEnd() => ((SplitContainer)_host).GetDragAreaMarginEnd();

    /// <inheritdoc cref="SplitContainer.SetDragAreaOffset(int)" />
    public void SetDragAreaOffset(int @offset) => ((SplitContainer)_host).SetDragAreaOffset(@offset);

    /// <inheritdoc cref="SplitContainer.GetDragAreaOffset()" />
    public int GetDragAreaOffset() => ((SplitContainer)_host).GetDragAreaOffset();

    /// <inheritdoc cref="SplitContainer.SetDragAreaHighlightInEditor(bool)" />
    public void SetDragAreaHighlightInEditor(bool @dragAreaHighlightInEditor) => ((SplitContainer)_host).SetDragAreaHighlightInEditor(@dragAreaHighlightInEditor);

    /// <inheritdoc cref="SplitContainer.IsDragAreaHighlightInEditorEnabled()" />
    public bool IsDragAreaHighlightInEditorEnabled() => ((SplitContainer)_host).IsDragAreaHighlightInEditorEnabled();

    /// <inheritdoc cref="SplitContainer.GetDragAreaControls()" />
    public Array<Control> GetDragAreaControls() => ((SplitContainer)_host).GetDragAreaControls();

    /// <inheritdoc cref="SplitContainer.SetTouchDraggerEnabled(bool)" />
    public void SetTouchDraggerEnabled(bool @enabled) => ((SplitContainer)_host).SetTouchDraggerEnabled(@enabled);

    /// <inheritdoc cref="SplitContainer.IsTouchDraggerEnabled()" />
    public bool IsTouchDraggerEnabled() => ((SplitContainer)_host).IsTouchDraggerEnabled();

    /// <inheritdoc cref="SplitContainer.GetDragAreaControl()" />
    public Control GetDragAreaControl() => ((SplitContainer)_host).GetDragAreaControl();

    /// <inheritdoc cref="SplitContainer.SetSplitOffset(int)" />
    public void SetSplitOffset(int @offset) => ((SplitContainer)_host).SetSplitOffset(@offset);

    /// <inheritdoc cref="SplitContainer.GetSplitOffset()" />
    public int GetSplitOffset() => ((SplitContainer)_host).GetSplitOffset();

    /// <inheritdoc cref="SplitContainer.ClampSplitOffset()" />
    public void ClampSplitOffset() => ((SplitContainer)_host).ClampSplitOffset();

}
