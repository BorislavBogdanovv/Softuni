using System;

namespace LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = Console.ReadLine()[0];
            char b = char.ToUpper(a);

            if (a == b)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
