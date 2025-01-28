namespace Algorithms
{
    public static class Bubble
    {
        /***
         * Runtime: O(n^2) Space: O(n) 
         * This class contains two implementations of the Bubble ShellSort algorithm.
         */

        // First implementation of Bubble ShellSort
        public static int[] BubbleSort(this int[] nums)
        {
            // Outer loop to iterate over the entire array
            for (int i = 0; i < nums.Length; i++)
            {
                // Inner loop to compare adjacent elements
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    // Swap if the current element is greater than the next element
                    if (nums[j] > nums[j + 1])
                    {
                        var temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }

            // Return the sorted array
            return nums;
        }

        // Second implementation of Bubble ShellSort with a flag to check if any swaps were made
        public static int[] BubbleSort2(this int[] arry)
        {
            bool swapped;

            // Repeat the process until no swaps are made
            do
            {
                swapped = false;

                // Iterate over the array and swap adjacent elements if needed
                for (int i = 0; i < arry.Length - 1; i++)
                {
                    if (arry[i] > arry[i + 1])
                    {
                        Common.Swap(arry, i, i + 1); // Use a helper method to swap elements
                        swapped = true; // Set the flag to true if a swap is made
                    }
                }

            } while (swapped); // Continue if any swaps were made in the previous pass

            // Return the sorted array
            return arry;
        }
    }
}
