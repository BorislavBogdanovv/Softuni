using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(' ');

            List<Person> people = new List<Person>();

            while (commands[0] != "End")
            {
                var person = new Person(commands[0], commands[1], int.Parse(commands[2]));

                people.Add(person);

                commands = Console.ReadLine().Split(' ');
            }

            people.OrderBy(a => a.Age).ToList().ForEach(person => Console.WriteLine(person));
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get; set; }

        public string Id { get; set; } 

        public int Age { get; set; }

        public override string ToString() => $"{Name} with ID: {Id} is {Age} years old.";
    }
}
