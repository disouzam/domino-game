using System.Collections.Generic;

namespace domino.models
{
  public class Player : IDominoActor
  {
    public List<Tile> TileSet => throw new System.NotImplementedException();

    public int TileCount => throw new System.NotImplementedException();

    public void AddTile(Tile tile)
    {
      throw new System.NotImplementedException();
    }

    public Tile RandomTileRemoval()
    {
      throw new System.NotImplementedException();
    }
  }
}