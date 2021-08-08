using System.Collections.Generic;

namespace domino.models
{
  public class DominoSet
  {
    private readonly int _MaxEndValue = int.MinValue;

    private readonly List<Tile> _TileSet = new List<Tile>();

    public DominoSet(int MaxEndValue)
    {
      _MaxEndValue = MaxEndValue;
    }

    public int Size()
    {
      return _TileSet.Count;
    }
  }
}
