namespace Algorithms.Sorting
{
    public static class Insertion
    {
        /*
         * 1. loop from index 1 to end.
         * 2. cache currentValue value outside while loop.
         * 3. while inner index is lower than zero and inner - 1 value is greated than currentValue. Shift values left.
         * 4. assign inner index value to currentValue.
         */

        public static int[] InsertionSort(this int[] values)
        {
            for (int i = 1; i < values.Length; i++)
            {
                int inner = i;
                int currentValue = values[i]; 

                while (inner > 0 && values[inner - 1] > currentValue)
                {
                    values[inner] = values[inner - 1];
                    inner--;
                }

                values[inner] = currentValue;
            }

            return values;
        }

        public static void Sort(int[] nums)
        {
            // loop through all items
            for (int i = 1; i < nums.Length; i++)
            {
                int j = i;
                int currentValue = nums[i]; // keep track of the currentValue value

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