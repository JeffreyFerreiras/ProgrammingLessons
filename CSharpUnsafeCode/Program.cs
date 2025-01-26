using BenchmarkDotNet.Running;
using System.Diagnostics;

namespace CSharpUnsafeCode
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            BenchmarkRunner.Run<FibonacciBenchmark>();
            BenchmarkRunner.Run<ComplexStructBenchmark>();
            BenchmarkRunner.Run<ComplexStructPerformanceTest>();
        }
    }
}
