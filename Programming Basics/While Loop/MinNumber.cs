using System;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int min = int.MaxValue;
            

            while (command != "Stop")
            {
                int num = int.Parse(command);

                if (num < min)
                {
                    min = num;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(min);
        }
    }
}
