using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    /*
    The capacity of a Stack is the number of elements the Stack can hold. As elements are added to a Stack, the capacity is automatically increased as required through reallocation.
If Count is less than the capacity of the stack, Push is an O(1) operation. If the capacity needs to be increased to accommodate the new element, Push becomes an O(n) operation, where n is Count. Pop is an O(1) operation.
Stack accepts null as a valid value and allows duplicate elements.
    */
    internal class Stack_Class
    {
        public Stack_Class()
        {
            // Creates and initializes a new Stack.
            
            var stackOfStrings = new Stack<string>();


            stackOfStrings.Push("Hello");
            stackOfStrings.Push("World");
            stackOfStrings.Push("!");

            var stackOfInts = new Stack<int>();
            stackOfInts.Push(1);
            stackOfInts.Push(2);
            stackOfInts.Push(3);
            
            var reversedintstack = stackOfInts.ReverseStack();
            var reversedstringstack = stackOfStrings.ReverseStack(); 
        }

        
    }
}