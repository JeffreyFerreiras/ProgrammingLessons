using System;
using System.Linq;

namespace ProgrammingLessons
{
    internal interface IProgram
    { }

    internal class Program : IProgram
    {
        private enum weekdays : byte
        { monday, tuesday, wednesday, thursday, friday, saturday, sunday }

        private static void Main(string[] args)
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

            Console.WriteLine(sizeof(weekdays));
            Console.ReadKey();
        }
    }
}