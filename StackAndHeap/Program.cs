using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndHeap
{
    class Program
    {
        //Testing mutability with strings...
        class Mutable
        {
            public string mutableString;
        }


        public static void Main(string[] args)
        {
            string abc = "abc";

            Change(abc);

            string cba = abc;

            if(cba == abc)
            {
                Console.Write("yeah immutable...");
            }

            var ref1  = new Program.Mutable();
            ref1.mutableString = "Hello there";


            var ref2 = ref1;
            ref2.mutableString = "Changed!";

            Console.WriteLine(ref1.mutableString);

            Console.ReadLine();
        }

        private static void Change(string abc)
        {
            abc = "cba";

        }
    }
}
