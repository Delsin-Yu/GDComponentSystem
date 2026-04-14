#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="TouchScreenButton" />
[Tool, GlobalClass]
public abstract partial class TouchScreenButtonComponent : Node2DComponent
{

    /// <inheritdoc cref="TouchScreenButton.SetTextureNormal(Texture2D)" />
    public void SetTextureNormal(Texture2D @texture) => ((TouchScreenButton)_host).SetTextureNormal(@texture);

    /// <inheritdoc cref="TouchScreenButton.GetTextureNormal()" />
    public Texture2D GetTextureNormal() => ((TouchScreenButton)_host).GetTextureNormal();

    /// <inheritdoc cref="TouchScreenButton.SetTexturePressed(Texture2D)" />
    public void SetTexturePressed(Texture2D @texture) => ((TouchScreenButton)_host).SetTexturePressed(@texture);

    /// <inheritdoc cref="TouchScreenButton.GetTexturePressed()" />
    public Texture2D GetTexturePressed() => ((TouchScreenButton)_host).GetTexturePressed();

    /// <inheritdoc cref="TouchScreenButton.SetBitmask(Bitmap)" />
    public void SetBitmask(Bitmap @bitmask) => ((TouchScreenButton)_host).SetBitmask(@bitmask);

    /// <inheritdoc cref="TouchScreenButton.GetBitmask()" />
    public Bitmap GetBitmask() => ((TouchScreenButton)_host).GetBitmask();

    /// <inheritdoc cref="TouchScreenButton.SetShape(Shape2D)" />
    public void SetShape(Shape2D @shape) => ((TouchScreenButton)_host).SetShape(@shape);

    /// <inheritdoc cref="TouchScreenButton.GetShape()" />
    public Shape2D GetShape() => ((TouchScreenButton)_host).GetShape();

    /// <inheritdoc cref="TouchScreenButton.SetShapeCentered(bool)" />
    public void SetShapeCentered(bool @bool) => ((TouchScreenButton)_host).SetShapeCentered(@bool);

    /// <inheritdoc cref="TouchScreenButton.IsShapeCentered()" />
    public bool IsShapeCentered() => ((TouchScreenButton)_host).IsShapeCentered();

    /// <inheritdoc cref="TouchScreenButton.SetShapeVisible(bool)" />
    public void SetShapeVisible(bool @bool) => ((TouchScreenButton)_host).SetShapeVisible(@bool);

    /// <inheritdoc cref="TouchScreenButton.IsShapeVisible()" />
    public bool IsShapeVisible() => ((TouchScreenButton)_host).IsShapeVisible();

    /// <inheritdoc cref="TouchScreenButton.SetAction(string)" />
    public void SetAction(string @action) => ((TouchScreenButton)_host).SetAction(@action);

    /// <inheritdoc cref="TouchScreenButton.GetAction()" />
    public string GetAction() => ((TouchScreenButton)_host).GetAction();

    /// <inheritdoc cref="TouchScreenButton.SetVisibilityMode(TouchScreenButton.VisibilityModeEnum)" />
    public void SetVisibilityMode(TouchScreenButton.VisibilityModeEnum @mode) => ((TouchScreenButton)_host).SetVisibilityMode(@mode);

    /// <inheritdoc cref="TouchScreenButton.GetVisibilityMode()" />
    public TouchScreenButton.VisibilityModeEnum GetVisibilityMode() => ((TouchScreenButton)_host).GetVisibilityMode();

    /// <inheritdoc cref="TouchScreenButton.SetPassbyPress(bool)" />
    public void SetPassbyPress(bool @enabled) => ((TouchScreenButton)_host).SetPassbyPress(@enabled);

    /// <inheritdoc cref="TouchScreenButton.IsPassbyPressEnabled()" />
    public bool IsPassbyPressEnabled() => ((TouchScreenButton)_host).IsPassbyPressEnabled();

    /// <inheritdoc cref="TouchScreenButton.IsPressed()" />
    public bool IsPressed() => ((TouchScreenButton)_host).IsPressed();

}
