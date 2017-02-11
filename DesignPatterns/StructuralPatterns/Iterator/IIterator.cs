using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
