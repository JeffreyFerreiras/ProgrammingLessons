namespace Algorithms
{
	public static class QuickTraining
	{
		internal static int[] QuickSort(int[] nums)
		{
			QuickSort(nums, 0, nums.Length - 1);

			return nums;
		}

		private static void QuickSort(int[] nums, int low, int high)
		{
			if (low < high)
			{
				int partitionIndex = Partition(nums, low, high);

				QuickSort(nums, low, partitionIndex - 1); //sort the left side
				QuickSort(nums, partitionIndex, high); // sort the right side
			}
		}

		private static int Partition(int[] nums, int low, int high)
		{
			int pivotValue = nums[low + (high - low) / 2];

			while(low <= high)
			{
				while (nums[low] < pivotValue) low++;
				while (nums[high] > pivotValue) high--;

				if(low <= high)
				{
					var temp = nums[low];
					nums[low] = nums[high];
					nums[high] = temp;
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
			if (low < high)
			{
				int i = PartitionSubarray(arr, low, high);

				QuickSort(arr, low, i - 1);      //ShellSort left side
				QuickSort(arr, i, high);         //ShellSort right side
			}
		}

		private static int PartitionSubarray(int[] arr, int low, int high)
		{
			int pivot = arr[(low + high) / 2];

			while (low <= high)
			{
				while (arr[low] < pivot) low++;          //Check numbers until one needs to be swaped to right side of the pivot.
				while (arr[high] > pivot) high--;         //Check numbers until one needs to be swaped to left side of the pivot.

				if (low <= high)
				{
					Common.Swap(arr, low++, high--);
				}
			}

			return low;
		}
	}
}