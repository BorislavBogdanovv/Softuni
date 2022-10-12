using System;
using System.Linq;

namespace EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                rightSum = 0;
                for (int l = i + 1; l < arr.Length; l++)
                {
                    rightSum += arr[l];
                }

                leftSum = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += arr[j];
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
