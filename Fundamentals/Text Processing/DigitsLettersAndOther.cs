using System;

namespace DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string digits = string.Empty;
            string letters = string.Empty;
            string chars = string.Empty;

            for (int i = 0; i < word.Length; i++)
            {
                bool digitsResult = false;
                bool letterResult = false;

                char result = word[i];

                digitsResult = Char.IsDigit(result);
                letterResult = Char.IsLetter(result);

                if (digitsResult)
                {
                    digits += word[i];
                    digitsResult = false;
                }
                else if (letterResult)
                {
                    letters += word[i];
                    letterResult = false;
                }
                else
                {
                    chars += word[i];
                }      
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(chars);
        }
    }
}
