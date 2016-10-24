using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder
{
    /*
     * 
     */
    class MainApp
    {
        public static void AppStart()
        {
            Director director = new Director();

            Builder builder1 = new ConcreteBuilder1();
            Builder builder2 = new ConcreteBuilder2();

            // Construct 2 products
            director.Construct(builder1);
            Product product1 = builder1.GetResult();
            product1.Show();

            director.Construct(builder2);
            Product product2 = builder2.GetResult();
            product2.Show();
        }
    }

    internal class ConcreteBuilder1 : Builder
    {
        private Product _product = new Product();

        public ConcreteBuilder1()
        {
        }
        public override void BuildPartA()
        {
            _product.Add("Part A");
        }
        public override void BuildPartB()
        {
            _product.Add("Part B");
        }
        internal override Product GetResult()
        {
            return _product;
        }
    }

    internal class ConcreteBuilder2 : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("PartX");
        }

        public override void BuildPartB()
        {
            _product.Add("PartY");
        }

        internal override Product GetResult()
        {
            return _product;
        }
    }

    internal abstract class Builder
    {
        internal abstract Product GetResult();

        public abstract void BuildPartA();

        public abstract void BuildPartB();
    }

    internal class Director
    {
        public Director()
        {
        }

        internal void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach(string part in _parts)
                Console.WriteLine(part);
        }
    }
}
