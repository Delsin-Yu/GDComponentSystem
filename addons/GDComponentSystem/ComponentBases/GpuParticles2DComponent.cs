#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GpuParticles2D" />
[Tool, GlobalClass]
public abstract partial class GpuParticles2DComponent : Node2DComponent
{

    /// <inheritdoc cref="GpuParticles2D.SetEmitting(bool)" />
    public void SetEmitting(bool @emitting) => ((GpuParticles2D)_host).SetEmitting(@emitting);

    /// <inheritdoc cref="GpuParticles2D.SetAmount(int)" />
    public void SetAmount(int @amount) => ((GpuParticles2D)_host).SetAmount(@amount);

    /// <inheritdoc cref="GpuParticles2D.SetLifetime(double)" />
    public void SetLifetime(double @secs) => ((GpuParticles2D)_host).SetLifetime(@secs);

    /// <inheritdoc cref="GpuParticles2D.SetOneShot(bool)" />
    public void SetOneShot(bool @secs) => ((GpuParticles2D)_host).SetOneShot(@secs);

    /// <inheritdoc cref="GpuParticles2D.SetPreProcessTime(double)" />
    public void SetPreProcessTime(double @secs) => ((GpuParticles2D)_host).SetPreProcessTime(@secs);

    /// <inheritdoc cref="GpuParticles2D.SetExplosivenessRatio(float)" />
    public void SetExplosivenessRatio(float @ratio) => ((GpuParticles2D)_host).SetExplosivenessRatio(@ratio);

    /// <inheritdoc cref="GpuParticles2D.SetRandomnessRatio(float)" />
    public void SetRandomnessRatio(float @ratio) => ((GpuParticles2D)_host).SetRandomnessRatio(@ratio);

    /// <inheritdoc cref="GpuParticles2D.SetVisibilityRect(Rect2)" />
    public void SetVisibilityRect(Rect2 @visibilityRect) => ((GpuParticles2D)_host).SetVisibilityRect(@visibilityRect);

    /// <inheritdoc cref="GpuParticles2D.SetUseLocalCoordinates(bool)" />
    public void SetUseLocalCoordinates(bool @enable) => ((GpuParticles2D)_host).SetUseLocalCoordinates(@enable);

    /// <inheritdoc cref="GpuParticles2D.SetFixedFps(int)" />
    public void SetFixedFps(int @fps) => ((GpuParticles2D)_host).SetFixedFps(@fps);

    /// <inheritdoc cref="GpuParticles2D.SetFractionalDelta(bool)" />
    public void SetFractionalDelta(bool @enable) => ((GpuParticles2D)_host).SetFractionalDelta(@enable);

    /// <inheritdoc cref="GpuParticles2D.SetInterpolate(bool)" />
    public void SetInterpolate(bool @enable) => ((GpuParticles2D)_host).SetInterpolate(@enable);

    /// <inheritdoc cref="GpuParticles2D.SetProcessMaterial(Material)" />
    public void SetProcessMaterial(Material @material) => ((GpuParticles2D)_host).SetProcessMaterial(@material);

    /// <inheritdoc cref="GpuParticles2D.SetSpeedScale(double)" />
    public void SetSpeedScale(double @scale) => ((GpuParticles2D)_host).SetSpeedScale(@scale);

    /// <inheritdoc cref="GpuParticles2D.SetCollisionBaseSize(float)" />
    public void SetCollisionBaseSize(float @size) => ((GpuParticles2D)_host).SetCollisionBaseSize(@size);

    /// <inheritdoc cref="GpuParticles2D.SetInterpToEnd(float)" />
    public void SetInterpToEnd(float @interp) => ((GpuParticles2D)_host).SetInterpToEnd(@interp);

    /// <inheritdoc cref="GpuParticles2D.RequestParticlesProcess(float)" />
    public void RequestParticlesProcess(float @processTime) => ((GpuParticles2D)_host).RequestParticlesProcess(@processTime);

    /// <inheritdoc cref="GpuParticles2D.IsEmitting()" />
    public bool IsEmitting() => ((GpuParticles2D)_host).IsEmitting();

