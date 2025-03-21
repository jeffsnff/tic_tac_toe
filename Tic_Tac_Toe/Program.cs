﻿using System;
using System.Reflection.Metadata;

namespace Tic_Tac_Toe
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Player playerOne = new Player(Convert.ToChar("X"));
      Player playerTwo = new Player(Convert.ToChar("O"));
      Grid board = new Grid();
      byte turn = 1;

      Intro();
      while (!board.ThreeInRow())
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
          CheckWin(board, playerTwo);
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

          CheckWin(board, playerOne);
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