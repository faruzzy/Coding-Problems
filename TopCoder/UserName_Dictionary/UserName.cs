using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserName_Dictionary
{
    class UserName
    {
        static void Main(string[] args)
        {
            //var existingNames = new string[] { "MasterOfDisaster", "TygerTyger1", "DingBat", "Orpheus", "TygerTyger", "WolfMan", "MrKnowItAll" };
            //var existingNames = new string[] { "Bart4", "Bart5", "Bart6", "Bart7", "Bart8", "Bart9", "Bart10", "Lisa", "Marge", "Homer", "Bart", "Bart1", "Bart2", "Bart3", "Bart11", "Bart12" };
            //var s = newMember(existingNames, "TygerTyger");
            //var s = newMember(existingNames, "Bart");

            var existingNames = new string[] { "TygerTyger2000", "TygerTyger1", "MasterDisaster", "DingBat", "Orpheus", "WolfMan", "MrKnowItAll" };
            var s = newMember(existingNames, "TygerTyger");
        }

        private static string newMember(string[] existingNames, string newName)
        {
            var nameDictionary = new Dictionary<string, int>();
            Regex rgx = new Regex(@"\d");

            int n = existingNames.Length;
            for (int i = 0; i < n; i++)
            {
                string match = rgx.Split(existingNames[i]).First();
                if (nameDictionary.ContainsKey(match))
                    nameDictionary[match]++;
                else
                    nameDictionary.Add(match, 0);
            }

            return nameDictionary[newName] > 0 ? (newName + (nameDictionary[newName] + 1)) : newName;
        }
    }
}