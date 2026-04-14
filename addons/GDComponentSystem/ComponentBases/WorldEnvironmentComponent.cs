#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="WorldEnvironment" />
[Tool, GlobalClass]
public abstract partial class WorldEnvironmentComponent : NodeComponent
{

    /// <inheritdoc cref="WorldEnvironment.SetEnvironment(Environment)" />
    public void SetEnvironment(Environment @env) => ((WorldEnvironment)_host).SetEnvironment(@env);

    /// <inheritdoc cref="WorldEnvironment.GetEnvironment()" />
    public Environment GetEnvironment() => ((WorldEnvironment)_host).GetEnvironment();

    /// <inheritdoc cref="WorldEnvironment.SetCameraAttributes(CameraAttributes)" />
    public void SetCameraAttributes(CameraAttributes @cameraAttributes) => ((WorldEnvironment)_host).SetCameraAttributes(@cameraAttributes);

    /// <inheritdoc cref="WorldEnvironment.GetCameraAttributes()" />
    public CameraAttributes GetCameraAttributes() => ((WorldEnvironment)_host).GetCameraAttributes();

    /// <inheritdoc cref="WorldEnvironment.SetCompositor(Compositor)" />
    public void SetCompositor(Compositor @compositor) => ((WorldEnvironment)_host).SetCompositor(@compositor);

    /// <inheritdoc cref="WorldEnvironment.GetCompositor()" />
    public Compositor GetCompositor() => ((WorldEnvironment)_host).GetCompositor();

}
