using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace T9Spelling
{
    class T9Spelling
    {
        static void Main(string[] args)
        {
            var keyPad = new Dictionary<char[], string>()
            {
                { "abc".ToCharArray(), "2" },
                { "def".ToCharArray(), "3" },
                { "ghi".ToCharArray(), "4" },
                { "jkl".ToCharArray(), "5" },
                { "mno".ToCharArray(), "6" }, 
                { "pqrs".ToCharArray(), "7" },
                { "tuv".ToCharArray(), "8" },
                { "wxyz".ToCharArray(), "9" },
                { " ".ToCharArray(), "0" }
                
            };

            string[] lines = File.ReadAllLines("small.in");
            var results = new List<string>();
            var sb = new StringBuilder();
            for(int i = 1; i < lines.Length; i++)
            {
                foreach (var character in lines[i])
                {
                    string currentKey = String.Empty;
                    foreach (var pad in keyPad.Keys)
                    {
                        if (Array.IndexOf(pad, character) != -1)
                        {
                            if (keyPad[pad] != currentKey)
                            {
                                for (int k = 0; k <= Array.IndexOf(pad, character); k++ )
                                    sb.Append(keyPad[pad]);

                                currentKey = keyPad[pad];
                                break;
                            }
                            else
                            {
                                sb.Append(" " + keyPad[pad]);
                                currentKey = keyPad[pad];
                                break;
                            }
                        }
                    }
                }
                results.Add(sb.ToString());
                sb.Clear();
            }

            using(var sw = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < results.Count; i++)
                    sw.WriteLine("Case #" + (i + 1) + ": " + results[i]);
            }
        }
    }
}
