using System;
using System.Linq;

namespace Tic_Tac_Toe
{
  internal class Grid
  {
    string[] gridArray;

    public Grid(byte number)
    {
      this.gridArray = new string[9];
      this.gridArray = CreateArray(number, gridArray);
      PrintGrid(this.gridArray);
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
  }
}