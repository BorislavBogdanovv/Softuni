using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _05.SetsAndDictionariesAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = input
                    .Split(", ");

                string command = cmdArgs[0];
                string carPlate = cmdArgs[1];

                if (command == "IN")
                {
                    set.Add(carPlate);
                }
                else if (command == "OUT")
                {
                    set.Remove(carPlate);
                }
            }

            if (!set.Any())
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            foreach (var plate in set)
            {
                Console.WriteLine(plate);
            }
        }
    }
}
