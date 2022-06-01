using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double bags = 0.4;

            double nylonPrice = (nylon + 2) * 1.5;
            double paintPrice = (paint + paint * 0.1) * 14.5;
            double thinnerPrice = thinner * 5;
            double price = nylonPrice + paintPrice + thinnerPrice + bags;
            double workPrice = (price * 0.3) * hours;
            double finalPrice = price + workPrice;

            Console.WriteLine(finalPrice);

        }
    }
}
