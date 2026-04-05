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
        if (!int.TryParse(Console.ReadLine(), out playerMove))
        {
          Console.WriteLine($"\nEnter a value between 1 - 9");
          Console.ReadKey();
          board.DrawBoard();
          continue;
        }
        
        if(!board.LegalMove(playerMove))
        {
          Console.WriteLine($"\n{playerMove} is not an option");
          Console.ReadKey();
          board.DrawBoard();
          continue;
        }
        board.UpdateBoard(playerMove, GetSymbol());
        break;
      }
    }
  }
}

enum Symbol {X,O};