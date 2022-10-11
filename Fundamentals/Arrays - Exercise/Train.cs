using System;
using System.Linq;

namespace _8._Exercise_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //number of wagons

            int[] train = new int[n];

            int sum = 0;

            for (int i = 0; i < train.Length; i++)
            {
                int passengersPerWagon = int.Parse(Console.ReadLine());

                train[i] += passengersPerWagon;

                sum += train[i];
            }

            Console.WriteLine(String.Join(" ", train));
            Console.WriteLine(sum);

        }
    }
}
