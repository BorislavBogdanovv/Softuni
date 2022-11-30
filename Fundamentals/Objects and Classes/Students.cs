using System;
using System.Collections.Generic;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] studentArgs = command
                    .Split(' ');

                string firstName = studentArgs[0];
                string lastName = studentArgs[1];
                int age = int.Parse(studentArgs[2]);
                string homeTown = studentArgs[3];

                Students student = new Students(firstName, lastName, age, homeTown);

                students.Add(student);

            }

            string cityName = Console.ReadLine();

            for (int i = 0; i < students.Count; i++)
            {
                Students currStudent = students[i];

                if (cityName == currStudent.HomeTown)
                {
                    Console.WriteLine($"{currStudent.FirstName} {currStudent.LastName} is {currStudent.Age} years old.");
                }
            }
        }
    }

    public class Students
    {
        public Students(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
