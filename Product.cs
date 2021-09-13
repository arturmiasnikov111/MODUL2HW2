using System;

namespace module_2_homeTask2
{
    public class Product
    {
        public Product()
        {
        }

        public string Name { get; set; }
        public Guid Id { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public CurrencyEnum Currency { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} {Environment.NewLine}" +
                $"Price {Price} {Environment.NewLine}" +
                $"Currency {Currency} {Environment.NewLine}" +
                $"------------------------------------------ {Environment.NewLine}";
        }
    }
}
