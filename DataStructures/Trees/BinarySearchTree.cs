using System.Collections.Generic;

namespace DataStructures.Trees
{
    public class BinarySearchTree
    {
        private int _count;
        private Node<int> _root;

        public int Count { get => _count; private set => _count = value; }

        public Node<int> Root { get => _root; private set => _root = value; }

        public void Add(int value)
        {
            if(_root == null)
            {
                _root = new Node<int>(value);
            }

            InternalAdd(_root, value);

            _count++;
        }

        private void InternalAdd(Node<int> node, int value)
        {
            if(node == null)
            {
                node = new Node<int>(value);

                return;
            }

            if(node.Value > value)
            {
                InternalAdd(node.LeftChild, value);
            }
            else if(node.Value < value)
            {
                InternalAdd(node.RightChild, value);
            }
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(int value)
        {
            if(Root == null) return false;
            if(Root.Value == value) return true;

            return InternalContains(Root, value);
        }

        public bool InternalContains(Node<int> node, int value)
        {
            if(node == null) return false;
            if(node.Value == value) return true;

            if(node.Value > value)
            {
                return InternalContains(node.LeftChild, value);
            }

            return InternalContains(node.RightChild, value);
        }

        public bool Remove(int item)
        {
            throw new System.NotImplementedException();
        }
    }
}