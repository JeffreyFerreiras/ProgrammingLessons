using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Common
    {
        public static readonly Random s_random = new Random();
        private static readonly object s_syncLock = new object();

        public static void Swap(this int[] array, int leftIndex, int rightIndex)
        {
            array[leftIndex] =  array[leftIndex] ^ array[rightIndex];
            array[rightIndex] = array[leftIndex] ^ array[rightIndex];
            array[leftIndex] =  array[leftIndex] ^ array[rightIndex];

            //int temp = array[leftIndex];
            //array[leftIndex] = array[rightIndex];
            //array[rightIndex] = temp;
        }

        public static int[] GetRandomizedArray(int length = 100)
        {
            int[] arry = new int[length];

            for (int i = 0; i < length; i++)
            {
                arry[i] = RandomNumber(0, 100);
            }

            return arry;
        }

        public static int RandomNumber(int min, int max)
        {
            lock (s_syncLock)
            { // synchronize
                return s_random.Next(min, max);
            }
        }

        public static bool IsSortedArray(this int[] arry)
        {
            for (int i = 0; i < arry.Length - 1; i++)
            {
                if (arry[i] > arry[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
