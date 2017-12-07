using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingLessons
{
    class Program
    {
        class Person 
        {
            public int ID { get; set; }
        }

        private static void Main(string[] args)
        {
            List<Person> peopleList1 = new List<Person>();
            peopleList1.Add(new Person() { ID = 1 });
            peopleList1.Add(new Person() { ID = 2 });
            peopleList1.Add(new Person() { ID = 3 });

            List<Person> peopleList2 = new List<Person>();
            peopleList2.Add(new Person() { ID = 1 });
            peopleList2.Add(new Person() { ID = 2 });
            peopleList2.Add(new Person() { ID = 3 });
            peopleList2.Add(new Person() { ID = 4 });
            peopleList2.Add(new Person() { ID = 5 });

            var comparer = Comparer<Person>.Create((x, y) => x.ID < y.ID ? 1 : x.ID == y.ID ? 0: -1);
            peopleList2.RemoveAll(x => peopleList1.Contains(x));
        }
    }
}