#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GpuParticles3D" />
[Tool, GlobalClass]
public abstract partial class GpuParticles3DComponent : GeometryInstance3DComponent
{

    /// <inheritdoc cref="GpuParticles3D.SetEmitting(bool)" />
    public void SetEmitting(bool @emitting) => ((GpuParticles3D)_host).SetEmitting(@emitting);

    /// <inheritdoc cref="GpuParticles3D.SetAmount(int)" />
    public void SetAmount(int @amount) => ((GpuParticles3D)_host).SetAmount(@amount);

    /// <inheritdoc cref="GpuParticles3D.SetLifetime(double)" />
    public void SetLifetime(double @secs) => ((GpuParticles3D)_host).SetLifetime(@secs);

    /// <inheritdoc cref="GpuParticles3D.SetOneShot(bool)" />
    public void SetOneShot(bool @enable) => ((GpuParticles3D)_host).SetOneShot(@enable);

    /// <inheritdoc cref="GpuParticles3D.SetPreProcessTime(double)" />
    public void SetPreProcessTime(double @secs) => ((GpuParticles3D)_host).SetPreProcessTime(@secs);

    /// <inheritdoc cref="GpuParticles3D.SetExplosivenessRatio(float)" />
    public void SetExplosivenessRatio(float @ratio) => ((GpuParticles3D)_host).SetExplosivenessRatio(@ratio);

    /// <inheritdoc cref="GpuParticles3D.SetRandomnessRatio(float)" />
    public void SetRandomnessRatio(float @ratio) => ((GpuParticles3D)_host).SetRandomnessRatio(@ratio);

    /// <inheritdoc cref="GpuParticles3D.SetVisibilityAabb(Aabb)" />
    public void SetVisibilityAabb(Aabb @aabb) => ((GpuParticles3D)_host).SetVisibilityAabb(@aabb);

    /// <inheritdoc cref="GpuParticles3D.SetUseLocalCoordinates(bool)" />
    public void SetUseLocalCoordinates(bool @enable) => ((GpuParticles3D)_host).SetUseLocalCoordinates(@enable);

    /// <inheritdoc cref="GpuParticles3D.SetFixedFps(int)" />
    public void SetFixedFps(int @fps) => ((GpuParticles3D)_host).SetFixedFps(@fps);

    /// <inheritdoc cref="GpuParticles3D.SetFractionalDelta(bool)" />
    public void SetFractionalDelta(bool @enable) => ((GpuParticles3D)_host).SetFractionalDelta(@enable);

    /// <inheritdoc cref="GpuParticles3D.SetInterpolate(bool)" />
    public void SetInterpolate(bool @enable) => ((GpuParticles3D)_host).SetInterpolate(@enable);

    /// <inheritdoc cref="GpuParticles3D.SetProcessMaterial(Material)" />
    public void SetProcessMaterial(Material @material) => ((GpuParticles3D)_host).SetProcessMaterial(@material);

    /// <inheritdoc cref="GpuParticles3D.SetSpeedScale(double)" />
    public void SetSpeedScale(double @scale) => ((GpuParticles3D)_host).SetSpeedScale(@scale);

    /// <inheritdoc cref="GpuParticles3D.SetCollisionBaseSize(float)" />
    public void SetCollisionBaseSize(float @size) => ((GpuParticles3D)_host).SetCollisionBaseSize(@size);

    /// <inheritdoc cref="GpuParticles3D.SetInterpToEnd(float)" />
    public void SetInterpToEnd(float @interp) => ((GpuParticles3D)_host).SetInterpToEnd(@interp);

    /// <inheritdoc cref="GpuParticles3D.IsEmitting()" />
    public bool IsEmitting() => ((GpuParticles3D)_host).IsEmitting();

    /// <inheritdoc cref="GpuParticles3D.GetAmount()" />
    public int GetAmount() => ((GpuParticles3D)_host).GetAmount();

    /// <inheritdoc cref="GpuParticles3D.GetLifetime()" />
    public double GetLifetime() => ((GpuParticles3D)_host).GetLifetime();

    /// <inheritdoc cref="GpuParticles3D.GetOneShot()" />
    public bool GetOneShot() => ((GpuParticles3D)_host).GetOneShot();

