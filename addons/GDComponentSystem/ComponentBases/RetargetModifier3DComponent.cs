#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="RetargetModifier3D" />
[Tool, GlobalClass]
public abstract partial class RetargetModifier3DComponent : SkeletonModifier3DComponent
{

    /// <inheritdoc cref="RetargetModifier3D.SetProfile(SkeletonProfile)" />
    public void SetProfile(SkeletonProfile @profile) => ((RetargetModifier3D)_host).SetProfile(@profile);

    /// <inheritdoc cref="RetargetModifier3D.GetProfile()" />
    public SkeletonProfile GetProfile() => ((RetargetModifier3D)_host).GetProfile();

    /// <inheritdoc cref="RetargetModifier3D.SetUseGlobalPose(bool)" />
    public void SetUseGlobalPose(bool @useGlobalPose) => ((RetargetModifier3D)_host).SetUseGlobalPose(@useGlobalPose);

    /// <inheritdoc cref="RetargetModifier3D.IsUsingGlobalPose()" />
    public bool IsUsingGlobalPose() => ((RetargetModifier3D)_host).IsUsingGlobalPose();

    /// <inheritdoc cref="RetargetModifier3D.SetEnableFlags(RetargetModifier3D.TransformFlag)" />
    public void SetEnableFlags(RetargetModifier3D.TransformFlag @enableFlags) => ((RetargetModifier3D)_host).SetEnableFlags(@enableFlags);

    /// <inheritdoc cref="RetargetModifier3D.GetEnableFlags()" />
    public RetargetModifier3D.TransformFlag GetEnableFlags() => ((RetargetModifier3D)_host).GetEnableFlags();

    /// <inheritdoc cref="RetargetModifier3D.SetPositionEnabled(bool)" />
    public void SetPositionEnabled(bool @enabled) => ((RetargetModifier3D)_host).SetPositionEnabled(@enabled);

    /// <inheritdoc cref="RetargetModifier3D.IsPositionEnabled()" />
    public bool IsPositionEnabled() => ((RetargetModifier3D)_host).IsPositionEnabled();

    /// <inheritdoc cref="RetargetModifier3D.SetRotationEnabled(bool)" />
    public void SetRotationEnabled(bool @enabled) => ((RetargetModifier3D)_host).SetRotationEnabled(@enabled);

    /// <inheritdoc cref="RetargetModifier3D.IsRotationEnabled()" />
    public bool IsRotationEnabled() => ((RetargetModifier3D)_host).IsRotationEnabled();

    /// <inheritdoc cref="RetargetModifier3D.SetScaleEnabled(bool)" />
    public void SetScaleEnabled(bool @enabled) => ((RetargetModifier3D)_host).SetScaleEnabled(@enabled);

    /// <inheritdoc cref="RetargetModifier3D.IsScaleEnabled()" />
    public bool IsScaleEnabled() => ((RetargetModifier3D)_host).IsScaleEnabled();

}
