using System;
using System.Net.WebSockets;

namespace SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char Symbol = Console.ReadLine()[0];
                sum += Symbol;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
