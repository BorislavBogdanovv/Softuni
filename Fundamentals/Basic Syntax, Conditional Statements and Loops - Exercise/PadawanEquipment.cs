using System;

namespace PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsNum = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double needLightsabers = Math.Ceiling(studentsNum * 1.10);

            int freeBelts = 0;

            for (int i = studentsNum; i > 0; i--)
            {
                if (i % 6 == 0)
                {
                    freeBelts = freeBelts + 1;
                }
            }
            
            double needMoney = lightsaberPrice * needLightsabers + robePrice * studentsNum + beltPrice * (studentsNum - freeBelts);

            if (money >= needMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {needMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {needMoney - money:f2}lv more.");
            }
        }
    }
}
