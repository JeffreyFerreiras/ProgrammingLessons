namespace DesignPatterns.StructuralPatterns.Composite
{
    class CompositePatternPractice
    {
        void AppStart()
        {
            var composite = new Composite("Root structure");
            composite.Add(new Leaf("leaf 1"));
            composite.Add(new Leaf("leaf 2"));

            var composite2 = new Composite("Composite structure");
            composite2.Add(new Leaf("leaf 3"));
            composite2.Add(new Leaf("leaf 4"));

            composite.Add(composite2);
            composite.Display();
        }
    }

    abstract class Component
    {
        public string Name { get; protected set; }
        public Component(string name)
        {
            Name = name;
        }
        
        public abstract void Add(Component component);
        public abstract Component Get();
        public abstract void Display();
    }

    class Composite : Component
    {
        private List<Component> _components = new List<Component>();

        public Composite(string name) : base(name)
        {
            Name = name;
        }

        public override void Add(Component component)
        {
            _components.Add(component);
        }

        public override void Display()
        {
            foreach(var c in _components)
            {
                Console.WriteLine(c.Name);
            }
        }

        public override Component Get()
        {
            return this;
        }

        public void Remove(Component component)
        {
            _components.Remove(component);
        }

    }
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
            Name = name;
        }

        public override void Add(Component component)
        {
            Console.WriteLine("Cannot add items to a leaf");
        }

        public override void Display()
        {
            Console.WriteLine(Name);
        }

        public override Component Get()
        {
            return this;
        }
    }
}
