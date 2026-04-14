#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="DirectionalLight2D" />
[Tool, GlobalClass]
public abstract partial class DirectionalLight2DComponent : Light2DComponent
{

    /// <inheritdoc cref="DirectionalLight2D.SetMaxDistance(float)" />
    public void SetMaxDistance(float @pixels) => ((DirectionalLight2D)_host).SetMaxDistance(@pixels);

    /// <inheritdoc cref="DirectionalLight2D.GetMaxDistance()" />
    public float GetMaxDistance() => ((DirectionalLight2D)_host).GetMaxDistance();

}
