using BenchmarkDotNet.Running;
using System.Diagnostics;

namespace CSharpUnsafeCode
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            //BenchmarkRunner.Run<FibonacciBenchmark>();
            BenchmarkRunner.Run<ComplexStructPerformanceTest>();

            //var test = new ComplexStructPerformanceTest { ArraySize = 3 };
            //test.RegularComplexClassArray();
            //test.StackAllocatedComplexClassArray();
        }
    }
}
