using Algorithms.Sorting;

namespace Algorithms
{
    class Program
    {
        private static readonly System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        delegate int[] Sort(int[] arry);

        static void Main(string[] args)
        {
            Common.PrintSwapEnabled = false;
            PrintSortStats(10000);
            // PrintSortStats(1000);
            // PrintSortStats(150);
            PrintSortStats(5);

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
            int[] arry = Common.GetRandomizedArray(len, 9);

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
            timer.Stop();

            string elapsedTime;
            if (timer.ElapsedMilliseconds > 0)
            {
                elapsedTime = $"{timer.ElapsedMilliseconds.ToString("N")} ms";
            }
            else
            {
                elapsedTime = $"{timer.ElapsedTicks.ToString("N")} ns";
            }

            Console.WriteLine(
                    $"{sort.Method.Name}:\t Time:{elapsedTime}\t\t\tSorted: {copy.IsSorted()}"
                   /*+$"\tMemory: {GC.GetTotalMemory(true).ToString("N")} bytes\n"*/);

            timer.Reset();
        }
    }
}
