#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="SubViewportContainer" />
[Tool, GlobalClass]
public abstract partial class SubViewportContainerComponent : ContainerComponent
{

    /// <inheritdoc cref="SubViewportContainer._PropagateInputEvent(InputEvent)" />
    public virtual bool _PropagateInputEvent(InputEvent @event) => ((SubViewportContainer)_host)._PropagateInputEvent(@event);

    /// <inheritdoc cref="SubViewportContainer.SetStretch(bool)" />
    public void SetStretch(bool @enable) => ((SubViewportContainer)_host).SetStretch(@enable);

    /// <inheritdoc cref="SubViewportContainer.IsStretchEnabled()" />
    public bool IsStretchEnabled() => ((SubViewportContainer)_host).IsStretchEnabled();

    /// <inheritdoc cref="SubViewportContainer.SetStretchShrink(int)" />
    public void SetStretchShrink(int @amount) => ((SubViewportContainer)_host).SetStretchShrink(@amount);

    /// <inheritdoc cref="SubViewportContainer.GetStretchShrink()" />
    public int GetStretchShrink() => ((SubViewportContainer)_host).GetStretchShrink();

    /// <inheritdoc cref="SubViewportContainer.SetMouseTarget(bool)" />
    public void SetMouseTarget(bool @amount) => ((SubViewportContainer)_host).SetMouseTarget(@amount);

    /// <inheritdoc cref="SubViewportContainer.IsMouseTargetEnabled()" />
    public bool IsMouseTargetEnabled() => ((SubViewportContainer)_host).IsMouseTargetEnabled();

}
