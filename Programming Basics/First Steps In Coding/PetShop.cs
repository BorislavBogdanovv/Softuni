using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDog = int.Parse(Console.ReadLine());
            int numCat = int.Parse(Console.ReadLine());

            double priceDog = numDog * 2.5;
            int priceCat = numCat * 4;

            double sum = priceDog + priceCat;

            Console.WriteLine($"{sum} lv.");
        }
    }
}
