#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="TileMapLayer" />
[Tool, GlobalClass]
public abstract partial class TileMapLayerComponent : Node2DComponent
{

    /// <inheritdoc cref="TileMapLayer._TileDataRuntimeUpdate(Vector2I, TileData)" />
    public virtual void _TileDataRuntimeUpdate(Vector2I @coords, TileData @tileData) { }

    /// <inheritdoc cref="TileMapLayer._UpdateCells(Array{Vector2I}, bool)" />
    public virtual void _UpdateCells(Array<Vector2I> @coords, bool @forcedCleanup) { }

    /// <inheritdoc cref="TileMapLayer._UseTileDataRuntimeUpdate(Vector2I)" />
    public virtual bool _UseTileDataRuntimeUpdate(Vector2I @coords) => ((TileMapLayer)_host)._UseTileDataRuntimeUpdate(@coords);

    /// <inheritdoc cref="TileMapLayer.SetCell(Vector2I, int, Vector2I?, int)" />
    public void SetCell(Vector2I @coords, int @sourceId, Vector2I? @atlasCoords, int @alternativeTile) => ((TileMapLayer)_host).SetCell(@coords, @sourceId, @atlasCoords, @alternativeTile);

    /// <inheritdoc cref="TileMapLayer.EraseCell(Vector2I)" />
    public void EraseCell(Vector2I @coords) => ((TileMapLayer)_host).EraseCell(@coords);

    /// <inheritdoc cref="TileMapLayer.FixInvalidTiles()" />
    public void FixInvalidTiles() => ((TileMapLayer)_host).FixInvalidTiles();

    /// <inheritdoc cref="TileMapLayer.Clear()" />
    public void Clear() => ((TileMapLayer)_host).Clear();

    /// <inheritdoc cref="TileMapLayer.GetCellSourceId(Vector2I)" />
    public int GetCellSourceId(Vector2I @coords) => ((TileMapLayer)_host).GetCellSourceId(@coords);

    /// <inheritdoc cref="TileMapLayer.GetCellAtlasCoords(Vector2I)" />
    public Vector2I GetCellAtlasCoords(Vector2I @coords) => ((TileMapLayer)_host).GetCellAtlasCoords(@coords);

    /// <inheritdoc cref="TileMapLayer.GetCellAlternativeTile(Vector2I)" />
    public int GetCellAlternativeTile(Vector2I @coords) => ((TileMapLayer)_host).GetCellAlternativeTile(@coords);

    /// <inheritdoc cref="TileMapLayer.GetCellTileData(Vector2I)" />
    public TileData GetCellTileData(Vector2I @coords) => ((TileMapLayer)_host).GetCellTileData(@coords);

    /// <inheritdoc cref="TileMapLayer.IsCellFlippedH(Vector2I)" />
    public bool IsCellFlippedH(Vector2I @coords) => ((TileMapLayer)_host).IsCellFlippedH(@coords);

    /// <inheritdoc cref="TileMapLayer.IsCellFlippedV(Vector2I)" />
    public bool IsCellFlippedV(Vector2I @coords) => ((TileMapLayer)_host).IsCellFlippedV(@coords);

    /// <inheritdoc cref="TileMapLayer.IsCellTransposed(Vector2I)" />
    public bool IsCellTransposed(Vector2I @coords) => ((TileMapLayer)_host).IsCellTransposed(@coords);

    /// <inheritdoc cref="TileMapLayer.GetUsedCells()" />
    public Array<Vector2I> GetUsedCells() => ((TileMapLayer)_host).GetUsedCells();

    /// <inheritdoc cref="TileMapLayer.GetUsedCellsById(int, Vector2I?, int)" />
    public Array<Vector2I> GetUsedCellsById(int @sourceId, Vector2I? @atlasCoords, int @alternativeTile) => ((TileMapLayer)_host).GetUsedCellsById(@sourceId, @atlasCoords, @alternativeTile);

    /// <inheritdoc cref="TileMapLayer.GetUsedRect()" />
    public Rect2I GetUsedRect() => ((TileMapLayer)_host).GetUsedRect();

    /// <inheritdoc cref="TileMapLayer.GetPattern(Array{Vector2I})" />
    public TileMapPattern GetPattern(Array<Vector2I> @coordsArray) => ((TileMapLayer)_host).GetPattern(@coordsArray);

    /// <inheritdoc cref="TileMapLayer.SetPattern(Vector2I, TileMapPattern)" />
    public void SetPattern(Vector2I @position, TileMapPattern @pattern) => ((TileMapLayer)_host).SetPattern(@position, @pattern);

