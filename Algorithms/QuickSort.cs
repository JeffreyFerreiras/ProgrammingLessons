using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    static class QuickSort
    {
        /* O(n log n) typical run time and O(log n) space
        1st half.
        1) Get pivot point. GetPivotPoint(arry, left, right)
        2) If left is less than pivot, recur left to pivot - 1
        3) If right if less than pivot, recur pivot + 1 to right
        */
        /*
        2nd half
        GetPivotPoint(arry, left, right)
        1) iterate while left is less than or equal to right.
             a)get mid point.
             b)traverse left index until one value in the array that belongs to the right is found, while increasing left++
             c)traverse right index until one value in the array that belongs to the left is found, while decreasing right--;
             d)check if left is still lower than or equal to right, if it is, swap values.
        2) return left;
         */
        public static int[] Sort(int[] arry)
        {
            Sort(arry, 0, arry.Length - 1);
            return arry;
        }

        public static void Sort(int[] arry, int leftIndex, int rightIndex)
        {
            int pivot = GetPartitionedPivot(arry, leftIndex, rightIndex);

            if(leftIndex < pivot - 1)
                Sort(arry, leftIndex, pivot -1);

            if(pivot < rightIndex)
                Sort(arry, pivot, rightIndex);
        }

        private static int GetPartitionedPivot(int[] array, int leftIndex, int rightIndex)
        {
            while(leftIndex <= rightIndex)
            {
                int midArryVal = array[(leftIndex + rightIndex) / 2];

                //Check numbers until one needs to be swaped to right side.
                while(array[leftIndex] < midArryVal) leftIndex++;

                //Check numbers until one needs to be swaped to left side.
                while(array[rightIndex] > midArryVal) rightIndex--;

                if(leftIndex <= rightIndex)
                {
                    Swap(array, leftIndex, rightIndex);

                    leftIndex++;
                    rightIndex--;
                }
            }

            return leftIndex;
        }

        private static void Swap(int[] array, int leftIndex, int rightIndex)
        {
            int temp = array[leftIndex];
            array[leftIndex] = array[rightIndex];
            array[rightIndex] = temp;
        }
    }
}
