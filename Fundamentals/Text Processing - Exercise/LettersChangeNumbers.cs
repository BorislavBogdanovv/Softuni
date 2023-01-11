using System;

namespace LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (string item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[^1]; // same as [item.Length - 1]

                string numAsAString = item[1..^1]; // this will give us everything thats between 0 and
                                                   // the last index

                double numFromString = double.Parse(numAsAString);

                if (char.IsUpper(firstLetter))
                {
                    int positionOfTheLetter = firstLetter - 64;
                    numFromString /= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = firstLetter - 96;
                    numFromString *= positionOfTheLetter;
                }

                if (char.IsUpper(lastLetter))
                {
                    int positionOfTheLetter = lastLetter - 64;
                    numFromString -= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = lastLetter - 96;
                    numFromString += positionOfTheLetter;
                }

                sum += numFromString;

            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
