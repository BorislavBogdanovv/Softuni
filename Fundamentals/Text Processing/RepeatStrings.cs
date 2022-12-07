using System;

namespace RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] allWords = Console.ReadLine().Split();

            string concatWords = string.Empty;

            foreach (var item in allWords)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    concatWords += item; 
                }
            }

            Console.WriteLine(concatWords);
        }
    }
}
