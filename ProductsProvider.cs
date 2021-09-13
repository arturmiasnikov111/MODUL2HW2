using System;
using System.Collections.Generic;
namespace module_2_homeTask2
{
    public class ProductsProvider
    {
        public ProductsProvider()
        {
        }

        public List<Product> getProducts()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product()
            { Id = Guid.NewGuid(), Name = "Table", Price = 50, IsAvailable = true, Currency = CurrencyEnum.UAH });
            productList.Add(new Product()
            { Id = Guid.NewGuid(), Name = "Chair", Price = 20.5, IsAvailable = true, Currency = CurrencyEnum.USD });
            productList.Add(new Product()
            { Id = Guid.NewGuid(), Name = "Milk", Price = 31.4, IsAvailable = false, Currency = CurrencyEnum.USD });
            productList.Add(new Product()
            { Id = Guid.NewGuid(), Name = "Dog", Price = 211, IsAvailable = true, Currency = CurrencyEnum.USD });
            productList.Add(new Product()
            { Id = Guid.NewGuid(), Name = "Cat", Price = 45.3, IsAvailable = false, Currency = CurrencyEnum.USD });
            productList.Add(new Product()
            { Id = Guid.NewGuid(), Name = "Watch", Price = 211.9, IsAvailable = true, Currency = CurrencyEnum.UAH });
            productList.Add(new Product()
            { Id = Guid.NewGuid(), Name = "Beer", Price = 22.23, IsAvailable = true, Currency = CurrencyEnum.UAH });

            return productList;
        }
    }
}
