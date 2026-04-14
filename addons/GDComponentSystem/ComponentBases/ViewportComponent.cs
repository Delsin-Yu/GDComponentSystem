#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Viewport" />
[Tool, GlobalClass]
public abstract partial class ViewportComponent : NodeComponent
{

    /// <inheritdoc cref="Viewport.SetWorld2D(World2D)" />
    public void SetWorld2D(World2D @world2D) => ((Viewport)_host).SetWorld2D(@world2D);

    /// <inheritdoc cref="Viewport.GetWorld2D()" />
    public World2D GetWorld2D() => ((Viewport)_host).GetWorld2D();

    /// <inheritdoc cref="Viewport.FindWorld2D()" />
    public World2D FindWorld2D() => ((Viewport)_host).FindWorld2D();

    /// <inheritdoc cref="Viewport.SetCanvasTransform(Transform2D)" />
    public void SetCanvasTransform(Transform2D @xform) => ((Viewport)_host).SetCanvasTransform(@xform);

    /// <inheritdoc cref="Viewport.GetCanvasTransform()" />
    public Transform2D GetCanvasTransform() => ((Viewport)_host).GetCanvasTransform();

    /// <inheritdoc cref="Viewport.SetGlobalCanvasTransform(Transform2D)" />
    public void SetGlobalCanvasTransform(Transform2D @xform) => ((Viewport)_host).SetGlobalCanvasTransform(@xform);

    /// <inheritdoc cref="Viewport.GetGlobalCanvasTransform()" />
    public Transform2D GetGlobalCanvasTransform() => ((Viewport)_host).GetGlobalCanvasTransform();

    /// <inheritdoc cref="Viewport.GetStretchTransform()" />
    public Transform2D GetStretchTransform() => ((Viewport)_host).GetStretchTransform();

    /// <inheritdoc cref="Viewport.GetFinalTransform()" />
    public Transform2D GetFinalTransform() => ((Viewport)_host).GetFinalTransform();

    /// <inheritdoc cref="Viewport.GetScreenTransform()" />
    public Transform2D GetScreenTransform() => ((Viewport)_host).GetScreenTransform();

    /// <inheritdoc cref="Viewport.GetVisibleRect()" />
    public Rect2 GetVisibleRect() => ((Viewport)_host).GetVisibleRect();

    /// <inheritdoc cref="Viewport.SetTransparentBackground(bool)" />
    public void SetTransparentBackground(bool @enable) => ((Viewport)_host).SetTransparentBackground(@enable);

    /// <inheritdoc cref="Viewport.HasTransparentBackground()" />
    public bool HasTransparentBackground() => ((Viewport)_host).HasTransparentBackground();

    /// <inheritdoc cref="Viewport.SetUseHdr2D(bool)" />
    public void SetUseHdr2D(bool @enable) => ((Viewport)_host).SetUseHdr2D(@enable);

    /// <inheritdoc cref="Viewport.IsUsingHdr2D()" />
    public bool IsUsingHdr2D() => ((Viewport)_host).IsUsingHdr2D();

    /// <inheritdoc cref="Viewport.SetMsaa2D(Viewport.Msaa)" />
    public void SetMsaa2D(Viewport.Msaa @msaa) => ((Viewport)_host).SetMsaa2D(@msaa);

    /// <inheritdoc cref="Viewport.GetMsaa2D()" />
    public Viewport.Msaa GetMsaa2D() => ((Viewport)_host).GetMsaa2D();

    /// <inheritdoc cref="Viewport.SetMsaa3D(Viewport.Msaa)" />
    public void SetMsaa3D(Viewport.Msaa @msaa) => ((Viewport)_host).SetMsaa3D(@msaa);

    /// <inheritdoc cref="Viewport.GetMsaa3D()" />
    public Viewport.Msaa GetMsaa3D() => ((Viewport)_host).GetMsaa3D();

