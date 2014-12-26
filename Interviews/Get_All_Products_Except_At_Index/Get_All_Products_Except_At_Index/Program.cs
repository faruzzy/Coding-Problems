using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_All_Products_Except_At_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 7, 3, 4 };
            int[] products = GetProducts(arr);

            foreach (int number in products)
                Console.WriteLine("result: " + number);
        }

        public static int[] GetProducts(int[] arr)
        {
            int product = 1;
            int[] ret = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                    if (i == j) continue;
                    else
                        product *= arr[j];

                ret[i] = product;
                product = 1;
            }

            return ret;
        }				
    }
}
