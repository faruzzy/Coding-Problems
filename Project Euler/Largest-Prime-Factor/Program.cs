using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Prime_Factor
{
    class Program
    {
        static void Main(string[] args)
        {
            var factors = new List<int>();
            for (int i = 2; i <= 13195; i++)
            {
                int c = i;
                bool check = false;
                while(c > 1)
                {
                    if (c - 1 == 1) break;
                    c--;
                    if (i % c == 0)
                    {
                        check = true;
                        break;
                    }
                }

                if (!check)
                {
                    factors.Add(i);
                }
            }

            Console.WriteLine(factors.Max());
            Console.ReadLine();
        }
    }
}
