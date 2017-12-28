using System;

namespace DataStructures.Trees
{
    public class Node
    {
        private int _value;
        private bool _isDeleted;

        public int Value { get => _value; set => _value = value; }

        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public bool IsLeafNode
        {
            get
            {
                return this.LeftChild == null && this.RightChild == null;
            }
        }

        public bool IsDeleted { get => _isDeleted; internal set => _isDeleted = value; }

        internal Node(int value)
        {
            Value = value;
        }

        public Node AddSorted(int[] data, int low, int high)
        {
            if(low <= high)
            {
                int mid = (low + high) / 2;

                Node node = new Node(data[mid]);
                node.LeftChild = node.AddSorted(data, low, mid - 1);
                node.RightChild = node.AddSorted(data, mid + 1, high);

                return node;
            }

            return null;
        }

        internal void Add(int value)
        {
            if(_value <= value)
            {
                if(this.RightChild == null)
                    this.RightChild = new Node(value);
                else
                    this.RightChild.Add(value);
            }
            else
            {
                if(this.LeftChild == null)
                    this.LeftChild = new Node(value);
                else
                    this.LeftChild.Add(value);
            }
        }

        internal void Balance()
        {
            int leftHeight = this.LeftChild.Height();
            int rightHeight = this.RightChild.Height();
            int balance = leftHeight - rightHeight;

            if(balance <= -2)//right heavy
            {
                Rotate(this.RightChild);
            }
            else if(balance >= 2)
            {
                SwapValues(this, this.LeftChild);
            }
        }

        private void RotateRight()
        {
            SwapValues(this, this.RightChild);

            if(this.LeftChild == null)
            {
                this.LeftChild = this.RightChild.RightChild;
                this.RightChild.RightChild = null;
            }
        }

        internal void SwapValues(Node left, Node right)
        {
            int temp = left.Value;
            left.Value = right.Value;
            right.Value = temp;
        }

        internal Node Find(int value)
        {
            if(_value == value && !this.IsDeleted) return this;

            if(this.Value > value && this.LeftChild != null)
            {
                return this.LeftChild.Find(value);
            }

            if(this.Value < value && this.RightChild != null)
            {
                return this.RightChild.Find(value);
            }

            return null;
        }

        internal Node Min()
        {
            if(this.LeftChild == null)
            {
                return this;
            }

            return LeftChild.Min();
        }

        internal Node Max()
        {
            if(this.RightChild == null)
            {
                return this;
            }

            return RightChild.Max();
        }

        internal int Height()
        {
            if(this.IsLeafNode) return 1;

            int left = this.LeftChild != null ? this.LeftChild.Height() : 0;
            int right = this.RightChild != null ? this.RightChild.Height() : 0;

            return left > right ? left + 1 : right + 1;
        }

        internal int LeafCount()
        {
            if(this.IsLeafNode) return 1;

            int leftLeafCount = LeftChild != null ? LeftChild.LeafCount() : 0;
            int rightLeafCount = RightChild != null ? RightChild.LeafCount() : 0;

            return leftLeafCount + rightLeafCount;
        }

        internal void TraverseInOrder(Action<Node> action)
        {
            if(IsLeafNode)
            {
                action(this);
            }
            else
            {
                this.LeftChild?.TraverseInOrder(action);

                action(this);

                this.RightChild?.TraverseInOrder(action);
            }
        }

        internal void TraversePreOrder(Action<Node> action)
        {
            action(this);

            this.LeftChild?.TraversePreOrder(action);
            this.RightChild?.TraversePreOrder(action);
        }

        internal void TraversePostOrder(Action<Node> action)
        {
            this.LeftChild?.TraversePreOrder(action);
            this.RightChild?.TraversePreOrder(action);

            action(this);
        }
    }
}