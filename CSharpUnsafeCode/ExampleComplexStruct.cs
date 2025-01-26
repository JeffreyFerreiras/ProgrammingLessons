/**
 * To use stackalloc, the class must be an unmanaged value type (struct).
 * Additionally, all its fields must also be unmanaged. Specifically, the string? Name field is a reference type and must be removed or replaced with an unmanaged equivalent.
 **/

using BenchmarkDotNet.Attributes;

namespace CSharpUnsafeCode;

public struct ExampleComplexStruct
{
    public int Id;
    public fixed char Name[100]; // Fixed-size buffer for string
    public DateTime BirthDate;
    public double Salary;
    public bool IsActive;
}

public class ComplexStructPerformanceTest
{
    [Params(20000)] // Array size for benchmarking
    public int ArraySize;

    private ExampleComplexStruct InitializeComplexClass(int index)
    {
        return new ExampleComplexStruct
        {
            Id = index,
            Name = $"Name{index}",
            BirthDate = DateTime.Now.AddYears(-index),
            Salary = index * 1000,
            IsActive = index % 2 == 0
        };
    }

    [Benchmark]
    public ExampleComplexStruct[] RegularComplexClassArray()
    {
        ExampleComplexStruct[] array = new ExampleComplexStruct[ArraySize];
        for (int i = 0; i < ArraySize; ++i)
        {
            array[i] = InitializeComplexClass(i);
        }

        for (int i = 0; i < ArraySize; ++i)
        {
            array[i].Id += 1;
            array[i].Name += "_Updated";
            array[i].BirthDate = array[i].BirthDate.AddDays(1);
            array[i].Salary += 500;
            array[i].IsActive = !array[i].IsActive;
        }

        return array;
    }

    [Benchmark]
    public unsafe ExampleComplexStruct[] StackAllocatedComplexClassArray()
    {
        //Declaring a pointer to the stack-allocated array
        ExampleComplexStruct* arrayPointer = stackalloc ExampleComplexStruct[ArraySize];
        for (int i = 0; i < ArraySize; ++i)
        {
            arrayPointer[i] = InitializeComplexClass(i);
        }

        for (int i = 0; i < ArraySize; ++i)
        {
            arrayPointer[i].Id += 1;
            arrayPointer[i].Name += "_Updated";
            arrayPointer[i].BirthDate = arrayPointer[i].BirthDate.AddDays(1);
            arrayPointer[i].Salary += 500;
            arrayPointer[i].IsActive = !arrayPointer[i].IsActive;
        }

        // Copying stack-allocated array to managed array
        var array = new ExampleComplexStruct[ArraySize];

        for (int i = 0; i < ArraySize; ++i)
        {
            array[i] = arrayPointer[i];
        }

        return array;
    }

    //assign string value to fixed char array
    private unsafe char* AssignStringToFixedCharArray(char* fixedCharArray, string value)
    {
        //Ensure the string is not null
        ArgumentNullException.ThrowIfNull(value);

        // Ensure the string length does not exceed the fixed size

        // Copy the string to the fixed-size buffer
        for (int i = 0; i < value.Length && i < 100; i++)
        {
            fixedCharArray[i] = value[i];
        }
        fixedCharArray[value.Length] = '\0'; // Null-terminate the string
    }
}
