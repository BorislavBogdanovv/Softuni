using System;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            string newText = string.Empty;
            
            for (int i = 0; i < text.Length; i++)
            {
                int ch = text[i] + 3;
                char newChar = (char)(ch);
                newText += newChar;
            }
            
            Console.WriteLine(newText);
        }
    }
}
