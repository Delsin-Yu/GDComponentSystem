#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="AspectRatioContainer" />
[Tool, GlobalClass]
public abstract partial class AspectRatioContainerComponent : ContainerComponent
{

    /// <inheritdoc cref="AspectRatioContainer.SetRatio(float)" />
    public void SetRatio(float @ratio) => ((AspectRatioContainer)_host).SetRatio(@ratio);

    /// <inheritdoc cref="AspectRatioContainer.GetRatio()" />
    public float GetRatio() => ((AspectRatioContainer)_host).GetRatio();

    /// <inheritdoc cref="AspectRatioContainer.SetStretchMode(AspectRatioContainer.StretchModeEnum)" />
    public void SetStretchMode(AspectRatioContainer.StretchModeEnum @stretchMode) => ((AspectRatioContainer)_host).SetStretchMode(@stretchMode);

    /// <inheritdoc cref="AspectRatioContainer.GetStretchMode()" />
    public AspectRatioContainer.StretchModeEnum GetStretchMode() => ((AspectRatioContainer)_host).GetStretchMode();

    /// <inheritdoc cref="AspectRatioContainer.SetAlignmentHorizontal(AspectRatioContainer.AlignmentMode)" />
    public void SetAlignmentHorizontal(AspectRatioContainer.AlignmentMode @alignmentHorizontal) => ((AspectRatioContainer)_host).SetAlignmentHorizontal(@alignmentHorizontal);

    /// <inheritdoc cref="AspectRatioContainer.GetAlignmentHorizontal()" />
    public AspectRatioContainer.AlignmentMode GetAlignmentHorizontal() => ((AspectRatioContainer)_host).GetAlignmentHorizontal();

    /// <inheritdoc cref="AspectRatioContainer.SetAlignmentVertical(AspectRatioContainer.AlignmentMode)" />
    public void SetAlignmentVertical(AspectRatioContainer.AlignmentMode @alignmentVertical) => ((AspectRatioContainer)_host).SetAlignmentVertical(@alignmentVertical);

    /// <inheritdoc cref="AspectRatioContainer.GetAlignmentVertical()" />
    public AspectRatioContainer.AlignmentMode GetAlignmentVertical() => ((AspectRatioContainer)_host).GetAlignmentVertical();

}
