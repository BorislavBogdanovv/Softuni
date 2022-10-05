using System;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint powerPokeN = uint.Parse(Console.ReadLine());
            uint targetsDistanceM = uint.Parse(Console.ReadLine());
            uint exhaustingFactorY = uint.Parse(Console.ReadLine());
            int cntTargets = 0;
            decimal powerPoke50 = 50 * powerPokeN / 100;

            while (powerPokeN >= targetsDistanceM)
            {
                powerPokeN -= targetsDistanceM;
                cntTargets++;

                if (powerPokeN == powerPoke50)
                {
                    powerPokeN /= exhaustingFactorY;
                }

            }

            Console.WriteLine(powerPokeN);
            Console.WriteLine(cntTargets);
        }
    }
}
