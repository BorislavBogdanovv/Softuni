using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setVip = new HashSet<string>();
            HashSet<string> setRegular = new HashSet<string>();

            string command;
            while ((command = Console.ReadLine()) != "PARTY")
            {
                bool isDigit = Char.IsDigit(command[0]);
                if (isDigit)
                {
                    setVip.Add(command);
                }
                else
                {
                    setRegular.Add(command);
                }
            }

            string partyCommand;
            while ((partyCommand = Console.ReadLine()) != "END")
            {
                bool isDigit = Char.IsDigit(partyCommand[0]);
                if (isDigit)
                {
                    setVip.Remove(partyCommand);
                }
                else
                {
                    setRegular.Remove(partyCommand);
                }
            }

            int count = setVip.Count + setRegular.Count;

            Console.WriteLine(count);

            if (setVip.Any())
            {
                Console.WriteLine(string.Join("\n", setVip));
            }
            if (setRegular.Any())
            {
                Console.WriteLine(string.Join("\n", setRegular));
            }
        }
    }
}
