namespace Algorithms.Sorting
{
    public class Shell
    {
        /// <summary>
        /// Shell sort is an unstable quadratic sorting algorithm, which can be seen as a generalization of insertion sort. Although it has an O(n^2) asymptotic complexity, it is the most efficient algorithm of this class.
        /// <remarks>
        /// An ordinary insertion sort maintains a list of already sorted elements. 
        /// Then it picks the element next to the list and places it at the correct position within the list.
        /// By iteratively repeating this procedure (starting with a list of one element) the array gets sorted in n steps.
        /// Shell sort operates analogously. The main difference is that Shell sort uses so-called diminishing increment.
        /// It means that in every step only elements at some distance are compared 
        /// (for example the first with the fifth, second with the sixth...).
        /// This approach ensures that elements with high and low value are moved to the appropriate side of the array very quickly.
        /// In every iteration the gap between the compared elements is reduced.
        /// In the iteration step, the gap is set to one – the algorithm degrades to an ordinary insertion sort,
        /// which terminates very quickly, because now the array contains only a few misplaced elements.
        /// </remarks>
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        /// <returns>The sorted array.</returns>
        public static int[] ShellSort(int[] array)
        {
            // Initialize the gap size.
            int gap = array.Length / 2;

            // Continue until the gap size is reduced to 0.
            while (gap > 0)
            {
                // Perform a modified insertion sort for each gap size.
                for (int i = gap; i < array.Length; i++)
                {
                    // Store the current value and its index.
                    int currentValue = array[i];
                    int currentIndex = i;

                    // Shift elements of the sorted segment to the right to create the correct position for the current value.
                    while (currentIndex >= gap && array[currentIndex - gap] > currentValue)
                    {
                        array[currentIndex] = array[currentIndex - gap];
                        currentIndex -= gap;
                    }

                    // Place the current value in its correct position.
                    array[currentIndex] = currentValue;
                }

                // Reduce the gap size for the next iteration.
                if (gap == 2)
                {
                    gap = 1;
                }
                else
                {
                    gap = (int)(gap / 2.2);
                }
            }

            // Return the sorted array.
            return array;
        }
    }
}
