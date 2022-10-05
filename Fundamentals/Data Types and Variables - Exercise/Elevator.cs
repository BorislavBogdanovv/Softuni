using System;
using System.ComponentModel;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = 0;

            courses = people / capacity;

            if (people % capacity != 0)
            {
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}
