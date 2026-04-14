#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="FlowContainer" />
[Tool, GlobalClass]
public abstract partial class FlowContainerComponent : ContainerComponent
{

    /// <inheritdoc cref="FlowContainer.GetLineCount()" />
    public int GetLineCount() => ((FlowContainer)_host).GetLineCount();

    /// <inheritdoc cref="FlowContainer.SetAlignment(FlowContainer.AlignmentMode)" />
    public void SetAlignment(FlowContainer.AlignmentMode @alignment) => ((FlowContainer)_host).SetAlignment(@alignment);

    /// <inheritdoc cref="FlowContainer.GetAlignment()" />
    public FlowContainer.AlignmentMode GetAlignment() => ((FlowContainer)_host).GetAlignment();

    /// <inheritdoc cref="FlowContainer.SetLastWrapAlignment(FlowContainer.LastWrapAlignmentMode)" />
    public void SetLastWrapAlignment(FlowContainer.LastWrapAlignmentMode @lastWrapAlignment) => ((FlowContainer)_host).SetLastWrapAlignment(@lastWrapAlignment);

    /// <inheritdoc cref="FlowContainer.GetLastWrapAlignment()" />
    public FlowContainer.LastWrapAlignmentMode GetLastWrapAlignment() => ((FlowContainer)_host).GetLastWrapAlignment();

    /// <inheritdoc cref="FlowContainer.SetVertical(bool)" />
    public void SetVertical(bool @vertical) => ((FlowContainer)_host).SetVertical(@vertical);

    /// <inheritdoc cref="FlowContainer.IsVertical()" />
    public bool IsVertical() => ((FlowContainer)_host).IsVertical();

    /// <inheritdoc cref="FlowContainer.SetReverseFill(bool)" />
    public void SetReverseFill(bool @reverseFill) => ((FlowContainer)_host).SetReverseFill(@reverseFill);

    /// <inheritdoc cref="FlowContainer.IsReverseFill()" />
    public bool IsReverseFill() => ((FlowContainer)_host).IsReverseFill();

}
