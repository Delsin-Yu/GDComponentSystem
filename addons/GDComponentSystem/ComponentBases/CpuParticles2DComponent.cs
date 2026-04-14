#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CpuParticles2D" />
[Tool, GlobalClass]
public abstract partial class CpuParticles2DComponent : Node2DComponent
{

    /// <inheritdoc cref="CpuParticles2D.SetEmitting(bool)" />
    public void SetEmitting(bool @emitting) => ((CpuParticles2D)_host).SetEmitting(@emitting);

    /// <inheritdoc cref="CpuParticles2D.SetAmount(int)" />
    public void SetAmount(int @amount) => ((CpuParticles2D)_host).SetAmount(@amount);

    /// <inheritdoc cref="CpuParticles2D.SetLifetime(double)" />
    public void SetLifetime(double @secs) => ((CpuParticles2D)_host).SetLifetime(@secs);

    /// <inheritdoc cref="CpuParticles2D.SetOneShot(bool)" />
    public void SetOneShot(bool @enable) => ((CpuParticles2D)_host).SetOneShot(@enable);

    /// <inheritdoc cref="CpuParticles2D.SetPreProcessTime(double)" />
    public void SetPreProcessTime(double @secs) => ((CpuParticles2D)_host).SetPreProcessTime(@secs);

    /// <inheritdoc cref="CpuParticles2D.SetExplosivenessRatio(float)" />
    public void SetExplosivenessRatio(float @ratio) => ((CpuParticles2D)_host).SetExplosivenessRatio(@ratio);

    /// <inheritdoc cref="CpuParticles2D.SetRandomnessRatio(float)" />
    public void SetRandomnessRatio(float @ratio) => ((CpuParticles2D)_host).SetRandomnessRatio(@ratio);

    /// <inheritdoc cref="CpuParticles2D.SetLifetimeRandomness(double)" />
    public void SetLifetimeRandomness(double @random) => ((CpuParticles2D)_host).SetLifetimeRandomness(@random);

    /// <inheritdoc cref="CpuParticles2D.SetUseLocalCoordinates(bool)" />
    public void SetUseLocalCoordinates(bool @enable) => ((CpuParticles2D)_host).SetUseLocalCoordinates(@enable);

    /// <inheritdoc cref="CpuParticles2D.SetFixedFps(int)" />
    public void SetFixedFps(int @fps) => ((CpuParticles2D)_host).SetFixedFps(@fps);

    /// <inheritdoc cref="CpuParticles2D.SetFractionalDelta(bool)" />
    public void SetFractionalDelta(bool @enable) => ((CpuParticles2D)_host).SetFractionalDelta(@enable);

    /// <inheritdoc cref="CpuParticles2D.SetSpeedScale(double)" />
    public void SetSpeedScale(double @scale) => ((CpuParticles2D)_host).SetSpeedScale(@scale);

    /// <inheritdoc cref="CpuParticles2D.RequestParticlesProcess(float)" />
    public void RequestParticlesProcess(float @processTime) => ((CpuParticles2D)_host).RequestParticlesProcess(@processTime);

    /// <inheritdoc cref="CpuParticles2D.IsEmitting()" />
    public bool IsEmitting() => ((CpuParticles2D)_host).IsEmitting();

    /// <inheritdoc cref="CpuParticles2D.GetAmount()" />
    public int GetAmount() => ((CpuParticles2D)_host).GetAmount();

    /// <inheritdoc cref="CpuParticles2D.GetLifetime()" />
    public double GetLifetime() => ((CpuParticles2D)_host).GetLifetime();

    /// <inheritdoc cref="CpuParticles2D.GetOneShot()" />
    public bool GetOneShot() => ((CpuParticles2D)_host).GetOneShot();

    /// <inheritdoc cref="CpuParticles2D.GetPreProcessTime()" />
    public double GetPreProcessTime() => ((CpuParticles2D)_host).GetPreProcessTime();

    /// <inheritdoc cref="CpuParticles2D.GetExplosivenessRatio()" />
    public float GetExplosivenessRatio() => ((CpuParticles2D)_host).GetExplosivenessRatio();

    /// <inheritdoc cref="CpuParticles2D.GetRandomnessRatio()" />
    public float GetRandomnessRatio() => ((CpuParticles2D)_host).GetRandomnessRatio();

    /// <inheritdoc cref="CpuParticles2D.GetLifetimeRandomness()" />
    public double GetLifetimeRandomness() => ((CpuParticles2D)_host).GetLifetimeRandomness();

