using System;
using System.Reflection.Metadata;

namespace Tic_Tac_Toe
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Player playerOne = new Player(Symbol.X);
      Player playerTwo = new Player(Symbol.O);
      Board board = new Board();

      Intro();
      while (!board.ThreeInRow())
      {
        board.DrawBoard();
        if (board.Turn % 2 == 0)
        {
          playerTwo.PlayerMove(board);
          board.CheckWin(playerTwo);
        }
        else
        {
          playerOne.PlayerMove(board);
          board.CheckWin(playerOne);
        }
        board.NextTurn();
      }
    }
    private static void Intro()
    {
      Console.Clear();
      Console.WriteLine("Welcome to Tic Tac Toe\n\n");
      Console.ReadKey();
    }
  }
}