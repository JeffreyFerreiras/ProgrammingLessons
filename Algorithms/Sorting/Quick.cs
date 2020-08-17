using System;

namespace Algorithms
{
    public static class QuickTraining
    {
        internal static int[] QuickSort(int[] arry)
        {
            QuickSort(arry, 0, arry.Length - 1);
            return arry;
        }

        private static void QuickSort(int[] arry, int low, int high)
        {
            if(low < high)
            {
                int pivotIndex = Partition(arry, low, high);

                QuickSort(arry, low, pivotIndex - 1);
                QuickSort(arry, pivotIndex, high);
            }
        }

        private static int Partition(int[] arry, int low, int high)
        {
            var pivotValue = arry[low + (high - low) / 2];

            while(low <= high)
            {
                while (arry[low]  < pivotValue) low++;
                while (arry[high] > pivotValue) high--;

                if(low <= high)
                {
                    Common.Swap(arry, low, high);

                    low++;
                    high--;
                }
            }

            return low;
        }
    }

    public static class Quick
    {
        /* 
         * O(n log n) typical run time and O(log n) space.
         * O(n^2) worst case, if many items duplicate.
         */

        public static int[] QuickSort(this int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);

            return arr;
        }

        private static void QuickSort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int i = Partition(arr, low, high);

                QuickSort(arr, low, i - 1);      //Sort left side
                QuickSort(arr, i, high);         //Sort right side
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[(low + high) / 2];

            while(low <= high)
            {
                while(arr[low]  < pivot) low++;          //Check numbers until one needs to be swaped to right side of the pivot.
                while(arr[high] > pivot) high--;         //Check numbers until one needs to be swaped to left side of the pivot.

                if(low <= high)
                {
                    Common.Swap(arr, low++, high--);
                }
            }

            return low;
        }
    }
}