    /// <inheritdoc cref="GpuParticles3D.GetPreProcessTime()" />
    public double GetPreProcessTime() => ((GpuParticles3D)_host).GetPreProcessTime();

    /// <inheritdoc cref="GpuParticles3D.GetExplosivenessRatio()" />
    public float GetExplosivenessRatio() => ((GpuParticles3D)_host).GetExplosivenessRatio();

    /// <inheritdoc cref="GpuParticles3D.GetRandomnessRatio()" />
    public float GetRandomnessRatio() => ((GpuParticles3D)_host).GetRandomnessRatio();

    /// <inheritdoc cref="GpuParticles3D.GetVisibilityAabb()" />
    public Aabb GetVisibilityAabb() => ((GpuParticles3D)_host).GetVisibilityAabb();

    /// <inheritdoc cref="GpuParticles3D.GetUseLocalCoordinates()" />
    public bool GetUseLocalCoordinates() => ((GpuParticles3D)_host).GetUseLocalCoordinates();

    /// <inheritdoc cref="GpuParticles3D.GetFixedFps()" />
    public int GetFixedFps() => ((GpuParticles3D)_host).GetFixedFps();

    /// <inheritdoc cref="GpuParticles3D.GetFractionalDelta()" />
    public bool GetFractionalDelta() => ((GpuParticles3D)_host).GetFractionalDelta();

    /// <inheritdoc cref="GpuParticles3D.GetInterpolate()" />
    public bool GetInterpolate() => ((GpuParticles3D)_host).GetInterpolate();

    /// <inheritdoc cref="GpuParticles3D.GetProcessMaterial()" />
    public Material GetProcessMaterial() => ((GpuParticles3D)_host).GetProcessMaterial();

    /// <inheritdoc cref="GpuParticles3D.GetSpeedScale()" />
    public double GetSpeedScale() => ((GpuParticles3D)_host).GetSpeedScale();

    /// <inheritdoc cref="GpuParticles3D.GetCollisionBaseSize()" />
    public float GetCollisionBaseSize() => ((GpuParticles3D)_host).GetCollisionBaseSize();

    /// <inheritdoc cref="GpuParticles3D.GetInterpToEnd()" />
    public float GetInterpToEnd() => ((GpuParticles3D)_host).GetInterpToEnd();

    /// <inheritdoc cref="GpuParticles3D.SetUseFixedSeed(bool)" />
    public void SetUseFixedSeed(bool @useFixedSeed) => ((GpuParticles3D)_host).SetUseFixedSeed(@useFixedSeed);

    /// <inheritdoc cref="GpuParticles3D.GetUseFixedSeed()" />
    public bool GetUseFixedSeed() => ((GpuParticles3D)_host).GetUseFixedSeed();

    /// <inheritdoc cref="GpuParticles3D.SetSeed(uint)" />
    public void SetSeed(uint @seed) => ((GpuParticles3D)_host).SetSeed(@seed);

    /// <inheritdoc cref="GpuParticles3D.GetSeed()" />
    public uint GetSeed() => ((GpuParticles3D)_host).GetSeed();

    /// <inheritdoc cref="GpuParticles3D.SetDrawOrder(GpuParticles3D.DrawOrderEnum)" />
    public void SetDrawOrder(GpuParticles3D.DrawOrderEnum @order) => ((GpuParticles3D)_host).SetDrawOrder(@order);

    /// <inheritdoc cref="GpuParticles3D.GetDrawOrder()" />
    public GpuParticles3D.DrawOrderEnum GetDrawOrder() => ((GpuParticles3D)_host).GetDrawOrder();

    /// <inheritdoc cref="GpuParticles3D.SetDrawPasses(int)" />
    public void SetDrawPasses(int @passes) => ((GpuParticles3D)_host).SetDrawPasses(@passes);

    /// <inheritdoc cref="GpuParticles3D.SetDrawPassMesh(int, Mesh)" />
    public void SetDrawPassMesh(int @pass, Mesh @mesh) => ((GpuParticles3D)_host).SetDrawPassMesh(@pass, @mesh);

