using static System.Math;
using Xunit;
using FluentAssertions;
using domino.models;

namespace domino_models_test
{
  public class TileTest
  {
    [Fact]
    public void TileCreation()
    {
      const int MAX_END_VALUE = 6;
      for (int i = 0; i <= MAX_END_VALUE; i++)
      {
        for (int j = 0; j <= MAX_END_VALUE; j++)
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
  }
}
