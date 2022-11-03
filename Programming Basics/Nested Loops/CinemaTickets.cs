using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int student = 0;
            int standard = 0;
            int kid = 0;
            int sum = 0;
            string name = Console.ReadLine();
            while (name != "Finish")
            {
                int ticket = int.Parse(Console.ReadLine());
                for (int i = 0; i < ticket; i++)
                {
                    string type = Console.ReadLine();

                    if (ticket == i - 1 || type == "End" || type == "Finish")
                    {
                        break;
                    }
                    else
                    {
                        if (type == "student")
                        {
                            student++;
                        }
                        else if (type == "standard")
                        {
                            standard++;
                        }
                        else if (type == "kid")
                        {
                            kid++;
                        }
                    }
                    sum++;
                }
                Console.WriteLine($"{name} - {100.0 * sum / ticket:f2}% full.");
                sum = 0;
                name = Console.ReadLine();
            }
            int totalTicket = student + standard + kid;
            Console.WriteLine($"Total tickets: {totalTicket}");
            Console.WriteLine($"{100.0 * student / totalTicket:f2}% student tickets.");
            Console.WriteLine($"{100.0 * standard / totalTicket:f2}% standard tickets.");
            Console.WriteLine($"{100.0 * kid / totalTicket:f2}% kids tickets.");



        }
    }
}
