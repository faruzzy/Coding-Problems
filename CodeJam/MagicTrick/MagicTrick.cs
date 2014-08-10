using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MagicTrick
{
    class MagicTrick
    {
        static void Main(string[] args)
        {
            List<int> indexes = "fooStringfooBar".AllIndexesOf("foo");

            string[] lines = File.ReadAllLines("small.in");
            int c = int.Parse(lines.First());

            List<string> results = new List<string>();
            for (int j = 1; j < lines.Length; j++)
            {
                int firstRowNumber = int.Parse(lines[j]);
                string[] firstRow = lines[j + firstRowNumber].Split(' ');

                int secondRowNumber = int.Parse(lines[j + 5]);
                string[] secondRow = lines[j + 5 + secondRowNumber].Split(' ');

                string result = string.Empty;

                for (int i = 0; i < firstRow.Length; i++)
                {
                    string value = firstRow[i];
                    string[] cardIndexes = Array.FindAll(secondRow, x => x == value);
                    //var cardIndexes = secondRow.AllIndexesOf(value);

                    if (cardIndexes.Count() == 1)
                    {
                        result = secondRow[int.Parse(cardIndexes.First())];
                        results.Add(result);
                        continue;
                    }

                    if (cardIndexes.Count() > 1)
                    {
                        result = "Bad Magician!";
                        results.Add(result);
                        break;
                    }
                }
                j += 9;
            }

            foreach (var result in results)
                Console.WriteLine(result);

            Console.ReadLine();
        }

    }

    static class Extension
    {
        public static List<int> AllIndexesOf(this string[] array, string value)
        {
            if (array.Length == 0)
                throw new ArgumentException("The array cannot be empty", "array");

            List<int> indexes = new List<int>();
            /*for (int index = 0; index < array.Length; index++)
            {
                index = Array.IndexOf(array, value, index);
            }*/

            int i = 0;
            for (int index = 0;; index += i)
            {
                i = Array.IndexOf(array, value, index); ;
                if (i == -1)
                    return indexes;

                indexes.Add(index);
            }
        }

        public static List<int> AllIndexesOf(this string str, string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");
            List<int> indexes = new List<int>();
            for (int index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }
    }
}
