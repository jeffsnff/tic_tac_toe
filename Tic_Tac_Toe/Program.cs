using System;
using System.Reflection.Metadata;

namespace Tic_Tac_Toe
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Player playerOne = new Player("X");
      Player playerTwo = new Player("O");
      Grid board = new Grid();
      int turn = 1;

      Intro();
      while (!board.ThreeInRow())
      {
        int playerMove;
        board.DrawBoard();
        if (turn % 2 == 0)
        {
          // TODO: Consider refactoring this logic into a helper function since it is also used above.
          Console.Write($"Player {playerTwo.name} choose a location: ");
          if (int.TryParse(Console.ReadLine(), out playerMove))
          {
            if (playerMove < 1 || playerMove > 9)
            {
              Console.WriteLine($"{playerMove} is an invalid selection.\nPlease try again.");
              continue;
            }
            board.UpdateBoard(playerMove, playerTwo.name);
            CheckWin(board, playerTwo);
          }
        }
        else
        {
          // TODO: Consider refactoring this logic into a helper function since it is also used above.
          Console.Write($"Player {playerOne.name} choose a location: ");
          if (int.TryParse(Console.ReadLine(), out playerMove))
          {
            if (playerMove < 1 || playerMove > 9)
            {
              Console.WriteLine($"{playerMove} is an invalid selection.\nPlease try again.");
              continue;
            }
            board.UpdateBoard(playerMove, playerOne.name);

            CheckWin(board, playerOne);
          }
        }
        turn++;
      }
    }
    private static void CheckWin(Grid board, Player player)
    {
      if (board.ThreeInRow())
      {
        board.DrawBoard();
        Console.WriteLine($"Player {player.name} has won!");
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