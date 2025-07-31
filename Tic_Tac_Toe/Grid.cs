using System;
using System.Dynamic;
using System.Linq;

namespace Tic_Tac_Toe
{
  internal class Board
  {
    private string[] gridArray = new string[] {"1","2","3","4","5","6","7","8","9"};
    private int turn { get; set; } = 1;

    public Board() { }
    public int Turn
    {
      get { return turn; }
    }
    public void DrawBoard()
    {
      Console.Clear();
      Console.WriteLine();
      Console.WriteLine();
      for (int j = 1; j <= 9; j++)
      {
        Console.Write($" {gridArray[j - 1]}");
        if (j % 3 != 0)
        {
          Console.Write(" |");
        }
        if (j % 3 == 0 && j < 7)
        {
          Console.Write("\n--- --- ---\n");
        }
      }
      Console.WriteLine();
      Console.WriteLine();
    }
    public void CheckWin(Player player)
    {
      if (ThreeInRow())
      {
        DrawBoard();
        Console.WriteLine($"Player {player.GetSymbol()} has won!");
      }
    }
    public bool LegalMove(int playerMove)
    {
      if (playerMove < 1 || playerMove > 9)
      {
        return false;
      }
      return true;
    }
    
    public void NextTurn()
    {
      turn++;
    }
    public void UpdateBoard(int playerMove, Symbol player)
    {
      if (this.gridArray.Contains(playerMove.ToString()))
      {
        this.gridArray[Convert.ToInt32(playerMove) - 1] = player.ToString();
      }
      else
      {
        Console.WriteLine("That space is not available.");
      }
    }
    public bool ThreeInRow()
    {
      bool row1 = gridArray[0] == gridArray[1] && gridArray[1] == gridArray[2];
      bool row2 = gridArray[3] == gridArray[4] && gridArray[4] == gridArray[5];
      bool row3 = gridArray[6] == gridArray[7] && gridArray[7] == gridArray[8];

      bool col1 = gridArray[0] == gridArray[3] && gridArray[3] == gridArray[6];
      bool col2 = gridArray[1] == gridArray[4] && gridArray[4] == gridArray[7];
      bool col3 = gridArray[2] == gridArray[5] && gridArray[5] == gridArray[8];

      bool diagDown = gridArray[0] == gridArray[4] && gridArray[4] == gridArray[8];
      bool diagUp = gridArray[6] == gridArray[4] && gridArray[4] == gridArray[2];

      return row1 || row2 || row3 || col1 || col2 || col3 || diagDown || diagUp;
    }
  }
}