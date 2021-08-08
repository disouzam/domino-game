using System;
using System.Collections.Generic;

namespace domino.models
{
  public class Stock : IDominoActor
  {
    private bool _FullSet = false;

    private int _MaxEndValue = int.MinValue;

    private List<Tile> _TileList = new List<Tile>();

    public Stock(DominoSet dominoSet)
    {
      _TileList = dominoSet.Tiles;
      _FullSet = true;
      _MaxEndValue = dominoSet.MaxEndValue;
    }

    public Stock()
    {

    }

    public void AddTile(Tile tile)
    {
      if (tile.MaxEndValue != _MaxEndValue) 
      {
        throw new InvalidOperationException($"Stock can't be formed of tiles from different domino sets.");
      }
      if (TileCount() == 0) _MaxEndValue = tile.MaxEndValue;
      if (_FullSet)
      {
        throw new InvalidOperationException($"Stock already contains a full domino set.");
      }
    }

    public Tile RandomTileRemoval()
    {
      throw new System.NotImplementedException();
    }

    public int TileCount()
    {
      return _TileList.Count;
    }

    public List<Tile> TileSet()
    {
      throw new System.NotImplementedException();
    }
  }
}