#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="TileMap" />
[Tool, GlobalClass]
public abstract partial class TileMapComponent : Node2DComponent
{

    /// <inheritdoc cref="TileMap._TileDataRuntimeUpdate(int, Vector2I, TileData)" />
    public virtual void _TileDataRuntimeUpdate(int @layer, Vector2I @coords, TileData @tileData) { }

    /// <inheritdoc cref="TileMap._UseTileDataRuntimeUpdate(int, Vector2I)" />
    public virtual bool _UseTileDataRuntimeUpdate(int @layer, Vector2I @coords) => ((TileMap)_host)._UseTileDataRuntimeUpdate(@layer, @coords);

    /// <inheritdoc cref="TileMap.SetNavigationMap(int, Rid)" />
    public void SetNavigationMap(int @layer, Rid @map) => ((TileMap)_host).SetNavigationMap(@layer, @map);

    /// <inheritdoc cref="TileMap.GetNavigationMap(int)" />
    public Rid GetNavigationMap(int @layer) => ((TileMap)_host).GetNavigationMap(@layer);

    /// <inheritdoc cref="TileMap.ForceUpdate(int)" />
    public void ForceUpdate(int @layer) => ((TileMap)_host).ForceUpdate(@layer);

    /// <inheritdoc cref="TileMap.SetTileset(TileSet)" />
    public void SetTileset(TileSet @tileset) => ((TileMap)_host).SetTileset(@tileset);

    /// <inheritdoc cref="TileMap.GetTileset()" />
    public TileSet GetTileset() => ((TileMap)_host).GetTileset();

    /// <inheritdoc cref="TileMap.SetRenderingQuadrantSize(int)" />
    public void SetRenderingQuadrantSize(int @size) => ((TileMap)_host).SetRenderingQuadrantSize(@size);

    /// <inheritdoc cref="TileMap.GetRenderingQuadrantSize()" />
    public int GetRenderingQuadrantSize() => ((TileMap)_host).GetRenderingQuadrantSize();

    /// <inheritdoc cref="TileMap.GetLayersCount()" />
    public int GetLayersCount() => ((TileMap)_host).GetLayersCount();

    /// <inheritdoc cref="TileMap.AddLayer(int)" />
    public void AddLayer(int @toPosition) => ((TileMap)_host).AddLayer(@toPosition);

    /// <inheritdoc cref="TileMap.MoveLayer(int, int)" />
    public void MoveLayer(int @layer, int @toPosition) => ((TileMap)_host).MoveLayer(@layer, @toPosition);

    /// <inheritdoc cref="TileMap.RemoveLayer(int)" />
    public void RemoveLayer(int @layer) => ((TileMap)_host).RemoveLayer(@layer);

    /// <inheritdoc cref="TileMap.SetLayerName(int, string)" />
    public void SetLayerName(int @layer, string @name) => ((TileMap)_host).SetLayerName(@layer, @name);

    /// <inheritdoc cref="TileMap.GetLayerName(int)" />
    public string GetLayerName(int @layer) => ((TileMap)_host).GetLayerName(@layer);

    /// <inheritdoc cref="TileMap.SetLayerEnabled(int, bool)" />
    public void SetLayerEnabled(int @layer, bool @enabled) => ((TileMap)_host).SetLayerEnabled(@layer, @enabled);

    /// <inheritdoc cref="TileMap.IsLayerEnabled(int)" />
    public bool IsLayerEnabled(int @layer) => ((TileMap)_host).IsLayerEnabled(@layer);

    /// <inheritdoc cref="TileMap.SetLayerModulate(int, Color)" />
    public void SetLayerModulate(int @layer, Color @modulate) => ((TileMap)_host).SetLayerModulate(@layer, @modulate);

    /// <inheritdoc cref="TileMap.GetLayerModulate(int)" />
    public Color GetLayerModulate(int @layer) => ((TileMap)_host).GetLayerModulate(@layer);

