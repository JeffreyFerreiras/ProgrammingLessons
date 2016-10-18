using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DataStructures.Trees
{
    internal class BinarySearchTree<T>
    {
        public class NodeList<TNodeList> : Collection<Node<TNodeList>>
        {
            public NodeList() : base(){}
            public NodeList(int size)
            {
                for(int i = 0; i < size; i++)
                {
                    base.Items.Add(default(Node<TNodeList>));
                }
            }
        } 
        
        public int Count { get; private set; }
        public Node<T> Root { get; private set; }
        public List<Node<T>> Neighbors { get; private set; }

        public void Add(T value)
        {
            var node = new Node<T>(value);
            if(Root == null)
            {
                Root = node;
            }
            else
            {
                bool assigned = false;
                Add(Root, node, ref assigned);
            }
        }

        private void Add(Node<T> root, Node<T> value, ref bool assigned)
        {
            //if(assigned) return;

            //if(root.Left == null)
            //{
            //    root.Left = value;
            //    assigned = true;
            //    Count++;
            //    return;
            //}
            //else if(root.Right == null)
            //{
            //    root.Right = value;
            //    assigned = true;
            //    Count++;
            //    return;
            //}
            

            //if(root.Left.Left != null && root.Left.Right != null)
            //{
            //    Add(root.Right, value, ref assigned);
            //}
            //else
            //{
            //    Add(root.Left, value, ref assigned);
            //}
        }

        public void DisplayPreOrder(Node<T> root)
        {
            if(root == null) return;
            Console.WriteLine(root.Value);
            //DisplayPreOrder(root.Left);
            //DisplayPreOrder(root.Right);
        }

        public void DisplayInOrder(Node<T> root)
        {
            //if(root == null) return;
            //DisplayInOrder(root.Left);
            //Console.WriteLine(root.Value);
            //DisplayInOrder(root.Right);
        }

        public void DisplayPostOrder(Node<T> root)
        {
            //if(root == null) return;
            //DisplayPostOrder(root.Left);
            //DisplayPostOrder(root.Right);
            //Console.WriteLine(root.Value);
        }

        public void DisplayLevelOrder()
        {
            //Node<T> temp = null;
            //var queue = new System.Collections.Queue();

            //if(Root == null) return;
            //queue.Enqueue(Root);

            //while(queue.Count > 0)
            //{
            //    temp = queue.Dequeue() as Node<T>;
            //    Console.WriteLine(temp.Value);

            //    if(temp.Left != null)
            //        queue.Enqueue(temp.Left);
            //    if(temp.Right != null)
            //        queue.Enqueue(temp.Right);
            //}
            //queue.Clear();
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