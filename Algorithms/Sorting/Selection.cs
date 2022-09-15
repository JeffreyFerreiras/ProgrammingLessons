using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Selection
    {
        /*
         * 1. Loop through every element minus one.
         * 2. Traverse non sorted elements. (i +1 to end)
         * 3. If item with min index is higher than non sorted item, set min index to non sorted index.
         * 4. Swap i the minIndex values.
         * 
         * This algorithm is good for minimizing writes
         */


        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                int indexOfElementNotSorted = i + 1;

                while(indexOfElementNotSorted < arr.Length)
                {
                    if(arr[minIndex] > arr[indexOfElementNotSorted])
                    {
                        minIndex = indexOfElementNotSorted;
                    }

                    indexOfElementNotSorted++;
                }

                Common.Swap(arr, i, minIndex);
            }

            return arr;
        }

		/// <summary>
		/// Selection sort - sort with diminishing increment (descending)
		/// </summary>
		/// <param name="nums"></param>
		public static void Sort(int[] nums)
        {

			// loop through the items
            for(int i = 0; i < nums.Length - 1; i++)
			{
				int smallest = i; // keep track of the smallest value index
				int unsorted = i + 1; // keep track of the unsorted index

				while (unsorted < nums.Length) // loop through the unsorted items
				{
					if (nums[smallest] > nums[unsorted])  // if the smallest is greater than the unsorted, the smallest now becomes the unsorted's index
					{
						smallest = unsorted;
					}
					unsorted++;
				}
				
				//swap smallest value found with the current index
				var temp = nums[smallest];
				nums[smallest] = nums[i];
				nums[i] = temp;
			}
        }
    }
}
