using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    public class Contact
    {
        public int ID { get; set; }
        public string Description { get; set; }
    }

    public class Member
    {
        public int ID { get; set; }
        public string Description { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var operators = new Operators();
            operators.RunAllMethods();

            //int[] unordered = { 5, 9, 4, 2, 6, 4 };
            //int min=0, max=0;

            //for (int i = 0; i < unordered.Length; i++)
            //{
            //    if (min > unordered[i]) min = unordered[i];
            //    if (max < unordered[i]) max = unordered[i];
            //}      
        }
        
        //---------------------------------------------------
        private readonly static object _syncLock = new object();
        private readonly static Random _random = new Random();

        static int GetMyRandomNumber(HashSet<int> picked)
        {
            lock (_syncLock)
            {
                int rand = _random.Next(0, picked.Count);
                picked.Remove(rand);

                return rand;
            }
        }

        public static T GetInstance<T>(string type)
        {
            var asssembly = Assembly.GetExecutingAssembly();
            string fullTypeName = asssembly.GetTypes().FirstOrDefault(x => x.Name.Equals(type)).FullName;

            return (T)asssembly.CreateInstance(fullTypeName);
        }

        public void m()
        {
            //var delegates = new Delegates_Lesson();
            //var asynchroniousProgramming = new AsynchronousProgramming();
            //var operators = new Operators();
            //operators.BitWiseOperators();

            //CSharpEventSubscriber subscriber = new CSharpEventSubscriber();
            
            //subscriber.AppStart();
            //EnumClass.UseEnum();

            var item = GetInstance<Contact>(nameof(Contact));
            var items = new List<dynamic>();

            items.Add(item);

            Contact contact = items[0];

            Console.ReadLine();
        }
    }
}
