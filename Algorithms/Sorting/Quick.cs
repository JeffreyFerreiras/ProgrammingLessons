using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Quick
    {
        /* O(n log n) typical run time and O(log n) space.
         * O(n^2) worst case.
         * 
         */

        public static int[] QuickSort(this int[] arry)
        {
            QuickSort(arry, 0, arry.Length - 1);

            return arry;
        }

        private static void QuickSort(int[] arry, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex) return;

            int pivot = arry[(leftIndex + rightIndex) / 2];
            int partitionIndex = Partition(arry, leftIndex, rightIndex, pivot);

            QuickSort(arry, leftIndex, partitionIndex -1);   //Sort left side
            QuickSort(arry, partitionIndex, rightIndex);     //Sort right side
        }

        private static int Partition(int[] array, int leftIndex, int rightIndex, int pivot)
        {
            while(leftIndex <= rightIndex)
            {
                while(array[leftIndex] < pivot) leftIndex++;        //Check numbers until one needs to be swaped to right side of the pivot.
                while (array[rightIndex] > pivot) rightIndex--;     //Check numbers until one needs to be swaped to left side of the pivot.

                if (leftIndex <= rightIndex)
                {
                    Common.Swap(array, leftIndex, rightIndex);

                    leftIndex++;
                    rightIndex--;
                }
            }

            return leftIndex;
        }

        public static int[] QuickSort2(this int[] arry)
        {
            QuickSort2(arry, 0, arry.Length - 1);
            return arry;
        }

        private static void QuickSort2(this int[] arry, int left, int right)
        {
            if (left <= right) return;

            int pivot = arry[(left + right) / 2];
            int index = Partition2(arry, left, right, pivot);

            QuickSort2(arry, left, index - 1);
            QuickSort2(arry, index, right);
        }

        private static int Partition2(int[] arry, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (arry[right] >= pivot) right--;
                while(arry[left] <= pivot) left++;

                if (left<=right)
                {
                    Common.Swap(arry, left, right);
                    left++;
                    right--; 
                }
            }

            return left;
        }
    }
}
