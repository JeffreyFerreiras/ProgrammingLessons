namespace DesignPatterns.StructuralPatterns.Iterator
{
    class Program
    {
        static void AppStart()
        {
            INewsPaper ny = new NYPaper();
            INewsPaper la = new LAPaper();

            IIterator nyIterator = ny.CreateIterator();
            IIterator laIterator = la.CreateIterator();

            Console.WriteLine("----- LA -----");
            PrintReporters(laIterator);
            Console.WriteLine("----- NY -----");
            PrintReporters(nyIterator);

        }

        static void PrintReporters(IIterator iterator)
        {
            iterator.First();
            while(!iterator.IsDone())
            {
                Console.WriteLine(iterator.CurrentItem());
            }
        }
    }
}
