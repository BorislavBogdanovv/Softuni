using System;

namespace NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            GetMatrix(n);
        }

        private static void GetMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int r = 0; r < n; r++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
