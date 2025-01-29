namespace Algorithms.Misc;

/*
* A prime number is a natural number greater than 1 that has no positive divisors other than 1 and itself.
* In other words, a prime number is a number that cannot be formed by multiplying two smaller natural numbers.
* Examples of prime numbers include 2, 3, 5, 7, 11, 13, etc.
*/
public class SieveOfEratosthenes
{
    // This method finds all prime numbers up to the specified integer using the Sieve of Eratosthenes algorithm.
    public static List<int> FindPrimesUpTo(int limit)
    {
        // Initialize a boolean array to track prime numbers.
        bool[] isPrime = new bool[limit + 1];
        for (int i = 2; i <= limit; i++)
        {
            isPrime[i] = true;
        }

        // Implement the Sieve of Eratosthenes algorithm.
        for (int p = 2; p * p <= limit; p++)
        {
            // If isPrime[p] is not changed, then it is a prime.
            if (isPrime[p])
            {
                // Update all multiples of p to not prime.
                for (int i = p * p; i <= limit; i += p)
                {
                    isPrime[i] = false;
                }
            }
        }

        // Collect all prime numbers.
        List<int> primes = [];
        for (int i = 2; i <= limit; i++)
        {
            if (isPrime[i])
            {
                primes.Add(i);
            }
        }

        return primes;
    }
}
