namespace Algorithms
{
    public static class Heap
    {
        public static int[] HeapSort(this int[] source)
        {
            int size = source.Length;

            //Rearange the array to a heap;
            for(int i = size / 2 - 1; i >= 0; i--)
            {
                Heapify(source, size, i);
            }

            for(int i = size - 1; i >= 0; i--)
            {
                Common.Swap(source, 0, i);

                Heapify(source, i, 0);
            }

            return source;
        }

        private static void Heapify(int[] source, int size, int index)
        {
            int largest = index;
            int leftIndex = 2 * index + 1;
            int rightIndex = 2 * index + 2;

            if(leftIndex < size && source[leftIndex] > source[largest]) largest = leftIndex;
            if(rightIndex < size && source[rightIndex] > source[largest]) largest = rightIndex;

            if(largest != index)
            {
                Common.Swap(source, index, largest);
                Heapify(source, size, largest);
            }
        }
    }
}