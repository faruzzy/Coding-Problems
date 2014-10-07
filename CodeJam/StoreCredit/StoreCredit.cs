using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreCredit
{
    class StoreCredit
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("small.in");
            int n = Convert.ToInt16(lines.First());
            var list = new List<int[]>();

            for (int i = 1; i < lines.Length; i++)
            {
                int max = Convert.ToInt16(lines[i]);
                int[] prices = Array.ConvertAll(lines[i + 2].Split(' '), int.Parse);

                for (int j = 0; j < prices.Length; j++)
                {
                    var set = new List<int>();
                    int remainer = max - prices[j];
                    int idx = Array.IndexOf(prices, remainer);

                    if (idx != -1)
                    {
                        set.Add(prices[j]);
                        set.Add(prices[idx]);
                        list.Add(set.ToArray());
                        break;
                    }
                }
                i += 2;
            }

            using(StreamWriter sw = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < list.Count(); i++)
                    sw.WriteLine("Case #" + (i + 1) + ": " + list[i][0] + " " + list[i][1]);
            }
        }
    }
}
