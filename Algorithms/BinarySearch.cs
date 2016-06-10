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
        {// bin search algorithm
            int left = 0, right = arry.Length -1;
            while(left <= right)
            {
                int mid = (left + right) / 2;
                if(arry[mid] < target) left = mid + 1; //to search the right side, assign mid to left.
                else if(arry[mid] > target) right = mid - 1; //to search the left side, assign mid to right.
                else return mid; //this means taht mid is on the correct index.
            }
            return -1;
        }
        public int RecursiveBinSearch(int[] arry, int left, int right, int target)
        {   //recursive bin search 
            int mid = (left + right)/2; //get the middle
            if(arry[mid] == target)     return mid;//middle is found!
            if(arry[mid] < target)      return RecursiveBinSearch(arry, mid + 1, right, target);// search the right side of the array
            if(arry[mid] > target)      return RecursiveBinSearch(arry, left, mid - 1, target); // search the left side of the array
            return -1;//not found!
        }

        int RecursiveBin2(int[]a, int l, int r, int x)
        {
            int m = (l+r)/2;
            if(a[m] == x) return m;
            if(a[m] < x)  return RecursiveBinSearch(a, l, m + 1, x);
            if(a[m] > x)  return RecursiveBinSearch(a, m - 1, r, x);
            return -1;
        }
        int BinSearch2(int[] a, int x)
        {
            int left = 0, right = a.Length-1;
            while(left<=right)
            {
                int mid = (left + right) / 2; // get mid point
                if(a[mid] < x) left = mid + 1;
                else if(a[mid] > x) right = mid -1;
                else return mid;
            }
            return -1;
        }
    }
}
