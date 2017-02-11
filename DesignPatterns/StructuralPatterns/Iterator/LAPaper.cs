using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Iterator
{
    class LAPaper : INewsPaper
    {
        private List<string> _reporters = new List<string> { "Fred Bacon",
        "Lenny Bargain",
        "Mr. Harrison",
        "Ford Fungus",
        "Jameson Neat",
        "Latosha Hellbringer"};

        public IIterator CreateIterator()
        {
            return new LAPaperIterator(_reporters);
        }
    }
}
