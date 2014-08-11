using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            WordsCounter.CountWordsDictionary(@"Albert Einstein (/ˈælbərt ˈaɪnstaɪn/; German: [ˈalbɐt ˈaɪnʃtaɪn] ( listen); 14 March 1879 – 18 April 1955) was a German-born theoretical physicist. He developed the general theory of relativity, one of the two pillars of modern physics (alongside quantum mechanics).[2][3] He is best known in popular culture for his mass–energy equivalence formula E = mc2 (which has been dubbed the world's most famous equation).[4] He received the 1921 Nobel Prize in Physics for his services to theoretical physics, and especially for his discovery of the law of the photoelectric effect.[5] The latter was pivotal in establishing quantum theory.
            Near the beginning of his career, Einstein thought that Newtonian mechanics was no longer enough to reconcile the laws of classical mechanics with the laws of the electromagnetic field. This led to the development of his special theory of relativity. He realized, however, that the principle of relativity could also be extended to gravitational fields, and with his subsequent theory of gravitation in 1916, he published a paper on the general theory of relativity. He continued to deal with problems of statistical mechanics and quantum theory, which led to his explanations of particle theory and the motion of molecules. He also investigated the thermal properties of light which laid the foundation of the photon theory of light. In 1917, Einstein applied the general theory of relativity to model the large-scale structure of the universe.[6]
            He was visiting the United States when Adolf Hitler came to power in 1933 and, being Jewish, did not go back to Germany, where he had been a professor at the Berlin Academy of Sciences. He settled in the U.S., becoming an American citizen in 1940.[7] On the eve of World War II, he endorsed a letter to President Franklin D. Roosevelt alerting him to the potential development of extremely powerful bombs of a new type and recommending that the U.S. begin similar research. This eventually led to what would become the Manhattan Project. Einstein supported defending the Allied forces, but largely denounced the idea of using the newly discovered nuclear fission as a weapon. Later, with the British philosopher Bertrand Russell, Einstein signed the Russell–Einstein Manifesto, which highlighted the danger of nuclear weapons. Einstein was affiliated with the Institute for Advanced Study in Princeton, New Jersey, until his death in 1955.
            Einstein published more than 300 scientific papers along with over 150 non-scientific works.[6][8] His great intellectual achievements and originality have made the word Einstein synonymous with genius.[9]");
        }
    }

    public class WordsCounter 
    {
        public static List<string> CountWordsDictionary(string s)
        {
            var wordDictionary = StringToWordDictionary(s);
            var kvpList = wordDictionary.ToList();
            kvpList.Sort(CompareKVPByCount);
            return ExtractTopTen(kvpList);
        }

        private static Dictionary<string, int> StringToWordDictionary(string s)
        {
            var words = s.Split(' ');
            var wordDictionary = new Dictionary<string, int>();

            foreach(string word in words)
            {
                if (wordDictionary.ContainsKey(word))
                {
                    wordDictionary[word]++;
                }
                else
                {
                    wordDictionary.Add(word, 1);
                }
            }

            return wordDictionary;
        }

        private static int CompareKVPByCount(KeyValuePair<string, int> a, KeyValuePair<string, int> b)
        {
            if (a.Value == b.Value)
            {
                return 0;
            } 
            else if (a.Value < b.Value)
            {
                return 1;
            }
            else 
            {
                return -1;
            }
        }

        private static List<string> ExtractTopTen(List<KeyValuePair<string, int>> countedWords)
        {
            var topTen = new List<string>();
            for (int i = 0; i < countedWords.Count && i < 10; i++)
                topTen.Add(countedWords[i].Key);

            return topTen;
        }
    }
}
