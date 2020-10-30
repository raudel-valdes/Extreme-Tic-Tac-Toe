public class Board {
  public Board(int x, int y, int z) {
  
    this.setUpNew2DBoard();
  }

  public Board(int x, int y) 
  {
    this.setUpNew3DBoard();
    PrintBoard(this.BoardLayout3D);
  }

  public void setUpNew2DBoard() 
  {
    
  }

  public void setUpNew3DBoard() 
  {

  }

  public void PrintBoard(Spot[,,] board) 
  {

  }

  Spot [,] BoardLayout2D { get; set; }
  Spot [,,] BoardLayout3D { get; set; }
}