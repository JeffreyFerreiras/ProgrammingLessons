namespace CSharpUnsafeCode
{
    class Point
    {
        public int x, y;
    }

    internal class FixedKeyWord
    {
        unsafe static void SquarePrintParam(int* p)
        {
            *p *= *p;
        }

        internal unsafe static void App()
        {
            Point point = new Point
            {
                x = 5,
                y = 6
            };

            fixed (int* p = &point.x)
            {
                SquarePrintParam(p);
            }

            Console.WriteLine($"{point.x} {point.y}");
        }
    }
}
