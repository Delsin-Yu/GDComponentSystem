#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Timer" />
[Tool, GlobalClass]
public abstract partial class TimerComponent : NodeComponent
{

    /// <inheritdoc cref="Timer.SetWaitTime(double)" />
    public void SetWaitTime(double @timeSec) => ((Timer)_host).SetWaitTime(@timeSec);

    /// <inheritdoc cref="Timer.GetWaitTime()" />
    public double GetWaitTime() => ((Timer)_host).GetWaitTime();

    /// <inheritdoc cref="Timer.SetOneShot(bool)" />
    public void SetOneShot(bool @enable) => ((Timer)_host).SetOneShot(@enable);

    /// <inheritdoc cref="Timer.IsOneShot()" />
    public bool IsOneShot() => ((Timer)_host).IsOneShot();

    /// <inheritdoc cref="Timer.SetAutostart(bool)" />
    public void SetAutostart(bool @enable) => ((Timer)_host).SetAutostart(@enable);

    /// <inheritdoc cref="Timer.HasAutostart()" />
    public bool HasAutostart() => ((Timer)_host).HasAutostart();

    /// <inheritdoc cref="Timer.Start(double)" />
    public void Start(double @timeSec) => ((Timer)_host).Start(@timeSec);

    /// <inheritdoc cref="Timer.Stop()" />
    public void Stop() => ((Timer)_host).Stop();

    /// <inheritdoc cref="Timer.SetPaused(bool)" />
    public void SetPaused(bool @paused) => ((Timer)_host).SetPaused(@paused);

    /// <inheritdoc cref="Timer.IsPaused()" />
    public bool IsPaused() => ((Timer)_host).IsPaused();

    /// <inheritdoc cref="Timer.SetIgnoreTimeScale(bool)" />
    public void SetIgnoreTimeScale(bool @ignore) => ((Timer)_host).SetIgnoreTimeScale(@ignore);

    /// <inheritdoc cref="Timer.IsIgnoringTimeScale()" />
    public bool IsIgnoringTimeScale() => ((Timer)_host).IsIgnoringTimeScale();

    /// <inheritdoc cref="Timer.IsStopped()" />
    public bool IsStopped() => ((Timer)_host).IsStopped();

    /// <inheritdoc cref="Timer.GetTimeLeft()" />
    public double GetTimeLeft() => ((Timer)_host).GetTimeLeft();

    /// <inheritdoc cref="Timer.SetTimerProcessCallback(Timer.TimerProcessCallback)" />
    public void SetTimerProcessCallback(Timer.TimerProcessCallback @callback) => ((Timer)_host).SetTimerProcessCallback(@callback);

    /// <inheritdoc cref="Timer.GetTimerProcessCallback()" />
    public Timer.TimerProcessCallback GetTimerProcessCallback() => ((Timer)_host).GetTimerProcessCallback();

}
