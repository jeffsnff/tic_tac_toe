using System;

namespace Tic_Tac_Toe
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Player playerOne = new Player(Convert.ToChar("X"));
      Player playerTwo = new Player(Convert.ToChar("O"));

      Grid board = new Grid(9);
    }
  }
}