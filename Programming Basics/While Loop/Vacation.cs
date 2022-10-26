using System;

namespace _5Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double balanceMoney = double.Parse(Console.ReadLine());
            int counterSpendDays = 0;
            int counterDays = 0;


            while (counterSpendDays < 5)
            {

                string spendOrSave = Console.ReadLine();
                double sumMoney = double.Parse(Console.ReadLine());
                counterDays++;

                if (spendOrSave == "spend")
                {
                    balanceMoney -= sumMoney;
                    counterSpendDays++;

                    if (balanceMoney <= 0)
                    {
                        balanceMoney = 0;
                    }
                }

                else if (spendOrSave == "save")
                {
                    balanceMoney += sumMoney;
                    counterSpendDays = 0;
                }

                if (balanceMoney >= needMoney)
                {
                    Console.WriteLine($"You saved the money for {counterDays} days.");
                    return;
                }
            }

            Console.WriteLine("You can't save the money.");
            Console.WriteLine(counterDays);
        }
    }
}
