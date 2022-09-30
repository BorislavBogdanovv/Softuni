using System;

namespace PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = n; i <= m; i++)
            {
                Console.Write(i + " ");
                count += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {count}");
        }
    }
}
