using System;
namespace module_2_homeTask2
{
    public class CurrencyConfig
    {
        public CurrencyConfig()
        {
            CurrentCurrency = CurrencyEnum.UAH;
            Rate = 27d;
        }

        public CurrencyEnum CurrentCurrency { get; set; }
        public double Rate { get; set; }
    }
}