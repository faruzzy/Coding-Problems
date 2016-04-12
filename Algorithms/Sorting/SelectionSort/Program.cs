using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 4, 10, 2, 7, 8, 9, 12 };
            SelectionSort(array);
        }

        static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int indexOfMin = i;
                for (int j = i; j < array.Length; j++)
                    if (array[indexOfMin] > array[j])
                        indexOfMin = j;

                int temp = array[i];
                array[i] = array[indexOfMin];
                array[indexOfMin] = temp;
            }
        }
    }
}
