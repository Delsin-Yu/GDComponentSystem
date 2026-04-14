#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="BackBufferCopy" />
[Tool, GlobalClass]
public abstract partial class BackBufferCopyComponent : Node2DComponent
{

    /// <inheritdoc cref="BackBufferCopy.SetRect(Rect2)" />
    public void SetRect(Rect2 @rect) => ((BackBufferCopy)_host).SetRect(@rect);

    /// <inheritdoc cref="BackBufferCopy.GetRect()" />
    public Rect2 GetRect() => ((BackBufferCopy)_host).GetRect();

    /// <inheritdoc cref="BackBufferCopy.SetCopyMode(BackBufferCopy.CopyModeEnum)" />
    public void SetCopyMode(BackBufferCopy.CopyModeEnum @copyMode) => ((BackBufferCopy)_host).SetCopyMode(@copyMode);

    /// <inheritdoc cref="BackBufferCopy.GetCopyMode()" />
    public BackBufferCopy.CopyModeEnum GetCopyMode() => ((BackBufferCopy)_host).GetCopyMode();

}
