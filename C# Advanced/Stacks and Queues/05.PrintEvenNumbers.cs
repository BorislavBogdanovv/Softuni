int[] array = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new Queue<int>();

Queue<int> newQueue = new Queue<int>();

foreach (var number in array)
{
    queue.Enqueue(number);
}

while(queue.Count != 0)
{
    int currNumber = queue.Dequeue();

    if (currNumber % 2 == 0)
    {
        newQueue.Enqueue(currNumber);
    }
}

Console.WriteLine(String.Join(", ", newQueue));
