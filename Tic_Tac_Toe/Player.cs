using System;

namespace Tic_Tac_Toe
{
  internal class Player
  {
    public readonly Char name;
    public int[] positions;

    public Player(Char playerName){
      this.name = playerName;
    }

  }
}