using System;

namespace ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string newText = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (i == text.Length - 1)
                {
                    newText += text[i];
                    break;
                }
                if (text[i] != text[i + 1])
                {
                    newText += text[i];
                }
            }

            Console.WriteLine(newText);
        }
    }
}
