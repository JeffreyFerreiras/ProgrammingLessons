using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWords
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeOfANDSizeOf typesizeof = new TypeOfANDSizeOf();
            typesizeof.TypeOf();
            typesizeof.SizeOf();         
            Console.ReadLine();
        }
    }
}
