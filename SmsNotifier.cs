using System;
namespace module_2_homeTask2
{
    public class SmsNotifier
    {
        public SmsNotifier()
        {
        }

        public void Notify(Order order)
        {
            var message = $"Your order number: {order.Id}. Order information: {order.ToString()}";
            Console.WriteLine($"Sms has been sent. Message: {message}");
        }
    }
}
