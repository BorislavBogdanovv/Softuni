using System;

namespace MultiplyEvensBOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();  //"12345"

            int absValue = Math.Abs(int.Parse(input));  //12345

            int sumOfEvenDigits = GetSumOfEvenDigits(absValue.ToString());
            int sumOfOddDigits = GetSumOfOddDigits(absValue.ToString());

            int result = sumOfEvenDigits * sumOfOddDigits;
            Console.WriteLine(result);
        }

        private static int GetSumOfOddDigits(string input)
        {
            {
                int sum = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    //from char ''.ToString = ""
                    int currNum = Math.Abs(int.Parse(input[i].ToString()));

                    if (currNum % 2 != 0)
                    {
                        sum += currNum;
                    }
                }
                return sum;
            }
        }

        private static int GetSumOfEvenDigits(string input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                //from char ''.ToString = ""
                int currNum = int.Parse(input[i].ToString());

                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }
            }
            return sum;
        }
    }
}
