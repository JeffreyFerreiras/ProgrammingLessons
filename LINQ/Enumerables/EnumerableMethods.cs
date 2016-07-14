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
        }

        public void Intersecting()
        {
            for(int i = 0; i < 101; i++)
            {
                int randomNumber = random.Next(100);
                collection.Add(randomNumber);
               
                int randomNumber2 = random.Next(100);
                collection2.Add(randomNumber2);
            }
            var collection3 = collection.Intersect(collection2).ToList();
        }
        public void Joining()
        {
            var collection3 = collection.Join(collection2, inner => inner, outer => outer, (inner, outer)=> new { age = inner, age2 = outer });
        }

    }
}