    /// <inheritdoc cref="TileMap.SetLayerYSortEnabled(int, bool)" />
    public void SetLayerYSortEnabled(int @layer, bool @ySortEnabled) => ((TileMap)_host).SetLayerYSortEnabled(@layer, @ySortEnabled);

    /// <inheritdoc cref="TileMap.IsLayerYSortEnabled(int)" />
    public bool IsLayerYSortEnabled(int @layer) => ((TileMap)_host).IsLayerYSortEnabled(@layer);

    /// <inheritdoc cref="TileMap.SetLayerYSortOrigin(int, int)" />
    public void SetLayerYSortOrigin(int @layer, int @ySortOrigin) => ((TileMap)_host).SetLayerYSortOrigin(@layer, @ySortOrigin);

    /// <inheritdoc cref="TileMap.GetLayerYSortOrigin(int)" />
    public int GetLayerYSortOrigin(int @layer) => ((TileMap)_host).GetLayerYSortOrigin(@layer);

    /// <inheritdoc cref="TileMap.SetLayerZIndex(int, int)" />
    public void SetLayerZIndex(int @layer, int @zIndex) => ((TileMap)_host).SetLayerZIndex(@layer, @zIndex);

    /// <inheritdoc cref="TileMap.GetLayerZIndex(int)" />
    public int GetLayerZIndex(int @layer) => ((TileMap)_host).GetLayerZIndex(@layer);

    /// <inheritdoc cref="TileMap.SetLayerNavigationEnabled(int, bool)" />
    public void SetLayerNavigationEnabled(int @layer, bool @enabled) => ((TileMap)_host).SetLayerNavigationEnabled(@layer, @enabled);

    /// <inheritdoc cref="TileMap.IsLayerNavigationEnabled(int)" />
    public bool IsLayerNavigationEnabled(int @layer) => ((TileMap)_host).IsLayerNavigationEnabled(@layer);

    /// <inheritdoc cref="TileMap.SetLayerNavigationMap(int, Rid)" />
    public void SetLayerNavigationMap(int @layer, Rid @map) => ((TileMap)_host).SetLayerNavigationMap(@layer, @map);

    /// <inheritdoc cref="TileMap.GetLayerNavigationMap(int)" />
    public Rid GetLayerNavigationMap(int @layer) => ((TileMap)_host).GetLayerNavigationMap(@layer);

    /// <inheritdoc cref="TileMap.SetCollisionAnimatable(bool)" />
    public void SetCollisionAnimatable(bool @enabled) => ((TileMap)_host).SetCollisionAnimatable(@enabled);

    /// <inheritdoc cref="TileMap.IsCollisionAnimatable()" />
    public bool IsCollisionAnimatable() => ((TileMap)_host).IsCollisionAnimatable();

    /// <inheritdoc cref="TileMap.SetCollisionVisibilityMode(TileMap.VisibilityMode)" />
    public void SetCollisionVisibilityMode(TileMap.VisibilityMode @collisionVisibilityMode) => ((TileMap)_host).SetCollisionVisibilityMode(@collisionVisibilityMode);

    /// <inheritdoc cref="TileMap.GetCollisionVisibilityMode()" />
    public TileMap.VisibilityMode GetCollisionVisibilityMode() => ((TileMap)_host).GetCollisionVisibilityMode();

    /// <inheritdoc cref="TileMap.SetNavigationVisibilityMode(TileMap.VisibilityMode)" />
    public void SetNavigationVisibilityMode(TileMap.VisibilityMode @navigationVisibilityMode) => ((TileMap)_host).SetNavigationVisibilityMode(@navigationVisibilityMode);

    /// <inheritdoc cref="TileMap.GetNavigationVisibilityMode()" />
    public TileMap.VisibilityMode GetNavigationVisibilityMode() => ((TileMap)_host).GetNavigationVisibilityMode();

