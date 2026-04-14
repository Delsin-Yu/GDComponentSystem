#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="OmniLight3D" />
[Tool, GlobalClass]
public abstract partial class OmniLight3DComponent : Light3DComponent
{

    /// <inheritdoc cref="OmniLight3D.SetShadowMode(OmniLight3D.ShadowMode)" />
    public void SetShadowMode(OmniLight3D.ShadowMode @mode) => ((OmniLight3D)_host).SetShadowMode(@mode);

    /// <inheritdoc cref="OmniLight3D.GetShadowMode()" />
    public OmniLight3D.ShadowMode GetShadowMode() => ((OmniLight3D)_host).GetShadowMode();

}
