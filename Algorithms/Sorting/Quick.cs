namespace Algorithms
{
    public static class Quick
    {
        /* 
         * O(n log n) typical run time and O(log n) space.
         * O(n^2) worst case, if many items duplicate.
         * 
         */

        public static int[] QuickSort(this int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);

            return arr;
        }

        private static void QuickSort(int[] arr, int leftIndex, int rightIndex)
        {
            if(leftIndex < rightIndex)
            {
                int partitionIndex = Partition(arr, leftIndex, rightIndex);

                QuickSort(arr, leftIndex, partitionIndex - 1);      //Sort left side
                QuickSort(arr, partitionIndex, rightIndex);         //Sort right side
            }
        }

        private static int Partition(int[] arr, int leftIndex, int rightIndex)
        {
            int pivot = arr[(leftIndex + rightIndex) / 2];

            while(leftIndex <= rightIndex)
            {
                while(arr[leftIndex] < pivot) leftIndex++;          //Check numbers until one needs to be swaped to right side of the pivot.
                while(arr[rightIndex] > pivot) rightIndex--;        //Check numbers until one needs to be swaped to left side of the pivot.

                if(leftIndex <= rightIndex)
                {
                    Common.Swap(arr, leftIndex++, rightIndex--);
                }
            }

            return leftIndex;
        }
    }
}