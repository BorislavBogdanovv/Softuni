using System;

namespace VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int h = 0;

            for (int i = 1; i <= n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                h += m;
            }
            Console.WriteLine(h);
        }
    }
}
