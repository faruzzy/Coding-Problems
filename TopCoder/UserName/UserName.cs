using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserName
{
    class UserName
    {
        static void Main(string[] args)
        {
            var existingNames = new string[] { "MasterOfDisaster", "TygerTyger1", "DingBat", "Orpheus", "TygerTyger", "WolfMan", "MrKnowItAll" };
            newMember(existingNames, "TygerTyger");
        }
        
        private static string newMember(string[] existingNames, string newName)
        {
            int n = existingNames.Length;
            string num = string.Empty;
            var list = new List<string>();

            for (int i = 0; i < n; i++)
                if (existingNames[i].Contains(newName))
                    list.Add(existingNames[i]);

            int N = list.Count();

            if (N == 1)
                return newName + "1";
            else 
            {
                var numberList = new List<string>();
                for (int i = 0; i < N; i++)
                {
                    var r = Regex.Match(list[i], @"[0-9]");

                    if (!String.IsNullOrEmpty(r.ToString()))
                        numberList.Add(r.ToString());
                }

                var array = numberList.ToArray();
                Array.ConvertAll(array, int.Parse);

                return (newName + (array.Max() + 1));

            }

        }
    }
}
