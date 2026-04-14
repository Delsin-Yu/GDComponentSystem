#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CenterContainer" />
[Tool, GlobalClass]
public abstract partial class CenterContainerComponent : ContainerComponent
{

    /// <inheritdoc cref="CenterContainer.SetUseTopLeft(bool)" />
    public void SetUseTopLeft(bool @enable) => ((CenterContainer)_host).SetUseTopLeft(@enable);

    /// <inheritdoc cref="CenterContainer.IsUsingTopLeft()" />
    public bool IsUsingTopLeft() => ((CenterContainer)_host).IsUsingTopLeft();

}
