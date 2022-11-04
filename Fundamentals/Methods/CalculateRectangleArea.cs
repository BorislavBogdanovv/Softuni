using System;

namespace CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = GetRectangleArea(height, width);
            Console.WriteLine(area);
        }

        static double GetRectangleArea(double a, double b)
        {
            return a * b;
        }
    }
}
