using System;
using System.Collections.Generic;
using System.Linq;

Stack<int> clothes = new Stack<int>(
    Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    );

int rackSize = int.Parse(Console.ReadLine());

int currRackSize = rackSize;

int numberOfRacks = 1;

while (clothes.Any())
{
    currRackSize -= clothes.Peek();

    if (currRackSize < 0)
    {
        currRackSize = rackSize;
        numberOfRacks++;

        continue;
    }

    clothes.Pop();
}

Console.WriteLine(numberOfRacks);
