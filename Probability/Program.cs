using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probability
{
    class Program
    {
        public delegate double Probability();

        static void Main(string[] args)
        {
            Print();
        }

        static void Print()
        {
            var deck = new CardDeck();
            foreach (var method in typeof(CardDeck).GetMethods())
            {
                Console.WriteLine($"{method.Name}: \t\t\t{method.Invoke(deck, null)}");
            }
        }
    }
}
