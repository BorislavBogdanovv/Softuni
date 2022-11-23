using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace _14._Exercise_18_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int maxPass = int.Parse(Console.ReadLine());

            bool flag = false;

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                Train(command, train, maxPass, flag);
               
            }

            Console.WriteLine(String.Join(' ', train));
        }

        static void Train(string command, List<int>train, int maxPass, bool flag)
        {
            string[] commandArr = command
                      .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                      .ToArray();

            if (commandArr.Length == 2)
            {
                train.Add(int.Parse(commandArr[1]));
            }
            else if (commandArr.Length == 1)
            {
                for (int i = 0; i < train.Count; i++)
                {
                    if (int.Parse(commandArr[0]) + train[i] <= maxPass)
                    {
                        train[i] += int.Parse(commandArr[0]);
                        flag = true;
                    }

                    if (flag)
                    {
                        flag = false;
                        break;
                    }
                }
            }
        }
    }
}
