using static System.Math;
using Xunit;
using FluentAssertions;
using domino.models;
using System;

namespace domino.models.test
{
  public class TileTest
  {
    const int _MAX_END_VALUE = 6;

    [Fact]
    public void TileCreation()
    {
      for (int i = 0; i <= _MAX_END_VALUE; i++)
      {
        for (int j = 0; j <= _MAX_END_VALUE; j++)
        {
          Tile tile = new Tile(i, j);
          tile.Should().BeOfType<Tile>();

          tile.End1.Should().Be(Min(i, j));
          tile.End2.Should().Be(Max(i, j));
        }
      }
    }

    [Fact]
    public void StringFormatting()
    {
      Tile tile = new Tile(1, 3);
      var expectedString = "Tile... 1 - 3.";
      tile.ToString().Should().Be(expectedString);
    }

    [Fact]
    public void CheckMaxEndValueValidation()
    {
      Tile tile = null;
      Action act = () =>
      {
        tile = new Tile(_MAX_END_VALUE + 1, 0);
      };

      act.Should().Throw<InvalidOperationException>().WithMessage($"Maximum end value is {Tile.MaxEndValue}");
    }

    [Fact]
    public void CheckNegativeParameters()
    {
      Tile tile = null;
      Action act = () =>
      {
        tile = new Tile(-1, 0);
      };
      act.Should().Throw<InvalidOperationException>().WithMessage($"Negative values are not allowed.");
    }
  }
}
