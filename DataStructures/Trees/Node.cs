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

        private Node()
        {
        }

        internal Node(int value)
        {
            Value = value;
        }

        internal static Node Create(int[] data)
        {
            return new Node().AddSorted(data, 0, data.Length - 1);
        }

        internal Node AddSorted(int[] data, int low, int high)
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
            this.Add(new Node(value));
        }

        internal void Add(Node node)
        {
            if(node.Value > this.Value)
            {
                if(this.RightChild == null)
                    this.RightChild = node;
                else
                    this.RightChild.Add(node);
            }
            else if(node.Value < this.Value)
            {
                if(this.LeftChild == null)
                    this.LeftChild = node;
                else
                    this.LeftChild.Add(node);
            }

            Balance();
        }

        internal void Balance(int tension = 2)
        {
            int balance = GetBalance();

            if(balance <= -tension)
            {
                if(this.LeftChild == null)
                {
                    if(this.RightChild.LeftChild != null)
                    {
                        RotateRightLeft();
                    }
                    else if(this.RightChild.RightChild != null)
                    {
                        RotateRight();
                    }
                }
                else
                {
                    RotateRight();
                }
            }
            else if(balance >= tension)
            {
                if(this.RightChild == null)
                {
                    if(this.LeftChild.RightChild != null)
                    {
                        RotateLeftRight();
                    }
                    else if(this.LeftChild.LeftChild != null)
                    {
                        RotateLeft();
                    }
                }
                else
                {
                    RotateLeft();
                }
            }
        }

        internal int GetBalance()
        {
            int leftHeight = this.LeftChild?.Height() ?? 0;
            int rightHeight = this.RightChild?.Height() ?? 0;

            int balance = leftHeight - rightHeight;
            return balance;
        }

        private void RotateRight()
        {
            Node rightTemp = this.RightChild;

            SwapValues(this, rightTemp);

            this.RightChild = this.RightChild.RightChild;

            rightTemp.RightChild = rightTemp.LeftChild;
            rightTemp.LeftChild = this.LeftChild;

            this.LeftChild = rightTemp;
        }

        private void RotateLeft()
        {
            Node leftTemp = this.LeftChild;

            SwapValues(this, leftTemp);

            this.LeftChild = this.LeftChild.LeftChild;

            leftTemp.LeftChild = leftTemp.RightChild;
            leftTemp.RightChild = this.RightChild;

            this.RightChild = leftTemp;
        }

        private void RotateLeftRight()
        {
            SwapValues(this, this.LeftChild.RightChild);

            this.RightChild = this.LeftChild.RightChild;
            this.LeftChild.RightChild = null;
        }

        private void RotateRightLeft()
        {
            SwapValues(this, this.RightChild.LeftChild);

            this.LeftChild = this.RightChild.LeftChild;
            this.RightChild.LeftChild = null;
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

        internal int Height() //Note to self: Cannot memoize height because it's always changing...
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
            this.LeftChild?.TraverseInOrder(action);

            action(this);

            this.RightChild?.TraverseInOrder(action);
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