using System;

namespace AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int num4 = GetSum(num1, num2);
            int num5 = GetSubtract(num3, num4);
            Console.WriteLine(num5);
        }

        static int GetSum(int n1, int n2)
        {
            int n4 = n1 + n2;
            return n4;
        }

        static int GetSubtract(int n3, int n4)
        {
            int n5 = n4 - n3;
            return n5;
        }
    }
}
