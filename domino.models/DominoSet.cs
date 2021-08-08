using System.Collections.Generic;
using System.Text;

namespace domino.models
{
  public class DominoSet
  {
    private readonly int _MaxEndValue = int.MinValue;

    private readonly List<Tile> _TileSet = new List<Tile>();

    public DominoSet(int MaxEndValue)
    {
      _MaxEndValue = MaxEndValue;

      int j = 0;
      for (int i = 0; i <= _MaxEndValue; i++)
      {
        while (j <= _MaxEndValue)
        {
          Tile tile = new Tile(i, j);
          _TileSet.Add(tile);
          j++;
        }
        j = i + 1;
      }
    }

    public List<Tile> Tiles
    {
      get
      {
        return _TileSet;
      }
    }

    public int Size()
    {
      return _TileSet.Count;
    }

    public int MaxEndValue
    {
      get
      {
        return _MaxEndValue;
      }
    }

    public override string ToString()
    {
      var sb = new StringBuilder();
      foreach (var item in _TileSet)
      {
        sb.AppendLine(item.ToString());
      }
      return sb.ToString();
    }
  }
}
