using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberStringToInt
{
    class Program
    {
        static int accumulator = 0;

        static void Main(string[] args)
        {

        }

        static void Convert(string s)
        {
            var map = new Dictionary<string, Dictionary<string, int>>();
            map.Add("singleton", new Dictionary<string, int>()
            {
                 {"one", 1}, 
                 {"two", 2},
                 {"three", 3},
                 {"four", 4},
                 {"five", 5},
                 {"six", 6}, 
                 {"seven", 7}, 
                 {"height", 8},
                 {"nine", 9},
                 {"ten", 10},
                 {"eleven", 11},
                 {"twelve", 12},
                 {"thirteen", 13},
                 {"fourteen", 14},
                 {"fifteen", 15},
                 {"sixteen", 16},
                 {"seventeen", 17},
                 {"heighteen", 18},
                 {"nineteen", 19}
            });

            map.Add("tens", new Dictionary<string, int>()
            {
                {"twenty", 20},
                {"thirty", 30},
                {"fourty", 40},
                {"fifty",  50},
                {"sixty",  60},
                {"seventy", 70},
                {"heighty", 80},
                {"ninety", 90}
            });

            map.Add("hundreds", new Dictionary<string, int>()
            {
                {"hundred", 100},
                {"hundreds", 100}
            });

            map.Add("thousands", new Dictionary<string, int>()
            {
                {"thousand", 1000},
                {"thousands", 1000}
            });

            map.Add("millions", new Dictionary<string, int>()
            {
                {"million", 1000000},
                {"millions", 1000000}
            });
        }

        static void Parse(string str, string operand)
        {


        }

        static void AddUp(string str)
        {
            var operands = new string[] { "hundred", "thousand", "million" };
            foreach(var operand in operands)
                if (str.Contains(operand))
                {
                    int index = str.IndexOf(operand);
                    Parse(str.Substring(0, index - 1), operand);
                }
        }
    }
}
