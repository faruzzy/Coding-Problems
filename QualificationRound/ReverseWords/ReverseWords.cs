using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReverseWords
{
    class ReverseWords
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("large.in");
            var newLines = new List<string>();
            var sb = new StringBuilder();
            for(int i = 1; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(' ');
                for (int j = words.Length - 1; j >= 0; j--)
                    sb.Append(words[j] + " ");

                newLines.Add(sb.ToString());
                sb.Clear();
            }

            using(var sw = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < newLines.Count(); i++)
                    sw.WriteLine("Case #" + (i + 1) + ": " + newLines[i]);
            }
        }
    }
}
