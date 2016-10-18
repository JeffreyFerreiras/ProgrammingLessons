using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class PizzaMaker
    {
        static void Start(string[] args)
        {
            IPizza pizza = new PepperoniDecorator(new MozzarellaDecorator(new PlainPizza()));
            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine(pizza.GetCost());
            Console.ReadLine();
        }
    }
}
