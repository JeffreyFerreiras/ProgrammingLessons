using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Enumerables
{
    class EnumerableMethods
    {
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

            Joining();     
        }

        public void Intersecting()
        {
            var collection3 = collection.Intersect(collection2).ToList();
        }
        public void Joining()
        {
            var collection3 = collection
                .Join(collection2,
                outer => outer,
                inner => inner,
                (inner, outer) => inner).ToList();
        }
    }
}
