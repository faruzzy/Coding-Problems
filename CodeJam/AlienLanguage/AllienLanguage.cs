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

            var results = new List<string>();
            var patterns = new List<string>();
            var testCases = new List<string>();

            for (int i = 1; i < d; i++)
                patterns.Add(lines[i]);

            for (int i = d + 1; i < lines.Length; i++)
                testCases.Add(lines[i]);

            foreach(var testCase in testCases)
            {
                string currentString = testCase;
                int index = 0;
                int bigCounter = 0;

                var token = new List<string>();
                while(currentString.Length > 0)
                {
                    string letter = currentString.Substring(index, 1);
                    if (letter.Equals("("))
                    {
                        int lower = currentString.IndexOf("(");
                        int upper = currentString.IndexOf(")");

                        token.Add(currentString.Substring(lower + 1, upper - 1));
                        index = upper + 1;
                        currentString = currentString.Substring(upper + 1);
                    }
                    else
                    {
                        token.Add(letter);
                        index++;
                        currentString = currentString.Substring(index);
                    }
                }

                foreach(var pattern in patterns)
                {
                    string[] patternArray = new string[pattern.Length];

                    for (int i = 0; i < pattern.Length; i++)
                        patternArray[i] = pattern[i].ToString();

                    int count = 0;
                    for (int i = 0; i < token.Count(); i++)
                    {
                        if (token.Contains(patternArray[i]))
                            count++;
                    }

                    if (count == token.Count())
                        bigCounter += 1;
                }

                results.Add(bigCounter.ToString());
            }

            foreach (var result in results)
                Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
