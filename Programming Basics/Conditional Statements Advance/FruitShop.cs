using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine($"{(quantity * 2.5):f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{(quantity * 1.2):f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{(quantity * 0.85):f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{(quantity * 1.45):f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{(quantity * 2.7):f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{(quantity * 5.5):f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{(quantity * 3.85):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine($"{(quantity * 2.7):f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{(quantity * 1.25):f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{(quantity * 0.90):f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{(quantity * 1.6):f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{(quantity * 3):f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{(quantity * 5.6):f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{(quantity * 4.2):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }

    }
}

