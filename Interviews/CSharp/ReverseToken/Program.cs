using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseToken
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Zamar has been experimenting with ORM";
            string s = ReverseToken(str);
            Console.WriteLine(s);

            Console.ReadLine();
        }

        static string ReverseToken(string str)
        {
            string[] tokens = str.Split(' ');
            var sentence = new StringBuilder();

            foreach(string token in tokens)
            {
                var sb = new StringBuilder();
                for (int i = token.Length - 1; i >= 0; i--)
                    sb.Append(token[i]);

                sentence.Append(sb.ToString() + " ");
            }

            string[] stoken = sentence.ToString().Split(' ');
            var s = new StringBuilder();
            for (int j = stoken.Length - 1; j >= 0; j--)
                s.Append(s[j] + " ");

            return s.ToString();
        }
    }
}
