using System;

namespace DefiningClasses;

public class StartUp
{
    private static void Main(string[] args)
    {
        Person person = new Person(18);

        Console.WriteLine($"{person.Name} is {person.Age} years old");
    }
}