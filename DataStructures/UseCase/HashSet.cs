using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class UsingHashSet
    {
        /*
        What is it?
        
        Like a Dictionary that stores hash values, a HashSet's key and value are the same thing.
            
        A list that will not retain duplicates and is made for extremely fast look ups as it only stores the hash value of objects. 
        A Hashset's "Contains()" method is nearly instant O(1). 
        It is an un-ordered collection containing unique elements. 
        It has the standard collection operations Add, Remove, Contains, but since it uses a hash-based implementation, these operation are O(1).

        Why use them?
        When look up speed is important but items don't have to be in order and when duplicates are not necessary.
        */
        
        public void HashSetOps()
        {
            // O(1)

            HashSet<int> intSet = new HashSet<int>();//ICollection<T>, IEnumerable<T>, IEnumerable, ISerializable, IDeserializationCallback, ISet<T>, IReadOnlyCollection<T>
            string value = "My name Jeeeffff";
            var key = value.GetHashCode();

            new Dictionary<int, string>() { { key, value} };
        }
    }
}
