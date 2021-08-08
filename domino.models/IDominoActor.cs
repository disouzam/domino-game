using System.Collections.Generic;

namespace domino.models
{
    public interface IDominoActor
    {
      List<Tile> TileSet();

      void AddTile(Tile tile);

      int TileCount();

      Tile RandomTileRemoval();
    }
}