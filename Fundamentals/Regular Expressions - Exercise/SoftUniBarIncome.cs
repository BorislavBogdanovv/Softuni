using System;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalIncome = 0;

            string pattern = @"^[^\%\|\$\.]*?\%(?<customer>[A-Z][a-z]+)\%[^\%\|\$\.]*?\<(?<product>\w+)\>[^\%\|\$\.]*?\|(?<count>\d+)\|[^\%\|\$\.]*?(?<price>\d+(\.\d+)?)\$[^\%\|\$\.]*?$";

            Regex regex= new Regex(pattern);

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(inputLine);

                if (match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double totalPrice = count * price;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
