public class Spot {

  public Spot (int id, bool isBoardLayout3D, ) 
  {
    OccupiedById = id;
    IsBoardLayout3D = isBoardLayout3D;
    IsOccupied = true;

  }
  public string XLocation { get; set; }
  public string YLocation { get; set; }
  public string ZLocation { get; set; }

  public int OccupiedById { get; set; }
  public bool IsOccupied { get; set; }
  public bool IsBoardLayout3D { get; set; }
}