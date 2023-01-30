using System;
using System.Linq;

namespace _03.MultidimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] data = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            int sum = 0;
            int counter = 0;

            for (int row = 0; row < 1; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    sum += matrix[row + counter, col];
                    counter++;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
