using System;
using System.Linq;

namespace MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int r = arr.Length - 1; r >= i; r--)
                {
                    if (i != r)
                    {
                        if (arr[i] + arr[r] == num)
                        {
                            Console.WriteLine($"{arr[i]} {arr[r]}");
                        }
                    }
                }
            }
        }
    }
}
