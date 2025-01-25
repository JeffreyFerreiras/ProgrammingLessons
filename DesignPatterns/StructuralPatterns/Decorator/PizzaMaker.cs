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
