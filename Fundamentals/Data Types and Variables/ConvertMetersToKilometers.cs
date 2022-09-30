using System;

namespace Lab_08__DataTypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());

            double km = m / 1000.0;

            Console.WriteLine($"{km:f2}");
        }
    }
}
