#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="AnimatedSprite3D" />
[Tool, GlobalClass]
public abstract partial class AnimatedSprite3DComponent : SpriteBase3DComponent
{

    /// <inheritdoc cref="AnimatedSprite3D.SetSpriteFrames(SpriteFrames)" />
    public void SetSpriteFrames(SpriteFrames @spriteFrames) => ((AnimatedSprite3D)_host).SetSpriteFrames(@spriteFrames);

    /// <inheritdoc cref="AnimatedSprite3D.GetSpriteFrames()" />
    public SpriteFrames GetSpriteFrames() => ((AnimatedSprite3D)_host).GetSpriteFrames();

    /// <inheritdoc cref="AnimatedSprite3D.SetAnimation(StringName)" />
    public void SetAnimation(StringName @name) => ((AnimatedSprite3D)_host).SetAnimation(@name);

    /// <inheritdoc cref="AnimatedSprite3D.GetAnimation()" />
    public StringName GetAnimation() => ((AnimatedSprite3D)_host).GetAnimation();

    /// <inheritdoc cref="AnimatedSprite3D.SetAutoplay(string)" />
    public void SetAutoplay(string @name) => ((AnimatedSprite3D)_host).SetAutoplay(@name);

    /// <inheritdoc cref="AnimatedSprite3D.GetAutoplay()" />
    public string GetAutoplay() => ((AnimatedSprite3D)_host).GetAutoplay();

    /// <inheritdoc cref="AnimatedSprite3D.IsPlaying()" />
    public bool IsPlaying() => ((AnimatedSprite3D)_host).IsPlaying();

    /// <inheritdoc cref="AnimatedSprite3D.Play(StringName, float, bool)" />
    public void Play(StringName @name, float @customSpeed, bool @fromEnd) => ((AnimatedSprite3D)_host).Play(@name, @customSpeed, @fromEnd);

    /// <inheritdoc cref="AnimatedSprite3D.PlayBackwards(StringName)" />
    public void PlayBackwards(StringName @name) => ((AnimatedSprite3D)_host).PlayBackwards(@name);

    /// <inheritdoc cref="AnimatedSprite3D.Pause()" />
    public void Pause() => ((AnimatedSprite3D)_host).Pause();

    /// <inheritdoc cref="AnimatedSprite3D.Stop()" />
    public void Stop() => ((AnimatedSprite3D)_host).Stop();

    /// <inheritdoc cref="AnimatedSprite3D.SetFrame(int)" />
    public void SetFrame(int @frame) => ((AnimatedSprite3D)_host).SetFrame(@frame);

    /// <inheritdoc cref="AnimatedSprite3D.GetFrame()" />
    public int GetFrame() => ((AnimatedSprite3D)_host).GetFrame();

    /// <inheritdoc cref="AnimatedSprite3D.SetFrameProgress(float)" />
    public void SetFrameProgress(float @progress) => ((AnimatedSprite3D)_host).SetFrameProgress(@progress);

    /// <inheritdoc cref="AnimatedSprite3D.GetFrameProgress()" />
    public float GetFrameProgress() => ((AnimatedSprite3D)_host).GetFrameProgress();

    /// <inheritdoc cref="AnimatedSprite3D.SetFrameAndProgress(int, float)" />
    public void SetFrameAndProgress(int @frame, float @progress) => ((AnimatedSprite3D)_host).SetFrameAndProgress(@frame, @progress);

    /// <inheritdoc cref="AnimatedSprite3D.SetSpeedScale(float)" />
    public void SetSpeedScale(float @speedScale) => ((AnimatedSprite3D)_host).SetSpeedScale(@speedScale);

    /// <inheritdoc cref="AnimatedSprite3D.GetSpeedScale()" />
    public float GetSpeedScale() => ((AnimatedSprite3D)_host).GetSpeedScale();

    /// <inheritdoc cref="AnimatedSprite3D.GetPlayingSpeed()" />
    public float GetPlayingSpeed() => ((AnimatedSprite3D)_host).GetPlayingSpeed();

}
