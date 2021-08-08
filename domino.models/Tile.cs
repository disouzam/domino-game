using System;
using System.Text;
using static System.Math;

namespace domino.models
{
  public class Tile
  {
    private static readonly int _MAX_END_VALUE = 6;

    private int _End1 = int.MinValue;

    private int _End2 = int.MinValue;

    public Tile(int End1, int End2)
    {
      if (End1 > _MAX_END_VALUE || End2 > _MAX_END_VALUE)
      {
        throw new InvalidOperationException($"Maximum end value is {_MAX_END_VALUE}");
      }

      if (End1 < 0 || End2 < 0)
      {
        throw new InvalidOperationException($"Negative values are not allowed.");
      }

      _End1 = Min(End1, End2);
      _End2 = Max(End1, End2);
    }

    public int End1
    {
      get
      {
        return _End1;
      }
    }

    public int End2
    {
      get
      {
        return _End2;
      }
    }

    public static int MaxEndValue
    {
      get
      {
        return _MAX_END_VALUE;
      }
    }

    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append($"Tile... {_End1} - {_End2}.");
      return sb.ToString();
    }
  }
}
