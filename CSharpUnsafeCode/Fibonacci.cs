using BenchmarkDotNet.Attributes;

namespace CSharpUnsafeCode;

public class FibonacciBenchmark
{
    [Params(20000)] // Array size for benchmarking
    public int ArraySize;

    [Benchmark]
    public unsafe int[] UnsafeFibonacci()
    {
        int* fib = stackalloc int[ArraySize];
        int* p = fib;

        *p++ = *p++ = 1;

        for (int i = 2; i < ArraySize; ++i, ++p)
        {
            *p = p[-1] + p[-2];
        }

        int[] result = new int[ArraySize];
        for (int i = 0; i < ArraySize; ++i)
        {
            result[i] = fib[i];
        }

        return result;
    }

    [Benchmark]
    public int[] RegularFibonacci()
    {
        int[] fib = new int[ArraySize];
        fib[0] = fib[1] = 1;

        for (int i = 2; i < ArraySize; ++i)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }

        return fib;
    }
}
