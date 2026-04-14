#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="MultiMeshInstance2D" />
[Tool, GlobalClass]
public abstract partial class MultiMeshInstance2DComponent : Node2DComponent
{

    /// <inheritdoc cref="MultiMeshInstance2D.SetMultimesh(MultiMesh)" />
    public void SetMultimesh(MultiMesh @multimesh) => ((MultiMeshInstance2D)_host).SetMultimesh(@multimesh);

    /// <inheritdoc cref="MultiMeshInstance2D.GetMultimesh()" />
    public MultiMesh GetMultimesh() => ((MultiMeshInstance2D)_host).GetMultimesh();

    /// <inheritdoc cref="MultiMeshInstance2D.SetTexture(Texture2D)" />
    public void SetTexture(Texture2D @texture) => ((MultiMeshInstance2D)_host).SetTexture(@texture);

    /// <inheritdoc cref="MultiMeshInstance2D.GetTexture()" />
    public Texture2D GetTexture() => ((MultiMeshInstance2D)_host).GetTexture();

}
