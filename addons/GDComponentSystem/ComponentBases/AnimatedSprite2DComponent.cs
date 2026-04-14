#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="AnimatedSprite2D" />
[Tool, GlobalClass]
public abstract partial class AnimatedSprite2DComponent : Node2DComponent
{

    /// <inheritdoc cref="AnimatedSprite2D.SetSpriteFrames(SpriteFrames)" />
    public void SetSpriteFrames(SpriteFrames @spriteFrames) => ((AnimatedSprite2D)_host).SetSpriteFrames(@spriteFrames);

    /// <inheritdoc cref="AnimatedSprite2D.GetSpriteFrames()" />
    public SpriteFrames GetSpriteFrames() => ((AnimatedSprite2D)_host).GetSpriteFrames();

    /// <inheritdoc cref="AnimatedSprite2D.SetAnimation(StringName)" />
    public void SetAnimation(StringName @name) => ((AnimatedSprite2D)_host).SetAnimation(@name);

    /// <inheritdoc cref="AnimatedSprite2D.GetAnimation()" />
    public StringName GetAnimation() => ((AnimatedSprite2D)_host).GetAnimation();

    /// <inheritdoc cref="AnimatedSprite2D.SetAutoplay(string)" />
    public void SetAutoplay(string @name) => ((AnimatedSprite2D)_host).SetAutoplay(@name);

    /// <inheritdoc cref="AnimatedSprite2D.GetAutoplay()" />
    public string GetAutoplay() => ((AnimatedSprite2D)_host).GetAutoplay();

    /// <inheritdoc cref="AnimatedSprite2D.IsPlaying()" />
    public bool IsPlaying() => ((AnimatedSprite2D)_host).IsPlaying();

    /// <inheritdoc cref="AnimatedSprite2D.Play(StringName, float, bool)" />
    public void Play(StringName @name, float @customSpeed, bool @fromEnd) => ((AnimatedSprite2D)_host).Play(@name, @customSpeed, @fromEnd);

    /// <inheritdoc cref="AnimatedSprite2D.PlayBackwards(StringName)" />
    public void PlayBackwards(StringName @name) => ((AnimatedSprite2D)_host).PlayBackwards(@name);

    /// <inheritdoc cref="AnimatedSprite2D.Pause()" />
    public void Pause() => ((AnimatedSprite2D)_host).Pause();

    /// <inheritdoc cref="AnimatedSprite2D.Stop()" />
    public void Stop() => ((AnimatedSprite2D)_host).Stop();

    /// <inheritdoc cref="AnimatedSprite2D.SetCentered(bool)" />
    public void SetCentered(bool @centered) => ((AnimatedSprite2D)_host).SetCentered(@centered);

    /// <inheritdoc cref="AnimatedSprite2D.IsCentered()" />
    public bool IsCentered() => ((AnimatedSprite2D)_host).IsCentered();

    /// <inheritdoc cref="AnimatedSprite2D.SetOffset(Vector2)" />
    public void SetOffset(Vector2 @offset) => ((AnimatedSprite2D)_host).SetOffset(@offset);

    /// <inheritdoc cref="AnimatedSprite2D.GetOffset()" />
    public Vector2 GetOffset() => ((AnimatedSprite2D)_host).GetOffset();

    /// <inheritdoc cref="AnimatedSprite2D.SetFlipH(bool)" />
    public void SetFlipH(bool @flipH) => ((AnimatedSprite2D)_host).SetFlipH(@flipH);

    /// <inheritdoc cref="AnimatedSprite2D.IsFlippedH()" />
    public bool IsFlippedH() => ((AnimatedSprite2D)_host).IsFlippedH();

    /// <inheritdoc cref="AnimatedSprite2D.SetFlipV(bool)" />
    public void SetFlipV(bool @flipV) => ((AnimatedSprite2D)_host).SetFlipV(@flipV);

    /// <inheritdoc cref="AnimatedSprite2D.IsFlippedV()" />
    public bool IsFlippedV() => ((AnimatedSprite2D)_host).IsFlippedV();

    /// <inheritdoc cref="AnimatedSprite2D.SetFrame(int)" />
    public void SetFrame(int @frame) => ((AnimatedSprite2D)_host).SetFrame(@frame);

    /// <inheritdoc cref="AnimatedSprite2D.GetFrame()" />
    public int GetFrame() => ((AnimatedSprite2D)_host).GetFrame();

    /// <inheritdoc cref="AnimatedSprite2D.SetFrameProgress(float)" />
    public void SetFrameProgress(float @progress) => ((AnimatedSprite2D)_host).SetFrameProgress(@progress);

    /// <inheritdoc cref="AnimatedSprite2D.GetFrameProgress()" />
    public float GetFrameProgress() => ((AnimatedSprite2D)_host).GetFrameProgress();

    /// <inheritdoc cref="AnimatedSprite2D.SetFrameAndProgress(int, float)" />
    public void SetFrameAndProgress(int @frame, float @progress) => ((AnimatedSprite2D)_host).SetFrameAndProgress(@frame, @progress);

    /// <inheritdoc cref="AnimatedSprite2D.SetSpeedScale(float)" />
    public void SetSpeedScale(float @speedScale) => ((AnimatedSprite2D)_host).SetSpeedScale(@speedScale);

    /// <inheritdoc cref="AnimatedSprite2D.GetSpeedScale()" />
    public float GetSpeedScale() => ((AnimatedSprite2D)_host).GetSpeedScale();

    /// <inheritdoc cref="AnimatedSprite2D.GetPlayingSpeed()" />
    public float GetPlayingSpeed() => ((AnimatedSprite2D)_host).GetPlayingSpeed();

}
