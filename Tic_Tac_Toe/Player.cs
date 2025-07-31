using System;

namespace Tic_Tac_Toe
{
  internal class Player
  {
    private Symbol symbol { get; }

    public Player(Symbol symbol)
    {
      this.symbol = symbol;
    }

    public Symbol GetSymbol()
    {
      return symbol;
    }

    public void PlayerMove(Board board)
    {
      while (true)
      {
        int playerMove;
        Console.Write($"Player {GetSymbol()} choose a location: ");
        if (int.TryParse(Console.ReadLine(), out playerMove))
        {
          if (board.LegalMove(playerMove))
          {
            board.UpdateBoard(playerMove, GetSymbol());
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
  }
}

enum Symbol {X,O};