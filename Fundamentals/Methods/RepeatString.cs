using System;

namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            string result = RepeatString(word, num);
            Console.WriteLine(result);

        }

        static string RepeatString(string word, int n)
        {
            string newStr = String.Empty;

            while (n > 0)
            {
                newStr += word;
                n--;
            }

            return newStr;
        }
    }
}
