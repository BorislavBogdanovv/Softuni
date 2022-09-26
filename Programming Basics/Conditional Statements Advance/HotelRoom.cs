using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int overnights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartment = 0;
            string type1 = "Studio";
            string type2 = "Apartment";

            if (month == "May" || month == "October")
            {
                priceStudio = 50 * overnights;
                priceApartment = 65 * overnights;

                if (overnights > 7 && overnights <= 14)
                {
                    priceStudio = priceStudio * 0.95;
                }
                else if (overnights > 14)
                {
                    priceStudio = priceStudio * 0.7;
                    priceApartment = priceApartment * 0.9;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 75.2 * overnights;
                priceApartment = 68.7 * overnights;

                if (overnights > 14)
                {
                    priceStudio = priceStudio * 0.8;
                    priceApartment = priceApartment * 0.9;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceStudio = 76 * overnights;
                priceApartment = 77 * overnights;

                if (overnights > 14)
                {
                    priceApartment = priceApartment * 0.9;
                }
            }

            Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }
    }
}