    /// <inheritdoc cref="Viewport.SetScreenSpaceAA(Viewport.ScreenSpaceAAEnum)" />
    public void SetScreenSpaceAA(Viewport.ScreenSpaceAAEnum @screenSpaceAA) => ((Viewport)_host).SetScreenSpaceAA(@screenSpaceAA);

    /// <inheritdoc cref="Viewport.GetScreenSpaceAA()" />
    public Viewport.ScreenSpaceAAEnum GetScreenSpaceAA() => ((Viewport)_host).GetScreenSpaceAA();

    /// <inheritdoc cref="Viewport.SetUseTaa(bool)" />
    public void SetUseTaa(bool @enable) => ((Viewport)_host).SetUseTaa(@enable);

    /// <inheritdoc cref="Viewport.IsUsingTaa()" />
    public bool IsUsingTaa() => ((Viewport)_host).IsUsingTaa();

    /// <inheritdoc cref="Viewport.SetUseDebanding(bool)" />
    public void SetUseDebanding(bool @enable) => ((Viewport)_host).SetUseDebanding(@enable);

    /// <inheritdoc cref="Viewport.IsUsingDebanding()" />
    public bool IsUsingDebanding() => ((Viewport)_host).IsUsingDebanding();

    /// <inheritdoc cref="Viewport.SetUseOcclusionCulling(bool)" />
    public void SetUseOcclusionCulling(bool @enable) => ((Viewport)_host).SetUseOcclusionCulling(@enable);

    /// <inheritdoc cref="Viewport.IsUsingOcclusionCulling()" />
    public bool IsUsingOcclusionCulling() => ((Viewport)_host).IsUsingOcclusionCulling();

    /// <inheritdoc cref="Viewport.SetDebugDraw(Viewport.DebugDrawEnum)" />
    public void SetDebugDraw(Viewport.DebugDrawEnum @debugDraw) => ((Viewport)_host).SetDebugDraw(@debugDraw);

    /// <inheritdoc cref="Viewport.GetDebugDraw()" />
    public Viewport.DebugDrawEnum GetDebugDraw() => ((Viewport)_host).GetDebugDraw();

    /// <inheritdoc cref="Viewport.SetUseOversampling(bool)" />
    public void SetUseOversampling(bool @enable) => ((Viewport)_host).SetUseOversampling(@enable);

    /// <inheritdoc cref="Viewport.IsUsingOversampling()" />
    public bool IsUsingOversampling() => ((Viewport)_host).IsUsingOversampling();

    /// <inheritdoc cref="Viewport.SetOversamplingOverride(float)" />
    public void SetOversamplingOverride(float @oversampling) => ((Viewport)_host).SetOversamplingOverride(@oversampling);

    /// <inheritdoc cref="Viewport.GetOversamplingOverride()" />
    public float GetOversamplingOverride() => ((Viewport)_host).GetOversamplingOverride();

    /// <inheritdoc cref="Viewport.GetOversampling()" />
    public float GetOversampling() => ((Viewport)_host).GetOversampling();

    /// <inheritdoc cref="Viewport.GetRenderInfo(Viewport.RenderInfoType, Viewport.RenderInfo)" />
    public int GetRenderInfo(Viewport.RenderInfoType @type, Viewport.RenderInfo @info) => ((Viewport)_host).GetRenderInfo(@type, @info);

    /// <inheritdoc cref="Viewport.GetTexture()" />
    public ViewportTexture GetTexture() => ((Viewport)_host).GetTexture();

    /// <inheritdoc cref="Viewport.SetPhysicsObjectPicking(bool)" />
    public void SetPhysicsObjectPicking(bool @enable) => ((Viewport)_host).SetPhysicsObjectPicking(@enable);

    /// <inheritdoc cref="Viewport.GetPhysicsObjectPicking()" />
    public bool GetPhysicsObjectPicking() => ((Viewport)_host).GetPhysicsObjectPicking();

