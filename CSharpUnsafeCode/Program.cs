using BenchmarkDotNet.Running;

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
