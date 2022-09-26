using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string posOrNegative = Console.ReadLine();
            double price = 0;
            int overnights = days - 1;

            if (type == "room for one person")
            {
                price = 18 * overnights;
            }
            else if (type == "apartment")
            {
                price = 25 * overnights;

                if (days < 10)
                {
                    price = price * 0.7;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = price * 0.65;
                }
                else if (days > 15)
                {
                    price = price * 0.5;
                }
            }
            else if (type == "president apartment")
            {
                price = 35 * overnights;

                if (days < 10)
                {
                    price = price * 0.9;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = price * 0.85;
                }
                else if (days > 15)
                {
                    price = price * 0.8;
                }
            }

            if (posOrNegative == "positive")
            {
                price = price * 1.25;
            }
            else if (posOrNegative == "negative")
            {
                price = price * 0.9;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
