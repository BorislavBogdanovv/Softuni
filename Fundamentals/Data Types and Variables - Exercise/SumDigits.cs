using System;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int newDigit = 0;

            for (int i = n.ToString().Length; i > 0 ; i--)
            {
                newDigit = n % 10;
                sum += newDigit;
                n /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
