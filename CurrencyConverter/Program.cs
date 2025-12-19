using CurrencyConverter.Entities;
using System.Globalization;

Console.WriteLine("What currency do you want to convert to?");
string coin = Console.ReadLine();

Console.WriteLine("How much do you want to convert?");
double value = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

Converter converter = new Converter(coin, value);

double result = converter.CoinConveter(coin, value);
Console.WriteLine(result);
