namespace DataStructures.Hash
{
    public class CustomHashTable<Key, Value>
    {
        public int Count
        {
            get { return Count; }
            private set { Count = value; }
        }

        //Array of linked lists
        private readonly LinkedList<KeyValuePair<Key, Value>>[] items;

        public CustomHashTable(int size)
        {
            Count = size;

            items = new LinkedList<KeyValuePair<Key, Value>>[size];
        }

        public Value FindByKey(Key key)
        {
            int position = GetItemIndex(key);
            var list = GetList(position);

            foreach(var pair in list)
            {
                if(key.Equals(pair.Key))
                    return pair.Value;
            }

            return default(Value);
        }

        public void Add(Key key, Value value)
        {
            int position = GetItemIndex(key);

            LinkedList<KeyValuePair<Key, Value>> list = GetList(position);
            var item = new KeyValuePair<Key, Value>(key, value);

            list.AddFirst(item);
        }

        public void Remove(Key key)
        {
            int position = GetItemIndex(key);
            LinkedList<KeyValuePair<Key, Value>> list = GetList(position);

            foreach(var pair in list)
            {
                if(pair.Key.Equals(key))
                {
                    items[position] = default(LinkedList<KeyValuePair<Key, Value>>);
                }
            }
        }

        private int GetItemIndex(Key Key)
        {
            int position = Key.GetHashCode() % Count;

            return Math.Abs(position);
        }

        private LinkedList<KeyValuePair<Key, Value>> GetList(int index)
        {
            var list = items[index];

            if(list == null)
            {
                list = new LinkedList<KeyValuePair<Key, Value>>();

                items[index] = list;
            }

            return list;
        }
    }
}