#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="MultiplayerSpawner" />
[Tool, GlobalClass]
public abstract partial class MultiplayerSpawnerComponent : NodeComponent
{

    /// <inheritdoc cref="MultiplayerSpawner.AddSpawnableScene(string)" />
    public void AddSpawnableScene(string @path) => ((MultiplayerSpawner)_host).AddSpawnableScene(@path);

    /// <inheritdoc cref="MultiplayerSpawner.GetSpawnableSceneCount()" />
    public int GetSpawnableSceneCount() => ((MultiplayerSpawner)_host).GetSpawnableSceneCount();

    /// <inheritdoc cref="MultiplayerSpawner.GetSpawnableScene(int)" />
    public string GetSpawnableScene(int @index) => ((MultiplayerSpawner)_host).GetSpawnableScene(@index);

    /// <inheritdoc cref="MultiplayerSpawner.ClearSpawnableScenes()" />
    public void ClearSpawnableScenes() => ((MultiplayerSpawner)_host).ClearSpawnableScenes();

    /// <inheritdoc cref="MultiplayerSpawner.Spawn(Variant)" />
    public Node Spawn(Variant @data) => ((MultiplayerSpawner)_host).Spawn(@data);

    /// <inheritdoc cref="MultiplayerSpawner.GetSpawnPath()" />
    public NodePath GetSpawnPath() => ((MultiplayerSpawner)_host).GetSpawnPath();

    /// <inheritdoc cref="MultiplayerSpawner.SetSpawnPath(NodePath)" />
    public void SetSpawnPath(NodePath @path) => ((MultiplayerSpawner)_host).SetSpawnPath(@path);

    /// <inheritdoc cref="MultiplayerSpawner.GetSpawnLimit()" />
    public uint GetSpawnLimit() => ((MultiplayerSpawner)_host).GetSpawnLimit();

    /// <inheritdoc cref="MultiplayerSpawner.SetSpawnLimit(uint)" />
    public void SetSpawnLimit(uint @limit) => ((MultiplayerSpawner)_host).SetSpawnLimit(@limit);

    /// <inheritdoc cref="MultiplayerSpawner.GetSpawnFunction()" />
    public Callable GetSpawnFunction() => ((MultiplayerSpawner)_host).GetSpawnFunction();

    /// <inheritdoc cref="MultiplayerSpawner.SetSpawnFunction(Callable)" />
    public void SetSpawnFunction(Callable @spawnFunction) => ((MultiplayerSpawner)_host).SetSpawnFunction(@spawnFunction);

}