    /// <inheritdoc cref="GpuParticles3D.GetDrawPasses()" />
    public int GetDrawPasses() => ((GpuParticles3D)_host).GetDrawPasses();

    /// <inheritdoc cref="GpuParticles3D.GetDrawPassMesh(int)" />
    public Mesh GetDrawPassMesh(int @pass) => ((GpuParticles3D)_host).GetDrawPassMesh(@pass);

    /// <inheritdoc cref="GpuParticles3D.SetSkin(Skin)" />
    public void SetSkin(Skin @skin) => ((GpuParticles3D)_host).SetSkin(@skin);

    /// <inheritdoc cref="GpuParticles3D.GetSkin()" />
    public Skin GetSkin() => ((GpuParticles3D)_host).GetSkin();

    /// <inheritdoc cref="GpuParticles3D.Restart(bool)" />
    public void Restart(bool @keepSeed) => ((GpuParticles3D)_host).Restart(@keepSeed);

    /// <inheritdoc cref="GpuParticles3D.CaptureAabb()" />
    public Aabb CaptureAabb() => ((GpuParticles3D)_host).CaptureAabb();

    /// <inheritdoc cref="GpuParticles3D.SetSubEmitter(NodePath)" />
    public void SetSubEmitter(NodePath @path) => ((GpuParticles3D)_host).SetSubEmitter(@path);

    /// <inheritdoc cref="GpuParticles3D.GetSubEmitter()" />
    public NodePath GetSubEmitter() => ((GpuParticles3D)_host).GetSubEmitter();

    /// <inheritdoc cref="GpuParticles3D.EmitParticle(Transform3D, Vector3, Color, Color, uint)" />
    public void EmitParticle(Transform3D @xform, Vector3 @velocity, Color @color, Color @custom, uint @flags) => ((GpuParticles3D)_host).EmitParticle(@xform, @velocity, @color, @custom, @flags);

    /// <inheritdoc cref="GpuParticles3D.SetTrailEnabled(bool)" />
    public void SetTrailEnabled(bool @enabled) => ((GpuParticles3D)_host).SetTrailEnabled(@enabled);

    /// <inheritdoc cref="GpuParticles3D.SetTrailLifetime(double)" />
    public void SetTrailLifetime(double @secs) => ((GpuParticles3D)_host).SetTrailLifetime(@secs);

    /// <inheritdoc cref="GpuParticles3D.IsTrailEnabled()" />
    public bool IsTrailEnabled() => ((GpuParticles3D)_host).IsTrailEnabled();

    /// <inheritdoc cref="GpuParticles3D.GetTrailLifetime()" />
    public double GetTrailLifetime() => ((GpuParticles3D)_host).GetTrailLifetime();

    /// <inheritdoc cref="GpuParticles3D.SetTransformAlign(GpuParticles3D.TransformAlignEnum)" />
    public void SetTransformAlign(GpuParticles3D.TransformAlignEnum @align) => ((GpuParticles3D)_host).SetTransformAlign(@align);

    /// <inheritdoc cref="GpuParticles3D.GetTransformAlign()" />
    public GpuParticles3D.TransformAlignEnum GetTransformAlign() => ((GpuParticles3D)_host).GetTransformAlign();

    /// <inheritdoc cref="GpuParticles3D.ConvertFromParticles(Node)" />
    public void ConvertFromParticles(Node @particles) => ((GpuParticles3D)_host).ConvertFromParticles(@particles);

    /// <inheritdoc cref="GpuParticles3D.SetAmountRatio(float)" />
    public void SetAmountRatio(float @ratio) => ((GpuParticles3D)_host).SetAmountRatio(@ratio);

    /// <inheritdoc cref="GpuParticles3D.GetAmountRatio()" />
    public float GetAmountRatio() => ((GpuParticles3D)_host).GetAmountRatio();

    /// <inheritdoc cref="GpuParticles3D.RequestParticlesProcess(float)" />
    public void RequestParticlesProcess(float @processTime) => ((GpuParticles3D)_host).RequestParticlesProcess(@processTime);

    /// <inheritdoc cref="GpuParticles3D.Restart()" />
    public void Restart() => ((GpuParticles3D)_host).Restart();

}
