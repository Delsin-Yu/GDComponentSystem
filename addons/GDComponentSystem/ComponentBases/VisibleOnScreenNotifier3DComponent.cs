#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="VisibleOnScreenNotifier3D" />
[Tool, GlobalClass]
public abstract partial class VisibleOnScreenNotifier3DComponent : VisualInstance3DComponent
{

    /// <inheritdoc cref="VisibleOnScreenNotifier3D.SetAabb(Aabb)" />
    public void SetAabb(Aabb @rect) => ((VisibleOnScreenNotifier3D)_host).SetAabb(@rect);

    /// <inheritdoc cref="VisibleOnScreenNotifier3D.IsOnScreen()" />
    public bool IsOnScreen() => ((VisibleOnScreenNotifier3D)_host).IsOnScreen();

}
