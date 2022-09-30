using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int i = n; i > 0; i--)
            {
                double priceCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int cntCapsules = int.Parse(Console.ReadLine());

                double coffeePrice = ((days * cntCapsules) * priceCapsule);
                totalPrice += coffeePrice;

                Console.WriteLine($"The price for the coffee is: ${coffeePrice:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
