using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tours = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            double averagePoints = 0;
            double win = 0;

            for (int i = 0; i < tours; i++)
            {
                string stage = Console.ReadLine();

                switch (stage)
                {
                    case "W":
                        startPoints += 2000;
                        averagePoints += 2000;
                        win += 1;
                        break;
                    case "F":
                        startPoints += 1200;
                        averagePoints += 1200;
                        break;
                    case "SF":
                        startPoints += 720;
                        averagePoints += 720;
                        break;
                }
            }

            averagePoints = averagePoints / tours;

            Console.WriteLine($"Final points: {startPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{(win / tours) * 100:f2}%");
        }
    }
}
