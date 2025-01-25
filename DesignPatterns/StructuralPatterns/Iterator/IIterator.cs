namespace DesignPatterns.StructuralPatterns.Iterator
{
    interface IIterator
    {
        void First();
        string Next();
        bool IsDone();
        string CurrentItem();
    }
}
