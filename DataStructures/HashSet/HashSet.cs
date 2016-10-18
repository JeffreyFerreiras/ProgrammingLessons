using System;
using System.Collections.Generic;

namespace DataStructures.HashSet
{
    public class CustomHashTable<K, V>
    {
        public int Count
        {
            get { return Count; }
            private set { Count = value; }
        }

        private readonly LinkedList<KeyValuePair<K, V>>[] items;

        public CustomHashTable(int size)
        {
            Count = size;
            items = new LinkedList<KeyValuePair<K, V>>[size];
        }

        public V FindByKey(K key)
        {
            int position = GetItemIndex(key);
            var list = GetList(position);

            foreach(var pair in list)
            {
                if(key.Equals(pair.Key))
                    return pair.Value;
            }

            return default(V);
        }

        public void Add(K key, V value)
        {
            int position = GetItemIndex(key);

            LinkedList<KeyValuePair<K,V>> list = GetList(position);
            var item = new KeyValuePair<K,V> (key, value);

            list.AddFirst(item);
        }

        public void Remove(K key)
        {
            int position = GetItemIndex(key);
            LinkedList<KeyValuePair <K, V>> list = GetList(position);

            foreach(var pair in list)
            {
                if(pair.Key.Equals(key))
                {
                    items[position] = default(LinkedList<KeyValuePair<K, V>>);
                }
            }
        }

        private int GetItemIndex(K Key)
        {
            int position = Key.GetHashCode() % Count;
            return Math.Abs(position);
        }

        private LinkedList<KeyValuePair<K, V>> GetList(int position)
        {
            var list = items[position];

            if(list == null)
            {
                list = new LinkedList<KeyValuePair<K, V>>();
                items[position] = list;
            }

            return list;
        }
    }
}