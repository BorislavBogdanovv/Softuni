using System;
using System.Collections.Generic;

namespace Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] studentArgs = command
                    .Split(' ');

                string firstName = studentArgs[0];
                string lastName = studentArgs[1];
                int age = int.Parse(studentArgs[2]);
                string homeTown = studentArgs[3];

                if (ExistingStudent(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    Student student = new Student(firstName, lastName, age, homeTown);
                    students.Add(student);
                }
            }

            string cityName = Console.ReadLine();

            for (int i = 0; i < students.Count; i++)
            {
                Student currStudent = students[i];

                if (cityName == currStudent.HomeTown)
                {
                    Console.WriteLine($"{currStudent.FirstName} {currStudent.LastName} is {currStudent.Age} years old.");
                }
            }
        }

        static bool ExistingStudent(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (firstName == student.FirstName && lastName == student.LastName)
                {
                    return true;
                }
            }
            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
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
