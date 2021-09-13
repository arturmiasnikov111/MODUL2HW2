using System;
namespace module_2_homeTask2
{
    public class EmailNotifier
    {
        public EmailNotifier()
        {
        }

        public void Notify(Order order)
        {
            var message = $"Your order number: {order.Id}. Order information: {order.ToString()}";
            Console.WriteLine($"Email has been sent. Message: {message}");
        }
    }
}
