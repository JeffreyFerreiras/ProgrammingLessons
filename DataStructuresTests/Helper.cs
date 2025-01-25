namespace DataStructuresTests
{
    public static class Helper
    {
        private static readonly Random s_random = new Random();
        private static readonly object s_syncLock = new object();

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

        internal static int[] GetRandomArray(int size)
        {
            return GetRandomArray(size, 0, 100);
        }

        internal static int[] GetRandomArray(int size, int max)
        {
            return GetRandomArray(size, 0, max);
        }

        internal static int[] GetRandomArray(int size, int min, int max)
        {
            var arr = new int[size];

            for(int i = 0; i < arr.Length; i++)
            {
                lock(s_syncLock)
                {
                    arr[i] = s_random.Next(min, max);
                }
            }

            return arr;
        }
    }
}
