using BenchmarkDotNet.Attributes;

namespace CSharpUnsafeCode;

public struct ComplexStruct
{
    public int Field1;
    public int Field2;
    public int Field3;
    public int Field4;
    public int Field5;
}

public class ComplexStructBenchmark
{
    [Params(20000)] // Array size for benchmarking
    public int ArraySize;

    [Benchmark]
    public unsafe ComplexStruct[] UnsafeComplexStructArray()
    {
        ComplexStruct* array = stackalloc ComplexStruct[ArraySize];
        for (int i = 0; i < ArraySize; ++i)
        {
            array[i] = new ComplexStruct { Field1 = i, Field2 = i, Field3 = i, Field4 = i, Field5 = i };
        }

        ComplexStruct[] result = new ComplexStruct[ArraySize];
        for (int i = 0; i < ArraySize; ++i)
        {
            result[i] = array[i];
        }

        return result;
    }

    [Benchmark]
    public ComplexStruct[] RegularComplexStructArray()
    {
        ComplexStruct[] array = new ComplexStruct[ArraySize];
        for (int i = 0; i < ArraySize; ++i)
        {
            array[i] = new ComplexStruct { Field1 = i, Field2 = i, Field3 = i, Field4 = i, Field5 = i };
        }

        return array;
    }
}
