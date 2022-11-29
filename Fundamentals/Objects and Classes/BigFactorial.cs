using System;
using System.Numerics;

namespace BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorielN = 1;

            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;
            }

            Console.WriteLine(factorielN);
        }
    }
}
