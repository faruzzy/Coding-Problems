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

            List<string> answers = new List<string>();
            for (int j = 1; j < lines.Length; j++)
            {
                List<string> results = new List<string>();

                int firstRowNumber = int.Parse(lines[j]);
                string[] firstRow = lines[j + firstRowNumber].Split(' ');

                int secondRowNumber = int.Parse(lines[j + 5]);
                string[] secondRow = lines[j + 5 + secondRowNumber].Split(' ');

                string result = string.Empty;

                for (int i = 0; i < firstRow.Length; i++)
                {
                    string value = firstRow[i];
                    if (Array.IndexOf(secondRow, value) != -1)
                        results.Add(value);
                }

                if (results.Count() == 1)
                    result = results.First();

                if (results.Count() > 1)
                    result = "Bad Magician!";

                if (results.Count() == 0)
                    result = "Volunteer cheated!";

                answers.Add(result);

                j += 9;
            }

            using(StreamWriter sw = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < answers.Count(); i++)
                    sw.WriteLine("Case #" + (i+1) + ": " + answers[i]);
            }
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