    /// <inheritdoc cref="TileMap.SetCell(int, Vector2I, int, Vector2I?, int)" />
    public void SetCell(int @layer, Vector2I @coords, int @sourceId, Vector2I? @atlasCoords, int @alternativeTile) => ((TileMap)_host).SetCell(@layer, @coords, @sourceId, @atlasCoords, @alternativeTile);

    /// <inheritdoc cref="TileMap.EraseCell(int, Vector2I)" />
    public void EraseCell(int @layer, Vector2I @coords) => ((TileMap)_host).EraseCell(@layer, @coords);

    /// <inheritdoc cref="TileMap.GetCellSourceId(int, Vector2I, bool)" />
    public int GetCellSourceId(int @layer, Vector2I @coords, bool @useProxies) => ((TileMap)_host).GetCellSourceId(@layer, @coords, @useProxies);

    /// <inheritdoc cref="TileMap.GetCellAtlasCoords(int, Vector2I, bool)" />
    public Vector2I GetCellAtlasCoords(int @layer, Vector2I @coords, bool @useProxies) => ((TileMap)_host).GetCellAtlasCoords(@layer, @coords, @useProxies);

    /// <inheritdoc cref="TileMap.GetCellAlternativeTile(int, Vector2I, bool)" />
    public int GetCellAlternativeTile(int @layer, Vector2I @coords, bool @useProxies) => ((TileMap)_host).GetCellAlternativeTile(@layer, @coords, @useProxies);

    /// <inheritdoc cref="TileMap.GetCellTileData(int, Vector2I, bool)" />
    public TileData GetCellTileData(int @layer, Vector2I @coords, bool @useProxies) => ((TileMap)_host).GetCellTileData(@layer, @coords, @useProxies);

    /// <inheritdoc cref="TileMap.IsCellFlippedH(int, Vector2I, bool)" />
    public bool IsCellFlippedH(int @layer, Vector2I @coords, bool @useProxies) => ((TileMap)_host).IsCellFlippedH(@layer, @coords, @useProxies);

    /// <inheritdoc cref="TileMap.IsCellFlippedV(int, Vector2I, bool)" />
    public bool IsCellFlippedV(int @layer, Vector2I @coords, bool @useProxies) => ((TileMap)_host).IsCellFlippedV(@layer, @coords, @useProxies);

    /// <inheritdoc cref="TileMap.IsCellTransposed(int, Vector2I, bool)" />
    public bool IsCellTransposed(int @layer, Vector2I @coords, bool @useProxies) => ((TileMap)_host).IsCellTransposed(@layer, @coords, @useProxies);

    /// <inheritdoc cref="TileMap.GetCoordsForBodyRid(Rid)" />
    public Vector2I GetCoordsForBodyRid(Rid @body) => ((TileMap)_host).GetCoordsForBodyRid(@body);

    /// <inheritdoc cref="TileMap.GetLayerForBodyRid(Rid)" />
    public int GetLayerForBodyRid(Rid @body) => ((TileMap)_host).GetLayerForBodyRid(@body);

    /// <inheritdoc cref="TileMap.GetPattern(int, Array{Vector2I})" />
    public TileMapPattern GetPattern(int @layer, Array<Vector2I> @coordsArray) => ((TileMap)_host).GetPattern(@layer, @coordsArray);

    /// <inheritdoc cref="TileMap.MapPattern(Vector2I, Vector2I, TileMapPattern)" />
    public Vector2I MapPattern(Vector2I @positionInTilemap, Vector2I @coordsInPattern, TileMapPattern @pattern) => ((TileMap)_host).MapPattern(@positionInTilemap, @coordsInPattern, @pattern);

    /// <inheritdoc cref="TileMap.SetPattern(int, Vector2I, TileMapPattern)" />
    public void SetPattern(int @layer, Vector2I @position, TileMapPattern @pattern) => ((TileMap)_host).SetPattern(@layer, @position, @pattern);

