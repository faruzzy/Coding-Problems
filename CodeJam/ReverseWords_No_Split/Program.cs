using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ReverseWords_No_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("small.in");
            List<string> ls = new List<string>();

            for(int j = 1; j < lines.Length; j++)
            {
                List<string> words = new List<string>();
                string line = lines[j];
                int start = 0;
                while (line.Length > 0)
                {
                    if (line.IndexOf(' ') != -1)
                    {
                        int idx = line.IndexOf(' ');
                        words.Add(line.Substring(start, idx));
                        line = line.Substring(idx + 1);
                    }
                    else
                    {
                        words.Add(line.Substring(0, line.Length));
                        line = line.Substring(line.Length);
                    }
                }

                StringBuilder sb = new StringBuilder();
                
                for(int i = words.Count - 1; i >= 0; i--)
                    sb.Append(words[i] + " ");

                ls.Add(sb.ToString());
            }

            using (StreamWriter sw = new StreamWriter(File.Open("ouput.txt", FileMode.Create)))
            {
                for (int i = 0; i < ls.Count(); i++)
                {
                    sw.WriteLine(ls[i]);
                }
            }
        }
    }
}
