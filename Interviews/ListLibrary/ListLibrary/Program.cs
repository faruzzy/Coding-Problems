using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List();

            list.Add(4);
            list.Add(5);
            list.Add(7);
            list.Add(10);

            list.Add("Hello there");

            list.Print();

            Console.ReadKey();
        }
    }
}
