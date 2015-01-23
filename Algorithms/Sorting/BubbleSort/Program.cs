using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 4, 10, 2, 7, 8, 9, 12 };
            BubbleSort(array);
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
    }
}
