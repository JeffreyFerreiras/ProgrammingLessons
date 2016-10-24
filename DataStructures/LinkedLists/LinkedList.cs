using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedLists
{
    public class LinkedList<T> : IEnumerator<T>, IEnumerable<T>
    {
        public class Node<TNode>
        {
            public TNode Value;
            public Node<TNode> Next;
        }

        //private long count;

        public long Count { get; private set; }

        public Node<T> First { get; private set; }
        public Node<T> Last { get; private set; }

        public T Current
        {
            get
            {
                return Last.Value;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }

        public LinkedList()
        {
            Count = 0;
            First = null;
            Last = null;
        }

        public void AddLast(T value)
        {
            var node = new Node<T> { Value = value };
            AddLast(node);
        }

        public void AddLast(Node<T> node)
        {
            if(First == null)
                First = node;
            else
                Last.Next = node;

            Last = node;
            Count++;
        }

        public void AddFirst(T value)
        {
            var node = new Node<T> { Value = value };
            AddFirst(node);
        }

        public void AddFirst(Node<T> node)
        {
            if(First == null)
                First = node;
            else
            {
                node.Next = First;
                First = node;
            }
            Count++;
        }

        public Node<T> NodeAt(int index)
        {
            if(index < this.Count && index >= 0)
            {
                var node = First;
                int counter = 0;
                while(node.Next != null)
                {
                    if(counter == index)
                        return node;
                    node = node.Next;
                }
            }
            throw new IndexOutOfRangeException();
        }

        public bool DeleteAt(int index)
        {
            if(index == 0)
            {
                if(Count == 1)
                {
                    First = null;
                    Last = null;
                    return true;
                }
                First = First.Next;
                Count--;
                return true;
            }
            else if(index >= 0 && index < Count)
            {
                Node<T> current = First, previous = new Node<T>();
                int counter = 0;
                while(current != null)
                {
                    if(counter == index)
                    {
                        previous.Next = current.Next;
                        Count--;
                        return true;
                    }
                    counter++;
                    previous = current;
                    current = current.Next;
                }
            }
            return false;
        }

        public void Remove(Node<T> node)
        {
            if(First == node)
            {
                First = node.Next;
                node.Next = null;
                Count--;
            }
            else
            {
                Node<T> current = First;
                while(current != null)
                {
                    if(node == current.Next)
                    {
                        current.Next = node.Next;
                        node.Next = null;
                        Count--;
                        return;
                    }
                    current = current.Next;
                }
            }
        }

        public void Reverse()
        {
            var current = First;
            while(current.Next != null)
            {
                var next = current.Next;
                Remove(next);
                AddFirst(next);
            }
        }

        private IEnumerable<T> CreateEnumerable()
        {
            var current = First;
            while(current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return CreateEnumerable().GetEnumerator();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[long index]
        {
            get
            {
                if(index >= 0 && index < Count)
                {
                    var current = First;
                    for(int i = 0; i < index; i++)
                    {
                        current = current.Next;
                    }

                    return current.Value;
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if(index >= 0 && index < Count)
                    this[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }
    }
}