#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="LightOccluder2D" />
[Tool, GlobalClass]
public abstract partial class LightOccluder2DComponent : Node2DComponent
{

    /// <inheritdoc cref="LightOccluder2D.SetOccluderPolygon(OccluderPolygon2D)" />
    public void SetOccluderPolygon(OccluderPolygon2D @polygon) => ((LightOccluder2D)_host).SetOccluderPolygon(@polygon);

    /// <inheritdoc cref="LightOccluder2D.GetOccluderPolygon()" />
    public OccluderPolygon2D GetOccluderPolygon() => ((LightOccluder2D)_host).GetOccluderPolygon();

    /// <inheritdoc cref="LightOccluder2D.SetOccluderLightMask(int)" />
    public void SetOccluderLightMask(int @mask) => ((LightOccluder2D)_host).SetOccluderLightMask(@mask);

    /// <inheritdoc cref="LightOccluder2D.GetOccluderLightMask()" />
    public int GetOccluderLightMask() => ((LightOccluder2D)_host).GetOccluderLightMask();

    /// <inheritdoc cref="LightOccluder2D.SetAsSdfCollision(bool)" />
    public void SetAsSdfCollision(bool @enable) => ((LightOccluder2D)_host).SetAsSdfCollision(@enable);

    /// <inheritdoc cref="LightOccluder2D.IsSetAsSdfCollision()" />
    public bool IsSetAsSdfCollision() => ((LightOccluder2D)_host).IsSetAsSdfCollision();

}