    /// <inheritdoc cref="TileMap.SetCellsTerrainConnect(int, Array{Vector2I}, int, int, bool)" />
    public void SetCellsTerrainConnect(int @layer, Array<Vector2I> @cells, int @terrainSet, int @terrain, bool @ignoreEmptyTerrains) => ((TileMap)_host).SetCellsTerrainConnect(@layer, @cells, @terrainSet, @terrain, @ignoreEmptyTerrains);

    /// <inheritdoc cref="TileMap.SetCellsTerrainPath(int, Array{Vector2I}, int, int, bool)" />
    public void SetCellsTerrainPath(int @layer, Array<Vector2I> @path, int @terrainSet, int @terrain, bool @ignoreEmptyTerrains) => ((TileMap)_host).SetCellsTerrainPath(@layer, @path, @terrainSet, @terrain, @ignoreEmptyTerrains);

    /// <inheritdoc cref="TileMap.FixInvalidTiles()" />
    public void FixInvalidTiles() => ((TileMap)_host).FixInvalidTiles();

    /// <inheritdoc cref="TileMap.ClearLayer(int)" />
    public void ClearLayer(int @layer) => ((TileMap)_host).ClearLayer(@layer);

    /// <inheritdoc cref="TileMap.Clear()" />
    public void Clear() => ((TileMap)_host).Clear();

    /// <inheritdoc cref="TileMap.UpdateInternals()" />
    public void UpdateInternals() => ((TileMap)_host).UpdateInternals();

    /// <inheritdoc cref="TileMap.NotifyRuntimeTileDataUpdate(int)" />
    public void NotifyRuntimeTileDataUpdate(int @layer) => ((TileMap)_host).NotifyRuntimeTileDataUpdate(@layer);

    /// <inheritdoc cref="TileMap.GetSurroundingCells(Vector2I)" />
    public Array<Vector2I> GetSurroundingCells(Vector2I @coords) => ((TileMap)_host).GetSurroundingCells(@coords);

    /// <inheritdoc cref="TileMap.GetUsedCells(int)" />
    public Array<Vector2I> GetUsedCells(int @layer) => ((TileMap)_host).GetUsedCells(@layer);

    /// <inheritdoc cref="TileMap.GetUsedCellsById(int, int, Vector2I?, int)" />
    public Array<Vector2I> GetUsedCellsById(int @layer, int @sourceId, Vector2I? @atlasCoords, int @alternativeTile) => ((TileMap)_host).GetUsedCellsById(@layer, @sourceId, @atlasCoords, @alternativeTile);

    /// <inheritdoc cref="TileMap.GetUsedRect()" />
    public Rect2I GetUsedRect() => ((TileMap)_host).GetUsedRect();

    /// <inheritdoc cref="TileMap.MapToLocal(Vector2I)" />
    public Vector2 MapToLocal(Vector2I @mapPosition) => ((TileMap)_host).MapToLocal(@mapPosition);

    /// <inheritdoc cref="TileMap.LocalToMap(Vector2)" />
    public Vector2I LocalToMap(Vector2 @localPosition) => ((TileMap)_host).LocalToMap(@localPosition);

    /// <inheritdoc cref="TileMap.GetNeighborCell(Vector2I, TileSet.CellNeighbor)" />
    public Vector2I GetNeighborCell(Vector2I @coords, TileSet.CellNeighbor @neighbor) => ((TileMap)_host).GetNeighborCell(@coords, @neighbor);

    /// <inheritdoc cref="TileMap.GetQuadrantSize()" />
    public int GetQuadrantSize() => ((TileMap)_host).GetQuadrantSize();

    /// <inheritdoc cref="TileMap.SetQuadrantSize(int)" />
    public void SetQuadrantSize(int @quadrantSize) => ((TileMap)_host).SetQuadrantSize(@quadrantSize);

}
