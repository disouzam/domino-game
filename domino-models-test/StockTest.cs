using Xunit;
using FluentAssertions;
using domino.models;

namespace domino_models_test
{
  public class StockTest
  {
    private const int MaxEndValue = 6;

    [Fact]
    public void StockCreationFromDominoSet()
    {
      DominoSet dominoSet = new DominoSet(MaxEndValue);
      Stock stock = new Stock(dominoSet);
      stock.TileCount().Should().Be(dominoSet.Size());
    }

    [Fact]
    public void EmptyStockCreation()
    {
      Stock stock = new Stock();
      stock.TileCount().Should().Be(0);
    }
  }
}