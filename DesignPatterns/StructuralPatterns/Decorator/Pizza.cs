namespace DesignPatterns.Decorator
{
    class PlainPizza : IPizza
    {
        public double GetCost()
        {
            return 10.00;
        }

        public string GetDescription()
        {
            return "thin dough";
        }
    }
}
