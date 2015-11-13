using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Numbers
{
    class Numbers
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("small.in");
            var list = new List<string>();
            for (int k = 1; k < lines.Length; k++)
            {
                var sb = new StringBuilder();
                double x = Math.Pow(3 + Math.Sqrt(5), int.Parse(lines[k]));
                int idx = x.ToString().IndexOf('.');
                string val = string.Empty;
                if (idx != -1) val = x.ToString().Substring(0, idx);
                for (int j = val.Length - 1; j >= val.Length - 3; j--)
                {
                    try
                    {
                        sb.Insert(0, val[j]);
                    }
                    catch (IndexOutOfRangeException ex) { }
                }

                if (val.Length < 3)
                {
                    int z = 3 - val.Length;
                    for (int b = 0; b < z; b++)
                        sb.Insert(0, "0");
                }
                list.Add(sb.ToString());
            }

            using (var sw = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < list.Count; i++)
                    sw.WriteLine("Case #{0}: {1}", (i + 1), list[i]);
            }
        }
    }
}
