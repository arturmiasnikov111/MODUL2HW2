using System;

namespace module_2_homeTask2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var user = new User("Vova", "qwe@mail.com");
            var productProvider = new ProductsProvider();
            var products = productProvider.getProducts();
            var basket = Basket.Instance;
            basket.Add(products[0]);
            basket.Add(products[1]);
            basket.Add(products[2]);
            basket.Add(products[3]);
            var order = new Order(user, basket);
            var notificationService = NotificationService.Instance;
            notificationService.notify(order);
            basket.Clear();
        }
    }
}