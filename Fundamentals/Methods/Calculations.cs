using System;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            if (command == "add")
            {
                Add(num1, num2);
            }
            else if (command == "multiply")
            {
                Multiply(num1, num2);
            }
            else if (command == "subtract")
            {
                Subtract(num1, num2);
            }
            else if (command == "divide")
            {
                Divide(num1, num2);
            }
        }

        static void Add(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }

        static void Multiply(double num1, double num2)
        {
            Console.WriteLine(num1 * num2);
        }

        static void Subtract(double num1, double num2)
        {
            Console.WriteLine(num1 - num2);
        }

        static void Divide(double num1, double num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
