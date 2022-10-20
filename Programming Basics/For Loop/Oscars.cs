using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string assessorName = Console.ReadLine();
                double assessorPoints = double.Parse(Console.ReadLine());

                academyPoints += (assessorName.Length * assessorPoints) / 2;

                if (academyPoints >= 1250)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:f1}!");
                    break;
                }
            }

            if (academyPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - academyPoints:f1} more!");
            }
        }
    }
}
