namespace Algorithms
{
    public static class BinarySearch
    {
        /*
            The binary search algo takes an ordered list of numbers and finds the target in O(log n)
        */

        /* Iterative Binary Search
         *
            0. Decrare the left and right points.
            1. While the left is less than or equal to right point
                a) Get the mid point by averaging the left and right.
                b) Check if target greater than array[mid]. If so, assign mid point to left + 1.
                c) Check if target lower than array[mid]. If so, assign mid point to right - 1
                d) Else, return midpoint.
            2. Return -1.
          *
          */

        /* Recursive Binary Search
         *
        0. Get the midpoint by averaging the left and right side.
        1. Check if target is mid, if mid return target.
        2. Check if target greater than array[mid]
            a) If target is greater, then it is on the right side. Search on right side.
        3. Check if target lower than array[mid]
            a) If target is lower, then it is on the left side. Search on left side.
        4. return -1. If this is hit... the item was not found.
        * */

        private static int RecursiveBinSearch(this int[] arry, int left, int right, int target)
        {
            int mid = (left + right) / 2;

            if(arry[mid] == target) return mid;
            if(arry[mid] < target)  return RecursiveBinSearch(arry, mid + 1, right, target);
            if(arry[mid] > target)  return RecursiveBinSearch(arry, left, mid - 1, target);

            return -1;
        }

        public static int BinSearch(this int[] arr, int x)
        {
            int mid;
            int low = 0;
            int high = arr.Length - 1;

            while(low < high)
            {
                mid = (low + high) / 2;

                if(arr[mid] > x)
                    high = mid - 1;
                else if(arr[mid] < x)
                    low = mid + 1;
                else
                    return mid;
            }

            return -1; //Not found
        }
    }
}