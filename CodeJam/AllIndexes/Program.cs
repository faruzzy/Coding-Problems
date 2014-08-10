using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllIndexes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> a = "roland pangu nkailu".WhileAllIndexesOf("z");
            List<int> b = "Daniel Pangu Umba".ForAllIndexesOf(" ");
            List<int> c = new string[] { "a", "b", "a", "z", "c", "z" }.ArrayAllIndexesOf("z");*/
            //int[] d = new string[] { "a", "b", "a", "z", "c", "z" }.ArrayAllIndexes("z");
            int[] e = new string[] { "a", "b", "a", "z", "c", "z" }.AllIndexes("z");
        }
    }

     static class ExtensionMethods
     {
         public static int[] ArrayAllIndexes(this string[] array, string value)
         {
             List<int> indexes = new List<int>();
             for (int i = 0; i < array.Length; i++)
                 if (array[i] == value)
                     indexes.Add(i);

             return indexes.ToArray();
         }

         public static int[] AllIndexes<T>(this T[] array, T val)
         {
             List<int> indexes = new List<int>();
             for (int i = 0; i < array.Length; i++)
                 if (object.Equals(array[i], val))
                     indexes.Add(i);

             return indexes.ToArray();
         }

         public static List<int> ArrayAllIndexesOf(this string[] array, string value)
         {
             List<int> indexes = new List<int>();
             int index = 0;
             for (; ;)
             {
                 index = Array.IndexOf(array, value, index);
                 if (index == -1)
                     break;

                 indexes.Add(index);
             }

             return indexes;
             /*for (int i = 0;; i += index)
             {
                 index = Array.IndexOf(array, value, i);
                 if (index == -1)
                     return indexes;

                 indexes.Add(index);
             }*/
         }

         public static List<int> WhileAllIndexesOf(this string str, string value)
         {
             List<int> indexes = new List<int>();
             while(str.Length > 0)
             {
                 int idx = str.IndexOf(value);
                 if (idx != -1)
                 {
                     indexes.Add(idx);
                     str = str.Substring(idx + 1);
                 }
                 else
                 {
                     str = "";
                 }
             }

             return indexes;
         }

         public static List<int> ForAllIndexesOf(this string str, string value)
         {
             List<int> indexes = new List<int>();

             if (String.IsNullOrEmpty(str))
                 throw new ArgumentException("String must not be empty", "value");

             for (int i = 0; ; i += value.Length)
             {
                 i = str.IndexOf(value, i);
                 if (i == -1)
                     return indexes;
                 indexes.Add(i);
             }
         }
     }
}
