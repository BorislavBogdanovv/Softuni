using System;

namespace ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sadEval = int.Parse(Console.ReadLine());
            int counterSadEval = 0;
            int counterTasksOK = 0;
            double totalEval = 0;
            string lastTaks = string.Empty;
            bool isFailed = true;

            while (counterSadEval < sadEval)
            {
                string taskName = Console.ReadLine();

                if (taskName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    counterSadEval++;
                }
                totalEval += grade;
                counterTasksOK++;
                lastTaks = taskName;
            }

            if (isFailed)
            {
                Console.WriteLine($"You need a break, {sadEval} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {totalEval / counterTasksOK:f2}");
                Console.WriteLine($"Number of problems: {counterTasksOK}");
                Console.WriteLine($"Last problem: {lastTaks}");
            }
        }
    }
}
