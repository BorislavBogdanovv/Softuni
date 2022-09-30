using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;

            if (type == "Students")
            {
                switch (day)
                {
                    case "Friday":

                        totalPrice = num * 8.45;

                        if (num >= 30)
                        {
                            totalPrice = totalPrice - (totalPrice * 15) / 100;
                        }
                        break;

                    case "Saturday":

                        totalPrice = num * 9.80;

                        if (num >= 30)
                        {
                            totalPrice = totalPrice - (totalPrice * 15) / 100;
                        }
                        break;

                    case "Sunday":

                        totalPrice = num * 10.46;

                        if (num >= 30)
                        {
                            totalPrice = totalPrice - (totalPrice * 15) / 100;
                        }

                        break;
                }
            }

            else if (type == "Business")
            {
                switch (day)
                {
                    case "Friday":

                        totalPrice = num * 10.90;

                        if (num >= 100)
                        {
                            totalPrice = totalPrice - (10.90 * 10);
                        }
                        break;

                    case "Saturday":

                        totalPrice = num * 15.60;

                        if (num >= 100)
                        {
                            totalPrice = totalPrice - (15.60 * 10);
                        }
                        break;

                    case "Sunday":

                        totalPrice = num * 16;

                        if (num >= 100)
                        {
                            totalPrice = totalPrice - (16 * 10);
                        }

                        break;
                }
            }

            else if (type == "Regular")
            {
                switch (day)
                {
                    case "Friday":

                        totalPrice = num * 15;

                        if (num >= 10 && num <= 20)
                        {
                            totalPrice = totalPrice - (totalPrice * 5) / 100;
                        }
                        break;

                    case "Saturday":

                        totalPrice = num * 20;

                        if (num >= 10 && num <= 20)
                        {
                            totalPrice = totalPrice - (totalPrice * 5) / 100;
                        }
                        break;

                    case "Sunday":

                        totalPrice = num * 22.50;

                        if (num >= 10 && num <= 20)
                        {
                            totalPrice = totalPrice - (totalPrice * 5) / 100;
                        }

                        break;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