    /// <inheritdoc cref="GpuParticles2D.GetAmount()" />
    public int GetAmount() => ((GpuParticles2D)_host).GetAmount();

    /// <inheritdoc cref="GpuParticles2D.GetLifetime()" />
    public double GetLifetime() => ((GpuParticles2D)_host).GetLifetime();

    /// <inheritdoc cref="GpuParticles2D.GetOneShot()" />
    public bool GetOneShot() => ((GpuParticles2D)_host).GetOneShot();

    /// <inheritdoc cref="GpuParticles2D.GetPreProcessTime()" />
    public double GetPreProcessTime() => ((GpuParticles2D)_host).GetPreProcessTime();

    /// <inheritdoc cref="GpuParticles2D.GetExplosivenessRatio()" />
    public float GetExplosivenessRatio() => ((GpuParticles2D)_host).GetExplosivenessRatio();

    /// <inheritdoc cref="GpuParticles2D.GetRandomnessRatio()" />
    public float GetRandomnessRatio() => ((GpuParticles2D)_host).GetRandomnessRatio();

    /// <inheritdoc cref="GpuParticles2D.GetVisibilityRect()" />
    public Rect2 GetVisibilityRect() => ((GpuParticles2D)_host).GetVisibilityRect();

    /// <inheritdoc cref="GpuParticles2D.GetUseLocalCoordinates()" />
    public bool GetUseLocalCoordinates() => ((GpuParticles2D)_host).GetUseLocalCoordinates();

    /// <inheritdoc cref="GpuParticles2D.GetFixedFps()" />
    public int GetFixedFps() => ((GpuParticles2D)_host).GetFixedFps();

    /// <inheritdoc cref="GpuParticles2D.GetFractionalDelta()" />
    public bool GetFractionalDelta() => ((GpuParticles2D)_host).GetFractionalDelta();

    /// <inheritdoc cref="GpuParticles2D.GetInterpolate()" />
    public bool GetInterpolate() => ((GpuParticles2D)_host).GetInterpolate();

    /// <inheritdoc cref="GpuParticles2D.GetProcessMaterial()" />
    public Material GetProcessMaterial() => ((GpuParticles2D)_host).GetProcessMaterial();

    /// <inheritdoc cref="GpuParticles2D.GetSpeedScale()" />
    public double GetSpeedScale() => ((GpuParticles2D)_host).GetSpeedScale();

    /// <inheritdoc cref="GpuParticles2D.GetCollisionBaseSize()" />
    public float GetCollisionBaseSize() => ((GpuParticles2D)_host).GetCollisionBaseSize();

    /// <inheritdoc cref="GpuParticles2D.GetInterpToEnd()" />
    public float GetInterpToEnd() => ((GpuParticles2D)_host).GetInterpToEnd();

    /// <inheritdoc cref="GpuParticles2D.SetDrawOrder(GpuParticles2D.DrawOrderEnum)" />
    public void SetDrawOrder(GpuParticles2D.DrawOrderEnum @order) => ((GpuParticles2D)_host).SetDrawOrder(@order);

    /// <inheritdoc cref="GpuParticles2D.GetDrawOrder()" />
    public GpuParticles2D.DrawOrderEnum GetDrawOrder() => ((GpuParticles2D)_host).GetDrawOrder();

    /// <inheritdoc cref="GpuParticles2D.SetTexture(Texture2D)" />
    public void SetTexture(Texture2D @texture) => ((GpuParticles2D)_host).SetTexture(@texture);

    /// <inheritdoc cref="GpuParticles2D.GetTexture()" />
    public Texture2D GetTexture() => ((GpuParticles2D)_host).GetTexture();

    /// <inheritdoc cref="GpuParticles2D.CaptureRect()" />
    public Rect2 CaptureRect() => ((GpuParticles2D)_host).CaptureRect();

    /// <inheritdoc cref="GpuParticles2D.Restart(bool)" />
    public void Restart(bool @keepSeed) => ((GpuParticles2D)_host).Restart(@keepSeed);

