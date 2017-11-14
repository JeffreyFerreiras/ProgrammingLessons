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

        //public static void BubbleSort(this int[] arry)
        //{
        //    for (int outer = 0; outer < arry.Length; outer++)
        //    {
        //        for (int inner = 0; inner < arry.Length - 1; inner++)
        //        {
        //            if(arry[inner] > arry[inner+1])
        //            {   
        //                int temp = arry[inner + 1];
        //                arry[inner + 1] = arry[inner];
        //                arry[inner] = temp;
        //            }
        //        }
        //    }
        //}

        public static int[] BubbleSort2(this int[] arry)
        {
            for (int outer = 0; outer < arry.Length; outer++)
            {
                for (int inner = 0; inner < arry.Length -1; inner++)
                {
                    if(arry[inner] > arry[inner + 1])
                    {
                        Common.Swap(arry, inner, inner + 1);
                    }
                }
            }

            return arry;
        }

        public static int[] BubbleSort(this int[] arry)
        {
            bool swapped = false;

            do
            {
                swapped = false;

                for (int i = 0; i < arry.Length - 1; i++)
                {
                    if (arry[i] > arry[i + 1])
                    {
                        Common.Swap(arry, i, i + 1);
                        swapped = true;
                    }
                }

            } while (swapped);

            return arry;
        }
    }
}
