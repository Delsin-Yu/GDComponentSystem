#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="OpenXRRenderModel" />
[Tool, GlobalClass]
public abstract partial class OpenXRRenderModelComponent : Node3DComponent
{

    /// <inheritdoc cref="OpenXRRenderModel.GetTopLevelPath()" />
    public string GetTopLevelPath() => ((OpenXRRenderModel)_host).GetTopLevelPath();

    /// <inheritdoc cref="OpenXRRenderModel.GetRenderModel()" />
    public Rid GetRenderModel() => ((OpenXRRenderModel)_host).GetRenderModel();

    /// <inheritdoc cref="OpenXRRenderModel.SetRenderModel(Rid)" />
    public void SetRenderModel(Rid @renderModel) => ((OpenXRRenderModel)_host).SetRenderModel(@renderModel);

}
