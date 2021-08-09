using Xunit;
using FluentAssertions;
using domino.models;
using System.Collections.Generic;

namespace domino_models_test
{
  public class DominoSetTest
  {
    private const int MaxEndValue = 6;

    private DominoSet dominoSet;

    public DominoSetTest()
    {
      dominoSet = new DominoSet(MaxEndValue);
    }

    [Fact]
    public void DominoSetCreation()
    {
      dominoSet.Should().BeOfType<DominoSet>();
      dominoSet.Size().Should().Be(28);
    }

    [Fact]
    public void TileSetRetrieval()
    {
      List<Tile> tileList = dominoSet.Tiles;
      tileList.Count.Should().Be(dominoSet.Size());
    }

    [Fact]
    public void CheckMaxEndValue()
    {
      dominoSet.MaxEndValue.Should().Be(MaxEndValue);
    }

    [Fact]
    public void TestingToString()
    {
      string expected = "Tile... 0 - 0.\r\nTile... 0 - 1.\r\nTile... 0 - 2.\r\nTile... 0 - 3.\r\nTile... 0 - 4.\r\nTile... 0 - 5.\r\nTile... 0 - 6.\r\nTile... 1 - 1.\r\nTile... 1 - 2.\r\nTile... 1 - 3.\r\nTile... 1 - 4.\r\nTile... 1 - 5.\r\nTile... 1 - 6.\r\nTile... 2 - 2.\r\nTile... 2 - 3.\r\nTile... 2 - 4.\r\nTile... 2 - 5.\r\nTile... 2 - 6.\r\nTile... 3 - 3.\r\nTile... 3 - 4.\r\nTile... 3 - 5.\r\nTile... 3 - 6.\r\nTile... 4 - 4.\r\nTile... 4 - 5.\r\nTile... 4 - 6.\r\nTile... 5 - 5.\r\nTile... 5 - 6.\r\nTile... 6 - 6.\r\n";
      dominoSet.ToString().Should().BeEquivalentTo(expected);
    }
  }
}