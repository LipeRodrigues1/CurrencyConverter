using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CurrencyConverter.Entities
{
    internal class Converter(string name, double value)
    {
        public string Name { get; set; } = name;
        public double Value { get; set; } = value;
    


    public double CoinConveter(string name, double value)
        {
            if (name == "EU")
            {
                return value * 5.54;
            }
            if(name == "USD")
            {
                return value * 6.49;
            }
            return 0;
        }

    }
}
