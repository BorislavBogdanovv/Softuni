using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());

                double savings = 0;

                while (savings < minBudget)
                {
                    savings += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");
                
                destination = Console.ReadLine();
            }
        }
    }
}
