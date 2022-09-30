using System;

namespace RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine());

            double mousePrice = double.Parse(Console.ReadLine());

            double keyboardPrice = double.Parse(Console.ReadLine());

            double monitorPrice = double.Parse(Console.ReadLine());

            int headsetCnt = 0;
            int mouseCnt = 0;
            int keyboardCnt = 0;
            int monitorCnt = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCnt++;
                }

                if (i % 3 == 0)
                {
                    mouseCnt++;
                }

                if (i % 6 == 0)
                {
                    keyboardCnt++;
                }
                if (i % 12 == 0)
                {
                    monitorCnt++;
                }
            }
            double expenses = (headsetCnt * headsetPrice) + (mouseCnt * mousePrice) + (keyboardPrice * keyboardCnt) + (monitorPrice * monitorCnt);
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
