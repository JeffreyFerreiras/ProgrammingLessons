using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public static class Insertion
    {
        public static void InsertionSort(this int [] arry)
        {
            for (int i = 1; i < arry.Length; i++)
            {
                int value = arry[i];
                int index = i - 1;

                //Movie value left until it's in the right place.
                while(arry[index] > value && index >= 0)
                {
                    Common.Swap(arry, index, index + 1);
                    index--;
                }
            }
        }
    }
}