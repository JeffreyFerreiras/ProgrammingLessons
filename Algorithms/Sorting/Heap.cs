using System.Collections;
using System.Collections.Generic;

namespace Algorithms
{
    public static class Heap
    {
        public static int[] HeapSort(this int[] source)
        {
            int size = source.Length;

            //Rearange the array to a heap;
            for(int i = (size / 2 ) - 1; i >= 0; i--)
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

        private static void Heapify(int[] source, int length, int index)
        {
            int biggerChildIndex = index;
            int leftChildIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;

			if (leftChildIndex < length && source[leftChildIndex] > source[biggerChildIndex])
			{
				biggerChildIndex = leftChildIndex;
			}
            
			if(rightChildIndex < length && source[rightChildIndex] > source[biggerChildIndex])
			{
				biggerChildIndex = rightChildIndex;
			}

			if (biggerChildIndex != index)
            {
                Common.Swap(source, index, biggerChildIndex);

                Heapify(source, length, biggerChildIndex);
            }
        }
    }
}