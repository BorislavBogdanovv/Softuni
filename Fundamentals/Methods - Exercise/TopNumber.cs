using System;
using System.Net.WebSockets;

namespace TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            TopNumber(n);
        }

        private static void TopNumber(int n)
        {
            bool yesOrNo = false;

            for (int i = 17; i < n; i++)
            {
                int currSum = i;
                int originalNum = i;
                int sum = 0;

                for (int r = 0; r < originalNum.ToString().Length; r++)
                {
                    int currNum = currSum % 10;
                    sum += currNum;

                    if (currNum % 2 != 0)
                    {
                        yesOrNo = true;
                    }
                    currSum = currSum / 10;
                }

                if (yesOrNo && sum % 8 == 0)
                {
                    Console.WriteLine(originalNum);
                }

                yesOrNo = false;
            }
        }
    }
}