    /// <inheritdoc cref="CpuParticles2D.GetUseLocalCoordinates()" />
    public bool GetUseLocalCoordinates() => ((CpuParticles2D)_host).GetUseLocalCoordinates();

    /// <inheritdoc cref="CpuParticles2D.GetFixedFps()" />
    public int GetFixedFps() => ((CpuParticles2D)_host).GetFixedFps();

    /// <inheritdoc cref="CpuParticles2D.GetFractionalDelta()" />
    public bool GetFractionalDelta() => ((CpuParticles2D)_host).GetFractionalDelta();

    /// <inheritdoc cref="CpuParticles2D.GetSpeedScale()" />
    public double GetSpeedScale() => ((CpuParticles2D)_host).GetSpeedScale();

    /// <inheritdoc cref="CpuParticles2D.SetUseFixedSeed(bool)" />
    public void SetUseFixedSeed(bool @useFixedSeed) => ((CpuParticles2D)_host).SetUseFixedSeed(@useFixedSeed);

    /// <inheritdoc cref="CpuParticles2D.GetUseFixedSeed()" />
    public bool GetUseFixedSeed() => ((CpuParticles2D)_host).GetUseFixedSeed();

    /// <inheritdoc cref="CpuParticles2D.SetSeed(uint)" />
    public void SetSeed(uint @seed) => ((CpuParticles2D)_host).SetSeed(@seed);

    /// <inheritdoc cref="CpuParticles2D.GetSeed()" />
    public uint GetSeed() => ((CpuParticles2D)_host).GetSeed();

    /// <inheritdoc cref="CpuParticles2D.SetDrawOrder(CpuParticles2D.DrawOrderEnum)" />
    public void SetDrawOrder(CpuParticles2D.DrawOrderEnum @order) => ((CpuParticles2D)_host).SetDrawOrder(@order);

    /// <inheritdoc cref="CpuParticles2D.GetDrawOrder()" />
    public CpuParticles2D.DrawOrderEnum GetDrawOrder() => ((CpuParticles2D)_host).GetDrawOrder();

    /// <inheritdoc cref="CpuParticles2D.SetTexture(Texture2D)" />
    public void SetTexture(Texture2D @texture) => ((CpuParticles2D)_host).SetTexture(@texture);

    /// <inheritdoc cref="CpuParticles2D.GetTexture()" />
    public Texture2D GetTexture() => ((CpuParticles2D)_host).GetTexture();

    /// <inheritdoc cref="CpuParticles2D.Restart(bool)" />
    public void Restart(bool @keepSeed) => ((CpuParticles2D)_host).Restart(@keepSeed);

    /// <inheritdoc cref="CpuParticles2D.SetDirection(Vector2)" />
    public void SetDirection(Vector2 @direction) => ((CpuParticles2D)_host).SetDirection(@direction);

    /// <inheritdoc cref="CpuParticles2D.GetDirection()" />
    public Vector2 GetDirection() => ((CpuParticles2D)_host).GetDirection();

    /// <inheritdoc cref="CpuParticles2D.SetSpread(float)" />
    public void SetSpread(float @spread) => ((CpuParticles2D)_host).SetSpread(@spread);

    /// <inheritdoc cref="CpuParticles2D.GetSpread()" />
    public float GetSpread() => ((CpuParticles2D)_host).GetSpread();

    /// <inheritdoc cref="CpuParticles2D.SetParamMin(CpuParticles2D.Parameter, float)" />
    public void SetParamMin(CpuParticles2D.Parameter @param, float @value) => ((CpuParticles2D)_host).SetParamMin(@param, @value);

    /// <inheritdoc cref="CpuParticles2D.GetParamMin(CpuParticles2D.Parameter)" />
    public float GetParamMin(CpuParticles2D.Parameter @param) => ((CpuParticles2D)_host).GetParamMin(@param);

    /// <inheritdoc cref="CpuParticles2D.SetParamMax(CpuParticles2D.Parameter, float)" />
    public void SetParamMax(CpuParticles2D.Parameter @param, float @value) => ((CpuParticles2D)_host).SetParamMax(@param, @value);

    /// <inheritdoc cref="CpuParticles2D.GetParamMax(CpuParticles2D.Parameter)" />
    public float GetParamMax(CpuParticles2D.Parameter @param) => ((CpuParticles2D)_host).GetParamMax(@param);

