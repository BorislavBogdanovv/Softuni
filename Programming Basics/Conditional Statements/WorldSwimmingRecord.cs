using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double secRecord = double.Parse(Console.ReadLine());
            double mDistance = double.Parse(Console.ReadLine());
            double secTime1M = double.Parse(Console.ReadLine());

            double secDistance = mDistance * secTime1M;
            double M15 = mDistance / 15;
            double sec125 = Math.Floor(M15) * 12.5;

            double totalTime = secDistance + sec125;

            if (secRecord <= totalTime)
            {
                Console.WriteLine($"No, he failed! He was {(totalTime - secRecord):f2} seconds slower.");
            }

            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");   
            }
        }
    }
}
