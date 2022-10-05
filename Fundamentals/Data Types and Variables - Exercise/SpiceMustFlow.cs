using System;
using System.Numerics;

namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BigInteger start = BigInteger.Parse(Console.ReadLine());
            BigInteger cntSpice = 0;
            BigInteger cntdays = 0;

            if (start < 100)
            {
                Console.WriteLine(cntdays);
                Console.WriteLine(cntSpice);
                return;
            }
            while (start >= 100)
            {
                cntSpice += start;
                cntSpice -= 26;
                start -= 10;
                cntdays++;
            }

            cntSpice -= 26;

            Console.WriteLine(cntdays);
            Console.WriteLine(cntSpice);
        }
    }
}
