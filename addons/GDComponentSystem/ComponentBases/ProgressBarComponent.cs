#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ProgressBar" />
[Tool, GlobalClass]
public abstract partial class ProgressBarComponent : RangeComponent
{

    /// <inheritdoc cref="ProgressBar.SetFillMode(int)" />
    public void SetFillMode(int @mode) => ((ProgressBar)_host).SetFillMode(@mode);

    /// <inheritdoc cref="ProgressBar.GetFillMode()" />
    public int GetFillMode() => ((ProgressBar)_host).GetFillMode();

    /// <inheritdoc cref="ProgressBar.SetShowPercentage(bool)" />
    public void SetShowPercentage(bool @visible) => ((ProgressBar)_host).SetShowPercentage(@visible);

    /// <inheritdoc cref="ProgressBar.IsPercentageShown()" />
    public bool IsPercentageShown() => ((ProgressBar)_host).IsPercentageShown();

    /// <inheritdoc cref="ProgressBar.SetIndeterminate(bool)" />
    public void SetIndeterminate(bool @indeterminate) => ((ProgressBar)_host).SetIndeterminate(@indeterminate);

    /// <inheritdoc cref="ProgressBar.IsIndeterminate()" />
    public bool IsIndeterminate() => ((ProgressBar)_host).IsIndeterminate();

    /// <inheritdoc cref="ProgressBar.SetEditorPreviewIndeterminate(bool)" />
    public void SetEditorPreviewIndeterminate(bool @previewIndeterminate) => ((ProgressBar)_host).SetEditorPreviewIndeterminate(@previewIndeterminate);

    /// <inheritdoc cref="ProgressBar.IsEditorPreviewIndeterminateEnabled()" />
    public bool IsEditorPreviewIndeterminateEnabled() => ((ProgressBar)_host).IsEditorPreviewIndeterminateEnabled();

}
