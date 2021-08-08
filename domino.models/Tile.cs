using System;
using System.Text;

namespace domino.models
{
  public class Tile
  {
    private const int MAX_END_VALUE = 6;

    private int _End1 = int.MinValue;

    private int _End2 = int.MinValue;

    public Tile(int End1, int End2)
    {
      if (End1 > MAX_END_VALUE || End2 > MAX_END_VALUE)
      {
        throw new InvalidOperationException($"Maximum end value is {MAX_END_VALUE}");
      }

      if (End1 < 0 || End2 < 0)
      {
        throw new InvalidOperationException($"Negative values are not allowed.");
      }

      _End1 = End1;
      _End2 = End2;
    }

    public int end1
    {
      get
      {
        return _End1;
      }
    }

    public int end2
    {
      get
      {
        return _End2;
      }
    }

    public override string ToString()
    {
      int min = end1 < end2 ? end1 : end2;
      int max = end1 < end2 ? end2 : end1;

      var sb = new StringBuilder();
      sb.AppendLine($"Tile...{min} - {max}");
      return sb.ToString();
    }
  }
}
