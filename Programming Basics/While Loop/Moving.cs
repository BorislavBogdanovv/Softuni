using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int place = width * lenght * height;

            int countPlace = 0;

            while (countPlace < place)
            {
                string numBoxes = Console.ReadLine();

                if (numBoxes != "Done")
                {
                    countPlace += int.Parse(numBoxes);

                    if (countPlace > place)
                    {
                        Console.WriteLine($"No more free space! You need {countPlace - place} Cubic meters more.");  
                    }
                }
                else
                {
                    Console.WriteLine($"{place - countPlace} Cubic meters left.");
                    return;
                }
            }
        }
    }
}