    /// <inheritdoc cref="TileMapLayer.SetCellsTerrainConnect(Array{Vector2I}, int, int, bool)" />
    public void SetCellsTerrainConnect(Array<Vector2I> @cells, int @terrainSet, int @terrain, bool @ignoreEmptyTerrains) => ((TileMapLayer)_host).SetCellsTerrainConnect(@cells, @terrainSet, @terrain, @ignoreEmptyTerrains);

    /// <inheritdoc cref="TileMapLayer.SetCellsTerrainPath(Array{Vector2I}, int, int, bool)" />
    public void SetCellsTerrainPath(Array<Vector2I> @path, int @terrainSet, int @terrain, bool @ignoreEmptyTerrains) => ((TileMapLayer)_host).SetCellsTerrainPath(@path, @terrainSet, @terrain, @ignoreEmptyTerrains);

    /// <inheritdoc cref="TileMapLayer.HasBodyRid(Rid)" />
    public bool HasBodyRid(Rid @body) => ((TileMapLayer)_host).HasBodyRid(@body);

    /// <inheritdoc cref="TileMapLayer.GetCoordsForBodyRid(Rid)" />
    public Vector2I GetCoordsForBodyRid(Rid @body) => ((TileMapLayer)_host).GetCoordsForBodyRid(@body);

    /// <inheritdoc cref="TileMapLayer.UpdateInternals()" />
    public void UpdateInternals() => ((TileMapLayer)_host).UpdateInternals();

    /// <inheritdoc cref="TileMapLayer.NotifyRuntimeTileDataUpdate()" />
    public void NotifyRuntimeTileDataUpdate() => ((TileMapLayer)_host).NotifyRuntimeTileDataUpdate();

    /// <inheritdoc cref="TileMapLayer.MapPattern(Vector2I, Vector2I, TileMapPattern)" />
    public Vector2I MapPattern(Vector2I @positionInTilemap, Vector2I @coordsInPattern, TileMapPattern @pattern) => ((TileMapLayer)_host).MapPattern(@positionInTilemap, @coordsInPattern, @pattern);

    /// <inheritdoc cref="TileMapLayer.GetSurroundingCells(Vector2I)" />
    public Array<Vector2I> GetSurroundingCells(Vector2I @coords) => ((TileMapLayer)_host).GetSurroundingCells(@coords);

    /// <inheritdoc cref="TileMapLayer.GetNeighborCell(Vector2I, TileSet.CellNeighbor)" />
    public Vector2I GetNeighborCell(Vector2I @coords, TileSet.CellNeighbor @neighbor) => ((TileMapLayer)_host).GetNeighborCell(@coords, @neighbor);

    /// <inheritdoc cref="TileMapLayer.MapToLocal(Vector2I)" />
    public Vector2 MapToLocal(Vector2I @mapPosition) => ((TileMapLayer)_host).MapToLocal(@mapPosition);

    /// <inheritdoc cref="TileMapLayer.LocalToMap(Vector2)" />
    public Vector2I LocalToMap(Vector2 @localPosition) => ((TileMapLayer)_host).LocalToMap(@localPosition);

    /// <inheritdoc cref="TileMapLayer.SetTileMapDataFromArray(byte[])" />
    public void SetTileMapDataFromArray(byte[] @tileMapLayerData) => ((TileMapLayer)_host).SetTileMapDataFromArray(@tileMapLayerData);

    /// <inheritdoc cref="TileMapLayer.SetTileMapDataFromArray(ReadOnlySpan{byte})" />
    public void SetTileMapDataFromArray(ReadOnlySpan<byte> @tileMapLayerData) => ((TileMapLayer)_host).SetTileMapDataFromArray(@tileMapLayerData);

    /// <inheritdoc cref="TileMapLayer.GetTileMapDataAsArray()" />
    public byte[] GetTileMapDataAsArray() => ((TileMapLayer)_host).GetTileMapDataAsArray();

    /// <inheritdoc cref="TileMapLayer.SetEnabled(bool)" />
    public void SetEnabled(bool @enabled) => ((TileMapLayer)_host).SetEnabled(@enabled);

    /// <inheritdoc cref="TileMapLayer.IsEnabled()" />
    public bool IsEnabled() => ((TileMapLayer)_host).IsEnabled();

    /// <inheritdoc cref="TileMapLayer.SetTileSet(TileSet)" />
    public void SetTileSet(TileSet @tileSet) => ((TileMapLayer)_host).SetTileSet(@tileSet);

    /// <inheritdoc cref="TileMapLayer.GetTileSet()" />
    public TileSet GetTileSet() => ((TileMapLayer)_host).GetTileSet();

    /// <inheritdoc cref="TileMapLayer.SetYSortOrigin(int)" />
    public void SetYSortOrigin(int @ySortOrigin) => ((TileMapLayer)_host).SetYSortOrigin(@ySortOrigin);

    /// <inheritdoc cref="TileMapLayer.GetYSortOrigin()" />
    public int GetYSortOrigin() => ((TileMapLayer)_host).GetYSortOrigin();

