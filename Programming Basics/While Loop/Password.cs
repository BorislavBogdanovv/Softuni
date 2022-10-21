using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string password2 = Console.ReadLine();

            while (password2 != password)
            {
                password2 = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
