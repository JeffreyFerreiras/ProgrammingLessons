
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        delegate int[] Sort(int[] arry);

        static void Main(string[] args)
        {
            const int LEN = 10;

            int[]arry = Common.GetRandomizedArray(LEN);

            GenericSort(Quick.QuickSort, arry);
            GenericSort(Merge.MergeSort, arry);
            GenericSort(Bubble.BubbleSort, arry);
            GenericSort(Insertion.InsertionSort, arry);
            GenericSort(Selection.SelectionSort, arry);

            Console.WriteLine("\nSort Again?");
            string input = Console.ReadLine();

            if (input.ToLower() != "n") Main(args);
        }

        static void GenericSort(Sort sort, int [] arry)
        {
            int[] copy = new int[arry.Length];
            Array.Copy(arry, copy, arry.Length);

            timer.Start();
            sort(copy);
            Console.WriteLine(
                    $"{sort.Method.Name}:\t Time:{timer.ElapsedTicks.ToString("N")}\t\t\tSorted: {copy.IsSortedArray()}"
                   /*+$"\tMemory: {GC.GetTotalMemory(true).ToString("N")} bytes\n"*/);

            timer.Reset();
        }
    }
}
