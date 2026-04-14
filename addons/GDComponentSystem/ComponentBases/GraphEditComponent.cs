#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GraphEdit" />
[Tool, GlobalClass]
public abstract partial class GraphEditComponent : ControlComponent
{

    /// <inheritdoc cref="GraphEdit.GetZoomHBox()" />
    public HBoxContainer GetZoomHBox() => ((GraphEdit)_host).GetZoomHBox();

    /// <inheritdoc cref="GraphEdit._GetConnectionLine(Vector2, Vector2)" />
    public virtual Vector2[] _GetConnectionLine(Vector2 @fromPosition, Vector2 @toPosition) => ((GraphEdit)_host)._GetConnectionLine(@fromPosition, @toPosition);

    /// <inheritdoc cref="GraphEdit._IsInInputHotzone(GodotObject, int, Vector2)" />
    public virtual bool _IsInInputHotzone(GodotObject @inNode, int @inPort, Vector2 @mousePosition) => ((GraphEdit)_host)._IsInInputHotzone(@inNode, @inPort, @mousePosition);

    /// <inheritdoc cref="GraphEdit._IsInOutputHotzone(GodotObject, int, Vector2)" />
    public virtual bool _IsInOutputHotzone(GodotObject @inNode, int @inPort, Vector2 @mousePosition) => ((GraphEdit)_host)._IsInOutputHotzone(@inNode, @inPort, @mousePosition);

    /// <inheritdoc cref="GraphEdit._IsNodeHoverValid(StringName, int, StringName, int)" />
    public virtual bool _IsNodeHoverValid(StringName @fromNode, int @fromPort, StringName @toNode, int @toPort) => ((GraphEdit)_host)._IsNodeHoverValid(@fromNode, @fromPort, @toNode, @toPort);

    /// <inheritdoc cref="GraphEdit.ConnectNode(StringName, int, StringName, int, bool)" />
    public Error ConnectNode(StringName @fromNode, int @fromPort, StringName @toNode, int @toPort, bool @keepAlive) => ((GraphEdit)_host).ConnectNode(@fromNode, @fromPort, @toNode, @toPort, @keepAlive);

    /// <inheritdoc cref="GraphEdit.IsNodeConnected(StringName, int, StringName, int)" />
    public bool IsNodeConnected(StringName @fromNode, int @fromPort, StringName @toNode, int @toPort) => ((GraphEdit)_host).IsNodeConnected(@fromNode, @fromPort, @toNode, @toPort);

    /// <inheritdoc cref="GraphEdit.DisconnectNode(StringName, int, StringName, int)" />
    public void DisconnectNode(StringName @fromNode, int @fromPort, StringName @toNode, int @toPort) => ((GraphEdit)_host).DisconnectNode(@fromNode, @fromPort, @toNode, @toPort);

    /// <inheritdoc cref="GraphEdit.SetConnectionActivity(StringName, int, StringName, int, float)" />
    public void SetConnectionActivity(StringName @fromNode, int @fromPort, StringName @toNode, int @toPort, float @amount) => ((GraphEdit)_host).SetConnectionActivity(@fromNode, @fromPort, @toNode, @toPort, @amount);

    /// <inheritdoc cref="GraphEdit.SetConnections(Array{Dictionary})" />
    public void SetConnections(Array<Dictionary> @connections) => ((GraphEdit)_host).SetConnections(@connections);

    /// <inheritdoc cref="GraphEdit.GetConnectionList()" />
    public Array<Dictionary> GetConnectionList() => ((GraphEdit)_host).GetConnectionList();

    /// <inheritdoc cref="GraphEdit.GetConnectionCount(StringName, int)" />
    public int GetConnectionCount(StringName @fromNode, int @fromPort) => ((GraphEdit)_host).GetConnectionCount(@fromNode, @fromPort);

    /// <inheritdoc cref="GraphEdit.GetClosestConnectionAtPoint(Vector2, float)" />
    public Dictionary GetClosestConnectionAtPoint(Vector2 @point, float @maxDistance) => ((GraphEdit)_host).GetClosestConnectionAtPoint(@point, @maxDistance);

    /// <inheritdoc cref="GraphEdit.GetConnectionListFromNode(StringName)" />
    public Array<Dictionary> GetConnectionListFromNode(StringName @node) => ((GraphEdit)_host).GetConnectionListFromNode(@node);

    /// <inheritdoc cref="GraphEdit.GetConnectionsIntersectingWithRect(Rect2)" />
    public Array<Dictionary> GetConnectionsIntersectingWithRect(Rect2 @rect) => ((GraphEdit)_host).GetConnectionsIntersectingWithRect(@rect);

    /// <inheritdoc cref="GraphEdit.ClearConnections()" />
    public void ClearConnections() => ((GraphEdit)_host).ClearConnections();

