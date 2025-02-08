using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week_4._1
{
    internal class Program
    {
        public class CurrencyConverter
        {
            private static double usdToEurRate = 0.96;
            private static double usdToJpyRate = 152.20;
            private static double eurToJpyRate = 158.18;

            public static double ConvertToUSD(double amount, string fromCurrency)
            {
                switch (fromCurrency.ToUpper())
                {
                    case "EUR":
                        return amount / usdToEurRate;
                    case "JPY":
                        return amount / usdToJpyRate;
                    case "USD":
                        return amount;
                    default:
                        Console.WriteLine("Invalid currency.");
                        return 0;
                }
            }

            public static double ConvertToEUR(double amount, string fromCurrency)
            {
                switch (fromCurrency.ToUpper())
                {
                    case "USD":
                        return amount * usdToEurRate;
                    case "JPY":
                        return ConvertToUSD(amount, "JPY") * usdToEurRate;
                    case "EUR":
                        return amount;
                    default:
                        Console.WriteLine("Invalid currency.");
                        return 0;
                }
            }

            public static double ConvertToJPY(double amount, string fromCurrency)
            {
                switch (fromCurrency.ToUpper())
                {
                    case "USD":
                        return amount * usdToJpyRate;
                    case "EUR":
                        return amount * eurToJpyRate;
                    case "JPY":
                        return amount;
                    default:
                        Console.WriteLine("Invalid currency.");
                        return 0;
                }
            }

            public static void Main(string[] args)
            {
                Console.WriteLine("Enter the amount to convert:");
                double amount = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the currency to convert from (USD, EUR, JPY):");
                string fromCurrency = Console.ReadLine();

                Console.WriteLine("Enter the currency to convert to (USD, EUR, JPY):");
                string toCurrency = Console.ReadLine();

                double convertedAmount = 0;

                switch (toCurrency.ToUpper())
                {
                    case "USD":
                        convertedAmount = ConvertToUSD(amount, fromCurrency);
                        break;
                    case "EUR":
                        convertedAmount = ConvertToEUR(amount, fromCurrency);
                        break;
                    case "JPY":
                        convertedAmount = ConvertToJPY(amount, fromCurrency);
                        break;
                    default:
                        Console.WriteLine("Invalid currency.");
                        return;
                }

                Console.WriteLine($"{amount} {fromCurrency} is equal to {convertedAmount} {toCurrency}");
            }
        }
    }
}
