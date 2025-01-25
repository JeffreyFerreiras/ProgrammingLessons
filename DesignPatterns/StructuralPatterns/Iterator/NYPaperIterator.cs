namespace DesignPatterns.StructuralPatterns.Iterator
{
    class NYPaperIterator : IIterator
    {
        private string[] _reporters;
        private int _current;
        public NYPaperIterator(string[] _reporters)
        {
            this._reporters = _reporters;
        }

        public string CurrentItem()
        {
            return _reporters[_current];
        }

        public void First()
        {
            _current = 0;
        }

        public bool IsDone()
        {
            return _current >= _reporters.Length;
        }

        public string Next()
        {
            return _reporters[_current++];
        }
    }
}
