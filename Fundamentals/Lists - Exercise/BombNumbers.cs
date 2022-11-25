using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] cmdArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == cmdArr[0])
                {
                    for (int r = 1; r <= cmdArr[1]; r++)
                    {
                        if (i - r < 0)
                        {
                            break;
                        }
                        else
                        {
                            list[i - r] = 0;
                        }
                    }

                    for (int k = 1; k <= cmdArr[1]; k++)
                    {
                        if (i + k > list.Count - 1)
                        {
                            if (i - 1 >= 0)
                            {
                                break;
                            }
                        }
                        else
                        {
                            list[i + k] = 0;
                        }
                    }

                    list[i] = 0;
                }
            }

            int sum = list.Sum();
            Console.WriteLine(sum);

        }
    }
}
