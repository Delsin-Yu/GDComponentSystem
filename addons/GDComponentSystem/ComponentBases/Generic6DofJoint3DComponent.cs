#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Generic6DofJoint3D" />
[Tool, GlobalClass]
public abstract partial class Generic6DofJoint3DComponent : Joint3DComponent
{

    /// <inheritdoc cref="Generic6DofJoint3D.SetParamX(Generic6DofJoint3D.Param, float)" />
    public void SetParamX(Generic6DofJoint3D.Param @param, float @value) => ((Generic6DofJoint3D)_host).SetParamX(@param, @value);

    /// <inheritdoc cref="Generic6DofJoint3D.GetParamX(Generic6DofJoint3D.Param)" />
    public float GetParamX(Generic6DofJoint3D.Param @param) => ((Generic6DofJoint3D)_host).GetParamX(@param);

    /// <inheritdoc cref="Generic6DofJoint3D.SetParamY(Generic6DofJoint3D.Param, float)" />
    public void SetParamY(Generic6DofJoint3D.Param @param, float @value) => ((Generic6DofJoint3D)_host).SetParamY(@param, @value);

    /// <inheritdoc cref="Generic6DofJoint3D.GetParamY(Generic6DofJoint3D.Param)" />
    public float GetParamY(Generic6DofJoint3D.Param @param) => ((Generic6DofJoint3D)_host).GetParamY(@param);

    /// <inheritdoc cref="Generic6DofJoint3D.SetParamZ(Generic6DofJoint3D.Param, float)" />
    public void SetParamZ(Generic6DofJoint3D.Param @param, float @value) => ((Generic6DofJoint3D)_host).SetParamZ(@param, @value);

    /// <inheritdoc cref="Generic6DofJoint3D.GetParamZ(Generic6DofJoint3D.Param)" />
    public float GetParamZ(Generic6DofJoint3D.Param @param) => ((Generic6DofJoint3D)_host).GetParamZ(@param);

    /// <inheritdoc cref="Generic6DofJoint3D.SetFlagX(Generic6DofJoint3D.Flag, bool)" />
    public void SetFlagX(Generic6DofJoint3D.Flag @flag, bool @value) => ((Generic6DofJoint3D)_host).SetFlagX(@flag, @value);

    /// <inheritdoc cref="Generic6DofJoint3D.GetFlagX(Generic6DofJoint3D.Flag)" />
    public bool GetFlagX(Generic6DofJoint3D.Flag @flag) => ((Generic6DofJoint3D)_host).GetFlagX(@flag);

    /// <inheritdoc cref="Generic6DofJoint3D.SetFlagY(Generic6DofJoint3D.Flag, bool)" />
    public void SetFlagY(Generic6DofJoint3D.Flag @flag, bool @value) => ((Generic6DofJoint3D)_host).SetFlagY(@flag, @value);

    /// <inheritdoc cref="Generic6DofJoint3D.GetFlagY(Generic6DofJoint3D.Flag)" />
    public bool GetFlagY(Generic6DofJoint3D.Flag @flag) => ((Generic6DofJoint3D)_host).GetFlagY(@flag);

    /// <inheritdoc cref="Generic6DofJoint3D.SetFlagZ(Generic6DofJoint3D.Flag, bool)" />
    public void SetFlagZ(Generic6DofJoint3D.Flag @flag, bool @value) => ((Generic6DofJoint3D)_host).SetFlagZ(@flag, @value);

    /// <inheritdoc cref="Generic6DofJoint3D.GetFlagZ(Generic6DofJoint3D.Flag)" />
    public bool GetFlagZ(Generic6DofJoint3D.Flag @flag) => ((Generic6DofJoint3D)_host).GetFlagZ(@flag);

}
