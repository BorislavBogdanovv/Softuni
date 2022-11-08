using System;

namespace _11._Exercise_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = GetSmallest(num1, num2, num3);
            Console.WriteLine(result);
        }

        static int GetSmallest(int num1, int num2, int num3)
        {
            if (num1 < num2 && num1 < num3)
            {
                return num1;
            }
            else if (num2 < num1 && num2 < num3)
            {
                return num2;
            }

            return num3;
        }
    }
}
