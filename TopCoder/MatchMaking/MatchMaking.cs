using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking
{
    class MatchMaking
    {
        static void Main(string[] args)
        {
            /*var name = makeMatch(new string[] { "Constance", "Bertha", "Alice" }, new string[] { "aaba", "baab", "aaaa" },
                new string[] { "Chip", "Biff", "Abe" }, new string[] { "bbaa", "baaa", "aaab" }, "Bertha");*/

            var name = makeMatch(new string[] { "Constance", "Bertha", "Alice" }, new string[] { "aaba", "baab", "aaaa" },
                new string[] { "Chip", "Biff", "Abe" }, new string[] { "bbaa", "baaa", "aaab" }, "Constance");
        }

        private static string makeMatch(string[] namesWomen, string[] answersWomen, string[] namesMen, string[] answersMen, string queryWoman)
        {
            int womanAnswerIndex = Array.IndexOf(namesWomen, queryWoman);
            string womanAnswer = answersWomen[womanAnswerIndex];

            var result = new List<int>();
            for (int i = womanAnswer.Length; i > 0; i--)
            {
                string pattern = womanAnswer.Substring(0, i);
                
                bool match = true;
                bool success = false;
                foreach (var manAnswer in answersMen)
                {
                    match = true;
                    for (int j = 0; j < pattern.Length; j++)
                    {
                        if (!pattern[j].Equals(manAnswer[j]))
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        result.Add(1);
                        success = true;
                    }
                    else
                    {
                        result.Add(0);
                    }
                }

                if (success) break;
                else result.Clear();
            }

            var menSelected = new List<string>();
            int n = result.Count();

            for (int i = 0; i < n; i++)
                if (result[i] == 1)
                    menSelected.Add(namesMen[i]);

            menSelected.Sort();
            return menSelected.First();

        }
    }
}
