namespace Algorithms
{
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
                while(arr[low] < pivot) low++;          //Check numbers until one needs to be swaped to right side of the pivot.
                while(arr[high] > pivot) high--;        //Check numbers until one needs to be swaped to left side of the pivot.

                if(low <= high)
                {
                    Common.Swap(arr, low++, high--);
                }
            }

            return low;
        }
    }
}