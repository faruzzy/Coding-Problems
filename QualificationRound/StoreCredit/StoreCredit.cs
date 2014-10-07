using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StoreCredit
{
    class StoreCredit
    {
        static void Main(string[] args)
        {
            string fileName = "large.in";
            string[] lines = File.ReadAllLines(fileName);

            var results = new List<List<int>>();
            for (int i = 1; i < lines.Length; i++)
            {
                var result = new List<int>();
                int C = int.Parse(lines[i]);
                int I = int.Parse(lines[i + 1]);
                int[] L = Array.ConvertAll(lines[i + 2].Split(' '), int.Parse);
                bool success = false;

                for (int j = 0; j < I; j++)
                {
                    for (int k = j + 1; k < I; k++)
                    {
                        if (L[j] + L[k] == C)
                        {
                            result.Add(j + 1);
                            result.Add(k + 1);
                            results.Add(result);
                            success = true;
                            break;
                        }
                    }
                    if (success) break;
                }

                i += 2;
            }

            using(StreamWriter sw = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < results.Count(); i++)
                    sw.WriteLine("Case #" + (i + 1) + ": " + results[i][0] + " " + results[i][1]);
            }
        }
    }
}
