using System;

namespace DataStructures.Trees
{
    public class MaxBinaryHeap : AbstractHeap
    {
        public override int Poll()
        {
            throw new NotImplementedException();
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

            while(HasParent(index) && Parent(index) < _items[index])
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
                int biggerChildIndex = GetBiggerChildIndex(index);

                if(_items[index] > _items[biggerChildIndex])
                {
                    break;
                }
                else
                {
                    Swap(index, biggerChildIndex);
                    index = biggerChildIndex;
                }
            }
        }

        protected int GetBiggerChildIndex(int index)
        {
            if(HasRightChild(index) && RightChild(index) > LeftChild(index))
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