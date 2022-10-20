using System;

namespace _5WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            string n = Console.ReadLine();

            while (n != "Stop")
            {

                Console.WriteLine(n);
                n = Console.ReadLine();
            }

        }
    }
}