    /// <inheritdoc cref="GraphEdit.ForceConnectionDragEnd()" />
    public void ForceConnectionDragEnd() => ((GraphEdit)_host).ForceConnectionDragEnd();

    /// <inheritdoc cref="GraphEdit.GetScrollOffset()" />
    public Vector2 GetScrollOffset() => ((GraphEdit)_host).GetScrollOffset();

    /// <inheritdoc cref="GraphEdit.SetScrollOffset(Vector2)" />
    public void SetScrollOffset(Vector2 @offset) => ((GraphEdit)_host).SetScrollOffset(@offset);

    /// <inheritdoc cref="GraphEdit.AddValidRightDisconnectType(int)" />
    public void AddValidRightDisconnectType(int @type) => ((GraphEdit)_host).AddValidRightDisconnectType(@type);

    /// <inheritdoc cref="GraphEdit.RemoveValidRightDisconnectType(int)" />
    public void RemoveValidRightDisconnectType(int @type) => ((GraphEdit)_host).RemoveValidRightDisconnectType(@type);

    /// <inheritdoc cref="GraphEdit.AddValidLeftDisconnectType(int)" />
    public void AddValidLeftDisconnectType(int @type) => ((GraphEdit)_host).AddValidLeftDisconnectType(@type);

    /// <inheritdoc cref="GraphEdit.RemoveValidLeftDisconnectType(int)" />
    public void RemoveValidLeftDisconnectType(int @type) => ((GraphEdit)_host).RemoveValidLeftDisconnectType(@type);

    /// <inheritdoc cref="GraphEdit.AddValidConnectionType(int, int)" />
    public void AddValidConnectionType(int @fromType, int @toType) => ((GraphEdit)_host).AddValidConnectionType(@fromType, @toType);

    /// <inheritdoc cref="GraphEdit.RemoveValidConnectionType(int, int)" />
    public void RemoveValidConnectionType(int @fromType, int @toType) => ((GraphEdit)_host).RemoveValidConnectionType(@fromType, @toType);

    /// <inheritdoc cref="GraphEdit.IsValidConnectionType(int, int)" />
    public bool IsValidConnectionType(int @fromType, int @toType) => ((GraphEdit)_host).IsValidConnectionType(@fromType, @toType);

    /// <inheritdoc cref="GraphEdit.GetConnectionLine(Vector2, Vector2)" />
    public Vector2[] GetConnectionLine(Vector2 @fromNode, Vector2 @toNode) => ((GraphEdit)_host).GetConnectionLine(@fromNode, @toNode);

    /// <inheritdoc cref="GraphEdit.AttachGraphElementToFrame(StringName, StringName)" />
    public void AttachGraphElementToFrame(StringName @element, StringName @frame) => ((GraphEdit)_host).AttachGraphElementToFrame(@element, @frame);

    /// <inheritdoc cref="GraphEdit.DetachGraphElementFromFrame(StringName)" />
    public void DetachGraphElementFromFrame(StringName @element) => ((GraphEdit)_host).DetachGraphElementFromFrame(@element);

    /// <inheritdoc cref="GraphEdit.GetElementFrame(StringName)" />
    public GraphFrame GetElementFrame(StringName @element) => ((GraphEdit)_host).GetElementFrame(@element);

    /// <inheritdoc cref="GraphEdit.GetAttachedNodesOfFrame(StringName)" />
    public Array<StringName> GetAttachedNodesOfFrame(StringName @frame) => ((GraphEdit)_host).GetAttachedNodesOfFrame(@frame);

    /// <inheritdoc cref="GraphEdit.SetPanningScheme(GraphEdit.PanningSchemeEnum)" />
    public void SetPanningScheme(GraphEdit.PanningSchemeEnum @scheme) => ((GraphEdit)_host).SetPanningScheme(@scheme);

    /// <inheritdoc cref="GraphEdit.GetPanningScheme()" />
    public GraphEdit.PanningSchemeEnum GetPanningScheme() => ((GraphEdit)_host).GetPanningScheme();

    /// <inheritdoc cref="GraphEdit.SetZoom(float)" />
    public void SetZoom(float @zoom) => ((GraphEdit)_host).SetZoom(@zoom);

    /// <inheritdoc cref="GraphEdit.GetZoom()" />
    public float GetZoom() => ((GraphEdit)_host).GetZoom();

    /// <inheritdoc cref="GraphEdit.SetZoomMin(float)" />
    public void SetZoomMin(float @zoomMin) => ((GraphEdit)_host).SetZoomMin(@zoomMin);

    /// <inheritdoc cref="GraphEdit.GetZoomMin()" />
    public float GetZoomMin() => ((GraphEdit)_host).GetZoomMin();

