#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="AudioListener2D" />
[Tool, GlobalClass]
public abstract partial class AudioListener2DComponent : Node2DComponent
{

    /// <inheritdoc cref="AudioListener2D.MakeCurrent()" />
    public void MakeCurrent() => ((AudioListener2D)_host).MakeCurrent();

    /// <inheritdoc cref="AudioListener2D.ClearCurrent()" />
    public void ClearCurrent() => ((AudioListener2D)_host).ClearCurrent();

    /// <inheritdoc cref="AudioListener2D.IsCurrent()" />
    public bool IsCurrent() => ((AudioListener2D)_host).IsCurrent();

}
