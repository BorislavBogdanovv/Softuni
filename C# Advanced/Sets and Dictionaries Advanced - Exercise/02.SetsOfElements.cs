using System;
using System.Collections.Generic;
using System.Linq;

HashSet<int> firstSet = new HashSet<int>();
HashSet<int> secondSet = new HashSet<int>();

int[] counts = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < counts[0]; i++)
{
    firstSet.Add(int.Parse(Console.ReadLine()));
}
for (int i = 0; i < counts[1]; i++)
{
    secondSet.Add(int.Parse(Console.ReadLine()));
}

firstSet.IntersectWith(secondSet);

Console.WriteLine(string.Join(" ", firstSet));
