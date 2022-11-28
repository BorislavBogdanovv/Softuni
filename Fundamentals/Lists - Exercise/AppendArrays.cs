using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            string[] arr1 = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                List<string> newList = arr1[i]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                list.AddRange(newList);
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
