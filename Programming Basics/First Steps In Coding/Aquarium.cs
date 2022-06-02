using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double percent = double.Parse(Console.ReadLine());

            double volume = lenght * width * height;

            double volumeLiters = volume / 1000;

            double busy = percent / 100;

            double liters = volumeLiters * (1 - busy);

            Console.WriteLine(liters);
        }
    }
}
