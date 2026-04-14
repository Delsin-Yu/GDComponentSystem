#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="XRNode3D" />
[Tool, GlobalClass]
public abstract partial class XRNode3DComponent : Node3DComponent
{

    /// <inheritdoc cref="XRNode3D.SetTracker(StringName)" />
    public void SetTracker(StringName @trackerName) => ((XRNode3D)_host).SetTracker(@trackerName);

    /// <inheritdoc cref="XRNode3D.GetTracker()" />
    public StringName GetTracker() => ((XRNode3D)_host).GetTracker();

    /// <inheritdoc cref="XRNode3D.SetPoseName(StringName)" />
    public void SetPoseName(StringName @pose) => ((XRNode3D)_host).SetPoseName(@pose);

    /// <inheritdoc cref="XRNode3D.GetPoseName()" />
    public StringName GetPoseName() => ((XRNode3D)_host).GetPoseName();

    /// <inheritdoc cref="XRNode3D.SetShowWhenTracked(bool)" />
    public void SetShowWhenTracked(bool @show) => ((XRNode3D)_host).SetShowWhenTracked(@show);

    /// <inheritdoc cref="XRNode3D.GetShowWhenTracked()" />
    public bool GetShowWhenTracked() => ((XRNode3D)_host).GetShowWhenTracked();

    /// <inheritdoc cref="XRNode3D.GetIsActive()" />
    public bool GetIsActive() => ((XRNode3D)_host).GetIsActive();

    /// <inheritdoc cref="XRNode3D.GetHasTrackingData()" />
    public bool GetHasTrackingData() => ((XRNode3D)_host).GetHasTrackingData();

    /// <inheritdoc cref="XRNode3D.GetPose()" />
    public XRPose GetPose() => ((XRNode3D)_host).GetPose();

    /// <inheritdoc cref="XRNode3D.TriggerHapticPulse(string, double, double, double, double)" />
    public void TriggerHapticPulse(string @actionName, double @frequency, double @amplitude, double @durationSec, double @delaySec) => ((XRNode3D)_host).TriggerHapticPulse(@actionName, @frequency, @amplitude, @durationSec, @delaySec);

}