    /// <inheritdoc cref="Viewport.SetPhysicsObjectPickingSort(bool)" />
    public void SetPhysicsObjectPickingSort(bool @enable) => ((Viewport)_host).SetPhysicsObjectPickingSort(@enable);

    /// <inheritdoc cref="Viewport.GetPhysicsObjectPickingSort()" />
    public bool GetPhysicsObjectPickingSort() => ((Viewport)_host).GetPhysicsObjectPickingSort();

    /// <inheritdoc cref="Viewport.SetPhysicsObjectPickingFirstOnly(bool)" />
    public void SetPhysicsObjectPickingFirstOnly(bool @enable) => ((Viewport)_host).SetPhysicsObjectPickingFirstOnly(@enable);

    /// <inheritdoc cref="Viewport.GetPhysicsObjectPickingFirstOnly()" />
    public bool GetPhysicsObjectPickingFirstOnly() => ((Viewport)_host).GetPhysicsObjectPickingFirstOnly();

    /// <inheritdoc cref="Viewport.GetViewportRid()" />
    public Rid GetViewportRid() => ((Viewport)_host).GetViewportRid();

    /// <inheritdoc cref="Viewport.PushTextInput(string)" />
    public void PushTextInput(string @text) => ((Viewport)_host).PushTextInput(@text);

    /// <inheritdoc cref="Viewport.PushInput(InputEvent, bool)" />
    public void PushInput(InputEvent @event, bool @inLocalCoords) => ((Viewport)_host).PushInput(@event, @inLocalCoords);

    /// <inheritdoc cref="Viewport.PushUnhandledInput(InputEvent, bool)" />
    public void PushUnhandledInput(InputEvent @event, bool @inLocalCoords) => ((Viewport)_host).PushUnhandledInput(@event, @inLocalCoords);

    /// <inheritdoc cref="Viewport.NotifyMouseEntered()" />
    public void NotifyMouseEntered() => ((Viewport)_host).NotifyMouseEntered();

    /// <inheritdoc cref="Viewport.NotifyMouseExited()" />
    public void NotifyMouseExited() => ((Viewport)_host).NotifyMouseExited();

    /// <inheritdoc cref="Viewport.GetMousePosition()" />
    public Vector2 GetMousePosition() => ((Viewport)_host).GetMousePosition();

    /// <inheritdoc cref="Viewport.WarpMouse(Vector2)" />
    public void WarpMouse(Vector2 @position) => ((Viewport)_host).WarpMouse(@position);

    /// <inheritdoc cref="Viewport.UpdateMouseCursorState()" />
    public void UpdateMouseCursorState() => ((Viewport)_host).UpdateMouseCursorState();

    /// <inheritdoc cref="Viewport.GuiCancelDrag()" />
    public void GuiCancelDrag() => ((Viewport)_host).GuiCancelDrag();

    /// <inheritdoc cref="Viewport.GuiGetDragData()" />
    public Variant GuiGetDragData() => ((Viewport)_host).GuiGetDragData();

    /// <inheritdoc cref="Viewport.GuiGetDragDescription()" />
    public string GuiGetDragDescription() => ((Viewport)_host).GuiGetDragDescription();

    /// <inheritdoc cref="Viewport.GuiSetDragDescription(string)" />
    public void GuiSetDragDescription(string @description) => ((Viewport)_host).GuiSetDragDescription(@description);

    /// <inheritdoc cref="Viewport.GuiIsDragging()" />
    public bool GuiIsDragging() => ((Viewport)_host).GuiIsDragging();

    /// <inheritdoc cref="Viewport.GuiIsDragSuccessful()" />
    public bool GuiIsDragSuccessful() => ((Viewport)_host).GuiIsDragSuccessful();

    /// <inheritdoc cref="Viewport.GuiReleaseFocus()" />
    public void GuiReleaseFocus() => ((Viewport)_host).GuiReleaseFocus();

