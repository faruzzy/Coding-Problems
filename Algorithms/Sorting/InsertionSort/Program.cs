using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 4, 10, 2, 7, 8, 9, 12 };
            InsertionSort(array);

            foreach (var item in array)
                Console.Write("{0} ", item);

            Console.ReadKey();
        }

        static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while(j > 0 && array[j - 1] > array[j])
                {
                    int temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                    j--;
                }
            }
        }
    }
}
