using System;

namespace domino.models
{
  public static class Utils
  {
    public static int factorial(int n)
    {
      if (n < 0)
      {
        throw new ArgumentOutOfRangeException("Invalid argument");
      }
      if (n == 0 || n == 1)
      {
        return 1;
      }
      else
      {
        return n * factorial(n - 1);
      }
    }

    public static int DominoSetSize(int MaxEndValue)
    {
      int doubles = MaxEndValue + 1;
      int combinations = factorial(MaxEndValue + 1) / (factorial(2) * factorial(MaxEndValue + 1 - 2));
      return doubles + combinations;
    }
  }
}