    /// <inheritdoc cref="Viewport.GuiGetFocusOwner()" />
    public Control GuiGetFocusOwner() => ((Viewport)_host).GuiGetFocusOwner();

    /// <inheritdoc cref="Viewport.GuiGetHoveredControl()" />
    public Control GuiGetHoveredControl() => ((Viewport)_host).GuiGetHoveredControl();

    /// <inheritdoc cref="Viewport.SetDisableInput(bool)" />
    public void SetDisableInput(bool @disable) => ((Viewport)_host).SetDisableInput(@disable);

    /// <inheritdoc cref="Viewport.IsInputDisabled()" />
    public bool IsInputDisabled() => ((Viewport)_host).IsInputDisabled();

    /// <inheritdoc cref="Viewport.SetPositionalShadowAtlasSize(int)" />
    public void SetPositionalShadowAtlasSize(int @size) => ((Viewport)_host).SetPositionalShadowAtlasSize(@size);

    /// <inheritdoc cref="Viewport.GetPositionalShadowAtlasSize()" />
    public int GetPositionalShadowAtlasSize() => ((Viewport)_host).GetPositionalShadowAtlasSize();

    /// <inheritdoc cref="Viewport.SetPositionalShadowAtlas16Bits(bool)" />
    public void SetPositionalShadowAtlas16Bits(bool @enable) => ((Viewport)_host).SetPositionalShadowAtlas16Bits(@enable);

    /// <inheritdoc cref="Viewport.GetPositionalShadowAtlas16Bits()" />
    public bool GetPositionalShadowAtlas16Bits() => ((Viewport)_host).GetPositionalShadowAtlas16Bits();

    /// <inheritdoc cref="Viewport.SetSnapControlsToPixels(bool)" />
    public void SetSnapControlsToPixels(bool @enabled) => ((Viewport)_host).SetSnapControlsToPixels(@enabled);

    /// <inheritdoc cref="Viewport.IsSnapControlsToPixelsEnabled()" />
    public bool IsSnapControlsToPixelsEnabled() => ((Viewport)_host).IsSnapControlsToPixelsEnabled();

    /// <inheritdoc cref="Viewport.SetSnap2DTransformsToPixel(bool)" />
    public void SetSnap2DTransformsToPixel(bool @enabled) => ((Viewport)_host).SetSnap2DTransformsToPixel(@enabled);

    /// <inheritdoc cref="Viewport.IsSnap2DTransformsToPixelEnabled()" />
    public bool IsSnap2DTransformsToPixelEnabled() => ((Viewport)_host).IsSnap2DTransformsToPixelEnabled();

    /// <inheritdoc cref="Viewport.SetSnap2DVerticesToPixel(bool)" />
    public void SetSnap2DVerticesToPixel(bool @enabled) => ((Viewport)_host).SetSnap2DVerticesToPixel(@enabled);

    /// <inheritdoc cref="Viewport.IsSnap2DVerticesToPixelEnabled()" />
    public bool IsSnap2DVerticesToPixelEnabled() => ((Viewport)_host).IsSnap2DVerticesToPixelEnabled();

    /// <inheritdoc cref="Viewport.SetPositionalShadowAtlasQuadrantSubdiv(int, Viewport.PositionalShadowAtlasQuadrantSubdiv)" />
    public void SetPositionalShadowAtlasQuadrantSubdiv(int @quadrant, Viewport.PositionalShadowAtlasQuadrantSubdiv @subdiv) => ((Viewport)_host).SetPositionalShadowAtlasQuadrantSubdiv(@quadrant, @subdiv);

    /// <inheritdoc cref="Viewport.GetPositionalShadowAtlasQuadrantSubdiv(int)" />
    public Viewport.PositionalShadowAtlasQuadrantSubdiv GetPositionalShadowAtlasQuadrantSubdiv(int @quadrant) => ((Viewport)_host).GetPositionalShadowAtlasQuadrantSubdiv(@quadrant);

