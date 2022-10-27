using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int size = height * width;
            int count = 0;

            while (count < size)
            {
                string pieces = Console.ReadLine();

                if (pieces != "STOP")
                {
                    count += int.Parse(pieces);

                    if (count > size)
                    {
                        Console.WriteLine($"No more cake left! You need {count - size} pieces more.");
                    }
                }
                else
                {
                    Console.WriteLine($"{size - count} pieces are left.");
                    return;
                }
            }
        }
    }
}
