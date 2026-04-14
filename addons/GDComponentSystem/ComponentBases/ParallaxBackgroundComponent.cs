#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ParallaxBackground" />
[Tool, GlobalClass]
public abstract partial class ParallaxBackgroundComponent : CanvasLayerComponent
{

    /// <inheritdoc cref="ParallaxBackground.SetScrollOffset(Vector2)" />
    public void SetScrollOffset(Vector2 @offset) => ((ParallaxBackground)_host).SetScrollOffset(@offset);

    /// <inheritdoc cref="ParallaxBackground.GetScrollOffset()" />
    public Vector2 GetScrollOffset() => ((ParallaxBackground)_host).GetScrollOffset();

    /// <inheritdoc cref="ParallaxBackground.SetScrollBaseOffset(Vector2)" />
    public void SetScrollBaseOffset(Vector2 @offset) => ((ParallaxBackground)_host).SetScrollBaseOffset(@offset);

    /// <inheritdoc cref="ParallaxBackground.GetScrollBaseOffset()" />
    public Vector2 GetScrollBaseOffset() => ((ParallaxBackground)_host).GetScrollBaseOffset();

    /// <inheritdoc cref="ParallaxBackground.SetScrollBaseScale(Vector2)" />
    public void SetScrollBaseScale(Vector2 @scale) => ((ParallaxBackground)_host).SetScrollBaseScale(@scale);

    /// <inheritdoc cref="ParallaxBackground.GetScrollBaseScale()" />
    public Vector2 GetScrollBaseScale() => ((ParallaxBackground)_host).GetScrollBaseScale();

    /// <inheritdoc cref="ParallaxBackground.SetLimitBegin(Vector2)" />
    public void SetLimitBegin(Vector2 @offset) => ((ParallaxBackground)_host).SetLimitBegin(@offset);

    /// <inheritdoc cref="ParallaxBackground.GetLimitBegin()" />
    public Vector2 GetLimitBegin() => ((ParallaxBackground)_host).GetLimitBegin();

    /// <inheritdoc cref="ParallaxBackground.SetLimitEnd(Vector2)" />
    public void SetLimitEnd(Vector2 @offset) => ((ParallaxBackground)_host).SetLimitEnd(@offset);

    /// <inheritdoc cref="ParallaxBackground.GetLimitEnd()" />
    public Vector2 GetLimitEnd() => ((ParallaxBackground)_host).GetLimitEnd();

    /// <inheritdoc cref="ParallaxBackground.SetIgnoreCameraZoom(bool)" />
    public void SetIgnoreCameraZoom(bool @ignore) => ((ParallaxBackground)_host).SetIgnoreCameraZoom(@ignore);

    /// <inheritdoc cref="ParallaxBackground.IsIgnoreCameraZoom()" />
    public bool IsIgnoreCameraZoom() => ((ParallaxBackground)_host).IsIgnoreCameraZoom();

}
