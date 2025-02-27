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
      Boolean gameOver = false;
      byte turn = 1;

      Intro();
      while (!gameOver)
      {
        byte playerMove;
        board.DrawBoard();
        if (turn % 2 == 0)
        {
          Console.Write($"Player {playerTwo.name} choose a location: ");
          playerMove = Convert.ToByte(Console.ReadLine());
          if (playerMove < 1 || playerMove > 9)
          {
            Console.WriteLine($"{playerMove} is an invalid selection.\nPlease try again.");
            continue;
          }
          board.UpdateBoard(playerMove, playerTwo.name);

          if (board.GameStatus())
          {
            Console.WriteLine($"Player {playerTwo.name} has won!");
            break;
          }
        }
        else
        {
          Console.Write($"Player {playerOne.name} choose a location: ");
          playerMove = Convert.ToByte(Console.ReadLine());
          if (playerMove < 1 || playerMove > 9)
          {
            Console.WriteLine($"{playerMove} is an invalid selection.\nPlease try again.");
            continue;
          }
          board.UpdateBoard(playerMove, playerOne.name);
         
          if (board.GameStatus())
          {
            Console.WriteLine($"Player {playerOne.name} has won!");
            break;
          }
        }
        turn++;
      }
    }

    private static void Intro()
    {
      Console.Clear();
      Console.WriteLine("Welcome to Tic Tac Toe\n\n");
    }
  }
}