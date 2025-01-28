namespace Algorithms.Misc
{
    // Euclid's Algorithm is used to find the greatest common divisor (GCD) of two numbers.

    public class Euclids
    {
        // This method finds the greatest common divisor (GCD) of two integers using Euclid's Algorithm.
        public static int FindCommonDivisor(int first, int second)
        {
            // Calculate the quotient of the division of the first number by the second number.
            int result = first / second;

            // Calculate the remainder of the division of the first number by the second number.
            int rem = first % second;

            // If the remainder is not zero, recursively call the method with the second number and the remainder.
            if (rem != 0)
            {
                first = second;
                second = rem;

                return FindCommonDivisor(first, second);
            }

            // If the remainder is zero, return the result which is the GCD.
            return result;
        }
    }
}
