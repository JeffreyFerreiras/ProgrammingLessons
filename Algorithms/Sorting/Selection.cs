using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Selection
    {
        /*
         * 1. Loop through every element minus one.
         * 2. Traverse non sorted elements. (i +1 to end)
         * 3. If item with min index is higher than non sorted item, set min index to non sorted index.
         * 4. Swap i the minIndex values.
         * 
         * This algorithm is good for minimizing writes
         */


        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                int indexOfElementNotSorted = i + 1;

                while(indexOfElementNotSorted < arr.Length)
                {
                    if(arr[minIndex] > arr[indexOfElementNotSorted])
                    {
                        minIndex = indexOfElementNotSorted;
                    }

                    indexOfElementNotSorted++;
                }

                Common.Swap(arr, i, minIndex);
            }

            return arr;
        }

        public static void Sort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int low = i;
                int high = i + 1;

                while(high < arr.Length)
                {
                    if(arr[low] > arr[high])
                    {
                        low = high;
                    }

                    high++;
                }

                Common.Swap(arr, low, i);
            }
        }
    }
}
