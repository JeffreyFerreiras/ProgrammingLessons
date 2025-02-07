using System;
using System.Collections.Generic;

namespace Algorithms.Window;

public class Sliding
{
    /// <summary>
    /// Finds the maximum sum of all contiguous subarrays of a specified window size.
    /// </summary>
    /// <param name="array">The source array of integers.</param>
    /// <param name="windowSize">The size of the sliding window. Must be > 0 and <= array length.</param>
    /// <returns>The maximum window sum.</returns>
    public static int MaxSlidingWindowSum(int[] array, int windowSize)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array));
        }
        if (windowSize <= 0 || windowSize > array.Length)
        {
            throw new ArgumentException("Window size must be greater than 0 and less than or equal to the length of the array.", nameof(windowSize));
        }

        int currentSum = 0;
        // Compute sum for the first window.
        for (int i = 0; i < windowSize; i++)
        {
            currentSum += array[i];
        }

        int maxSum = currentSum;

        // Slide the window across the array.
        for (int i = windowSize; i < array.Length; i++)
        {
            currentSum += array[i] - array[i - windowSize];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }

        return maxSum;
    }
}
