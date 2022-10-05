using System;
using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger highestSnowballValue = BigInteger.MinusOne;
            int snowballSnowBest = int.MinValue;
            int snowballTimeBest = int.MinValue;
            int snowballQualityBest = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > highestSnowballValue)
                {
                    highestSnowballValue = snowballValue;
                    snowballSnowBest = snowballSnow;
                    snowballTimeBest = snowballTime;
                    snowballQualityBest = snowballQuality;
                }

            }

            Console.WriteLine($"{snowballSnowBest} : {snowballTimeBest} = {highestSnowballValue} ({snowballQualityBest})");
        }
    }
}
