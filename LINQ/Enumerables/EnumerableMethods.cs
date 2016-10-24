using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Enumerables
{
    internal class EnumerableMethods
    {
        /***************
         * System.Linq *
         ***************/
        /* Provides Classes and interfaces supporting Language-Integrated Query (LINQ). */

        private List<int> collection = new List<int>();
        private List<int> collection2 = new List<int>();

        private Random random = new Random();

        public EnumerableMethods()
        {
            for(int i = 0; i < 100; i++)
            {
                int rand = random.Next(100);
                collection.Add(rand);

                rand = random.Next(100);
                collection2.Add(rand);
            }
        }
        public void Cast()
        {
            double[] doubles = new [] { 5.5, 6.6, 7.7};
            int[] ints = doubles.Cast<int>().ToArray();
        }

        public void Aggregate()
        {
            int num = 10;
            int factorial;

            factorial = Enumerable.Range(0, num).Aggregate((a, b) => a * b);
            factorial = Enumerable.Range(0, num).Aggregate(num / 2, (a, b) => a * b);
            factorial = Enumerable.Range(0, num).Aggregate(num / 2, (a, b) => a * b, a => a*15);
        }

        public void Intersecting()
        {
            var collection3 = collection.Intersect(collection2).ToList();
        }

        public void Join()
        {
            var collection3 = collection
                .Join(collection2,
                outer => outer,
                inner => inner,
                (inner, outer) => inner).ToList();
        }
    }
}

