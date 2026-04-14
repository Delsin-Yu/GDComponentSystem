#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ParallaxLayer" />
[Tool, GlobalClass]
public abstract partial class ParallaxLayerComponent : Node2DComponent
{

    /// <inheritdoc cref="ParallaxLayer.SetMotionScale(Vector2)" />
    public void SetMotionScale(Vector2 @scale) => ((ParallaxLayer)_host).SetMotionScale(@scale);

    /// <inheritdoc cref="ParallaxLayer.GetMotionScale()" />
    public Vector2 GetMotionScale() => ((ParallaxLayer)_host).GetMotionScale();

    /// <inheritdoc cref="ParallaxLayer.SetMotionOffset(Vector2)" />
    public void SetMotionOffset(Vector2 @offset) => ((ParallaxLayer)_host).SetMotionOffset(@offset);

    /// <inheritdoc cref="ParallaxLayer.GetMotionOffset()" />
    public Vector2 GetMotionOffset() => ((ParallaxLayer)_host).GetMotionOffset();

    /// <inheritdoc cref="ParallaxLayer.SetMirroring(Vector2)" />
    public void SetMirroring(Vector2 @mirror) => ((ParallaxLayer)_host).SetMirroring(@mirror);

    /// <inheritdoc cref="ParallaxLayer.GetMirroring()" />
    public Vector2 GetMirroring() => ((ParallaxLayer)_host).GetMirroring();

}
