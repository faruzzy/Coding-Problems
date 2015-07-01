using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AlienLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("large.in");
            var data = Array.ConvertAll(lines.First().Split(' '), int.Parse);
            var list = new List<int>();
            int l = data[0];
            int d = data[1];
            int n = data[2];

            string regex = @"\((\w+)\)|\w";
            var pattern = new List<string>();
            var matches = new List<List<string>>();
            var bigCounter = new List<int>();

            for (int i = 1; i <= d; i++)
                pattern.Add(lines[i]);

            for (int j = 1 + d; j < lines.Length; j++)
            {
                var slist = new List<string>();
                foreach (Match match in Regex.Matches(lines[j], regex))
                    slist.Add(match.Groups[0].Value);
                matches.Add(slist);
                slist = new List<string>();
            }

            foreach (List<string> match in matches)
            {
                int counter = 0;
                foreach (string p in pattern)
                {
                    bool broke = false;
                    for (int i = 0; i < match.Count; i++)
                    {
                        if (match[i].StartsWith("("))
                        {
                            if (!match[i].Equals(p[i].ToString())) broke = true;
                        }
                        else
                        {
                            if (match[i].IndexOf(p[i].ToString()) == -1) broke = true;
                        }
                        if (broke) break;
                    }
                    if (broke) continue;
                    counter++;
                }
                bigCounter.Add(counter);
                counter = 0;
            }

            using (var sw = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < bigCounter.Count(); i++)
                    sw.WriteLine("Case #" + (i + 1) + ": " + bigCounter[i]);
            }
        }
    }
}
