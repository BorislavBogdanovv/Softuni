using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {

            int needSteps = 10000;
            int totalSteps = 0;

            while (totalSteps < needSteps)
            {
                string steps = Console.ReadLine();

                if (steps != "Going home")
                {
                    totalSteps += int.Parse(steps);
                }
                else
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    totalSteps += lastSteps;

                    if (totalSteps < needSteps)
                    {
                        Console.WriteLine($"{needSteps - totalSteps} more steps to reach goal.");
                        return;
                    }
                }

            }

            if (totalSteps >= needSteps)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - needSteps} steps over the goal!");
            }
        }
    }
}
