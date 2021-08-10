using Xunit;
using FluentAssertions;
using domino.models;
using System;
using System.Collections.Generic;
using static domino.models.Utils;

namespace domino.models.test
{
  public class StockTest
  {
    private const int _MaxEndValue = 6;

    [Fact]
    public void StockCreationFromDominoSet()
    {
      DominoSet dominoSet = new DominoSet(_MaxEndValue);
      Stock stock = new Stock(dominoSet);
      stock.TileCount.Should().Be(dominoSet.Size());
    }

    [Fact]
    public void EmptyStockCreation()
    {
      Stock stock = new Stock();
      stock.TileCount.Should().Be(0);
    }

    [Fact]
    public void AddOneTileToEmptyStock()
    {
      Stock stock = new Stock();
      Tile tile = new Tile(0, 0);
      stock.AddTile(tile);

      stock.TileCount.Should().Be(1);
    }

    [Fact]
    public void AddOneTileToStockWith1Tile()
    {
      Stock stock = new Stock();
      Tile tile1 = new Tile(0, 0);
      Tile tile2 = new Tile(0, 1);
      stock.AddTile(tile1);
      stock.AddTile(tile2);

      stock.TileCount.Should().Be(2);
    }

    [Fact]
    public void AddRepeatedTile()
    {
      Stock stock = new Stock();
      Tile tile1 = new Tile(0, 0);
      stock.AddTile(tile1);

      Action act = () =>
      {
        Tile tile2 = new Tile(0, 0);
        stock.AddTile(tile2);
      };
      act.Should().Throw<InvalidOperationException>().WithMessage("A stock can't have repeated tiles.");
      stock.TileCount.Should().Be(1);
    }

    [Fact]
    public void AddingACompleteSet()
    {
      Stock stock = CreateCompleteSet(_MaxEndValue);
      stock.TileCount.Should().Be(DominoSetSize(_MaxEndValue));
    }

    [Fact]
    public void AddingAnExcessTile()
    {
      Stock stock = CreateCompleteSet(_MaxEndValue);
      Tile tile1 = new Tile(0, 0);

      Action act = () =>
      {
        stock.AddTile(tile1);
      };

      act.Should().Throw<InvalidOperationException>().WithMessage($"Stock already contains a full domino set.");
      stock.TileCount.Should().Be(DominoSetSize(_MaxEndValue));
    }

    [Fact]
    public void AddingATilefromADifferentSet()
    {
      // Not implemented
    }

    [Fact]
    public void CheckReturnCompleteTileSet()
    {
      Stock stock = CreateCompleteSet(_MaxEndValue);
      stock.TileCount.Should().Be(DominoSetSize(_MaxEndValue));
      List<Tile> tileSet = stock.TileSet;
      tileSet.Count.Should().Be(DominoSetSize(_MaxEndValue));
    }

    [Fact]
    public void GetARandomTile()
    {
      Stock stock = CreateCompleteSet(_MaxEndValue);
      Tile tile = stock.RandomTileRemoval();
      tile.Should().NotBeNull();
    }

    [Fact]
    public void RemoveAllTiles()
    {
      Stock stock = CreateCompleteSet(_MaxEndValue);
      while (stock.TileCount > 0)
      {
        Tile tile = stock.RandomTileRemoval();
        tile.Should().NotBeNull();
      }

      Tile lastTile = stock.RandomTileRemoval();
      lastTile.Should().BeNull();
    }

    private Stock CreateCompleteSet(int MaxEndValue)
    {
      Stock stock = new Stock();

      int j = 0;
      for (int i = 0; i <= MaxEndValue; i++)
      {
        while (j <= MaxEndValue)
        {
          Tile tile = new Tile(i, j);
          stock.AddTile(tile);
          j++;
        }
        j = i + 1;
      }

      return stock;
    }
  }
}