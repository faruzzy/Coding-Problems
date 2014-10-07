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
            List<Dictionary<int, int>> list = new List<Dictionary<int, int>>();

            for (int i = 1; i < n; i++)
            {
                int max = Convert.ToInt16(lines[i]);
                int x = Convert.ToInt16(lines[i + 1]);
                int[] prices = Array.ConvertAll(lines[i + 2].Split(' '), int.Parse);

                foreach (int price in prices)
                {
                    Dictionary<int, int> set = new Dictionary<int, int>();
                    int remainer = max - price;
                    int idx = Array.IndexOf(prices, remainer);

                    if (idx != -1)
                    {
                        set.Add(price, prices[idx]);
                        list.Add(set);
                        break;
                    }
                }
                i += 2;
            }

            using(StreamWriter sw = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < list.Count(); i++)
                    foreach (var dictionary in list[i])
                        sw.WriteLine("Case #" + (i + 1) + ":" + dictionary.Key + " " + dictionary.Value);
            }
        }
    }
}
