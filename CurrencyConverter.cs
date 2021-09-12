using System;
namespace module_2_homeTask2
{
    public class CurrencyConverter
    {
        private Config _config = new Config();
        public CurrencyConverter()
        {
        }

        public double ToUsd(double value)
        {
            return Math.Round(value * _config.CurrencyConfig.Rate, 2);
        }

        public double ToUah(double value)
        {
            return Math.Round(value / _config.CurrencyConfig.Rate, 2);
        }

        public double Convert(double value, CurrencyEnum currency)
        {
            if (currency == CurrencyEnum.UAH)
            {
                return ToUah(value);
            }

            return ToUsd(value);
        }
    }
}
