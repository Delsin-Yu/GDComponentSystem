#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GraphFrame" />
[Tool, GlobalClass]
public abstract partial class GraphFrameComponent : GraphElementComponent
{

    /// <inheritdoc cref="GraphFrame.SetTitle(string)" />
    public void SetTitle(string @title) => ((GraphFrame)_host).SetTitle(@title);

    /// <inheritdoc cref="GraphFrame.GetTitle()" />
    public string GetTitle() => ((GraphFrame)_host).GetTitle();

    /// <inheritdoc cref="GraphFrame.GetTitlebarHBox()" />
    public HBoxContainer GetTitlebarHBox() => ((GraphFrame)_host).GetTitlebarHBox();

    /// <inheritdoc cref="GraphFrame.SetAutoshrinkEnabled(bool)" />
    public void SetAutoshrinkEnabled(bool @shrink) => ((GraphFrame)_host).SetAutoshrinkEnabled(@shrink);

    /// <inheritdoc cref="GraphFrame.IsAutoshrinkEnabled()" />
    public bool IsAutoshrinkEnabled() => ((GraphFrame)_host).IsAutoshrinkEnabled();

    /// <inheritdoc cref="GraphFrame.SetAutoshrinkMargin(int)" />
    public void SetAutoshrinkMargin(int @autoshrinkMargin) => ((GraphFrame)_host).SetAutoshrinkMargin(@autoshrinkMargin);

    /// <inheritdoc cref="GraphFrame.GetAutoshrinkMargin()" />
    public int GetAutoshrinkMargin() => ((GraphFrame)_host).GetAutoshrinkMargin();

    /// <inheritdoc cref="GraphFrame.SetDragMargin(int)" />
    public void SetDragMargin(int @dragMargin) => ((GraphFrame)_host).SetDragMargin(@dragMargin);

    /// <inheritdoc cref="GraphFrame.GetDragMargin()" />
    public int GetDragMargin() => ((GraphFrame)_host).GetDragMargin();

    /// <inheritdoc cref="GraphFrame.SetTintColorEnabled(bool)" />
    public void SetTintColorEnabled(bool @enable) => ((GraphFrame)_host).SetTintColorEnabled(@enable);

    /// <inheritdoc cref="GraphFrame.IsTintColorEnabled()" />
    public bool IsTintColorEnabled() => ((GraphFrame)_host).IsTintColorEnabled();

    /// <inheritdoc cref="GraphFrame.SetTintColor(Color)" />
    public void SetTintColor(Color @color) => ((GraphFrame)_host).SetTintColor(@color);

    /// <inheritdoc cref="GraphFrame.GetTintColor()" />
    public Color GetTintColor() => ((GraphFrame)_host).GetTintColor();

}
