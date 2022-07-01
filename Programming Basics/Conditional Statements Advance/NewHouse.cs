using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем входа от конзолата
            string flowersType = Console.ReadLine();
            int flowerQuantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0.0;

            //правим 5 проверки за всеки тип цвете
            //Roses, Dahlias, Tulips, Narcissus, Gladiouls
            // + вътрешна проверка

            if (flowersType == "Roses")
            {
                price = flowerQuantity * 5.00;

                if (flowerQuantity > 80)
                {
                    price = price - price * 0.1;
                }
            }
            else if (flowersType == "Dahlias")
            {
                //... да я довърша сам, всичко се повтаря
            }
            
        }
    }
}
