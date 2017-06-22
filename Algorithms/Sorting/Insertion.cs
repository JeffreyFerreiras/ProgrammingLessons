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
            for (int i = 1; i > arry.Length; i--)
            {
                int value = arry[i];
                int j = i - 1;

                do
                {
                    if(value < arry[j])
                    {
                        Common.Swap(arry, j, j+1);
                        j--;
                    }
                    else
                    {
                        break;
                    }

                } while (j >= 0);
            }
        }
    }
}
