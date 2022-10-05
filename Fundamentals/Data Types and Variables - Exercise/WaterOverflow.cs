using System;

namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cntTotal = 0;

            for (int i = 0; i < n; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                int cnt = cntTotal + quantity;


                if (cnt <= 255)
                {
                    cntTotal += quantity;
                    cnt = 0;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(cntTotal);
        }
    }
}
