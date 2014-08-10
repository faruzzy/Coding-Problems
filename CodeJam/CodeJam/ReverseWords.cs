using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeJam
{
    class ReverseWords
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("small.in");
            int n = Convert.ToInt16(lines.First());
            List<string> output = new List<string>();

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < n; i++)
            {
                string[] words = lines[i].Split(' ');
                for (int j = words.Length - 1; j >= 0; j--)
                    sb.Append(words[j] + " ");

                output.Add(sb.ToString());
                sb.Clear();
            }

            using (StreamWriter sw = new StreamWriter("output.in"))
            {
                for (int i = 0; i < output.Count; i++)
                    sw.WriteLine("Case #" + (i + 1) + ":" + output[i]);
            }
        }
    }
}
