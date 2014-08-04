using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter letters: ");
            string letters = Console.ReadLine();

            Console.WriteLine();

            bool a = hasDuplicate(letters.ToCharArray());
            if (a)
                Console.WriteLine("duplicate letters were found");
            else
                Console.WriteLine("no duplicate letters were found");

            Console.ReadLine();
        }

        static bool hasDuplicate(char[] letters)
        {
            bool hasDuplicate = false;
            List<char> c = new List<char>();

            for (int i = 0; i < letters.Length; i++ )
            {
                if (i == 0)
                {
                    c.Add(letters[i]);
                    continue;
                }

                if (c.IndexOf(letters[i]) == -1)
                    c.Add(letters[i]);
                else
                    return true;
            }

            return hasDuplicate;
        }

    }
}
