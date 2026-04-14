#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="AudioListener3D" />
[Tool, GlobalClass]
public abstract partial class AudioListener3DComponent : Node3DComponent
{

    /// <inheritdoc cref="AudioListener3D.MakeCurrent()" />
    public void MakeCurrent() => ((AudioListener3D)_host).MakeCurrent();

    /// <inheritdoc cref="AudioListener3D.ClearCurrent()" />
    public void ClearCurrent() => ((AudioListener3D)_host).ClearCurrent();

    /// <inheritdoc cref="AudioListener3D.IsCurrent()" />
    public bool IsCurrent() => ((AudioListener3D)_host).IsCurrent();

    /// <inheritdoc cref="AudioListener3D.GetListenerTransform()" />
    public Transform3D GetListenerTransform() => ((AudioListener3D)_host).GetListenerTransform();

    /// <inheritdoc cref="AudioListener3D.SetDopplerTracking(AudioListener3D.DopplerTrackingEnum)" />
    public void SetDopplerTracking(AudioListener3D.DopplerTrackingEnum @mode) => ((AudioListener3D)_host).SetDopplerTracking(@mode);

    /// <inheritdoc cref="AudioListener3D.GetDopplerTracking()" />
    public AudioListener3D.DopplerTrackingEnum GetDopplerTracking() => ((AudioListener3D)_host).GetDopplerTracking();

}
