using System;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = double.Parse(Console.ReadLine());

            if (result >= 5.5)
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }
    }
}
