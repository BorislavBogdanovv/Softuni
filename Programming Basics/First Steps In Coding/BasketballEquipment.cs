using System;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = double.Parse(Console.ReadLine());

            double shoesPrice = tax - tax * (40 / 100.0);
            double outfitPrice = shoesPrice - shoesPrice * (20 / 100.0);
            double ballPrice = outfitPrice / 4;
            double accesPrice = ballPrice / 5;

            double sum = tax + shoesPrice + outfitPrice + ballPrice + accesPrice;
            Console.WriteLine(sum);
        }
    }
}
