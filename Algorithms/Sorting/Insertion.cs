using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Insertion
    {
        /*
         * 1. loop from index 1 to end.
         * 2. cache current value outside while loop.
         * 3. while inner index is lower than zero and inner - 1 value is greated than current. Shift values left.
         * 4. assign inner index value to current.
         */

        public static int[] InsertionSort(this int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int inner = i;
                int current = arr[i];

                while(inner > 0 && arr[inner -1] > current)
                {
                    arr[inner] = arr[inner - 1];
                    inner--;
                }

                arr[inner] = current;
            }

            return arr;
        }

        public static void Sort(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int insert = i;
                int current = arr[i];

                while(insert > 0 && arr[insert -1] > current)
                {
                    arr[insert] = arr[insert-1];
                    insert--;
                }

                arr[insert] = current;
            }
        }
    }
}