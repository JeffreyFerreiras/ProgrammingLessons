using System;
using DesignPatterns.Decorator;

namespace DesignPatterns.StructuralPatterns.Decorator
{
    internal class MainApp
    {
        /*The Decorator Pattern is used for adding additional functionality to a particular object as opposed to a class of objects. It is easy to add functionality to an entire class of objects by subclassing an object, but it is impossible to extend a single object this way. With the Decorator Pattern, you can add functionality to a single object and leave others like it unmodified.*/

        public void DecoratorPattern()
        {
            //DECORATOR USAGE
            IPizza plainPizza = new PlainPizza();
            IPizza mozzarella = new MozzarellaDecorator(plainPizza);
            IPizza pepperoni = new PepperoniDecorator(mozzarella);

            //Wrap the decorations around the original object.
            IPizza pizza =
                new PepperoniDecorator(
                    new MozzarellaDecorator(
                        new PlainPizza()));

            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine(pizza.GetCost());
            Console.ReadLine();

            //Real World Example below, because stream writers and readers
            //use decorator patterns internally.
            using(var reader = System.IO.File.OpenWrite("~/test.txt"))
            {
                using(var writer = new System.IO.StreamWriter(reader)) 
                {
                    //write something
                    writer.Write("Hello World!");
                }
            }
        }
    }
}