using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionLibrary;

namespace LinkedListCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List();
            var list2 = new List();
            var newList = new List();
            
            list1.Add(3);
            list1.Add(10);
            list1.Add(20);
            list1.Add(40);

            list2.Add(50);
            list2.Add(11);
            list2.Add(13);
            list2.Add(40);
            list2.Add(3);

            for (int i = 0; i < list1.Count; i++)
                if (list2.Contains(list1[i])) continue;
                else newList.Add(list1[i]);

            foreach (var item in list1)
                Console.Write(item + " ");

            Console.WriteLine();

            foreach (var item in list2)
                Console.Write(item + " ");

            Console.WriteLine();

            foreach (var item in newList)
                Console.Write(item + " ");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