    /// <inheritdoc cref="Viewport.SetInputAsHandled()" />
    public void SetInputAsHandled() => ((Viewport)_host).SetInputAsHandled();

    /// <inheritdoc cref="Viewport.IsInputHandled()" />
    public bool IsInputHandled() => ((Viewport)_host).IsInputHandled();

    /// <inheritdoc cref="Viewport.SetHandleInputLocally(bool)" />
    public void SetHandleInputLocally(bool @enable) => ((Viewport)_host).SetHandleInputLocally(@enable);

    /// <inheritdoc cref="Viewport.IsHandlingInputLocally()" />
    public bool IsHandlingInputLocally() => ((Viewport)_host).IsHandlingInputLocally();

    /// <inheritdoc cref="Viewport.SetDefaultCanvasItemTextureFilter(Viewport.DefaultCanvasItemTextureFilter)" />
    public void SetDefaultCanvasItemTextureFilter(Viewport.DefaultCanvasItemTextureFilter @mode) => ((Viewport)_host).SetDefaultCanvasItemTextureFilter(@mode);

    /// <inheritdoc cref="Viewport.GetDefaultCanvasItemTextureFilter()" />
    public Viewport.DefaultCanvasItemTextureFilter GetDefaultCanvasItemTextureFilter() => ((Viewport)_host).GetDefaultCanvasItemTextureFilter();

    /// <inheritdoc cref="Viewport.SetEmbeddingSubwindows(bool)" />
    public void SetEmbeddingSubwindows(bool @enable) => ((Viewport)_host).SetEmbeddingSubwindows(@enable);

    /// <inheritdoc cref="Viewport.IsEmbeddingSubwindows()" />
    public bool IsEmbeddingSubwindows() => ((Viewport)_host).IsEmbeddingSubwindows();

    /// <inheritdoc cref="Viewport.GetEmbeddedSubwindows()" />
    public Array<Window> GetEmbeddedSubwindows() => ((Viewport)_host).GetEmbeddedSubwindows();

    /// <inheritdoc cref="Viewport.SetDragThreshold(int)" />
    public void SetDragThreshold(int @threshold) => ((Viewport)_host).SetDragThreshold(@threshold);

    /// <inheritdoc cref="Viewport.GetDragThreshold()" />
    public int GetDragThreshold() => ((Viewport)_host).GetDragThreshold();

    /// <inheritdoc cref="Viewport.SetCanvasCullMask(uint)" />
    public void SetCanvasCullMask(uint @mask) => ((Viewport)_host).SetCanvasCullMask(@mask);

    /// <inheritdoc cref="Viewport.GetCanvasCullMask()" />
    public uint GetCanvasCullMask() => ((Viewport)_host).GetCanvasCullMask();

    /// <inheritdoc cref="Viewport.SetCanvasCullMaskBit(uint, bool)" />
    public void SetCanvasCullMaskBit(uint @layer, bool @enable) => ((Viewport)_host).SetCanvasCullMaskBit(@layer, @enable);

    /// <inheritdoc cref="Viewport.GetCanvasCullMaskBit(uint)" />
    public bool GetCanvasCullMaskBit(uint @layer) => ((Viewport)_host).GetCanvasCullMaskBit(@layer);

    /// <inheritdoc cref="Viewport.SetDefaultCanvasItemTextureRepeat(Viewport.DefaultCanvasItemTextureRepeat)" />
    public void SetDefaultCanvasItemTextureRepeat(Viewport.DefaultCanvasItemTextureRepeat @mode) => ((Viewport)_host).SetDefaultCanvasItemTextureRepeat(@mode);

    /// <inheritdoc cref="Viewport.GetDefaultCanvasItemTextureRepeat()" />
    public Viewport.DefaultCanvasItemTextureRepeat GetDefaultCanvasItemTextureRepeat() => ((Viewport)_host).GetDefaultCanvasItemTextureRepeat();

