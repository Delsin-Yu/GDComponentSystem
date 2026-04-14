#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="OpenXRCompositionLayerEquirect" />
[Tool, GlobalClass]
public abstract partial class OpenXRCompositionLayerEquirectComponent : OpenXRCompositionLayerComponent
{

    /// <inheritdoc cref="OpenXRCompositionLayerEquirect.SetRadius(float)" />
    public void SetRadius(float @radius) => ((OpenXRCompositionLayerEquirect)_host).SetRadius(@radius);

    /// <inheritdoc cref="OpenXRCompositionLayerEquirect.GetRadius()" />
    public float GetRadius() => ((OpenXRCompositionLayerEquirect)_host).GetRadius();

    /// <inheritdoc cref="OpenXRCompositionLayerEquirect.SetCentralHorizontalAngle(float)" />
    public void SetCentralHorizontalAngle(float @angle) => ((OpenXRCompositionLayerEquirect)_host).SetCentralHorizontalAngle(@angle);

    /// <inheritdoc cref="OpenXRCompositionLayerEquirect.GetCentralHorizontalAngle()" />
    public float GetCentralHorizontalAngle() => ((OpenXRCompositionLayerEquirect)_host).GetCentralHorizontalAngle();

    /// <inheritdoc cref="OpenXRCompositionLayerEquirect.SetUpperVerticalAngle(float)" />
    public void SetUpperVerticalAngle(float @angle) => ((OpenXRCompositionLayerEquirect)_host).SetUpperVerticalAngle(@angle);

    /// <inheritdoc cref="OpenXRCompositionLayerEquirect.GetUpperVerticalAngle()" />
    public float GetUpperVerticalAngle() => ((OpenXRCompositionLayerEquirect)_host).GetUpperVerticalAngle();

    /// <inheritdoc cref="OpenXRCompositionLayerEquirect.SetLowerVerticalAngle(float)" />
    public void SetLowerVerticalAngle(float @angle) => ((OpenXRCompositionLayerEquirect)_host).SetLowerVerticalAngle(@angle);

    /// <inheritdoc cref="OpenXRCompositionLayerEquirect.GetLowerVerticalAngle()" />
    public float GetLowerVerticalAngle() => ((OpenXRCompositionLayerEquirect)_host).GetLowerVerticalAngle();

    /// <inheritdoc cref="OpenXRCompositionLayerEquirect.SetFallbackSegments(uint)" />
    public void SetFallbackSegments(uint @segments) => ((OpenXRCompositionLayerEquirect)_host).SetFallbackSegments(@segments);

    /// <inheritdoc cref="OpenXRCompositionLayerEquirect.GetFallbackSegments()" />
    public uint GetFallbackSegments() => ((OpenXRCompositionLayerEquirect)_host).GetFallbackSegments();

}
