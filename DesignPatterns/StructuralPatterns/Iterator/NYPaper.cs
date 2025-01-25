namespace DesignPatterns.StructuralPatterns.Iterator
{
    class NYPaper : INewsPaper
    {
        private string[] _reporters = new [] { "Fred Bacon",
        "Lenny Bargain",
        "Mr. Harrison",
        "Ford Fungus",
        "Jameson Neat",
        "Latosha Hellbringer"};
        public IIterator CreateIterator()
        {
            return new NYPaperIterator(_reporters);
        }
    }
}
