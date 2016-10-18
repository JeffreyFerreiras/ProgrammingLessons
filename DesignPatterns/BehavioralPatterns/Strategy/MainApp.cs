using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Strategy
{
    class MainApp
    {
        static void StrategyPattern()
        {
            var studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            Console.ReadKey();
        }
    }
}


interface ISortStrategy
{
    void Sort(List<string> list);
}

class QuickSort : ISortStrategy
{
    public void Sort(List<string> list)
    {
        list.Sort(); // Default is Quicksort
        Console.WriteLine("QuickSorted list ");
    }
}

class ShellSort : ISortStrategy
{
    public void Sort(List<string> list)
    {
        //list.ShellSort(); not-implemented
        Console.WriteLine("ShellSorted list ");
    }
}

class MergeSort : ISortStrategy
{
    public void Sort(List<string> list)
    {
        //list.MergeSort(); not-implemented
        Console.WriteLine("MergeSorted list ");
    }
}

class SortedList
{
    private List<string> _list = new List<string>();
    private ISortStrategy _sortstrategy;

    public void SetSortStrategy(ISortStrategy sortstrategy)
    {
        this._sortstrategy = sortstrategy;
    }

    public void Add(string name)
    {
        _list.Add(name);
    }

    public void Sort()
    {
        _sortstrategy.Sort(_list);

        // Iterate over list and display results
        foreach(string name in _list)
        {
            Console.WriteLine(" " + name);
        }
        Console.WriteLine();
    }
}