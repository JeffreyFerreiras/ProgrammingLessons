using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Enumerables
{
    /****************************************
     * System.Collections.Generic Namespace *
     ****************************************/

    /* The System.Collections.Generic namespace contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections. */

    /* --- Behavior Classes/Interfaces --- */
    // private ICollection<T>
    //            Add()
    //private

    //    Clear()
    //private

    //    Contains()
    //private

    //    Remove()
    //private

    //    GetEnumerator()
    //private

    //    CopyTo(T[] array, int index)

    /* --- Data Structures Classes --- */

    internal class AllCollections<T, TKey, TValue>
    {
        KeyValuePair<TKey, TValue> keyvaluepair;
        Dictionary<TKey, TValue> dictionary;
        SortedDictionary<TKey, TValue> sortedDictionary;
        HashSet<T> hashSet;
        SortedSet<T> sortedSet;
        LinkedList<T> linkedList;
        List<T> list;
        Stack<T> stack;
        Queue<T> queue;
    }
}
