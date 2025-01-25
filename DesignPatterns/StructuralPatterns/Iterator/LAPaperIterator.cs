namespace DesignPatterns.StructuralPatterns.Iterator
{
    class LAPaperIterator : IIterator
    {
        private IList<string> _reporters;
        private int _current;
        public LAPaperIterator(IList<string> _reporters)
        {
            this._reporters = _reporters;
        }

        public string CurrentItem()
        {
            return _reporters.ElementAt(_current);
        }

        public void First()
        {
            _current = 0;
        }

        public bool IsDone()
        {
            return _current >= _reporters.Count;
        }

        public string Next()
        {
            return _reporters.ElementAt(_current++);
        }
    }
}
