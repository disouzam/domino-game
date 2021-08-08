using System;
using System.Collections.Generic;
using static domino.models.Utils;

namespace domino.models
{
  public class Stock : IDominoActor
  {
    private static Random randomGenerator = new Random(0);

    private bool _FullSet = false;

    private int _MaxEndValue = int.MinValue;

    private int _MaxNumberTiles = int.MinValue;

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

    private int MaxNumberTiles()
    {
      int combinations;
      int doubles;
      if (_MaxEndValue >= 0)
      {
        doubles = _MaxEndValue + 1;
        combinations = factorial(_MaxEndValue + 1) / (factorial(2) * factorial(_MaxEndValue + 1 - 2));
        return combinations + doubles;
      }
      else
      {
        return int.MinValue;
      }
    }

    public void AddTile(Tile tile)
    {
      if (TileCount == 0 && tile != null)
      {
        _MaxEndValue = Tile.MaxEndValue;
        _MaxNumberTiles = MaxNumberTiles();
      }

      if (Tile.MaxEndValue != _MaxEndValue)
      {
        throw new InvalidOperationException($"Stock can't be formed of tiles from different domino sets.");
      }

      if (_FullSet)
      {
        throw new InvalidOperationException($"Stock already contains a full domino set.");
      }

      foreach (var item in _TileList)
      {
        if (item.End1 == tile.End1 && item.End2 == tile.End2)
        {
          throw new InvalidOperationException($"A stock can't have repeated tiles.");
        }
      }

      _TileList.Add(tile);

      if (_TileList.Count == _MaxNumberTiles)
      {
        _FullSet = true;
      }

    }

    public Tile RandomTileRemoval()
    {
      var size = TileCount;
      if (size > 0)
      {
        int index = randomGenerator.Next(size);

        Tile tile = _TileList[index];
        _TileList.RemoveAt(index);
        return tile;
      }else
      {
        return null;
      }

      
    }

    public int TileCount
    {
      get
      {
        return _TileList.Count;
      }
    }

    public List<Tile> TileSet
    {
      get
      {
        return _TileList;
      }
    }
  }
}