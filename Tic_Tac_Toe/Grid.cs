using System;
using System.Linq;

namespace Tic_Tac_Toe
{
  internal class Grid
  {
    private string[] gridArray;

    public Grid(byte number)
    {
      this.gridArray = new string[9];
      this.gridArray = CreateArray(number, gridArray);
    }

    public void DrawBoard()
    {
      PrintGrid(this.gridArray);
      Console.WriteLine();
    }

    public void UpdateBoard(byte playerMove, Char name)
    {
      if (this.gridArray.Contains(playerMove.ToString()))
      {
        this.gridArray[Convert.ToInt32(playerMove) - 1] = name.ToString();
      }
      else
      {
        Console.WriteLine("That space is not available.");
      }
    }
    private static string[] CreateArray(byte number, string[] gridArray)
    {
      for (int i = 1; i <= number; i++)
      {
        gridArray[i - 1] = i.ToString();
      }
      return gridArray;
    }

    private static void PrintGrid(string[] gridArray)
    {
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
    }
    public bool GameStatus()
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