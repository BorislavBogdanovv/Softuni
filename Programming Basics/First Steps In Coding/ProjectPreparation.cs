using System;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numProjects = int.Parse(Console.ReadLine());
            int time = numProjects * 3;

            Console.WriteLine($"The architect {name} will need {time} hours to complete {numProjects} project/s.");
        }
    }
}
