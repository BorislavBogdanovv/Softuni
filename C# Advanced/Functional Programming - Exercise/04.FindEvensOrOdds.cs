using System;
using System.Collections.Generic;
using System.Linq;

Func<int, int, List<int>> generateRange = (start, end) =>
{
    List<int> range = new List<int>();

    for (int i = start; i <= end; i++)
    {
        range.Add(i);
    }

    return range;
};

Predicate<int> match;

int[] range = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(r => int.Parse(r))
    .ToArray();

string command = Console.ReadLine();

List<int> numbers = generateRange(range[0], range[1]);

if (command == "even")
{
    match = number => number % 2 == 0;
}
else
{
    match = number => number % 2 != 0;

}

foreach (var number in numbers)
{
    if (match(number))
    {
        Console.Write($"{number} ");
    }
}
