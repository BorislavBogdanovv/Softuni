using System;

namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            double result = GetCalculate(num1, @operator, num2);
            Console.WriteLine(result);
        }

        static double GetCalculate(int num1, string @operator, int num2)
        {
            double result = 0;

            switch (@operator)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = (double)num1 / num2;
                    break;
            }

            return result;
        }

    }
}
