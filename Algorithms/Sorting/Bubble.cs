using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Bubble
    {
        /***
         * Runtime: O(n^2) Space: O(n) 
         */

        public static void BubbleSort(this int[] arry)
        {
            for (int i = 0; i < arry.Length; i++)
            {
                for (int j = 0; j < arry.Length - 1; j++)
                {
                    if (arry[j] == arry[j+1]) continue;

                    if(arry[j] > arry[j+1])
                    {
                        int temp = arry[i+1];
                        arry[j+1] = arry[j];
                        arry[j] = temp; 
                    }
                }
            }
        }
    }
}
