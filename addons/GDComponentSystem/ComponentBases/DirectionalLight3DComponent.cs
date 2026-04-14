#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="DirectionalLight3D" />
[Tool, GlobalClass]
public abstract partial class DirectionalLight3DComponent : Light3DComponent
{

    /// <inheritdoc cref="DirectionalLight3D.SetShadowMode(DirectionalLight3D.ShadowMode)" />
    public void SetShadowMode(DirectionalLight3D.ShadowMode @mode) => ((DirectionalLight3D)_host).SetShadowMode(@mode);

    /// <inheritdoc cref="DirectionalLight3D.GetShadowMode()" />
    public DirectionalLight3D.ShadowMode GetShadowMode() => ((DirectionalLight3D)_host).GetShadowMode();

    /// <inheritdoc cref="DirectionalLight3D.SetBlendSplits(bool)" />
    public void SetBlendSplits(bool @enabled) => ((DirectionalLight3D)_host).SetBlendSplits(@enabled);

    /// <inheritdoc cref="DirectionalLight3D.IsBlendSplitsEnabled()" />
    public bool IsBlendSplitsEnabled() => ((DirectionalLight3D)_host).IsBlendSplitsEnabled();

    /// <inheritdoc cref="DirectionalLight3D.SetSkyMode(DirectionalLight3D.SkyModeEnum)" />
    public void SetSkyMode(DirectionalLight3D.SkyModeEnum @mode) => ((DirectionalLight3D)_host).SetSkyMode(@mode);

    /// <inheritdoc cref="DirectionalLight3D.GetSkyMode()" />
    public DirectionalLight3D.SkyModeEnum GetSkyMode() => ((DirectionalLight3D)_host).GetSkyMode();

}
