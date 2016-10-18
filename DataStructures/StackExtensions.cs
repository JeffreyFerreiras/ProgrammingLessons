using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public static class StackExtensions
    {
        public static Stack<T> ReverseStack<T>(this Stack<T> stack)
        {
            var tempStack = new Stack<T>();
            while(stack.Count > 0)
            {
                tempStack.Push(stack.Pop());
            }
            return tempStack;
        }

        private static void Reverse<T>(Stack<T> stack)
        {
            if(stack.Count > 0)
            {
                var temp = stack.Pop();
                ReverseStack(stack);
                BottomInsert(stack, temp);
            }
        }
        private static void BottomInsert<T>(Stack<T> stack, T item)
        {
            if(stack.Count == 0)
            {
                stack.Push(item);
            }
            else
            {
                var temp = stack.Pop();
                BottomInsert(stack, item);
                stack.Push(temp);
            }
        }
    }
}
