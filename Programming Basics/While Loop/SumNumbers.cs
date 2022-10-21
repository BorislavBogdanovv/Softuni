using System;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());

            while (num1 < firstNum)
            {
                int num = int.Parse(Console.ReadLine());
                num1 += num;
            }

            Console.WriteLine(num1);
        }
    }
}
