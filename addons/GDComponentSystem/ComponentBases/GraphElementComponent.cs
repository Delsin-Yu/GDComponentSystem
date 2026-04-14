#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GraphElement" />
[Tool, GlobalClass]
public abstract partial class GraphElementComponent : ContainerComponent
{

    /// <inheritdoc cref="GraphElement.SetResizable(bool)" />
    public void SetResizable(bool @resizable) => ((GraphElement)_host).SetResizable(@resizable);

    /// <inheritdoc cref="GraphElement.IsResizable()" />
    public bool IsResizable() => ((GraphElement)_host).IsResizable();

    /// <inheritdoc cref="GraphElement.SetDraggable(bool)" />
    public void SetDraggable(bool @draggable) => ((GraphElement)_host).SetDraggable(@draggable);

    /// <inheritdoc cref="GraphElement.IsDraggable()" />
    public bool IsDraggable() => ((GraphElement)_host).IsDraggable();

    /// <inheritdoc cref="GraphElement.SetSelectable(bool)" />
    public void SetSelectable(bool @selectable) => ((GraphElement)_host).SetSelectable(@selectable);

    /// <inheritdoc cref="GraphElement.IsSelectable()" />
    public bool IsSelectable() => ((GraphElement)_host).IsSelectable();

    /// <inheritdoc cref="GraphElement.SetSelected(bool)" />
    public void SetSelected(bool @selected) => ((GraphElement)_host).SetSelected(@selected);

    /// <inheritdoc cref="GraphElement.IsSelected()" />
    public bool IsSelected() => ((GraphElement)_host).IsSelected();

    /// <inheritdoc cref="GraphElement.SetScalingMenus(bool)" />
    public void SetScalingMenus(bool @scalingMenus) => ((GraphElement)_host).SetScalingMenus(@scalingMenus);

    /// <inheritdoc cref="GraphElement.IsScalingMenus()" />
    public bool IsScalingMenus() => ((GraphElement)_host).IsScalingMenus();

    /// <inheritdoc cref="GraphElement.SetPositionOffset(Vector2)" />
    public void SetPositionOffset(Vector2 @offset) => ((GraphElement)_host).SetPositionOffset(@offset);

    /// <inheritdoc cref="GraphElement.GetPositionOffset()" />
    public Vector2 GetPositionOffset() => ((GraphElement)_host).GetPositionOffset();

}
