using System;
using System.Numerics;

namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            GetDivision(num1, num2);

        }

        static void GetDivision(int n1, int n2)
        {

            double factorial1 = 1;
            double factorial2 = 1;

            for (int i = 1; i <= n1; i++)
            {
                factorial1 *= i;
            }
            for (int i = 1; i <= n2; i++)
            {
                factorial2 *= i;
            }

            double result = factorial1 / factorial2;
            Console.WriteLine($"{result:f2}");
        }
    }
}
