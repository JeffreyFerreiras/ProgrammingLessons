using BenchmarkDotNet.Attributes;

namespace CSharpUnsafeCode;

public class FibonacciBenchmark
{
    // Parameter for the size of the Fibonacci array to be used in benchmarking
    [Params(20000)]
    public int ArraySize;

    // Benchmark method to calculate Fibonacci sequence using unsafe code and stack allocation
    [Benchmark]
    public unsafe int[] UnsafeFibonacci()
    {
        // Allocate memory on the stack for the Fibonacci sequence
        int* fib = stackalloc int[ArraySize];
        int* p = fib;

        // Initialize the first two elements of the Fibonacci sequence
        *p++ = *p++ = 1;

        // Calculate the rest of the Fibonacci sequence
        for (int i = 2; i < ArraySize; ++i, ++p)
        {
            *p = p[-1] + p[-2];
        }

        // Copy the result from stack-allocated memory to a managed array
        int[] result = new int[ArraySize];
        for (int i = 0; i < ArraySize; ++i)
        {
            result[i] = fib[i];
        }

        // Return the managed array containing the Fibonacci sequence
        return result;
    }

    // Benchmark method to calculate Fibonacci sequence using regular managed code
    [Benchmark]
    public int[] RegularFibonacci()
    {
        // Allocate memory on the heap for the Fibonacci sequence
        int[] fib = new int[ArraySize];

        // Initialize the first two elements of the Fibonacci sequence
        fib[0] = fib[1] = 1;

        // Calculate the rest of the Fibonacci sequence
        for (int i = 2; i < ArraySize; ++i)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }

        // Return the array containing the Fibonacci sequence
        return fib;
    }
}
