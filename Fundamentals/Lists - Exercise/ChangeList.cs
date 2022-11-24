using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                ControlTheList(list, command);
            }

            Console.WriteLine(String.Join(' ', list));
        }

        static void ControlTheList (List<int> list, string command)
        {
            string[] commArg = command
                    .Split(' ')
                    .ToArray();

            if (commArg.Length == 2)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == int.Parse(commArg[1]))
                    {
                        list.Remove(list[i]);
                    }
                }
            }
            else if (commArg.Length == 3)
            {
                list.Insert(int.Parse(commArg[2]), int.Parse(commArg[1]));
            }
        }
    }
}
