using System;

namespace TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            int sqKm = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {town} has population of {population} and area {sqKm} square km.");
        }
    }
}
