using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public abstract class AbstractHeap
    {
        protected static int _capacity = 10;
        protected int[] _items = new int[_capacity];

        public int Count { get; protected set; }
        public abstract bool IsBalanced { get; }
        public int Peek()
        {
            if(0 == Count)
            {
                throw new InvalidOperationException("Heap not initialized");
            }

            return _items[0];
        }

        public abstract int Poll();
        public abstract void Add(int item);
        public abstract void Remove(int item);
        
        protected abstract void HeapifyUp();
        protected abstract void HeapifyDown();

        protected int GetLeftChildIndex(int parentIndex)    => 2 * parentIndex + 1;
        protected int GetRightChildIndex(int parentIndex)   => 2 * parentIndex + 2;
        protected int GetParentIndex(int index)             => (index - 1) / 2;

        protected bool HasRightChild(int index)             => GetRightChildIndex(index) < Count;
        protected bool HasLeftChild(int index)              => GetLeftChildIndex(index) < Count;
        protected bool HasParent(int index)                 => GetParentIndex(index) >= 0;

        protected int LeftChild(int index)                  => _items[GetLeftChildIndex(index)];
        protected int RightChild(int index)                 => _items[GetRightChildIndex(index)];
        protected int Parent(int index)                     => _items[GetParentIndex(index)];

        protected void Swap(int left, int right)
        {
            _items[left] =  _items[left] ^ _items[right];
            _items[right] = _items[left] ^ _items[right];
            _items[left] =  _items[left] ^ _items[right];
        }

        protected void EnsureExtraCapacity()
        {
            if(Count == _capacity)
            {
                _capacity *= 2;

                var temp = new int[_capacity];

                _items.CopyTo(temp, 0);
                _items = temp;
            }
        }
    }
}
