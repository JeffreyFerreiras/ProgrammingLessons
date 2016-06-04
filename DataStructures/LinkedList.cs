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
            //
            // Create a new linked list object instance.
            //
            LinkedList<string> linked = new LinkedList<string>();
            //
            // Use AddLast method to add elements at the end.
            // Use AddFirst method to add element at the start.
            //
            linked.AddLast("cat");
            linked.AddLast("dog");
            linked.AddLast("man");
            linked.AddFirst("first");
            //
            // Loop through the linked list with the foreach-loop.
            //
            foreach(var item in linked)
            {
                Console.WriteLine(item);
            }
        }
        static void Example2()
        {
            //
            // Create a new linked list.
            //
            LinkedList<string> linked = new LinkedList<string>();
            //
            // First add three elements to the linked list.
            //
            linked.AddLast("one");
            linked.AddLast("two");
            linked.AddLast("three");
            //
            // Insert a node before the second node (after the first node)
            //
          
            LinkedListNode<string> node = linked.Find("one");
            linked.AddAfter(node, "inserted");
            //
            // Loop through the linked list.
            //
            foreach(var value in linked)
            {
                Console.WriteLine(value);
            }
        }
    }
}
