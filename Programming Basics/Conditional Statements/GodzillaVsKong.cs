using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extra = int.Parse(Console.ReadLine());
            double priceExCloth = double.Parse(Console.ReadLine());

            double priceDecor = budget * 0.1;
            double totalPriceExCloth = extra * priceExCloth;

            if (extra > 150)
            {
                totalPriceExCloth = totalPriceExCloth * 0.9;
            }

            double priceFilm = priceDecor + totalPriceExCloth;
            double restMoney = budget - priceFilm;

            if (priceDecor + totalPriceExCloth <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {restMoney:f2} leva left.");
            }

            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(restMoney):f2} leva more.");
            }


        }
    }
}
