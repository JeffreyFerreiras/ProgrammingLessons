using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList
    {
        static void ExampleLinkedList()
        {
            //.NET has a default linked list class which takes generics.
            LinkedList<string> linked = new LinkedList<string>();
            
            linked.AddLast("cat");
            linked.AddLast("dog");
            linked.AddLast("man");
            linked.AddFirst("first");
            
            foreach(var item in linked)
            {
                Console.WriteLine(item);
            }
        }
        static void Example2()
        {
            
            LinkedList<string> linked = new LinkedList<string>();
            
            linked.AddLast("one");
            linked.AddLast("two");
            linked.AddLast("three");
          
            LinkedListNode<string> node = linked.Find("one");
            linked.AddAfter(node, "inserted");
            
            foreach(var value in linked)
            {
                Console.WriteLine(value);
            }
        }
    }
}
