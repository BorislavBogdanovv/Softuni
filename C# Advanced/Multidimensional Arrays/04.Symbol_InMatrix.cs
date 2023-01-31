using System;
using System.Linq;

namespace _04.Symbol_InMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string data = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            char isOccurChar = char.Parse(Console.ReadLine());

            char currChar = ' ';

            bool flag = false;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    currChar = matrix[row, col];

                    if (currChar == isOccurChar)
                    {
                        Console.WriteLine($"({row}, {col})");
                        flag = true;
                        return;
                    }
                }
            }

            if (!flag)
            {
                Console.WriteLine($"{isOccurChar} does not occur in the matrix");
            }
        }
    }
}
