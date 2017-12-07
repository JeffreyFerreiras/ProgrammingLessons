using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DataStructures.Trees
{
    public class BinarySearchTree<T>
    {
        
        public int Count { get; private set; }
        public Node<T> Root { get; private set; }
        public List<Node<T>> Neighbors { get; private set; }

        public void Add(T value)
        {

            if(Root == null)
            {
                Root = node;
            }
            else
            {
                var current = Root;

                while(current != null)
                {
                    if(Root.)
                }
            }
        }
        
        private void InternalAdd(Node<T> value)
        {

        }
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public List<Node<T>> Children { get; set; }

        public Node(T value)
        {
            Value = value;
        }
        public Node(T value, Node<T> left, Node<T> right)
        {

            Children[0] = left;
            Children[1] = right;
        }
    }
}