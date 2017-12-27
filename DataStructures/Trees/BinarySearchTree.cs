using System;

namespace DataStructures.Trees
{
    public class BinarySearchTree
    {
        private int _count;
        private Node _root;

        public int Count { get => _count; private set => _count = value; }

        public Node Root { get => _root; private set => _root = value; }

        public void Add(int value)
        {
            if(_root == null)
            {
                _root = new Node(value);
            }
            else
            {
                _root.Add(value);
            }

            _count++;
        }

        public Node Find(int value)
        {
            if(_root != null)
            {
                return _root.Find(value);
            }

            return null;
        }

        public void Clear()
        {
            _root = null;
        }

        public bool Contains(int value)
        {
            Node node = _root?.Find(value);

            return node != null;
        }

        public void Delete(int value)
        {
            Node node = _root.Find(value);

            if(node != null)
            {
                node.IsDeleted = true;
            }
        }

        public int Min()
        {
            if(_root == null)
                throw new InvalidOperationException("Tree not initialized");

            return _root.Min().Value;
        }

        public int Max()
        {
            if(_root == null)
                throw new InvalidOperationException("Tree not initialized");

            return _root.Max().Value;
        }

        public void Remove(int value)
        {
            Node parent = _root;
            Node current = _root;
            bool isLeftChild = false;

            while(current != null && current.Value != value)
            {
                parent = current;

                if(current.Value < value)
                {
                    current = current.RightChild;
                    isLeftChild = false;
                }
                else
                {
                    current = current.LeftChild;
                    isLeftChild = true;
                }
            }

            if(current == null) return;

            if(current.IsLeafNode)
            {
                if(current == _root)
                    _root = null;
                else
                {
                    if(isLeftChild)
                        parent.LeftChild = null;
                    else
                        parent.RightChild = null;
                }
            }
            else if(current.RightChild == null)
            {
                if(current == _root)
                    _root = current.LeftChild;
                else if(isLeftChild)
                    parent.LeftChild = current.LeftChild;
                else
                    parent.RightChild = current.LeftChild;
            }
            else if(current.LeftChild == null)
            {
                if(current == _root)
                    _root = current.RightChild;
                else if(isLeftChild)
                    parent.LeftChild = current.RightChild;
                else
                    parent.RightChild = current.RightChild;
            }
            else
            {
                Node successor = GetSuccessor(current);

                if(current == _root)
                    _root = successor;
                if(isLeftChild)
                    parent.LeftChild = successor;
                else
                    parent.RightChild = successor;

                successor.LeftChild = current.LeftChild;
            }
        }

        private Node GetSuccessor(Node node)
        {
            Node current = node.RightChild;
            Node successor = node;
            Node parentOfSuccessor = node;

            while(current!=null)
            {
                parentOfSuccessor = successor;
                successor = current;
                current = current.LeftChild;
            }

            if(successor != node.RightChild)
            {
                parentOfSuccessor.LeftChild = successor.RightChild;
                successor.RightChild = node.RightChild;
            }

            return successor;
        }
    }
}