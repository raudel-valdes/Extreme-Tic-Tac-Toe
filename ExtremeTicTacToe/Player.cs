using System;
using System.Collections;
using System.Collections.Generic;

public class Player {
  public Player(string name, int id) 
  {
    Name = name;
    Id = id;
    NumberOfMoves = 0;
  }

  public string Name { get;}
  public int Id { get; }

  public List<string> Moves {
    get { return Moves; }
    set { 
      Moves = value;
      NumberOfMoves++;
    }
  }

  public int NumberOfMoves { get; set; }
}