    /// <inheritdoc cref="Viewport.SetSdfOversize(Viewport.SdfOversizeEnum)" />
    public void SetSdfOversize(Viewport.SdfOversizeEnum @oversize) => ((Viewport)_host).SetSdfOversize(@oversize);

    /// <inheritdoc cref="Viewport.GetSdfOversize()" />
    public Viewport.SdfOversizeEnum GetSdfOversize() => ((Viewport)_host).GetSdfOversize();

    /// <inheritdoc cref="Viewport.SetSdfScale(Viewport.SdfScaleEnum)" />
    public void SetSdfScale(Viewport.SdfScaleEnum @scale) => ((Viewport)_host).SetSdfScale(@scale);

    /// <inheritdoc cref="Viewport.GetSdfScale()" />
    public Viewport.SdfScaleEnum GetSdfScale() => ((Viewport)_host).GetSdfScale();

    /// <inheritdoc cref="Viewport.SetMeshLodThreshold(float)" />
    public void SetMeshLodThreshold(float @pixels) => ((Viewport)_host).SetMeshLodThreshold(@pixels);

    /// <inheritdoc cref="Viewport.GetMeshLodThreshold()" />
    public float GetMeshLodThreshold() => ((Viewport)_host).GetMeshLodThreshold();

    /// <inheritdoc cref="Viewport.SetAsAudioListener2D(bool)" />
    public void SetAsAudioListener2D(bool @enable) => ((Viewport)_host).SetAsAudioListener2D(@enable);

    /// <inheritdoc cref="Viewport.IsAudioListener2D()" />
    public bool IsAudioListener2D() => ((Viewport)_host).IsAudioListener2D();

    /// <inheritdoc cref="Viewport.GetAudioListener2D()" />
    public AudioListener2D GetAudioListener2D() => ((Viewport)_host).GetAudioListener2D();

    /// <inheritdoc cref="Viewport.GetCamera2D()" />
    public Camera2D GetCamera2D() => ((Viewport)_host).GetCamera2D();

    /// <inheritdoc cref="Viewport.SetWorld3D(World3D)" />
    public void SetWorld3D(World3D @world3D) => ((Viewport)_host).SetWorld3D(@world3D);

    /// <inheritdoc cref="Viewport.GetWorld3D()" />
    public World3D GetWorld3D() => ((Viewport)_host).GetWorld3D();

    /// <inheritdoc cref="Viewport.FindWorld3D()" />
    public World3D FindWorld3D() => ((Viewport)_host).FindWorld3D();

    /// <inheritdoc cref="Viewport.SetUseOwnWorld3D(bool)" />
    public void SetUseOwnWorld3D(bool @enable) => ((Viewport)_host).SetUseOwnWorld3D(@enable);

    /// <inheritdoc cref="Viewport.IsUsingOwnWorld3D()" />
    public bool IsUsingOwnWorld3D() => ((Viewport)_host).IsUsingOwnWorld3D();

    /// <inheritdoc cref="Viewport.GetAudioListener3D()" />
    public AudioListener3D GetAudioListener3D() => ((Viewport)_host).GetAudioListener3D();

    /// <inheritdoc cref="Viewport.GetCamera3D()" />
    public Camera3D GetCamera3D() => ((Viewport)_host).GetCamera3D();

    /// <inheritdoc cref="Viewport.SetAsAudioListener3D(bool)" />
    public void SetAsAudioListener3D(bool @enable) => ((Viewport)_host).SetAsAudioListener3D(@enable);

    /// <inheritdoc cref="Viewport.IsAudioListener3D()" />
    public bool IsAudioListener3D() => ((Viewport)_host).IsAudioListener3D();

    /// <inheritdoc cref="Viewport.SetDisable3D(bool)" />
    public void SetDisable3D(bool @disable) => ((Viewport)_host).SetDisable3D(@disable);

    /// <inheritdoc cref="Viewport.Is3DDisabled()" />
    public bool Is3DDisabled() => ((Viewport)_host).Is3DDisabled();