    /// <inheritdoc cref="GraphEdit.SetZoomMax(float)" />
    public void SetZoomMax(float @zoomMax) => ((GraphEdit)_host).SetZoomMax(@zoomMax);

    /// <inheritdoc cref="GraphEdit.GetZoomMax()" />
    public float GetZoomMax() => ((GraphEdit)_host).GetZoomMax();

    /// <inheritdoc cref="GraphEdit.SetZoomStep(float)" />
    public void SetZoomStep(float @zoomStep) => ((GraphEdit)_host).SetZoomStep(@zoomStep);

    /// <inheritdoc cref="GraphEdit.GetZoomStep()" />
    public float GetZoomStep() => ((GraphEdit)_host).GetZoomStep();

    /// <inheritdoc cref="GraphEdit.SetShowGrid(bool)" />
    public void SetShowGrid(bool @enable) => ((GraphEdit)_host).SetShowGrid(@enable);

    /// <inheritdoc cref="GraphEdit.IsShowingGrid()" />
    public bool IsShowingGrid() => ((GraphEdit)_host).IsShowingGrid();

    /// <inheritdoc cref="GraphEdit.SetGridPattern(GraphEdit.GridPatternEnum)" />
    public void SetGridPattern(GraphEdit.GridPatternEnum @pattern) => ((GraphEdit)_host).SetGridPattern(@pattern);

    /// <inheritdoc cref="GraphEdit.GetGridPattern()" />
    public GraphEdit.GridPatternEnum GetGridPattern() => ((GraphEdit)_host).GetGridPattern();

    /// <inheritdoc cref="GraphEdit.SetSnappingEnabled(bool)" />
    public void SetSnappingEnabled(bool @enable) => ((GraphEdit)_host).SetSnappingEnabled(@enable);

    /// <inheritdoc cref="GraphEdit.IsSnappingEnabled()" />
    public bool IsSnappingEnabled() => ((GraphEdit)_host).IsSnappingEnabled();

    /// <inheritdoc cref="GraphEdit.SetSnappingDistance(int)" />
    public void SetSnappingDistance(int @pixels) => ((GraphEdit)_host).SetSnappingDistance(@pixels);

    /// <inheritdoc cref="GraphEdit.GetSnappingDistance()" />
    public int GetSnappingDistance() => ((GraphEdit)_host).GetSnappingDistance();

    /// <inheritdoc cref="GraphEdit.SetConnectionLinesCurvature(float)" />
    public void SetConnectionLinesCurvature(float @curvature) => ((GraphEdit)_host).SetConnectionLinesCurvature(@curvature);

    /// <inheritdoc cref="GraphEdit.GetConnectionLinesCurvature()" />
    public float GetConnectionLinesCurvature() => ((GraphEdit)_host).GetConnectionLinesCurvature();

    /// <inheritdoc cref="GraphEdit.SetConnectionLinesThickness(float)" />
    public void SetConnectionLinesThickness(float @pixels) => ((GraphEdit)_host).SetConnectionLinesThickness(@pixels);

    /// <inheritdoc cref="GraphEdit.GetConnectionLinesThickness()" />
    public float GetConnectionLinesThickness() => ((GraphEdit)_host).GetConnectionLinesThickness();

    /// <inheritdoc cref="GraphEdit.SetConnectionLinesAntialiased(bool)" />
    public void SetConnectionLinesAntialiased(bool @pixels) => ((GraphEdit)_host).SetConnectionLinesAntialiased(@pixels);

    /// <inheritdoc cref="GraphEdit.IsConnectionLinesAntialiased()" />
    public bool IsConnectionLinesAntialiased() => ((GraphEdit)_host).IsConnectionLinesAntialiased();

    /// <inheritdoc cref="GraphEdit.SetMinimapSize(Vector2)" />
    public void SetMinimapSize(Vector2 @size) => ((GraphEdit)_host).SetMinimapSize(@size);

    /// <inheritdoc cref="GraphEdit.GetMinimapSize()" />
    public Vector2 GetMinimapSize() => ((GraphEdit)_host).GetMinimapSize();

    /// <inheritdoc cref="GraphEdit.SetMinimapOpacity(float)" />
    public void SetMinimapOpacity(float @opacity) => ((GraphEdit)_host).SetMinimapOpacity(@opacity);

    /// <inheritdoc cref="GraphEdit.GetMinimapOpacity()" />
    public float GetMinimapOpacity() => ((GraphEdit)_host).GetMinimapOpacity();

    /// <inheritdoc cref="GraphEdit.SetMinimapEnabled(bool)" />
    public void SetMinimapEnabled(bool @enable) => ((GraphEdit)_host).SetMinimapEnabled(@enable);

