using System;

namespace TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + n; i++)
            {
                for (char k = 'a'; k < 'a' + n; k++)
                {
                    for (char p = 'a'; p < 'a' + n; p++)
                    {
                        Console.WriteLine($"{i}{k}{p}");

                    }
                }
            }
        }
    }
}
