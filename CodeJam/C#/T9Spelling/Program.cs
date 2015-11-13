using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9Spelling
{
    class Program
    {
        private static Dictionary<string, char[]> pad;
        private static string lastKey = String.Empty;
        private static bool found = false;

        static void Main(string[] args)
        {
            Dictionary<string, char[]> pad = new Dictionary<string, char[]>();
            List<string> cases = new List<string>();

            string[] lines = File.ReadAllLines("small.in");
            int n = int.Parse(lines.First());
            string output = string.Empty;

            for (int i = 1; i < n; i++)
            {
                string[] words = lines[i].Split(' ');
                foreach(var word in words)
                {
                    char[] letters = word.ToCharArray();
                    foreach (var letter in letters)
                        output += getNumbers(letter);

                    cases.Add(output);
                    output = "";
                }
            }

            using(StreamWriter sw = new StreamWriter("ouput.txt"))
            {
                for (int i = 0; i < cases.Count(); i++)
                    sw.WriteLine("Case #" + (i + 1) + ":" + cases[i]);
            }
        }

        static string getNumbers(char s)
        {
            pad = new Dictionary<string, char[]>();

            pad.Add("0", new char[] { ' ' });
            pad.Add("2", new char[] { 'a', 'b', 'c' });
            pad.Add("3", new char[] { 'd', 'e', 'f' });
            pad.Add("4", new char[] { 'g', 'h', 'i' });
            pad.Add("5", new char[] { 'j', 'k', 'l' });
            pad.Add("6", new char[] { 'm', 'n', 'o' });
            pad.Add("7", new char[] { 'p', 'q', 'r', 's' });
            pad.Add("8", new char[] { 't', 'u', 'v' });
            pad.Add("9", new char[] { 'w', 'x', 'y', 'z' });

            StringBuilder sb = new StringBuilder();
            foreach(var key in pad.Keys)
            {
                if (pad[key].Contains(s))
                {
                    int pressedNumber = Array.IndexOf(pad[key], s) + 1;
                    for (int i = 0; i < pressedNumber; i++)
                    {
                        if (i == 0 && lastKey.Equals(key))
                        {
                            sb.Append(" " + pad[key]);
                        }
                        else
                        {
                            sb.Append(key);
                            lastKey = key;
                            if (i == pressedNumber - 1) found = true;
                        }
                    }
                }

                if (found)
                {
                    found = false;
                    break;
                }
            }

            return sb.ToString();
        }
    }
}
