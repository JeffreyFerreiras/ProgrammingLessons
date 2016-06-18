using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class QuickSort
    {
        /*
        1st half.
        1) Get pivot point. GetPivotPoint(arry, left, right)
        2) If left is less than pivot, recur left to pivot - 1
        3) If right if less than pivot, recur pivot + 1 to right
        */
        /*
        2nd half
        GetPivotPoint(arry, left, right)
        1) iterate while left is less than or equal to right.
             a)get mid point.
             b)traverse left index until one value in the array that belongs to the right is found, while increasing left++
             c)traverse right index until one value in the array that belongs to the left is found, while decreasing right--;
             d)check if left is still lower than or equal to right, if it is, swap values.
        2) return left;
         */
        public QuickSort()
        {
            List<int> randList = new List<int>();
            var random = new Random();
            for(int i = 0; i < 10; i++)
                randList.Add(random.Next(100));
            var arry = randList.ToArray();
            QuickSorter(arry, 0, randList.Count() - 1);
            ;
        }
        public void QuickSorter(int[] arry, int left, int right)
        {
            int pivot = GetPartitionedPivot(arry, left, right); //gets new pivot point.
            if(left < pivot - 1)//sort left half         
                QuickSorter(arry, left, pivot - 1);
            if(pivot < right)// sort right half
                QuickSorter(arry, pivot, right);
        }
        private int GetPartitionedPivot(int[] arry, int left, int right)
        {
            int pivot = arry[(left + right) / 2 ]; //pivot point A.K.A middle
            while(left <= right)
            {
                while(arry[left] < pivot)//find element on left that should be on the right.              
                    left++;

                while(arry[right] > pivot)//find element on right that should be on left, then move on to swap.          
                    right--;

                if(left <= right)//quick check to make sure we can swap.
                {
                    //swap them!
                    int temp = arry[left];
                    arry[left] = arry[right];
                    arry[right] = temp;

                    //change left right values to avoid infinite loop.
                    left++;
                    right--;
                }
            }
            return left; //new pivot...
        }
        public void QuickSort2(int[] arry, int left, int right)
        {
            int pivot = GetPartitionedPivot2(arry, left, right);
            if(left < pivot - 1) QuickSort2(arry, left, pivot);
            if(pivot < right) QuickSort2(arry, pivot, right);
        }
        private int GetPartitionedPivot2(int[] arry, int left, int right)
        {
            while(left <= right) //continues until the right index and left side reaches index of the right side.
            {
                int mid = arry[(left + right) / 2];//gets the middle point of the array
                while(arry[left] < mid) left++; //move left index right until it reaches a number that belongs on the right side.
                while(arry[right] > mid) right--; //move right index to the left until it reaches a number that belongs on the right side.

                if(left <= right) //check that the indexes still make sense. The left can't be higher than the right index duhhh.
                {
                    //swap
                    int temp = arry[left];
                    arry[left] = arry[right];
                    arry[right] = temp;

                    //avoid infinite loop
                    left++;
                    right--;
                }
            }
            return left; // new pivot
        }
    }
}
