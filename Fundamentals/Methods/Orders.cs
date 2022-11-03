using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double number = int.Parse(Console.ReadLine());

            GetCalculation(command, number);
        }

        static void GetCalculation(string order, double quantity)
        {
            double total = 0;


            if (order == "coffee")
            {
                total = quantity * 1.5;
                Console.WriteLine($"{total:f2}");
            }
            else if (order == "water")
            {
                total = quantity * 1;
                Console.WriteLine($"{total:f2}");
            }
            else if (order == "coke")
            {
                total = quantity * 1.4;
                Console.WriteLine($"{total:f2}");
            }
            else if (order == "snacks")
            {
                total = quantity * 2;
                Console.WriteLine($"{total:f2}");
            }



        }
    }
}
