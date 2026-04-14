#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="OpenXRCompositionLayerQuad" />
[Tool, GlobalClass]
public abstract partial class OpenXRCompositionLayerQuadComponent : OpenXRCompositionLayerComponent
{

    /// <inheritdoc cref="OpenXRCompositionLayerQuad.SetQuadSize(Vector2)" />
    public void SetQuadSize(Vector2 @size) => ((OpenXRCompositionLayerQuad)_host).SetQuadSize(@size);

    /// <inheritdoc cref="OpenXRCompositionLayerQuad.GetQuadSize()" />
    public Vector2 GetQuadSize() => ((OpenXRCompositionLayerQuad)_host).GetQuadSize();

}
