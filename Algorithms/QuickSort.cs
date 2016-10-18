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
            QuickSort2(arry, 0, arry.Length - 1);
            return arry;
        }

        public static void QuickSort2(int[] arry, int leftIndex, int rightIndex)
        {
            int pivot = GetPartitionedPivot2(arry, leftIndex, rightIndex);

            if(leftIndex < pivot - 1)
                QuickSort2(arry, leftIndex, pivot -1);

            if(pivot < rightIndex)
                QuickSort2(arry, pivot, rightIndex);
        }

        private static int GetPartitionedPivot2(int[] arry, int leftIndex, int rightIndex)
        {
            while(leftIndex <= rightIndex)
            {
                int midArryVal = arry[(leftIndex + rightIndex) / 2];

                while(arry[leftIndex] < midArryVal) leftIndex++;
                while(arry[rightIndex] > midArryVal) rightIndex--;

                if(leftIndex <= rightIndex)
                {
                    Swap(arry, leftIndex, rightIndex);

                    leftIndex++;
                    rightIndex--;
                }
            }
            return leftIndex;
        }

        private static void Swap(int[] arry, int leftIndex, int rightIndex)
        {
            int temp = arry[leftIndex];
            arry[leftIndex] = arry[rightIndex];
            arry[rightIndex] = temp;
        }
    }
}
