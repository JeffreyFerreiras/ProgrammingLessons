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
         * 2. Traverse non sorted elements. (i to end)
         * 3. If item with min index is higher than non sorted item, set min index to non sorted index.
         * 4. Assign current i the minIndex item.
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
    }
}
