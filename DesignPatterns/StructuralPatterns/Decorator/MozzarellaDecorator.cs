using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class MozzarellaDecorator : ToppingDecorator
    {
        public MozzarellaDecorator(IPizza pizza) : base(pizza) { }
        
        public override string GetDescription()
        {
            return tempPizza.GetDescription() + ", Mozzarella";
        }

        public override double GetCost()
        {
            return tempPizza.GetCost() + 0.50;
        }
    }
}
