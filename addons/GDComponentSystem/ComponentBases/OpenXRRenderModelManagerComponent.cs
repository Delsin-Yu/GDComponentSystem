#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="OpenXRRenderModelManager" />
[Tool, GlobalClass]
public abstract partial class OpenXRRenderModelManagerComponent : Node3DComponent
{

    /// <inheritdoc cref="OpenXRRenderModelManager.GetTracker()" />
    public OpenXRRenderModelManager.RenderModelTracker GetTracker() => ((OpenXRRenderModelManager)_host).GetTracker();

    /// <inheritdoc cref="OpenXRRenderModelManager.SetTracker(OpenXRRenderModelManager.RenderModelTracker)" />
    public void SetTracker(OpenXRRenderModelManager.RenderModelTracker @tracker) => ((OpenXRRenderModelManager)_host).SetTracker(@tracker);

    /// <inheritdoc cref="OpenXRRenderModelManager.GetMakeLocalToPose()" />
    public string GetMakeLocalToPose() => ((OpenXRRenderModelManager)_host).GetMakeLocalToPose();

    /// <inheritdoc cref="OpenXRRenderModelManager.SetMakeLocalToPose(string)" />
    public void SetMakeLocalToPose(string @makeLocalToPose) => ((OpenXRRenderModelManager)_host).SetMakeLocalToPose(@makeLocalToPose);

}
