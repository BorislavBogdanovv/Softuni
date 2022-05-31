using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBook = int.Parse(Console.ReadLine());
            int numPage = int.Parse(Console.ReadLine());
            int numDays = int.Parse(Console.ReadLine());

            int time = numBook / numPage;
            int needt = time / numDays;

            Console.WriteLine(needt);
        }
    }
}
