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
            // Exchange rates
            private static double usdToEurRate = 0.96;
            private static double usdToJpyRate = 152.20;
            private static double eurToJpyRate = 158.18;

            public static void Main(string[] args)
    {
        // Get input from the user
        Console.Write("Enter the amount to convert: ");
        double amount = double.Parse(Console.ReadLine());

        Console.Write("Enter the source currency (USD, EUR, JPY): ");
        string fromCurrency = Console.ReadLine().ToUpper();

        Console.Write("Enter the target currency (USD, EUR, JPY): ");
        string toCurrency = Console.ReadLine().ToUpper();

        // Perform conversion
        double convertedAmount = ConvertCurrency(amount, fromCurrency, toCurrency);

        // Display the result
        Console.WriteLine($"{amount} {fromCurrency} is equal to {convertedAmount} {toCurrency}");
    }

    // Method to convert currency
    public static double ConvertCurrency(double amount, string fromCurrency, string toCurrency)
    {
        double amountInUsd = 0;

        // Convert to USD first, if necessary
        switch (fromCurrency)
        {
            case "USD":
                amountInUsd = amount;
                break;
            case "EUR":
                amountInUsd = amount / UsdToEurRate;
                break;
            case "JPY":
                amountInUsd = amount / UsdToJpyRate;
                break;
            default:
                Console.WriteLine("Invalid source currency.");
                return 0;
        }

        // Convert from USD to the target currency
        switch (toCurrency)
        {
            case "USD":
                return amountInUsd;
            case "EUR":
                return amountInUsd * UsdToEurRate;
            case "JPY":
                return amountInUsd * UsdToJpyRate;
            default:
                Console.WriteLine("Invalid target currency.");
                return 0;
        }
    }
        }
    }
}
