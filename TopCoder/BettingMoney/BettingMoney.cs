using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingMoney
{
    class BettingMoney
    {
        static void Main(string[] args)
        {
            int sum = moneyMade(new int[] { 100, 100, 100, 100 }, new int[] { 5, 5, 5, 5 }, 0);
        }

        private static int moneyMade(int[] amounts, int[] centsPerDollar, int finalResult)
        {
            int sum = 0;
            int n = amounts.Length;

            for(int i = 0; i < n; i++)
            {
                if (i == finalResult) continue;
                sum += amounts[i];
            }

            return (sum * 100) - (centsPerDollar[finalResult] * amounts[finalResult]);
        }
    }
}