    /// <inheritdoc cref="CpuParticles2D.SetParamCurve(CpuParticles2D.Parameter, Curve)" />
    public void SetParamCurve(CpuParticles2D.Parameter @param, Curve @curve) => ((CpuParticles2D)_host).SetParamCurve(@param, @curve);

    /// <inheritdoc cref="CpuParticles2D.GetParamCurve(CpuParticles2D.Parameter)" />
    public Curve GetParamCurve(CpuParticles2D.Parameter @param) => ((CpuParticles2D)_host).GetParamCurve(@param);

    /// <inheritdoc cref="CpuParticles2D.SetColor(Color)" />
    public void SetColor(Color @color) => ((CpuParticles2D)_host).SetColor(@color);

    /// <inheritdoc cref="CpuParticles2D.GetColor()" />
    public Color GetColor() => ((CpuParticles2D)_host).GetColor();

    /// <inheritdoc cref="CpuParticles2D.SetColorRamp(Gradient)" />
    public void SetColorRamp(Gradient @ramp) => ((CpuParticles2D)_host).SetColorRamp(@ramp);

    /// <inheritdoc cref="CpuParticles2D.GetColorRamp()" />
    public Gradient GetColorRamp() => ((CpuParticles2D)_host).GetColorRamp();

    /// <inheritdoc cref="CpuParticles2D.SetColorInitialRamp(Gradient)" />
    public void SetColorInitialRamp(Gradient @ramp) => ((CpuParticles2D)_host).SetColorInitialRamp(@ramp);

    /// <inheritdoc cref="CpuParticles2D.GetColorInitialRamp()" />
    public Gradient GetColorInitialRamp() => ((CpuParticles2D)_host).GetColorInitialRamp();

    /// <inheritdoc cref="CpuParticles2D.SetParticleFlag(CpuParticles2D.ParticleFlags, bool)" />
    public void SetParticleFlag(CpuParticles2D.ParticleFlags @particleFlag, bool @enable) => ((CpuParticles2D)_host).SetParticleFlag(@particleFlag, @enable);

    /// <inheritdoc cref="CpuParticles2D.GetParticleFlag(CpuParticles2D.ParticleFlags)" />
    public bool GetParticleFlag(CpuParticles2D.ParticleFlags @particleFlag) => ((CpuParticles2D)_host).GetParticleFlag(@particleFlag);

    /// <inheritdoc cref="CpuParticles2D.SetEmissionShape(CpuParticles2D.EmissionShapeEnum)" />
    public void SetEmissionShape(CpuParticles2D.EmissionShapeEnum @shape) => ((CpuParticles2D)_host).SetEmissionShape(@shape);

    /// <inheritdoc cref="CpuParticles2D.GetEmissionShape()" />
    public CpuParticles2D.EmissionShapeEnum GetEmissionShape() => ((CpuParticles2D)_host).GetEmissionShape();

    /// <inheritdoc cref="CpuParticles2D.SetEmissionSphereRadius(float)" />
    public void SetEmissionSphereRadius(float @radius) => ((CpuParticles2D)_host).SetEmissionSphereRadius(@radius);

    /// <inheritdoc cref="CpuParticles2D.GetEmissionSphereRadius()" />
    public float GetEmissionSphereRadius() => ((CpuParticles2D)_host).GetEmissionSphereRadius();

    /// <inheritdoc cref="CpuParticles2D.SetEmissionRectExtents(Vector2)" />
    public void SetEmissionRectExtents(Vector2 @extents) => ((CpuParticles2D)_host).SetEmissionRectExtents(@extents);

    /// <inheritdoc cref="CpuParticles2D.GetEmissionRectExtents()" />
    public Vector2 GetEmissionRectExtents() => ((CpuParticles2D)_host).GetEmissionRectExtents();

    /// <inheritdoc cref="CpuParticles2D.SetEmissionPoints(Vector2[])" />
    public void SetEmissionPoints(Vector2[] @array) => ((CpuParticles2D)_host).SetEmissionPoints(@array);

    /// <inheritdoc cref="CpuParticles2D.SetEmissionPoints(ReadOnlySpan{Vector2})" />
    public void SetEmissionPoints(ReadOnlySpan<Vector2> @array) => ((CpuParticles2D)_host).SetEmissionPoints(@array);

