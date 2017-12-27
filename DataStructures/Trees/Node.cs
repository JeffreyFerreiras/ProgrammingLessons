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
                if(this.LeftChild == null && this.RightChild == null)
                {
                    return true;
                }

                return false;
            }
        }

        public bool IsDeleted { get => _isDeleted; internal set => _isDeleted = value; }

        public Node(int value)
        {
            Value = value;
        }

        public void Add(int value)
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

        public Node Find(int value)
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

        public Node Min()
        {
            if(this.LeftChild == null)
            {
                return this;
            }

            return LeftChild.Min();
        }

        public Node Max()
        {
            if(this.RightChild == null)
            {
                return this;
            }

            return RightChild.Max();
        }
    }
}