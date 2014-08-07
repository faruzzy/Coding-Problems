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
            List<string> words = new List<string>();
            for(int j = 1; j < lines.Length; j++)
            {
                string line = lines[j];
                int idx = 0;
                while (line.Length > 0)
                {
                    idx = line.IndexOf(' ');
                }
                /*string line = lines[j];
                for(int i = 0; i < line.Length; i++)
                {
                    int idx = line.IndexOf(' ');
                    words.Add(line.Substring(i, idx));
                    i = idx;
                }*/
            }

        }
    }
}
