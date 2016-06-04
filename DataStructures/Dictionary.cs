using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Dictionary
    {
        //Dictionaries have key value pairs.
        public Dictionary<string, ulong> GetPhoneBook()
        {
            Dictionary<string, ulong> phoneBook = new Dictionary<string, ulong>();
            phoneBook.Add("Alex", 9084459999);
            phoneBook["Jessica"] = 7325129874;
            return phoneBook;
        }
        public void DisplayDictionaryValue()
        {
            Dictionary<string, ulong> phoneBook = GetPhoneBook();
            if(phoneBook.ContainsKey("Alex"))
            {
                Console.WriteLine(phoneBook["Alex"]); 
            }
        }
        public void LoopThroughDictionary()
        {
            Dictionary<string, ulong> phoneBook = GetPhoneBook();
            foreach(KeyValuePair<string, ulong> pair in phoneBook)
            {
                Console.WriteLine(pair.Key, pair.Value);
            }
        }
    }
}
