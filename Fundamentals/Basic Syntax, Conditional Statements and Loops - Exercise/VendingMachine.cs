using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double coin = 0.0f;
            double coins = 0.0f;

            while (command != "Start")
            {
                coin = double.Parse(command);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    coins += coin;
                    command = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                    command = Console.ReadLine();
                }

            }

            command = Console.ReadLine();

            while (command != "End")
            {
                switch (command)
                {
                    case "Nuts":
                        if (coins >= 2.0)
                        {
                            coins -= 2.0;
                            Console.WriteLine("Purchased nuts");
                            command = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            command = Console.ReadLine();
                        }
                        break;

                    case "Water":
                        if (coins >= 0.7)
                        {
                            coins -= 0.7;
                            Console.WriteLine("Purchased water");
                            command = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            command = Console.ReadLine();
                        }
                        break;

                    case "Crisps":
                        if (coins >= 1.5)
                        {
                            coins -= 1.5;
                            Console.WriteLine("Purchased crisps");
                            command = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            command = Console.ReadLine();
                        }
                        break;

                    case "Soda":
                        if (coins >= 0.8)
                        {
                            coins -= 0.8;
                            Console.WriteLine("Purchased soda");
                            command = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            command = Console.ReadLine();
                        }
                        break;

                    case "Coke":
                        if (coins >= 1.0)
                        {
                            coins -= 1.0;
                            Console.WriteLine("Purchased coke");
                            command = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            command = Console.ReadLine();
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        command = Console.ReadLine();
                        break;
                }
            }
            Console.WriteLine($"Change: {coins:f2}");
        }
    }
}
