using System;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int max = int.MinValue;
            

            while (command != "Stop")
            {
                int num = int.Parse(command);

                if (num > max)
                {
                    max = num;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(max);
        }
    }
}
