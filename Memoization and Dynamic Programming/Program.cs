using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoization_and_Dynamic_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 40;
            var sw = new Stopwatch();

            Console.WriteLine("Recursive formula");
            sw.Start();
            foreach (var num in Enumerable.Range(0, max))
            {
                Console.WriteLine($"Fib result: {Fib(num)} Ticks: {sw.ElapsedTicks}");
            }
            Console.WriteLine();
            sw.Reset();


            Console.WriteLine("Golden Ratio formula");

            sw.Start();

            foreach (var num in Enumerable.Range(0, max))
            {
                Console.WriteLine($"Fib result: {ConstantFib(num)} Ticks: {sw.ElapsedTicks}");
            }

            Console.WriteLine();
            sw.Reset();

            Console.ReadLine();
        }


        static Dictionary<int, int> cache = new Dictionary<int, int>();

        static int Fib(int n)
        {
            if (cache.ContainsKey(n) && cache[n] != 0)
                return cache[n];
            
            if (n < 2) return n;

            cache[n] = Fib(n - 1) + Fib(n - 2);

            return cache[n];
        }

        static int ConstantFib(int input)
        {
            double termA = Math.Pow(((1 + Math.Sqrt(5)) / 2), input);
            double termB = Math.Pow(((1 - Math.Sqrt(5)) / 2), input);

            double factor = 1 / Math.Sqrt(5);

            return (int)Math.Round(factor * (termA - termB));
        }
    }
}
