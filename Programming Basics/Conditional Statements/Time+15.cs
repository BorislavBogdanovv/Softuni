using System;

namespace Time_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int timeInMin = m + h * 60;
            timeInMin = timeInMin + 15;

            h = timeInMin / 60;
            m = timeInMin % 60;

            if (h == 24)
            {
                h = 0;
            }

            if (m < 10)
            {
                Console.WriteLine($"{h}:0{m}");
            }
            else
            {
                Console.WriteLine($"{h}:{m}");
            }
        }
    }
}
