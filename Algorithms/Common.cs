namespace Algorithms
{
    public static class Common
    {
        public static readonly Random s_random = new Random();
        private static readonly object s_syncLock = new object();
        public static bool PrintSwapEnabled = false;

        public static void Swap(this int[] array, int leftIndex, int rightIndex)
        {
            // Print array before swap
            if (PrintSwapEnabled)
            {
                Console.Write("Before: ");
                array.PrintArray(new[] { leftIndex, rightIndex });
            }
            int temp = array[leftIndex];
            array[leftIndex] = array[rightIndex];
            array[rightIndex] = temp;
            
            // Print array after swap
            if (PrintSwapEnabled)
            {
                Console.Write("After:  ");
                array.PrintArray(new[] { leftIndex, rightIndex });
            }
        }

        public static void PrintArray(this int[] array, int[] highlightIndices = null, ConsoleColor highlightColor = ConsoleColor.Red)
        {
            const int maxDisplayElements = 20; // Limit display to avoid overwhelming console
            
            Console.Write("[");
            
            int displayCount = Math.Min(array.Length, maxDisplayElements);
            bool showEllipsis = array.Length > maxDisplayElements;
            
            for (int i = 0; i < displayCount; i++)
            {
                if (highlightIndices != null && Array.IndexOf(highlightIndices, i) >= 0)
                {
                    ConsoleColor originalColor = Console.ForegroundColor;
                    Console.ForegroundColor = highlightColor;
                    Console.Write(array[i]);
                    Console.ForegroundColor = originalColor;
                }
                else
                {
                    Console.Write(array[i]);
                }
                
                if (i < displayCount - 1)
                {
                    Console.Write(", ");
                }
            }
            
            if (showEllipsis)
            {
                Console.Write(", ...");
            }
            
            Console.WriteLine("]");
        }

        public static int[] GetRandomizedArray(int length = 100, int max = 1000)
        {
            int[] arry = new int[length];

            for (int i = 0; i < length; i++)
            {
                arry[i] = RandomNumber(0, max);
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

        public static bool IsSorted(this int[] arry)
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
