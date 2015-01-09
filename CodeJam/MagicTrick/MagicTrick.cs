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
            string[] lines = File.ReadAllLines("small.in");
            int c = int.Parse(lines.First());

            var answers = new List<string>();
            for (int j = 1; j < lines.Length; j++)
            {
                var results = new List<string>();

                int firstRowNumber = int.Parse(lines[j]);
                string[] firstRow = lines[j + firstRowNumber].Split(' ');

                int secondRowNumber = int.Parse(lines[j + 5]);
                string[] secondRow = lines[j + 5 + secondRowNumber].Split(' ');

                string result = string.Empty;

                for (int i = 0; i < firstRow.Length; i++)
                    if (Array.IndexOf(secondRow, firstRow[i]) != -1)
                        results.Add(firstRow[i]);

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
}
