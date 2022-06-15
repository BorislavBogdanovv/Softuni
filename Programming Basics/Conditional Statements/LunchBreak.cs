using System;

namespace Conditional_Statements___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double timeMovie = double.Parse(Console.ReadLine());
            double timeRest = double.Parse(Console.ReadLine());

            double timeLunch = timeRest * 1 / 8;
            double timeRest2 = timeRest * 1 / 4;
            double timeLeft = timeRest - timeLunch - timeRest2;

            if (timeLeft >= timeMovie)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeLeft - timeMovie)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(timeMovie - timeLeft)} more minutes.");
            }
        }
    }
}
