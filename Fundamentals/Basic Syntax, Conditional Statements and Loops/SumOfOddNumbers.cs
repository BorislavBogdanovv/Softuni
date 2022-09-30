using System;

namespace SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(k);
                sum += k;
                k += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
