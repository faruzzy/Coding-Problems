using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SquareDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "input.txt";
            var lines = File.ReadAllLines(inputFile);
            
            for (int j = 1; j < lines.Length; j++)
            {
                int n = int.Parse(lines[j]);
                int[,] grid = new int[n, n];
                var currentLine = lines[j + 1];

                // fill the grid
                var comparator = new List<List<int>>();
                var bb = new List<int>();

                for (int row = 0; row < grid.GetLength(0); row++)
                    for (int column = 0; column <= grid.GetLength(1); column++)
                        for (int s = 0; s < currentLine.Length; s++)
                            grid[row, column] = currentLine[column];

                for (int row = 0; row < grid.GetLength(0); row++)
                    for(int column = 0; column <= grid.GetLength(1); column++)
                        for (int i = 0; i < currentLine.Length; i++)
                            if (currentLine[column].Equals("#"))
                                bb.Add(1);
                            else
                                bb.Add(0);
            }
        }
    }
}
