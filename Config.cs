using System;
namespace module_2_homeTask2
{
    public class Config
    {
        public Config()
        {
            BasketConfig = new BasketConfig();
            CurrencyConfig = new CurrencyConfig();
        }

        public CurrencyConfig CurrencyConfig { get; set; }
        public BasketConfig BasketConfig { get; set; }
    }
}
