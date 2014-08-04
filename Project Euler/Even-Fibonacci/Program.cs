using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<uint> sequence = new List<uint>();
            sequence.Add(1);
            sequence.Add(2);

            uint c = 0;
            uint sum = 0;
            while (c <= 4000000)
            {
                c = (uint)sequence[sequence.Count() - 1] + (uint)sequence[sequence.Count() - 2];
                sequence.Add(c);
            }

            foreach (var x in sequence)
                if (x % 2 == 0)
                    sum += x;

            Console.Write(sum);
            Console.ReadLine();
        }
    }
}
