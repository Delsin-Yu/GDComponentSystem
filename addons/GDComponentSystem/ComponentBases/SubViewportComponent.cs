#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="SubViewport" />
[Tool, GlobalClass]
public abstract partial class SubViewportComponent : ViewportComponent
{

    /// <inheritdoc cref="SubViewport.SetSize(Vector2I)" />
    public void SetSize(Vector2I @size) => ((SubViewport)_host).SetSize(@size);

    /// <inheritdoc cref="SubViewport.GetSize()" />
    public Vector2I GetSize() => ((SubViewport)_host).GetSize();

    /// <inheritdoc cref="SubViewport.SetSize2DOverride(Vector2I)" />
    public void SetSize2DOverride(Vector2I @size) => ((SubViewport)_host).SetSize2DOverride(@size);

    /// <inheritdoc cref="SubViewport.GetSize2DOverride()" />
    public Vector2I GetSize2DOverride() => ((SubViewport)_host).GetSize2DOverride();

    /// <inheritdoc cref="SubViewport.SetSize2DOverrideStretch(bool)" />
    public void SetSize2DOverrideStretch(bool @enable) => ((SubViewport)_host).SetSize2DOverrideStretch(@enable);

    /// <inheritdoc cref="SubViewport.IsSize2DOverrideStretchEnabled()" />
    public bool IsSize2DOverrideStretchEnabled() => ((SubViewport)_host).IsSize2DOverrideStretchEnabled();

    /// <inheritdoc cref="SubViewport.SetUpdateMode(SubViewport.UpdateMode)" />
    public void SetUpdateMode(SubViewport.UpdateMode @mode) => ((SubViewport)_host).SetUpdateMode(@mode);

    /// <inheritdoc cref="SubViewport.GetUpdateMode()" />
    public SubViewport.UpdateMode GetUpdateMode() => ((SubViewport)_host).GetUpdateMode();

    /// <inheritdoc cref="SubViewport.SetClearMode(SubViewport.ClearMode)" />
    public void SetClearMode(SubViewport.ClearMode @mode) => ((SubViewport)_host).SetClearMode(@mode);

    /// <inheritdoc cref="SubViewport.GetClearMode()" />
    public SubViewport.ClearMode GetClearMode() => ((SubViewport)_host).GetClearMode();

}
