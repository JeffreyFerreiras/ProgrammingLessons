using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class MinBinaryHeap : AbstractHeap
    {
        
        public override int Poll()
        {
            if(0 == Count)
            {
                throw new InvalidOperationException("Heap not initialized");
            }

            int item = _items[0];
            _items[0]= _items[Count-1];

            Count--;

            HeapifyDown();

            return item;
        }

        public override void Add(int item)
        {
            EnsureExtraCapacity();

            _items[Count++] = item;

            HeapifyUp();
        }

        protected override void HeapifyUp()
        {
            int index = Count - 1;

            while(HasParent(index) && Parent(index) > _items[index])
            {
                Swap(GetParentIndex(index), index);

                index = GetParentIndex(index);
            }
        }

        protected override void HeapifyDown()
        {
            int index = 0;

            while(HasLeftChild(index))
            {
                int smallerChildIndex = GetSmallerChildIndex(index);

                if(_items[index] < _items[smallerChildIndex])
                {
                    break;
                }
                else
                {
                    Swap(index, smallerChildIndex);
                    index = smallerChildIndex;
                }
            }
        }

        private int GetSmallerChildIndex(int index)
        {
            if(HasRightChild(index) && RightChild(index) < LeftChild(index))
            {
                return GetRightChildIndex(index);
            }
            else
            {
                return GetLeftChildIndex(index);
            }
        }

        public override void Remove(int item)
        {
            throw new NotImplementedException();
        }
    }
}
