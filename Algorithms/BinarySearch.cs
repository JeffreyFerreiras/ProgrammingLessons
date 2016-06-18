using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BinarySearch
    {
        /*
        The binary search algo takes an ordered list of numbers and finds the target in O(log n)
        */
/*
 * 	
1. check if target is mid, if mid return target.
2. if target is on right side of mid then search right side
3. if target is on left side of mid then search left side.
4. return -1. If this is hit... the item was not found.
* */
        public BinarySearch()
        {
            List<int> randList = new List<int>();
            var random = new Random();
            for(int i = 0; i < 100; i++)
            {
                randList.Add(i + 1);
                //randList.Add(random.Next(100));
            }
            int index = BinSearch(randList.OrderBy(o => o).ToArray(), 40);
            ;
        }
        public int BinSearch(int [] arry, int target)
        {
            int left = 0, right = arry.Length -1;
            while(left <= right)
            {
                int mid = (left + right) / 2;
                if(arry[mid] < target) left = mid + 1; 
                else if(arry[mid] > target) right = mid - 1;
                else return mid;
            }
            return -1;
        }
        public int RecursiveBinSearch(int[] arry, int left, int right, int target)
        {   
            int mid = (left + right)/2; 
            if(arry[mid] == target)     return mid;
            if(arry[mid] < target)      return RecursiveBinSearch(arry, mid + 1, right, target);
            if(arry[mid] > target)      return RecursiveBinSearch(arry, left, mid - 1, target); 
            return -1;
        }
    }
}
