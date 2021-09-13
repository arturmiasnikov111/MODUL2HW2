using System;
using System.Collections.Generic;
using System.Text;

namespace module_2_homeTask2
{
    public class Basket
    {
        private List<Product> _productList = new List<Product>();
        private static readonly Basket _instance = new Basket();
        private Config _config = new Config();

        static Basket()
        {
        }

        private Basket()
        {
        }

        public static Basket Instance
        {
            get { return _instance; }
        }

        public List<Product> ProductList
        {
            get { return _productList; }
            set { }
        }

        public bool Add(Product product)
        {
            if (_config.BasketConfig.BasketSize > ProductList.Count)
            {
                if (product.IsAvailable)
                {
                    ProductList.Add(product);
                    if (_config.CurrencyConfig.CurrentCurrency != product.Currency)
                    {
                        var currencyConverter = new CurrencyConverter();
                        var newVal = currencyConverter.Convert(product.Price, _config.CurrencyConfig.CurrentCurrency);
                        product.Price = newVal;
                        product.Currency = _config.CurrencyConfig.CurrentCurrency;
                    }

                    return true;
                }

                Console.WriteLine($"Product{product.Name} is unavailable!");
                return false;
            }

            Console.WriteLine($"Basket size exceeded");
            return false;
        }

        public void Clear()
        {
            ProductList.Clear();
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder($"Size: {ProductList.Count} {Environment.NewLine}");
            ProductList.ForEach(product => { stringBuilder.Append(product.ToString()); });
            return stringBuilder.ToString();
        }
    }
}
