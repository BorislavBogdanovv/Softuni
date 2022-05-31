using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int preparation = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double pensPrice = pens * 5.80;
            double markersPrice = markers * 7.20;
            double preparationPrice = preparation * 1.20;

            double sum = pensPrice + markersPrice + preparationPrice;

            double totalSum = sum - sum * (percent / 100.0);
            Console.WriteLine(totalSum);
        }
    }
}
