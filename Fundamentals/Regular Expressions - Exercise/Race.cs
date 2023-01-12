using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace _26._30_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> racers = new Dictionary<string, int>();

            string namePattern = @"[A-Za-z]";

            string kmPattern = @"\d";

            Regex nameRegex = new Regex(namePattern);

            Regex kmRegex = new Regex(kmPattern);

            string command;
            while ((command = Console.ReadLine()) != "end of race")
            {
                for (int i = 0; i < names.Length; i++)
                {

                }
                MatchCollection matches = nameRegex.Matches(command);

                string name = string.Empty;

                foreach (Match item in matches)
                {
                    name += item.Value;
                }

                bool flag = false;

                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        flag = true;
                    }
                }

                if (flag)
                {
                    MatchCollection matches2 = kmRegex.Matches(command);

                    int km = 0;

                    foreach (Match item in matches2)
                    {
                        km += int.Parse(item.Value);
                    }

                    if (!(racers.ContainsKey(name)))
                    {
                        racers.Add(name, km);
                    }
                    else
                    {
                        racers[name] += km;
                    }

                    flag = false;
                }
            }

            string[] sortedRacers = racers.OrderByDescending(x => x.Value).Take(3).Select(x => x.Key).ToArray();

            Console.WriteLine($"1st place: {sortedRacers[0]}");
            Console.WriteLine($"2nd place: {sortedRacers[1]}");
            Console.WriteLine($"3rd place: {sortedRacers[2]}");
        }
    }
}
