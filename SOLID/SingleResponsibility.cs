namespace SOLID
{
    /*
    
    Single Responsibility Principle (SRP)
    - A class should have only one reason to change.
    - Each class should focus on a single part of the functionality provided by the software.
    
    Benefits of SRP:
    - Improves code maintainability.
    - Enhances readability and understandability.
    - Facilitates easier testing and debugging.
    - Allows for more flexible and scalable code architecture.
    
    */

    // Example Without SRP
    class OrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            // Validate order
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            // Save to database
            SaveOrder(order);

            // Send confirmation email
            SendEmail(order.CustomerEmail, "Order Confirmation", "Your order has been processed.");
        }

        private void SaveOrder(Order order)
        {
            // Code to save order to the database
        }

        private void SendEmail(string to, string subject, string body)
        {
            // Code to send email
        }
    }

    // Example With SRP

    // Handles order validation and processing
    class OrderHandler
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IEmailService _emailService;

        public OrderHandler(IOrderRepository orderRepository, IEmailService emailService)
        {
            _orderRepository = orderRepository;
            _emailService = emailService;
        }

        public void Process(Order order)
        {
            Validate(order);
            _orderRepository.Save(order);
            _emailService.Send(order.CustomerEmail, "Order Confirmation", "Your order has been processed.");
        }

        private void Validate(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));
            // Additional validation logic
        }
    }

    // Handles data access for orders
    public interface IOrderRepository
    {
        void Save(Order order);
    }

    public class OrderRepository : IOrderRepository
    {
        public void Save(Order order)
        {
            // Code to save order to the database
        }
    }

    // Handles email operations
    public interface IEmailService
    {
        void Send(string to, string subject, string body);
    }

    public class EmailService : IEmailService
    {
        public void Send(string to, string subject, string body)
        {
            // Code to send email
        }
    }

    // Order entity
    public class Order
    {
        public string CustomerEmail { get; set; }
        // Additional order properties
    }
}
