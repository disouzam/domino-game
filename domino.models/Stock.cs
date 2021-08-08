using System.Collections.Generic;

namespace domino.models
{
  public class Stock : IDominoActor
  {
    private DominoSet _DominoSet = null;

    private List<Tile> _TileList = new List<Tile>();

    public Stock(DominoSet dominoSet)
    {
      _TileList = dominoSet.Tiles();
    }

    public Stock()
    {

    }

    void IDominoActor.AddTile(Tile tile)
    {
      throw new System.NotImplementedException();
    }

    Tile IDominoActor.RandomTileRemoval()
    {
      throw new System.NotImplementedException();
    }

    int IDominoActor.TileCount()
    {
      throw new System.NotImplementedException();
    }

    List<Tile> IDominoActor.TileSet()
    {
      throw new System.NotImplementedException();
    }
  }
}