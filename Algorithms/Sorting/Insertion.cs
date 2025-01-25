namespace Algorithms
{
    public static class Insertion
    {
        /*
         * 1. loop from index 1 to end.
         * 2. cache current value outside while loop.
         * 3. while inner index is lower than zero and inner - 1 value is greated than current. Shift values left.
         * 4. assign inner index value to current.
         */

        public static int[] InsertionSort(this int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int inner = i;
                int current = arr[i];

                while(inner > 0 && arr[inner -1] > current)
                {
                    arr[inner] = arr[inner - 1];
                    inner--;
                }

                arr[inner] = current;
            }

            return arr;
        }

		public static void Sort(int[] nums)
		{
			// loop through all items
			for (int i = 1; i < nums.Length; i++)
			{
				int j = i;
				int currentValue = nums[i]; // keep track of the current value

				while (j > 0 && nums[j - 1] > currentValue)
				{
					//shift items right
					nums[j] = nums[j - 1];

					j--;
				}

				nums[j] = currentValue;
			}
		}
    }
}