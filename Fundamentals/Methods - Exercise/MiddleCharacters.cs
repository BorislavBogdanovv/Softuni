using System;
using System.Linq;

namespace MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            GetMiddleChar(word);
        }

        static void GetMiddleChar(string a)
        {
            int sumWord = a.Length - 1;

            if (sumWord % 2 == 0)
            {
                int index1 = sumWord / 2;
                Console.WriteLine(a[index1]);

            }
            else if (sumWord % 2 != 0)
            {
                int index1 = sumWord / 2;
                int index2 = index1 + 1;
                Console.WriteLine($"{a[index1]}{a[index2]}");
            }
        }
    }
}
