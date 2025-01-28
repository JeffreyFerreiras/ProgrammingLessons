using Algorithms.Sorting;

namespace Algorithms
{
    class Program
    {
        private static readonly System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        delegate int[] Sort(int[] arry);

        static void Main(string[] args)
        {
            PrintSortStats(10000);
            PrintSortStats(1000);
            PrintSortStats(150);

            Console.WriteLine("\nSort Again?");
            string? input = Console.ReadLine();

            if(input?.ToLower() != "n")
            {
                Main(args);
            }
        }

        private static void PrintSortStats(int len)
        {
            Console.WriteLine($"\nItem Count: {len}");
            int[] arry = Common.GetRandomizedArray(len);

            GenericSort(Shell.ShellSort, arry);
            GenericSort(Heap.HeapSort, arry);
            GenericSort(Quick.QuickSort, arry);
            GenericSort(Merge.MergeSort, arry);
            GenericSort(Bubble.BubbleSort, arry);
            GenericSort(Insertion.InsertionSort, arry);
            GenericSort(Selection.SelectionSort, arry);
        }

        static void GenericSort(Sort sort, int [] arry)
        {
            int[] copy = new int[arry.Length];
            Array.Copy(arry, copy, arry.Length);

            timer.Start();
            sort(copy);

            Console.WriteLine(
                    $"{sort.Method.Name}:\t Time:{timer.ElapsedTicks.ToString("N")}\t\t\tSorted: {copy.IsSorted()}"
                   /*+$"\tMemory: {GC.GetTotalMemory(true).ToString("N")} bytes\n"*/);

            timer.Reset();
        }
    }
}
