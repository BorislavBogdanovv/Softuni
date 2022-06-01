using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numChicken = int.Parse(Console.ReadLine());
            int numFish = int.Parse(Console.ReadLine());
            int numVege = int.Parse(Console.ReadLine());

            double chickenPrice = numChicken * 10.35;
            double fishPrice = numFish * 12.4;
            double vegePrice = numVege * 8.15;

            double totalPrice = chickenPrice + fishPrice + vegePrice;
            double dessertPrice = totalPrice * 0.2;

            double delPrice = 2.5;

            double finalPrice = totalPrice + dessertPrice + delPrice;

            Console.WriteLine(finalPrice);
        }
    }
}
