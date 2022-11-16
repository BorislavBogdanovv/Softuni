using System;

namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command.Length % 2 == 0)
                {
                    GetEvenMethod(command);
                }
                else
                {
                    GetOddMethod(command);
                }
            }
        }

        static void GetEvenMethod(string command)
        {
            string secondHalf = String.Empty;
            string firstHalf = String.Empty;

            for (int i = 0; i < command.Length / 2; i++)
            {
                firstHalf += command[i];
            }
            for (int i = command.Length - 1; i >= command.Length / 2; i--)
            {
                secondHalf += command[i];
            }

            GetTrueOrFalse(secondHalf, firstHalf);
        }

        static void GetOddMethod(string command)
        {
            string secondHalf = String.Empty;
            string firstHalf = String.Empty;

            for (int i = 0; i < command.Length / 2; i++)
            {
                firstHalf += command[i];
            }
            for (int i = command.Length - 1; i > command.Length / 2; i--)
            {
                secondHalf += command[i];
            }

            GetTrueOrFalse(secondHalf, firstHalf);
        }

        static void GetTrueOrFalse(string n1, string n2)
        {
            if (n1 == n2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
