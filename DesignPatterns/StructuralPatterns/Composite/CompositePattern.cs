namespace DesignPatterns.StructuralPatterns.CompositePattern
{
    class MainApp
    {
        void AppStart()
        {
            var root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            var comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf
            var leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree
            root.Display(1);
            root.Display(2);


            // Wait for user
            Console.ReadKey();
        }
    }
    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
    internal class Composite : Component
    {
        private List<Component>_children = new List<Component>();

        public Composite(string name) : base (name)
        {
            this.name = name;
        }

        public override void Add(Component c)
        {
            _children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine("-{0} {1}", depth, name);

            //Recursively display nodes
            foreach(Component component in _children)
                component.Display(depth + 2);
        }

        public override void Remove(Component c)
        {
            _children.Remove(c);
        }
    }
    internal class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
            this.name = name;
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine("-{0} {1}", depth, name);
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }
    }
}