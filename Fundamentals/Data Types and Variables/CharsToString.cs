using System;
using System.Net.WebSockets;

namespace CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = Console.ReadLine()[0];
            char b = Console.ReadLine()[0];
            char c = Console.ReadLine()[0];
            string result = a.ToString() + b.ToString() + c.ToString();

            Console.WriteLine(result);
        }
    }
}
