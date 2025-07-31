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
      Player currentPlayer;

      Intro();
      while (!board.ThreeInRow())
      {
        board.DrawBoard();
        if (board.Turn % 2 == 0)
        {
          currentPlayer = playerTwo;
        }
        else
        {
          currentPlayer = playerOne;
        }
        PlayerMove(currentPlayer, board);
      }
    }
    static void PlayerMove(Player player, Board board)
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
            board.CheckWin(player);
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