using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresTests
{
    public static class Helper
    {
        private static readonly Random s_random = new Random();
        private static readonly object s_lock = new object();

        public static bool IsOrdered(this IEnumerable<int> arr)
        {
            for(int i = 1; i < arr.Count(); i++)
            {
                if(arr.ElementAt(i-1) > arr.ElementAt(i))
                {
                    return false;
                }
            }

            return true;
        }

        internal static int[] GetRandomArry(int size)
        {
            var arr = new int[size];

            for(int i = 0; i < arr.Length; i++)
            {
                lock(s_lock)
                {
                    arr[i] = s_random.Next(0, 99999);
                }
            }

            return arr;
        }
    }
}
