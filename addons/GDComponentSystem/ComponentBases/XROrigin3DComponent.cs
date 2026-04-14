#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="XROrigin3D" />
[Tool, GlobalClass]
public abstract partial class XROrigin3DComponent : Node3DComponent
{

    /// <inheritdoc cref="XROrigin3D.SetWorldScale(float)" />
    public void SetWorldScale(float @worldScale) => ((XROrigin3D)_host).SetWorldScale(@worldScale);

    /// <inheritdoc cref="XROrigin3D.GetWorldScale()" />
    public float GetWorldScale() => ((XROrigin3D)_host).GetWorldScale();

    /// <inheritdoc cref="XROrigin3D.SetCurrent(bool)" />
    public void SetCurrent(bool @enabled) => ((XROrigin3D)_host).SetCurrent(@enabled);

    /// <inheritdoc cref="XROrigin3D.IsCurrent()" />
    public bool IsCurrent() => ((XROrigin3D)_host).IsCurrent();

}
