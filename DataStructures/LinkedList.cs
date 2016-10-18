using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public static class LinkedList
    {
        /*
Linked list & Doubly Linked List.
What is it ?
A list where nodes are linked to the next node. A doubly linked list is where nodes are linked to both the previous and next node.

Why use it?
Allows for fast inserts and removes especially in the middle of a list(if node is known), but slower when searching. Use it when searching through a list will not be a priority. When adding nodes, a linked list does not make an entire copy of the array to insert a new item.

Linked list let you easily manipulate the order of items with methods like AddFirst(), AddAfter(), AddBefore(), AddLast(), Find(),  RemoveFirst(), RemoveLast() etc...

The "LinkedList" class in .NET is a doubly linked list.

Use this when order matters.

*/
        static void ExampleLinkedList()
        {

            LinkedList<string> linked = new LinkedList<string>();

            linked.AddLast("cat");
            linked.AddLast("dog");
            linked.AddLast("man");
            linked.AddFirst("first");

            var huh = linked.Aggregate((a,b) => a + b);

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

        public static void ReverseLinkedList(this LinkedList<string> linkedList)
        {
            LinkedListNode<string> current  = linkedList.First;
            
            while(current.Next != null)
            {
                LinkedListNode<string> next = current.Next;
                linkedList.Remove(next);
                linkedList.AddFirst(next.Value);
            }
        }
    }
}