    /// <inheritdoc cref="GraphEdit.IsMinimapEnabled()" />
    public bool IsMinimapEnabled() => ((GraphEdit)_host).IsMinimapEnabled();

    /// <inheritdoc cref="GraphEdit.SetShowMenu(bool)" />
    public void SetShowMenu(bool @hidden) => ((GraphEdit)_host).SetShowMenu(@hidden);

    /// <inheritdoc cref="GraphEdit.IsShowingMenu()" />
    public bool IsShowingMenu() => ((GraphEdit)_host).IsShowingMenu();

    /// <inheritdoc cref="GraphEdit.SetShowZoomLabel(bool)" />
    public void SetShowZoomLabel(bool @enable) => ((GraphEdit)_host).SetShowZoomLabel(@enable);

    /// <inheritdoc cref="GraphEdit.IsShowingZoomLabel()" />
    public bool IsShowingZoomLabel() => ((GraphEdit)_host).IsShowingZoomLabel();

    /// <inheritdoc cref="GraphEdit.SetShowGridButtons(bool)" />
    public void SetShowGridButtons(bool @hidden) => ((GraphEdit)_host).SetShowGridButtons(@hidden);

    /// <inheritdoc cref="GraphEdit.IsShowingGridButtons()" />
    public bool IsShowingGridButtons() => ((GraphEdit)_host).IsShowingGridButtons();

    /// <inheritdoc cref="GraphEdit.SetShowZoomButtons(bool)" />
    public void SetShowZoomButtons(bool @hidden) => ((GraphEdit)_host).SetShowZoomButtons(@hidden);

    /// <inheritdoc cref="GraphEdit.IsShowingZoomButtons()" />
    public bool IsShowingZoomButtons() => ((GraphEdit)_host).IsShowingZoomButtons();

    /// <inheritdoc cref="GraphEdit.SetShowMinimapButton(bool)" />
    public void SetShowMinimapButton(bool @hidden) => ((GraphEdit)_host).SetShowMinimapButton(@hidden);

    /// <inheritdoc cref="GraphEdit.IsShowingMinimapButton()" />
    public bool IsShowingMinimapButton() => ((GraphEdit)_host).IsShowingMinimapButton();

    /// <inheritdoc cref="GraphEdit.SetShowArrangeButton(bool)" />
    public void SetShowArrangeButton(bool @hidden) => ((GraphEdit)_host).SetShowArrangeButton(@hidden);

    /// <inheritdoc cref="GraphEdit.IsShowingArrangeButton()" />
    public bool IsShowingArrangeButton() => ((GraphEdit)_host).IsShowingArrangeButton();

    /// <inheritdoc cref="GraphEdit.SetRightDisconnects(bool)" />
    public void SetRightDisconnects(bool @enable) => ((GraphEdit)_host).SetRightDisconnects(@enable);

    /// <inheritdoc cref="GraphEdit.IsRightDisconnectsEnabled()" />
    public bool IsRightDisconnectsEnabled() => ((GraphEdit)_host).IsRightDisconnectsEnabled();

    /// <inheritdoc cref="GraphEdit.SetTypeNames(Dictionary)" />
    public void SetTypeNames(Dictionary @typeNames) => ((GraphEdit)_host).SetTypeNames(@typeNames);

    /// <inheritdoc cref="GraphEdit.GetTypeNames()" />
    public Dictionary GetTypeNames() => ((GraphEdit)_host).GetTypeNames();

    /// <inheritdoc cref="GraphEdit.GetMenuHBox()" />
    public HBoxContainer GetMenuHBox() => ((GraphEdit)_host).GetMenuHBox();

    /// <inheritdoc cref="GraphEdit.ArrangeNodes()" />
    public void ArrangeNodes() => ((GraphEdit)_host).ArrangeNodes();

    /// <inheritdoc cref="GraphEdit.SetSelected(Node)" />
    public void SetSelected(Node @node) => ((GraphEdit)_host).SetSelected(@node);

    /// <inheritdoc cref="GraphEdit.ConnectNode(StringName, int, StringName, int)" />
    public Error ConnectNode(StringName @fromNode, int @fromPort, StringName @toNode, int @toPort) => ((GraphEdit)_host).ConnectNode(@fromNode, @fromPort, @toNode, @toPort);

    /// <inheritdoc cref="GraphEdit.SetArrangeNodesButtonHidden(bool)" />
    public void SetArrangeNodesButtonHidden(bool @enable) => ((GraphEdit)_host).SetArrangeNodesButtonHidden(@enable);

    /// <inheritdoc cref="GraphEdit.IsArrangeNodesButtonHidden()" />
    public bool IsArrangeNodesButtonHidden() => ((GraphEdit)_host).IsArrangeNodesButtonHidden();

}
