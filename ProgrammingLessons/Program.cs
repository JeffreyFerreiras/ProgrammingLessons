using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLessons
{
    interface IProgram { }
    class Program:IProgram
    {
        enum weekdays : byte { monday, tuesday, wednesday, thursday, friday, saturday, sunday }
        static void Main(string[] args)
        {
            Console.WriteLine(weekdays.monday);
            Console.WriteLine(weekdays.tuesday);
            Console.WriteLine(weekdays.wednesday);
            Console.WriteLine(weekdays.thursday);
            Console.WriteLine(weekdays.friday);
            Console.WriteLine(weekdays.saturday);
            Console.WriteLine(weekdays.sunday);
            Console.WriteLine();

            typeof(object).GetMembers().ToList().ForEach(Console.WriteLine);
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

