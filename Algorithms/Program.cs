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

        static void Main(string[] args)
        {
            int [] unsortedArry = GetUnsortedArray().ToArray();

            var q = new int [unsortedArry.Length];
            for(int i = 0; i < unsortedArry.Length; i++)
                q[i] = unsortedArry[i];
            

            timer.Start();
            q = QuickSort.Sort(q);
            timer.Stop();
            
            timer.Reset();

            var m = new int [unsortedArry.Length];
            for(int i = 0; i < unsortedArry.Length; i++)
                m[i] = unsortedArry[i];
            
            timer.Start();
            m = MergeSort.Sort(m);
            timer.Stop();
        }
        static IEnumerable<int> GetUnsortedArray()
        {
            var random = new Random();

            for(int i = 0; i < 10000; i++)
            {
                yield return random.Next(0, 1000);
            }
        }
    }
}
