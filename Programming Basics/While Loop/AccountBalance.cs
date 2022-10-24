using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string sum = Console.ReadLine();

            double money = 0;

            while (sum != "NoMoreMoney")
            {
                double amount = double.Parse(sum);

                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                
                money += amount;

                Console.WriteLine($"Increase: {amount:f2}");

                sum = Console.ReadLine();
            }

            Console.WriteLine($"Total: {money:f2}");
        }
    }
}
