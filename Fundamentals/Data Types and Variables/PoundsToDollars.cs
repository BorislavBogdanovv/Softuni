using System;

namespace PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());

            double US = pounds * 1.31;

            Console.WriteLine($"{US:f3}");
        }
    }
}