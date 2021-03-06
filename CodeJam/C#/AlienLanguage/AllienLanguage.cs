﻿using System;
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
            //string fileName = "small.in";
            string fileName = "large.in";
            string[] lines = File.ReadAllLines(fileName);

            int[] arr = Array.ConvertAll(lines.First().Split(' '), int.Parse);

            int l = arr[0];
            int d = arr[1];
            int n = arr[2];

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
                        int lowerIndex = currentString.IndexOf("(");
                        int upperIndex = currentString.IndexOf(")");

                        token.Add(currentString.Substring(lowerIndex + 1, upperIndex - 1));
                        currentString = currentString.Substring(upperIndex + 1);
                    }
                    else
                    {
                        token.Add(letter);
                        currentString = currentString.Substring(1);
                    }
                }

                foreach(var pattern in patterns)
                {
                    int count = 0;
                    for (int i = 0; i < token.Count(); i++)
                    {
                        if (token[i].Contains(pattern[i])) count++;
                        else break;
                    }

                    if (count == token.Count()) bigCounter++;
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
