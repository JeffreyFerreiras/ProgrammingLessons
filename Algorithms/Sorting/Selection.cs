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
         */


        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                int nonSortedIndex = i + 1;

                while(nonSortedIndex < arr.Length)
                {
                    if(arr[minIndex] > arr[nonSortedIndex])
                    {
                        minIndex = nonSortedIndex;
                    }

                    nonSortedIndex++;
                }

                Common.Swap(arr, i, minIndex);
            }

            return arr;
        }

        public static void Sort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                int unsorted = i+1;

                while(unsorted < arr.Length)
                {
                    if(arr[min] > arr[unsorted])
                    {
                        min = unsorted;
                    }

                    unsorted++;
                }

                int tmp = arr[i];
                arr[i] = arr[min];
                arr[min] = tmp;
            }
        }
    }
}
