using System;

namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            double powerNum = double.Parse(Console.ReadLine());

            double result = GetPower(baseNum, powerNum);

            Console.WriteLine(result);

        }

        static double GetPower(double num1, double num2)
        {
            double result = Math.Pow(num1, num2);

            return result;
        }
    }
}