    /// <inheritdoc cref="Viewport.SetUseXR(bool)" />
    public void SetUseXR(bool @use) => ((Viewport)_host).SetUseXR(@use);

    /// <inheritdoc cref="Viewport.IsUsingXR()" />
    public bool IsUsingXR() => ((Viewport)_host).IsUsingXR();

    /// <inheritdoc cref="Viewport.SetScaling3DMode(Viewport.Scaling3DModeEnum)" />
    public void SetScaling3DMode(Viewport.Scaling3DModeEnum @scaling3DMode) => ((Viewport)_host).SetScaling3DMode(@scaling3DMode);

    /// <inheritdoc cref="Viewport.GetScaling3DMode()" />
    public Viewport.Scaling3DModeEnum GetScaling3DMode() => ((Viewport)_host).GetScaling3DMode();

    /// <inheritdoc cref="Viewport.SetScaling3DScale(float)" />
    public void SetScaling3DScale(float @scale) => ((Viewport)_host).SetScaling3DScale(@scale);

    /// <inheritdoc cref="Viewport.GetScaling3DScale()" />
    public float GetScaling3DScale() => ((Viewport)_host).GetScaling3DScale();

    /// <inheritdoc cref="Viewport.SetFsrSharpness(float)" />
    public void SetFsrSharpness(float @fsrSharpness) => ((Viewport)_host).SetFsrSharpness(@fsrSharpness);

    /// <inheritdoc cref="Viewport.GetFsrSharpness()" />
    public float GetFsrSharpness() => ((Viewport)_host).GetFsrSharpness();

    /// <inheritdoc cref="Viewport.SetTextureMipmapBias(float)" />
    public void SetTextureMipmapBias(float @textureMipmapBias) => ((Viewport)_host).SetTextureMipmapBias(@textureMipmapBias);

    /// <inheritdoc cref="Viewport.GetTextureMipmapBias()" />
    public float GetTextureMipmapBias() => ((Viewport)_host).GetTextureMipmapBias();

    /// <inheritdoc cref="Viewport.SetAnisotropicFilteringLevel(Viewport.AnisotropicFiltering)" />
    public void SetAnisotropicFilteringLevel(Viewport.AnisotropicFiltering @anisotropicFilteringLevel) => ((Viewport)_host).SetAnisotropicFilteringLevel(@anisotropicFilteringLevel);

    /// <inheritdoc cref="Viewport.GetAnisotropicFilteringLevel()" />
    public Viewport.AnisotropicFiltering GetAnisotropicFilteringLevel() => ((Viewport)_host).GetAnisotropicFilteringLevel();

    /// <inheritdoc cref="Viewport.SetVrsMode(Viewport.VrsModeEnum)" />
    public void SetVrsMode(Viewport.VrsModeEnum @mode) => ((Viewport)_host).SetVrsMode(@mode);

    /// <inheritdoc cref="Viewport.GetVrsMode()" />
    public Viewport.VrsModeEnum GetVrsMode() => ((Viewport)_host).GetVrsMode();

    /// <inheritdoc cref="Viewport.SetVrsUpdateMode(Viewport.VrsUpdateModeEnum)" />
    public void SetVrsUpdateMode(Viewport.VrsUpdateModeEnum @mode) => ((Viewport)_host).SetVrsUpdateMode(@mode);

    /// <inheritdoc cref="Viewport.GetVrsUpdateMode()" />
    public Viewport.VrsUpdateModeEnum GetVrsUpdateMode() => ((Viewport)_host).GetVrsUpdateMode();

    /// <inheritdoc cref="Viewport.SetVrsTexture(Texture2D)" />
    public void SetVrsTexture(Texture2D @texture) => ((Viewport)_host).SetVrsTexture(@texture);

    /// <inheritdoc cref="Viewport.GetVrsTexture()" />
    public Texture2D GetVrsTexture() => ((Viewport)_host).GetVrsTexture();

}
