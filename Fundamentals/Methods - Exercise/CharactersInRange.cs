using System;

namespace CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());


            GetASCII(a, b);
        }

        static void GetASCII(char a, char b)
        {
            if (b < a)
            {
                char c = a;
                a = b;
                b = c;
            }

            for (int i = a + 1; i < b; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
