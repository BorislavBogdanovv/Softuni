using System;

namespace VowelsSum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];

                if (letter == 'a')
                {
                    n += 1;
                }
                else if (letter == 'e')
                {
                    n += 2;
                }
                else if (letter == 'i')
                {
                    n += 3;
                }
                else if (letter == 'o')
                {
                    n += 4;
                }
                else if (letter == 'u')
                {
                    n += 5;
                }
            }

            Console.WriteLine(n);
        }
    }
}
