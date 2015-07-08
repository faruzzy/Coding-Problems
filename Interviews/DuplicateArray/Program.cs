using System;
using System.Collections.Generic;
using System.Linq;

namespace Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowLength = Convert.ToInt32(Console.ReadLine());
            var list = new List<int[]>();

            for (int i = 0; i < rowLength; i++)
            {
                var array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                list.Add(array);
            }

            int k = Convert.ToInt32(Console.ReadLine());

            int[,] array2D = new int[rowLength, list.First().Count()];

            int c = 0;
            while (c < array2D.GetLength(1))
            {
                for (int i = 0; i < list.Count; i++)
                    array2D[c, i] = list[c][i];
                c++;
            }

            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    if (CheckDuplicate(array2D, i, j, k))
                    {
                        Console.WriteLine("YES");
                        Console.ReadLine();
                        return;
                    }
                }
            }
            Console.WriteLine("NO");
            Console.ReadLine();
        }

        static bool CheckDuplicate(int[,] array, int i, int j, int k)
        {
            for (int s = 0; s < k; s++)
                if (s + j + 1 < array.GetLength(0))
                    if (array[i, j] == array[i, s + j + 1]) return true;

            for (int s = 0; s < k; s++)
                if (i + s + 1 < array.GetLength(1))
                    if (array[i, j] == array[i + s + 1, j]) return true;

            for (int s = 0; s < k; s++)
                if (i + s + 1 < array.GetLength(0) && j + s + 1 < array.GetLength(1))
                    if (array[i, j] == array[i + s + 1, j + s + 1]) return true;

            for (int s = 0; s < k; s++)
                if (i + s + 1 < array.GetLength(0) && j - 1 >= 0)
                    if (array[i, j] == array[i + s + 1, j - 1]) return true;

            return false;
        }
    }
}
