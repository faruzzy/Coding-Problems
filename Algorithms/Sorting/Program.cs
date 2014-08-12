using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 4, 10, 2, 7, 8, 9, 12 };
            //BubbleSort(array);
            //SelectionSort(array);
            LinqToArraySelectionSort(array);
        }

        static void BubbleSort(int[] array)
        {
            bool switched = false;
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        switched = true;
                        int temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
                if (switched)
                    break;
            }
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

        static void LinqToArraySelectionSort(int[] array)
        {
            var newArray = new List<int>();
            var originalArray = array.ToList();

            for (int i = 0; i < originalArray.Count(); i++)
            {
                int minIdx = i;
                for (int j = i; j < originalArray.Count(); j++)
                    if (originalArray[minIdx] > originalArray[j])
                        minIdx = j;

                newArray.Add(originalArray[minIdx]);
                originalArray.RemoveAt(minIdx);
            }

            array = newArray.ToArray();
        }
    }
}
