using System.Collections.Generic;

namespace domino.models
{
  public interface IDominoActor
  {
    List<Tile> TileSet { get; }

    void AddTile(Tile tile);

    int TileCount { get; }


    Tile RandomTileRemoval();

  }
}