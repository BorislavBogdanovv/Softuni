using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            //час изпит

            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());
            //час пристигане

            examMin = examMin + examHour * 60;
            arrivalMin = arrivalMin + arrivalHour * 60;

            int difference = 0;
            int diffHour = 0;
            int diffMin = 0;

            //закъснял - examMin < arrivalMin
            //на време - (examMin == arrivalMin) или до 30мин по-късно (examMin - arrivalMin <= 30)
            //подранил - examMin - arrivalMin > 30


            //проверяваме дали закъснява
            if (examMin < arrivalMin)
            {
                Console.WriteLine("Late");

                //намираме разликата във времето на пристигане
                difference = arrivalMin - examMin;

                //преобразуваме в минути и часове
                diffHour = difference / 60;
                diffMin = difference % 60;

                //проверяваме дали закъснява с повече от 1 час
                if (diffHour >= 1)
                {
                    //проверяваме дали минутите са по-малко от 10(ако са-отпечатваме с водеща 0)
                    if (diffMin < 10)
                    {
                        Console.WriteLine($"{diffHour}:0{diffMin} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{diffHour}:{diffMin} hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{diffMin} minutes after the start");
                }
            }
            else if (examMin - arrivalMin <= 30)
            {
                Console.WriteLine("On time");

                //проверяваме дали е закъснял
                if (examMin != arrivalMin)
                {
                    difference = examMin - arrivalMin;
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                difference = examMin - arrivalMin;

                //преобразуваме в минути и часове
                diffHour = difference / 60;
                diffMin = difference % 60;

                //проверяваме дали закъснява с повече от 1 час
                if (diffHour >= 1)
                {
                    //проверяваме дали минутите са по-малко от 10(ако са-отпечатваме с водеща 0)
                    if (diffMin < 10)
                    {
                        Console.WriteLine($"{diffHour}:0{diffMin} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{diffHour}:{diffMin} hours before the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{diffMin} minutes before the start");
                }
            }
        }
    }
}
