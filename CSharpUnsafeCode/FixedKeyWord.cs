namespace CSharpUnsafeCode
{
    class Point
    {
        public int x, y;
    }

    internal class FixedKeyWord
    {
        // Method to square the value pointed to by the pointer
        unsafe static void SquarePrintParam(int* p)
        {
            *p *= *p; // Square the value at the pointer location
        }

        // Method to demonstrate using fixed with a Point object
        internal unsafe static void FixedWithPoint()
        {
            Point point = new Point
            {
                x = 5,
                y = 6
            };

            // Fix the address of point.x and pass it to SquarePrintParam
            fixed (int* p = &point.x)
            {
                SquarePrintParam(p);
            }

            // Print the modified values of point.x and point.y
            Console.WriteLine($"{point.x} {point.y}");
        }

        // Method to demonstrate using fixed with an array
        internal unsafe static void FixedWithArray()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Fix the address of the first element of the array
            fixed (int* pArray = numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    // Pass the address of each element to SquarePrintParam
                    SquarePrintParam(pArray + i);
                }
            }

            // Print the modified array elements
            Console.WriteLine("Squared array elements:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        // Method to demonstrate using fixed with a string
        internal unsafe static void FixedWithString()
        {
            string str = "Hello";

            // Fix the address of the first character of the string
            fixed (char* pStr = str)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    // Print each character in the string
                    Console.WriteLine(*(pStr + i));
                }
            }
        }

        // Main method to call the other methods
        internal unsafe static void App()
        {
            FixedWithPoint(); // Demonstrate fixed with Point
            FixedWithArray(); // Demonstrate fixed with array
            FixedWithString(); // Demonstrate fixed with string
        }
    }
}
