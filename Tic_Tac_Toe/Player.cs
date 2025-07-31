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
  }
}

enum Symbol {X,O};