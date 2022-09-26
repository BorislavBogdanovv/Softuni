using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;

            if (type == "Roses")
            {
                price = quantity * 5;

                if (quantity > 80)
                {
                    price = price * 0.9;
                }
            }
            else if (type == "Dahlias")
            {
                price = quantity * 3.8;

                if (quantity > 90)
                {
                    price = price * 0.85;
                }
            }
            else if (type == "Tulips")
            {
                price = quantity * 2.8;

                if (quantity > 80)
                {
                    price = price * 0.85;
                }
            }
            else if (type == "Narcissus")
            {
                price = quantity * 3;

                if (quantity < 120)
                {
                    price = price * 1.15;
                }
            }
            else if (type == "Gladiolus")
            {
                price = quantity * 2.5;

                if (quantity < 80)
                {
                    price = price * 1.2;
                }
            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {type} and {budget - price:f2} leva left.");
            }
            else if (budget < price)
            {
                Console.WriteLine($"Not enough money, you need {(budget - price)*-1:f2} leva more.");
            }
        }
    }
}
