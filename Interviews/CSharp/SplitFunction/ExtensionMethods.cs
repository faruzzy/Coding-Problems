using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitFunction
{
    public static class ExtensionMethods
    {
        public static string[] MySplit(this string str, char pattern)
        {
            List<string> words = new List<string>();

            while (str.Length > 0)
            {
                int index = str.IndexOf(' ');
                if (index == -1)
                {
                    words.Add(str.Substring(0, str.Length));
                    str = str.Substring(str.Length);
                }
                else
                {
                    words.Add(str.Substring(0, index));
                }

                str = str.Substring(index + 1);
            }

            return words.ToArray();
        }
    }
}
