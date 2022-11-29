using System;

namespace _16._Lab_20_Objects_and_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentance = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();

            for (int i = 0; i < sentance.Length; i++)
            {
                int randomIndex = rnd.Next(0, sentance.Length);

                string currentWord = sentance[i];
                string nextWord = sentance[randomIndex];

                sentance[i] = nextWord;
                sentance[randomIndex] = currentWord;
            }

            Console.WriteLine(String.Join(Environment.NewLine, sentance));
        }
    }
}
