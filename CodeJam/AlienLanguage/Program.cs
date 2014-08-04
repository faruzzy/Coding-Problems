using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace AlienLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            // fileName is either 'small.in' or 'large.in'
            string fileName = "small.in";
            string[] lines = File.ReadAllLines(fileName);

            int l = 0;
            int d = 0;
            int n = 0;

            int[] arr = Array.ConvertAll(lines.First().Split(' '), int.Parse);

            l = arr[0];
            d = arr[1];
            n = arr[2];

            var pattern = new List<string>();
            var testCases = new List<string>();

            for (int i = 1; i < d; i++)
                pattern.Add(lines[i]);

            for (int i = d + 1; i < lines.Length; i++)
                testCases.Add(lines[i]);
        }

        static void tokenizer(string str)
        {
            string pattern = @"[a-z]";

            StringBuilder sb = new StringBuilder();
            Regex regex = new Regex(pattern);

            foreach(char s in str)
            {
                if (regex.IsMatch(s.ToString()))
                {
                    sb.Append(s.ToString());
                }
            }

        }

        static void tokenize()
        {

        }
    }
}
