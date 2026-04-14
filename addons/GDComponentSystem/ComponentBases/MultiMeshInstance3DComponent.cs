#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="MultiMeshInstance3D" />
[Tool, GlobalClass]
public abstract partial class MultiMeshInstance3DComponent : GeometryInstance3DComponent
{

    /// <inheritdoc cref="MultiMeshInstance3D.SetMultimesh(MultiMesh)" />
    public void SetMultimesh(MultiMesh @multimesh) => ((MultiMeshInstance3D)_host).SetMultimesh(@multimesh);

    /// <inheritdoc cref="MultiMeshInstance3D.GetMultimesh()" />
    public MultiMesh GetMultimesh() => ((MultiMeshInstance3D)_host).GetMultimesh();

}
