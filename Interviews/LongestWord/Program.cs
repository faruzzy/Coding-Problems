using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I think it is better to assume that the truth always preveils and that event in time of troulbe and uncertainty or marabouopliuw";
            string longestWord = GetLongestWord(sentence);
            Console.WriteLine(longestWord);
            Console.Read();
        }

        private static string GetLongestWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            var longest = new List<string>();

            foreach(string word in words)
            {
                if (longest.Count == 0 || longest.First().Length == word.Length)
                {
                    longest.Add(word);
                }
                else
                {
                    if (longest.Contains(word))
                    {
                        continue;
                    } 
                    else
                    {
                        longest.Clear();
                        longest.Add(word);
                    }
                }
            }

            return longest.First();
        }
    }
}
