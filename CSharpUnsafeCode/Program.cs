namespace CSharpUnsafeCode
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            OutOfRangeTest();
            Fibbonacci();

            FixedKeyWord.App();
        }

        private static unsafe void Fibbonacci()
        {
            const int arraySize = 20;
            int* fib = stackalloc int[arraySize]; //square brackets take the size to allocate for the int, in the stack.
            int* p = fib;

            *p++ = *p++ = 1;

            for (int i = 2; i < arraySize; ++i, ++p)
            {
                *p = p[-1] + p[-2];
            }

            for (int i = 0; i < arraySize; ++i)
            {
                Console.WriteLine(fib[i]);
            }

            Console.ReadLine();
        }

        static unsafe void OutOfRangeTest()
        {
            int* num = stackalloc int[10];

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"ln: {i}, value: {num[i]}");
            }
        }
    }
}
