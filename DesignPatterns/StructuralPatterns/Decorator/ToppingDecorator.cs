namespace DesignPatterns.Decorator
{
    abstract class ToppingDecorator : IPizza
    {
        protected IPizza tempPizza;
        public ToppingDecorator(IPizza pizza)
        {
            tempPizza = pizza;
        }

        public abstract string GetDescription();
        public abstract double GetCost();
    }
}
