namespace Algorithms.Strings;

public class KMP
{
    /*
     * Knuth-Morris-Pratt (KMP) Algorithm
     * Efficiently performs substring searches within a main string by preprocessing the pattern to avoid redundant comparisons.
     */

    /// <summary>
    /// Searches for occurrences of a pattern within a main string using the KMP algorithm.
    /// </summary>
    /// <param name="text">The main string to search within.</param>
    /// <param name="pattern">The pattern to search for.</param>
    /// <returns>A list of starting indices where the pattern is found in the text.</returns>
    public List<int> KMPSearch(string text, string pattern)
    {
        List<int> resultIndices = [];
        int[] lpsArray = ComputeLPSArray(pattern);
        int textIndex = 0; // index for text
        int patternIndex = 0; // index for pattern

        while (textIndex < text.Length)
        {
            if (pattern[patternIndex] == text[textIndex])
            {
                patternIndex++;
                textIndex++;
            }

            if (patternIndex == pattern.Length)
            {
                resultIndices.Add(textIndex - patternIndex);
                patternIndex = lpsArray[patternIndex - 1];
            }
            else if (textIndex < text.Length && pattern[patternIndex] != text[textIndex])
            {
                if (patternIndex != 0)
                {
                    patternIndex = lpsArray[patternIndex - 1];
                }
                else
                {
                    textIndex++;
                }
            }
        }

        return resultIndices;
    }

    /// <summary>
    /// Computes the Longest Prefix Suffix (LPS) array used to skip characters while matching.
    /// </summary>
    /// <param name="pattern">The pattern for which to compute the LPS array.</param>
    /// <returns>The LPS array.</returns>
    private int[] ComputeLPSArray(string pattern)
    {
        int length = 0;
        int patternIndex = 1;
        int[] lpsArray = new int[pattern.Length];
        lpsArray[0] = 0;

        while (patternIndex < pattern.Length)
        {
            if (pattern[patternIndex] == pattern[length])
            {
                length++;
                lpsArray[patternIndex] = length;
                patternIndex++;
            }
            else
            {
                if (length != 0)
                {
                    length = lpsArray[length - 1];
                }
                else
                {
                    lpsArray[patternIndex] = 0;
                    patternIndex++;
                }
            }
        }

        return lpsArray;
    }
}
