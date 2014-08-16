using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace AlienLanguage
{
    class AllienLanguage
    {
        static void Main(string[] args)
        {
            //string fileName = "test.txt";
            //string fileName = "small.in";
            string fileName = "large.in";
            string[] lines = File.ReadAllLines(fileName);

            int l = 0;
            int d = 0;
            int n = 0;

            int[] arr = Array.ConvertAll(lines.First().Split(' '), int.Parse);

            l = arr[0];
            d = arr[1];
            n = arr[2];

            var results = new List<string>();
            var patterns = new List<string>();
            var testCases = new List<string>();

            for (int i = 1; i <= d; i++)
                patterns.Add(lines[i]);

            for (int i = d + 1; i < lines.Length; i++)
                testCases.Add(lines[i]);

            foreach(var testCase in testCases)
            {
                string currentString = testCase;
                int bigCounter = 0;

                var token = new List<string>();
                while(currentString.Length > 0)
                {
                    string letter = currentString.Substring(0, 1);
                    if (letter.Equals("("))
                    {
                        int lower = currentString.IndexOf("(");
                        int upper = currentString.IndexOf(")");

                        token.Add(currentString.Substring(lower + 1, upper - 1));
                        currentString = currentString.Substring(upper + 1);
                    }
                    else
                    {
                        token.Add(letter);
                        currentString = currentString.Substring(1);
                    }
                }

                foreach(var pattern in patterns)
                {
                    string[] patternArray = new string[pattern.Length];

                    for (int i = 0; i < pattern.Length; i++)
                        patternArray[i] = pattern[i].ToString();

                    int count = 0;
                    for (int i = 0; i < token.Count(); i++)
                        if (token[i].Contains(patternArray[i]))
                            count++;
                        else break;

                    if (count == token.Count())
                        bigCounter += 1;
                }

                results.Add(bigCounter.ToString());
            }

            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < results.Count(); i++)
                    sw.WriteLine("Case #" + (i + 1) + ": " + results[i]);
            }
        }
    }
}
