using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static int[] array = new int[] { 100, 98, 5, 33, 21, 10, 9, 20, 15, 77, 88, 37, 13, 23, 12 };
        static void SelectSort(int[] arr)
        {
            int n = arr.Length;
            for (int j = 0; j < n; j++)
            {
                int i = j; //index of smallest number
                for (int k = j; k < n; k++)
                {
                    if (arr[i] > arr[k])
                        i = k;
                }

                int temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Selection Sort");
            Console.WriteLine();
            Console.WriteLine("Before sort");

            foreach (int i in array)
                Console.Write("{0} ", i);

            Console.WriteLine();
            Console.WriteLine();

            SelectSort(array);

            Console.WriteLine("After Sort");
            foreach (int i in array)
                Console.Write("{0} ", i);

            Console.ReadLine();
        }
    }
}
