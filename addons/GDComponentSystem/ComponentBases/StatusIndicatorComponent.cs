#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="StatusIndicator" />
[Tool, GlobalClass]
public abstract partial class StatusIndicatorComponent : NodeComponent
{

    /// <inheritdoc cref="StatusIndicator.SetTooltip(string)" />
    public void SetTooltip(string @tooltip) => ((StatusIndicator)_host).SetTooltip(@tooltip);

    /// <inheritdoc cref="StatusIndicator.GetTooltip()" />
    public string GetTooltip() => ((StatusIndicator)_host).GetTooltip();

    /// <inheritdoc cref="StatusIndicator.SetIcon(Texture2D)" />
    public void SetIcon(Texture2D @texture) => ((StatusIndicator)_host).SetIcon(@texture);

    /// <inheritdoc cref="StatusIndicator.GetIcon()" />
    public Texture2D GetIcon() => ((StatusIndicator)_host).GetIcon();

    /// <inheritdoc cref="StatusIndicator.SetVisible(bool)" />
    public void SetVisible(bool @visible) => ((StatusIndicator)_host).SetVisible(@visible);

    /// <inheritdoc cref="StatusIndicator.IsVisible()" />
    public bool IsVisible() => ((StatusIndicator)_host).IsVisible();

    /// <inheritdoc cref="StatusIndicator.SetMenu(NodePath)" />
    public void SetMenu(NodePath @menu) => ((StatusIndicator)_host).SetMenu(@menu);

    /// <inheritdoc cref="StatusIndicator.GetMenu()" />
    public NodePath GetMenu() => ((StatusIndicator)_host).GetMenu();

    /// <inheritdoc cref="StatusIndicator.GetRect()" />
    public Rect2 GetRect() => ((StatusIndicator)_host).GetRect();

}