    /// <inheritdoc cref="GpuParticles2D.SetSubEmitter(NodePath)" />
    public void SetSubEmitter(NodePath @path) => ((GpuParticles2D)_host).SetSubEmitter(@path);

    /// <inheritdoc cref="GpuParticles2D.GetSubEmitter()" />
    public NodePath GetSubEmitter() => ((GpuParticles2D)_host).GetSubEmitter();

    /// <inheritdoc cref="GpuParticles2D.EmitParticle(Transform2D, Vector2, Color, Color, uint)" />
    public void EmitParticle(Transform2D @xform, Vector2 @velocity, Color @color, Color @custom, uint @flags) => ((GpuParticles2D)_host).EmitParticle(@xform, @velocity, @color, @custom, @flags);

    /// <inheritdoc cref="GpuParticles2D.SetTrailEnabled(bool)" />
    public void SetTrailEnabled(bool @enabled) => ((GpuParticles2D)_host).SetTrailEnabled(@enabled);

    /// <inheritdoc cref="GpuParticles2D.SetTrailLifetime(double)" />
    public void SetTrailLifetime(double @secs) => ((GpuParticles2D)_host).SetTrailLifetime(@secs);

    /// <inheritdoc cref="GpuParticles2D.IsTrailEnabled()" />
    public bool IsTrailEnabled() => ((GpuParticles2D)_host).IsTrailEnabled();

    /// <inheritdoc cref="GpuParticles2D.GetTrailLifetime()" />
    public double GetTrailLifetime() => ((GpuParticles2D)_host).GetTrailLifetime();

    /// <inheritdoc cref="GpuParticles2D.SetTrailSections(int)" />
    public void SetTrailSections(int @sections) => ((GpuParticles2D)_host).SetTrailSections(@sections);

    /// <inheritdoc cref="GpuParticles2D.GetTrailSections()" />
    public int GetTrailSections() => ((GpuParticles2D)_host).GetTrailSections();

    /// <inheritdoc cref="GpuParticles2D.SetTrailSectionSubdivisions(int)" />
    public void SetTrailSectionSubdivisions(int @subdivisions) => ((GpuParticles2D)_host).SetTrailSectionSubdivisions(@subdivisions);

    /// <inheritdoc cref="GpuParticles2D.GetTrailSectionSubdivisions()" />
    public int GetTrailSectionSubdivisions() => ((GpuParticles2D)_host).GetTrailSectionSubdivisions();

    /// <inheritdoc cref="GpuParticles2D.ConvertFromParticles(Node)" />
    public void ConvertFromParticles(Node @particles) => ((GpuParticles2D)_host).ConvertFromParticles(@particles);

    /// <inheritdoc cref="GpuParticles2D.SetAmountRatio(float)" />
    public void SetAmountRatio(float @ratio) => ((GpuParticles2D)_host).SetAmountRatio(@ratio);

    /// <inheritdoc cref="GpuParticles2D.GetAmountRatio()" />
    public float GetAmountRatio() => ((GpuParticles2D)_host).GetAmountRatio();

    /// <inheritdoc cref="GpuParticles2D.SetUseFixedSeed(bool)" />
    public void SetUseFixedSeed(bool @useFixedSeed) => ((GpuParticles2D)_host).SetUseFixedSeed(@useFixedSeed);

    /// <inheritdoc cref="GpuParticles2D.GetUseFixedSeed()" />
    public bool GetUseFixedSeed() => ((GpuParticles2D)_host).GetUseFixedSeed();

    /// <inheritdoc cref="GpuParticles2D.SetSeed(uint)" />
    public void SetSeed(uint @seed) => ((GpuParticles2D)_host).SetSeed(@seed);

    /// <inheritdoc cref="GpuParticles2D.GetSeed()" />
    public uint GetSeed() => ((GpuParticles2D)_host).GetSeed();

    /// <inheritdoc cref="GpuParticles2D.Restart()" />
    public void Restart() => ((GpuParticles2D)_host).Restart();

}
