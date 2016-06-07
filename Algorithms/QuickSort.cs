using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class QuickSort
    {
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
        public void QuickSorter(int [] arry, int left, int right)
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
    }
}
