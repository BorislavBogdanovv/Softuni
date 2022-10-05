using System;

namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string modelKeg = string.Empty;

            double biggestKeg = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * (radius * radius) * height;

                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    modelKeg = model;
                }
            }

            Console.WriteLine(modelKeg);
        }
    }
}
