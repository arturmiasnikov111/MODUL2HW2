using System;
using System.Text;
using System.Collections.Generic;

namespace module_2_homeTask2
{
    public class Order
    {
        private Guid _id;
        private List<Product> _productList;

        public Order(User user, Basket basket)
        {
            _id = Guid.NewGuid();
            User = user;
            _productList = basket.ProductList;
        }

        public Guid Id => _id;

        public User User { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder($"Size: {_productList.Count} {Environment.NewLine}");
            _productList.ForEach(product => { stringBuilder.Append(product.ToString()); });
            return stringBuilder.ToString();
        }
    }
}
