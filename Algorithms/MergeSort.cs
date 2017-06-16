using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
/*
Merge sort O(n log n) typical runtime.
-  O(n) time complexity.
-  Merge sort is used when the data structure doesn't support random access, since it works with pure sequential access.

    So, to generalize, quicksort is probably more effective for datasets that fit in memory.
    For stuff that's larger, it's better to use mergesort.

    The other general time to use mergesort over quicksort is if the data is very similar (that is, not close to being uniform).
    Quicksort relies on using a pivot. In the case where all the values are the similar, quicksort hits a worst case of O(n^2).
    If the values of the data are very similar,
    then it's more likely that a poor pivot will be chosen leading to very unbalanced partitions leading to an O(n^2) runtime.
    The most straightforward example is if all the values in the list are the same.
*/
/*
 * 1. Create a sort method that takes an array.
 * 2. Call the overloaded sort method with the array, helper, left index and right index.
 * 3. In the overloaded sort method declare an if statement stating if the left index is less than the right index, continue.
 * 4. get mid index
 * 5. sort the left half by recursively calling sort.
 * 6. sort the right half by recursively calling sort.
 * 7. merge the array.
 * 
 * 1. In Merge, copy items from array to helper from left, to right indexes.
 * 2. Declare 3 integers. A low that equals left index, a currentIndex that equals the left index and a high that equals the mid point.
 * 3. while low is less than or equals to mid (NOT high) and high is less or equals to right, continue.
 * 4. if helper low <= helper high, assign helper low to array currentIndex.
 * 5. else assign helper high to array currentIndex.
 * 6. handle remaining elements by declaring in remaining equals to mid - left
 * 7. for each index assign helper left + index to array current + index 
 */
    static class MergeSort
    {    
        public static int[] Sort(int[] array)
        {
            int[]helper = new int[array.Length];

            Sort(array, helper, 0, array.Length - 1);

            return array;
        }

        static void Sort(int[] array, int[] helper, int low, int high)
        {
            if(low < high)
            {
                int mid = (low + high)/2;

                Sort(array, helper, low, mid);          
                Sort(array, helper, mid + 1, high);

                Merge(array, helper, low, mid, high);
            }
        }

        static void Merge(int[] array, int[] helper, int lowIndex, int middleIndex, int highIndex)
        {
            for (int i = lowIndex; i <= highIndex; i++)
            {
                helper[i] = array[i];
            }

            int leftIndex = lowIndex;
            int currentIndex = lowIndex;
            int rightIndex = middleIndex + 1;

            while(leftIndex <= middleIndex && rightIndex <= highIndex)
            {
                if(helper[leftIndex] <= helper[rightIndex])
                {
                    array[currentIndex] = helper[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[currentIndex] = helper[rightIndex];
                    rightIndex++;
                }

                currentIndex++;
            }

            int remaining = middleIndex - leftIndex;

            for (int i = 0; i <= remaining; i++)
            {
                array[currentIndex + i] = helper[leftIndex + i];
            }
        }
    }
}