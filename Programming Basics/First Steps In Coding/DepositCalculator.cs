using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double dep = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double perc = double.Parse(Console.ReadLine());

            double inter = dep * (perc / 100);
            double month = inter / 12;

            double sum = dep + term * month;
            Console.WriteLine(sum);
        }
    }
}
