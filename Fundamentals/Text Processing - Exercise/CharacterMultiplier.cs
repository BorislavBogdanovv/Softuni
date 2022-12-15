using System;

namespace _23._27_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSum = 0;

            bool flag = false;

            string[] twoWords = Console.ReadLine()
                .Split();

            string word1 = twoWords[0];
            string word2 = twoWords[1];

            if (word1.Length >= word2.Length)
            {
                for (int i = 0; i <= word2.Length; i++)
                {
                    if (i == word2.Length)
                    {
                        flag = true;
                        break;
                    }
                    totalSum += word1[i] * word2[i];                 
                }

                if (flag)
                {
                    for (int r = word2.Length; r < word1.Length; r++)
                    {
                        totalSum += word1[r];
                    }

                    flag = false;
                }
            }
            else
            {
                for (int i = 0; i <= word1.Length; i++)
                {
                    if (i == word1.Length)
                    {
                        flag = true;
                        break;
                    }
                    totalSum += word1[i] * word2[i];
                }

                if (flag)
                {
                    for (int r = word1.Length; r < word2.Length; r++)
                    {
                        totalSum += word2[r];
                    }

                    flag = false;
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