    /// <inheritdoc cref="TileMapLayer.SetXDrawOrderReversed(bool)" />
    public void SetXDrawOrderReversed(bool @xDrawOrderReversed) => ((TileMapLayer)_host).SetXDrawOrderReversed(@xDrawOrderReversed);

    /// <inheritdoc cref="TileMapLayer.IsXDrawOrderReversed()" />
    public bool IsXDrawOrderReversed() => ((TileMapLayer)_host).IsXDrawOrderReversed();

    /// <inheritdoc cref="TileMapLayer.SetRenderingQuadrantSize(int)" />
    public void SetRenderingQuadrantSize(int @size) => ((TileMapLayer)_host).SetRenderingQuadrantSize(@size);

    /// <inheritdoc cref="TileMapLayer.GetRenderingQuadrantSize()" />
    public int GetRenderingQuadrantSize() => ((TileMapLayer)_host).GetRenderingQuadrantSize();

    /// <inheritdoc cref="TileMapLayer.SetCollisionEnabled(bool)" />
    public void SetCollisionEnabled(bool @enabled) => ((TileMapLayer)_host).SetCollisionEnabled(@enabled);

    /// <inheritdoc cref="TileMapLayer.IsCollisionEnabled()" />
    public bool IsCollisionEnabled() => ((TileMapLayer)_host).IsCollisionEnabled();

    /// <inheritdoc cref="TileMapLayer.SetUseKinematicBodies(bool)" />
    public void SetUseKinematicBodies(bool @useKinematicBodies) => ((TileMapLayer)_host).SetUseKinematicBodies(@useKinematicBodies);

    /// <inheritdoc cref="TileMapLayer.IsUsingKinematicBodies()" />
    public bool IsUsingKinematicBodies() => ((TileMapLayer)_host).IsUsingKinematicBodies();

    /// <inheritdoc cref="TileMapLayer.SetCollisionVisibilityMode(TileMapLayer.DebugVisibilityMode)" />
    public void SetCollisionVisibilityMode(TileMapLayer.DebugVisibilityMode @visibilityMode) => ((TileMapLayer)_host).SetCollisionVisibilityMode(@visibilityMode);

    /// <inheritdoc cref="TileMapLayer.GetCollisionVisibilityMode()" />
    public TileMapLayer.DebugVisibilityMode GetCollisionVisibilityMode() => ((TileMapLayer)_host).GetCollisionVisibilityMode();

    /// <inheritdoc cref="TileMapLayer.SetPhysicsQuadrantSize(int)" />
    public void SetPhysicsQuadrantSize(int @size) => ((TileMapLayer)_host).SetPhysicsQuadrantSize(@size);

    /// <inheritdoc cref="TileMapLayer.GetPhysicsQuadrantSize()" />
    public int GetPhysicsQuadrantSize() => ((TileMapLayer)_host).GetPhysicsQuadrantSize();

    /// <inheritdoc cref="TileMapLayer.SetOcclusionEnabled(bool)" />
    public void SetOcclusionEnabled(bool @enabled) => ((TileMapLayer)_host).SetOcclusionEnabled(@enabled);

    /// <inheritdoc cref="TileMapLayer.IsOcclusionEnabled()" />
    public bool IsOcclusionEnabled() => ((TileMapLayer)_host).IsOcclusionEnabled();

    /// <inheritdoc cref="TileMapLayer.SetNavigationEnabled(bool)" />
    public void SetNavigationEnabled(bool @enabled) => ((TileMapLayer)_host).SetNavigationEnabled(@enabled);

    /// <inheritdoc cref="TileMapLayer.IsNavigationEnabled()" />
    public bool IsNavigationEnabled() => ((TileMapLayer)_host).IsNavigationEnabled();

    /// <inheritdoc cref="TileMapLayer.SetNavigationMap(Rid)" />
    public void SetNavigationMap(Rid @map) => ((TileMapLayer)_host).SetNavigationMap(@map);

    /// <inheritdoc cref="TileMapLayer.GetNavigationMap()" />
    public Rid GetNavigationMap() => ((TileMapLayer)_host).GetNavigationMap();

    /// <inheritdoc cref="TileMapLayer.SetNavigationVisibilityMode(TileMapLayer.DebugVisibilityMode)" />
    public void SetNavigationVisibilityMode(TileMapLayer.DebugVisibilityMode @showNavigation) => ((TileMapLayer)_host).SetNavigationVisibilityMode(@showNavigation);

    /// <inheritdoc cref="TileMapLayer.GetNavigationVisibilityMode()" />
    public TileMapLayer.DebugVisibilityMode GetNavigationVisibilityMode() => ((TileMapLayer)_host).GetNavigationVisibilityMode();

}
