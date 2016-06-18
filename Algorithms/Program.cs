using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinarySearch binSearch = new BinarySearch();
            //QuickSort quickSort = new QuickSort();
            MergeSort mergeSort = new MergeSort();
            mergeSort.Sort(GetUnsortedArray());
        }
        static int[] GetUnsortedArray()
        {
            List<int> randList = new List<int>();
            var random = new Random();
            for(int i = 0; i < 100; i++)
            {
                randList.Add(random.Next(100));
            }
            return randList.ToArray();
        }
    }
}
