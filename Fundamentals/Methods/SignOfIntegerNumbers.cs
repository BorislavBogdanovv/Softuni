using System;

namespace Lab_14_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                IsPositive(num);
            }
            else if (num < 0)
            {
                IsNegative(num);
            }
            else
            {
                IsZero(num);
            }
            
        }

        static void IsPositive(int num)
        {
            Console.WriteLine($"The number {num} is positive.");
        }

        static void IsNegative(int num)
        {
            Console.WriteLine($"The number {num} is negative.");
        }

        static void IsZero(int num)
        {
            Console.WriteLine($"The number {num} is zero.");
        }
    }
}
