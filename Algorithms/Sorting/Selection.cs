using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Selection
    {
        public static int[] SelectionSort(this int[] arry)
        {
            for (int i = 0; i < arry.Length - 1; i++)
            {
                int minIndex = i;
                int inner = i + 1;

                while(inner < arry.Length)
                {
                    if(arry[inner] < arry[minIndex])
                    {
                        minIndex = inner;
                    }

                    inner++;
                }

                Common.Swap(arry, i, minIndex);
            }

            return arry;
        }
    }
}
