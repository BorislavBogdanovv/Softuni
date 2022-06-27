using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comm = 0;

            switch (city)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        comm = sales * 0.05;
                        Console.WriteLine($"{comm:f2}") ;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comm = sales * 0.07;
                        Console.WriteLine($"{comm:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comm = sales * 0.08;
                        Console.WriteLine($"{comm:f2}");
                    }
                    else if (sales > 10000)
                    {
                        comm = sales * 0.12;
                        Console.WriteLine($"{comm:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        comm = sales * 0.045;
                        Console.WriteLine($"{comm:f2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comm = sales * 0.075;
                        Console.WriteLine($"{comm:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comm = sales * 0.1;
                        Console.WriteLine($"{comm:f2}");
                    }
                    else if (sales > 10000)
                    {
                        comm = sales * 0.13;
                        Console.WriteLine($"{comm:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        comm = sales * 0.055;
                        Console.WriteLine($"{comm:f2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comm = sales * 0.08;
                        Console.WriteLine($"{comm:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comm = sales * 0.12;
                        Console.WriteLine($"{comm:f2}");
                    }
                    else if (sales > 10000)
                    {
                        comm = sales * 0.145;
                        Console.WriteLine($"{comm:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;


                default:
                    Console.WriteLine("error");
                    break;

            }
        }
    }
}
