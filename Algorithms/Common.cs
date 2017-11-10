using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Common
    {
        public static readonly Random rand = new Random();
        private static readonly object syncLock = new object();

        public static void Swap(this int[] array, int leftIndex, int rightIndex)
        {
            int temp = array[leftIndex];
            array[leftIndex] = array[rightIndex];
            array[rightIndex] = temp;
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
            lock (syncLock)
            { // synchronize
                return rand.Next(min, max);
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
