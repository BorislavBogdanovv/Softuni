using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] condensed = new int[nums.Length - 1];

            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int p = 0; p < nums.Length - 1; p++)
                {
                    condensed[p] = nums[p] + nums[p + 1];     
                }

               nums = condensed;
            }
            Console.WriteLine(condensed[0]);
        }
    }
}
