namespace ProgrammingLessons
{
    class Program
    {
        class Product
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public string Description { get; set; }
        }

        class Order
        {
            public int ID { get; set; }
            public int ProductID { get; set; }

            public DateTime DeliveryDate { get; set; }
        }
        
        private static void Main(string[] args)
        {
        }
    }
}