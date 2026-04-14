#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="OpenXRCompositionLayerCylinder" />
[Tool, GlobalClass]
public abstract partial class OpenXRCompositionLayerCylinderComponent : OpenXRCompositionLayerComponent
{

    /// <inheritdoc cref="OpenXRCompositionLayerCylinder.SetRadius(float)" />
    public void SetRadius(float @radius) => ((OpenXRCompositionLayerCylinder)_host).SetRadius(@radius);

    /// <inheritdoc cref="OpenXRCompositionLayerCylinder.GetRadius()" />
    public float GetRadius() => ((OpenXRCompositionLayerCylinder)_host).GetRadius();

    /// <inheritdoc cref="OpenXRCompositionLayerCylinder.SetAspectRatio(float)" />
    public void SetAspectRatio(float @aspectRatio) => ((OpenXRCompositionLayerCylinder)_host).SetAspectRatio(@aspectRatio);

    /// <inheritdoc cref="OpenXRCompositionLayerCylinder.GetAspectRatio()" />
    public float GetAspectRatio() => ((OpenXRCompositionLayerCylinder)_host).GetAspectRatio();

    /// <inheritdoc cref="OpenXRCompositionLayerCylinder.SetCentralAngle(float)" />
    public void SetCentralAngle(float @angle) => ((OpenXRCompositionLayerCylinder)_host).SetCentralAngle(@angle);

    /// <inheritdoc cref="OpenXRCompositionLayerCylinder.GetCentralAngle()" />
    public float GetCentralAngle() => ((OpenXRCompositionLayerCylinder)_host).GetCentralAngle();

    /// <inheritdoc cref="OpenXRCompositionLayerCylinder.SetFallbackSegments(uint)" />
    public void SetFallbackSegments(uint @segments) => ((OpenXRCompositionLayerCylinder)_host).SetFallbackSegments(@segments);

    /// <inheritdoc cref="OpenXRCompositionLayerCylinder.GetFallbackSegments()" />
    public uint GetFallbackSegments() => ((OpenXRCompositionLayerCylinder)_host).GetFallbackSegments();

}
