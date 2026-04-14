#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="BoxContainer" />
[Tool, GlobalClass]
public abstract partial class BoxContainerComponent : ContainerComponent
{

    /// <inheritdoc cref="BoxContainer.AddSpacer(bool)" />
    public Control AddSpacer(bool @begin) => ((BoxContainer)_host).AddSpacer(@begin);

    /// <inheritdoc cref="BoxContainer.SetAlignment(BoxContainer.AlignmentMode)" />
    public void SetAlignment(BoxContainer.AlignmentMode @alignment) => ((BoxContainer)_host).SetAlignment(@alignment);

    /// <inheritdoc cref="BoxContainer.GetAlignment()" />
    public BoxContainer.AlignmentMode GetAlignment() => ((BoxContainer)_host).GetAlignment();

    /// <inheritdoc cref="BoxContainer.SetVertical(bool)" />
    public void SetVertical(bool @vertical) => ((BoxContainer)_host).SetVertical(@vertical);

    /// <inheritdoc cref="BoxContainer.IsVertical()" />
    public bool IsVertical() => ((BoxContainer)_host).IsVertical();

}
