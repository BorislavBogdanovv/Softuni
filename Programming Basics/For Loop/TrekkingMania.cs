using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;
            double total = 0;

            for (int i = 0; i < groups; i++)
            {
                int people = int.Parse(Console.ReadLine());

                total += people;

                if (people <= 5)
                {
                    musala += people;
                }
                else if (people <= 12)
                {
                    monblan += people;
                }
                else if (people <= 25)
                {
                    kilimandjaro += people;
                }
                else if (people <= 40)
                {
                    k2 += people;
                }
                else if (people >= 41)
                {
                    everest += people;
                }
            }

            double musala1 = musala / total * 100;
            double monblan1 = monblan / total * 100;
            double kilimandjaro1 = kilimandjaro / total * 100;
            double k21 = k2 / total * 100;
            double everest1 = everest / total * 100;

            Console.WriteLine($"{musala1:f2}%");
            Console.WriteLine($"{monblan1:f2}%");
            Console.WriteLine($"{kilimandjaro1:f2}%");
            Console.WriteLine($"{k21:f2}%");
            Console.WriteLine($"{everest1:f2}%");
        }
    }
}
