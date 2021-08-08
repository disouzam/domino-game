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
  }
}