using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Numbers
    {
        static void Main(string[] args)
        {

        }

        static string calculate(int n)
        {
            double c = Math.Pow(3 + Math.Sqrt(5), n);
            string answer = "" + (int)c;

            if (answer.Length >= 3)
                return answer.Substring(answer.Length - 3);
            else
                return "0" + answer;
        }
    }
}
