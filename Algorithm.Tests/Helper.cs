using System;

namespace Algorithms.Tests
{
    internal static class Helper
    {
        public static readonly Random rand = new Random();
        private static readonly object syncLock = new object();

        public static int RandomNumber(int min, int max)
        {
            lock(syncLock)
            { //synchronize
                return rand.Next(min, max);
            }
        }

        public static bool IsSortedArray(int[] arry)
        {
            for(int i = 0; i < arry.Length - 1; i++)
            {
                if(arry[i] > arry[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static int[] GetRandomizedArray(int length = 1000, int maxValue = 100)
        {
            int[] arry = new int[length];

            for(int i = 0; i < length; i++)
            {
                arry[i] = RandomNumber(0, maxValue);
            }

            return arry;
        }

        public static int[] GetSortedArray(int length = 1000)
        {
            return GetRandomizedArray(length).QuickSort();
        }
    }
}