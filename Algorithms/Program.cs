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
            
            // Add call to test topological sort
            PrintGraphSortStats();

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
        
        private static void PrintGraphSortStats()
        {
            Console.WriteLine("\n--- Topological Sort Examples ---");
            
            // Example 1: Linear graph (A → B → C → D)
            Console.WriteLine("\nExample 1: Linear graph (A → B → C → D)");
            var graph1 = new Dictionary<string, List<string>>
            {
                { "A", new List<string> { "B" } },
                { "B", new List<string> { "C" } },
                { "C", new List<string> { "D" } },
                { "D", new List<string>() }
            };
            
            timer.Start();
            var result1 = TopologicalSort.KahnSort(graph1);
            timer.Stop();
            
            Console.WriteLine($"Time: {timer.ElapsedTicks} ticks");
            Console.WriteLine($"Result: {string.Join(" -> ", result1)}");
            Console.WriteLine($"Valid: {result1.Count == graph1.Count}");
            timer.Reset();
            
            // Example 2: Course prerequisites (LeetCode style)
            // Example: Course 0 requires courses 1 and 2, Course 3 requires courses 1 and 4, etc.
            Console.WriteLine("\nExample 2: Course prerequisites graph");
            var graph2 = new Dictionary<int, List<int>>
            {
                { 0, new List<int>() },
                { 1, new List<int> { 0 } },
                { 2, new List<int> { 0 } },
                { 3, new List<int> { 1, 2 } },
                { 4, new List<int> { 3 } },
                { 5, new List<int> { 3 } }
            };
            
            timer.Start();
            var result2 = TopologicalSort.KahnSort(graph2);
            timer.Stop();
            
            Console.WriteLine($"Time: {timer.ElapsedTicks} ticks");
            Console.WriteLine($"Order to take courses: {string.Join(" -> ", result2)}");
            Console.WriteLine($"Valid: {result2.Length == graph2.Count}");
            timer.Reset();
            
            // Example 3: Graph with a cycle (should detect and return empty list)
            Console.WriteLine("\nExample 3: Graph with a cycle (should detect and return empty list)");
            var graph3 = new Dictionary<char, List<char>>
            {
                { 'A', new List<char> { 'B' } },
                { 'B', new List<char> { 'C' } },
                { 'C', new List<char> { 'A' } } // Creates a cycle A → B → C → A
            };
            
            timer.Start();
            var result3 = TopologicalSort.KahnSort(graph3);
            timer.Stop();
            
            Console.WriteLine($"Time: {timer.ElapsedTicks} ticks");
            Console.WriteLine($"Result: {(result3.Count == 0 ? "Cycle detected!" : string.Join(" -> ", result3))}");
            Console.WriteLine($"Valid: {result3.Count == 0}"); // Should be empty due to cycle
            timer.Reset();
        }
    }
}
