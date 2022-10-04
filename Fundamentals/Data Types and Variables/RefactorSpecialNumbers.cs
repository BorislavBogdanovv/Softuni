using System;

namespace RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int total = 0;
            int b = 0;
            bool trueOrFalse = false;
            for (int n = 1; n <= a; n++)
            {
                b = n;
                while (n > 0)
                {
                    total += n % 10;
                    n = n / 10;
                }
                trueOrFalse = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine("{0} -> {1}", b, trueOrFalse);
                total = 0;
                n = b;
            }

        }
    }
}
