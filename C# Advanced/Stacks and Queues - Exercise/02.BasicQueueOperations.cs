using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

int[] tokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int elementsToDequeue = tokens[1];
int number = tokens[2];

Queue<int> queue = new Queue<int>(numbers);  //we can put array numbers direct in queue 

for (int i = 0; i < elementsToDequeue; i++)
{
    queue.Dequeue();
}

if (queue.Contains(number))
{
    Console.WriteLine("true");
}
else
{
    if (queue.Any())  
    {
        Console.WriteLine(queue.Min());  
    }
    else
    {
        Console.WriteLine(0);
    }
}
