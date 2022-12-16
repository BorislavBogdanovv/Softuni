using System;
using System.Linq;

namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine()
                .Split("\\");

            string lastIndex = path.Last();

            string[] file = lastIndex.Split(".");

            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}
