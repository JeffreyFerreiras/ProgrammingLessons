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
    class MergeSort
    {
        
        public int[] Sort(int[] array)
        {
            int[]helper = new int[array.Length];
            Sort(array, helper, 0, array.Length - 1);
            return array;
        }
        void Sort(int[] array, int[] helper, int low, int high)
        {
            if(low < high)
            {
                int mid = (low + high)/2;
                Sort(array, helper, low, mid);          //sort left side.
                Sort(array, helper, mid + 1, high);     //sort right side.
                Merge(array, helper, low, mid, high);   //merge them.
            }
        }
        void Merge(int[] array, int[] helper, int low, int mid, int high)
        {
            for(int i = low; i <= high; i++)//copy low - high into helper array
            {
                helper[i] = array[i];
            }

            //merging part.
            int left = low, right = mid + 1, current = low; //assign new variables to make changes to them.
            while(left <= mid && right <= high)
            {
                if(helper[left] <= helper[right]) //element on left is smaller than right element
                {
                    array[current] = helper[left];
                    left++;
                }
                else// If right element is smaller than left element.
                {
                    array[current] = helper[right];
                    right++;
                }
                current++;
            }

            //handle remaining elements.
            int remaining = mid - left;
            for(int i = 0; i <= remaining; i++)
            {
                array[current + i] = helper[left + i];
            }
        }
    }
}