    /// <inheritdoc cref="CpuParticles2D.GetEmissionPoints()" />
    public Vector2[] GetEmissionPoints() => ((CpuParticles2D)_host).GetEmissionPoints();

    /// <inheritdoc cref="CpuParticles2D.SetEmissionNormals(Vector2[])" />
    public void SetEmissionNormals(Vector2[] @array) => ((CpuParticles2D)_host).SetEmissionNormals(@array);

    /// <inheritdoc cref="CpuParticles2D.SetEmissionNormals(ReadOnlySpan{Vector2})" />
    public void SetEmissionNormals(ReadOnlySpan<Vector2> @array) => ((CpuParticles2D)_host).SetEmissionNormals(@array);

    /// <inheritdoc cref="CpuParticles2D.GetEmissionNormals()" />
    public Vector2[] GetEmissionNormals() => ((CpuParticles2D)_host).GetEmissionNormals();

    /// <inheritdoc cref="CpuParticles2D.SetEmissionColors(Color[])" />
    public void SetEmissionColors(Color[] @array) => ((CpuParticles2D)_host).SetEmissionColors(@array);

    /// <inheritdoc cref="CpuParticles2D.SetEmissionColors(ReadOnlySpan{Color})" />
    public void SetEmissionColors(ReadOnlySpan<Color> @array) => ((CpuParticles2D)_host).SetEmissionColors(@array);

    /// <inheritdoc cref="CpuParticles2D.GetEmissionColors()" />
    public Color[] GetEmissionColors() => ((CpuParticles2D)_host).GetEmissionColors();

    /// <inheritdoc cref="CpuParticles2D.SetEmissionRingInnerRadius(float)" />
    public void SetEmissionRingInnerRadius(float @innerRadius) => ((CpuParticles2D)_host).SetEmissionRingInnerRadius(@innerRadius);

    /// <inheritdoc cref="CpuParticles2D.GetEmissionRingInnerRadius()" />
    public float GetEmissionRingInnerRadius() => ((CpuParticles2D)_host).GetEmissionRingInnerRadius();

    /// <inheritdoc cref="CpuParticles2D.SetEmissionRingRadius(float)" />
    public void SetEmissionRingRadius(float @radius) => ((CpuParticles2D)_host).SetEmissionRingRadius(@radius);

    /// <inheritdoc cref="CpuParticles2D.GetEmissionRingRadius()" />
    public float GetEmissionRingRadius() => ((CpuParticles2D)_host).GetEmissionRingRadius();

    /// <inheritdoc cref="CpuParticles2D.GetGravity()" />
    public Vector2 GetGravity() => ((CpuParticles2D)_host).GetGravity();

    /// <inheritdoc cref="CpuParticles2D.SetGravity(Vector2)" />
    public void SetGravity(Vector2 @accelVec) => ((CpuParticles2D)_host).SetGravity(@accelVec);

    /// <inheritdoc cref="CpuParticles2D.GetSplitScale()" />
    public bool GetSplitScale() => ((CpuParticles2D)_host).GetSplitScale();

    /// <inheritdoc cref="CpuParticles2D.SetSplitScale(bool)" />
    public void SetSplitScale(bool @splitScale) => ((CpuParticles2D)_host).SetSplitScale(@splitScale);

    /// <inheritdoc cref="CpuParticles2D.GetScaleCurveX()" />
    public Curve GetScaleCurveX() => ((CpuParticles2D)_host).GetScaleCurveX();

    /// <inheritdoc cref="CpuParticles2D.SetScaleCurveX(Curve)" />
    public void SetScaleCurveX(Curve @scaleCurve) => ((CpuParticles2D)_host).SetScaleCurveX(@scaleCurve);

    /// <inheritdoc cref="CpuParticles2D.GetScaleCurveY()" />
    public Curve GetScaleCurveY() => ((CpuParticles2D)_host).GetScaleCurveY();

    /// <inheritdoc cref="CpuParticles2D.SetScaleCurveY(Curve)" />
    public void SetScaleCurveY(Curve @scaleCurve) => ((CpuParticles2D)_host).SetScaleCurveY(@scaleCurve);

    /// <inheritdoc cref="CpuParticles2D.ConvertFromParticles(Node)" />
    public void ConvertFromParticles(Node @particles) => ((CpuParticles2D)_host).ConvertFromParticles(@particles);

    /// <inheritdoc cref="CpuParticles2D.Restart()" />
    public void Restart() => ((CpuParticles2D)_host).Restart();

}
