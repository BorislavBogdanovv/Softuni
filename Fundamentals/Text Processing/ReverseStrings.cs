using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace _22._Lab_26_TextProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            string text;
            while ((text = Console.ReadLine()) != "end")
            {
                var newText = new StringBuilder();

                for (int i = text.Length - 1; i >= 0; i--)
                {
                    newText.Append(text[i]);
                }

                list.Add($"{text} = {newText}");
            }

            Console.WriteLine(String.Join("\n", list));
        }
    }
}
