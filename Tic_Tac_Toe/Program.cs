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
      Grid board = new Grid();

      Intro();
      while (!board.ThreeInRow())
      {
        board.DrawBoard();
        if (board.Turn % 2 == 0)
        {
          PlayerMove(playerTwo, board);
        }
        else
        {
          PlayerMove(playerOne, board);
        }
      }
    }
    private static void CheckWin(Grid board, Player player)
    {
      if (board.ThreeInRow())
      {
        board.DrawBoard();
        Console.WriteLine($"Player {player.GetSymbol()} has won!");
      }
    }

    static void PlayerMove(Player player, Grid board)
    {
      int playerMove;
      while (true)
      {
        Console.Write($"Player {player.GetSymbol()} choose a location: ");
        if (int.TryParse(Console.ReadLine(), out playerMove))
        {
          if (board.LegalMove(playerMove))
          {
            board.UpdateBoard(playerMove, player.GetSymbol());
            CheckWin(board, player);
            board.NextTurn();
          }
        }
        else
        {
          Console.WriteLine("\nThat is not an option");
          Console.ReadKey();
          continue;
        }
        break;
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