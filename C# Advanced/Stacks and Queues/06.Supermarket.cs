Queue<string> names = new Queue<string>();

string command = Console.ReadLine();
while (true)
{
    while (command != "Paid" && command != "End")
    {
        names.Enqueue(command);

        command = Console.ReadLine();
    }
    if (command == "Paid")
    {
        Console.WriteLine(String.Join(Environment.NewLine, names));

        names.Clear();

        command = Console.ReadLine();
    }
    if (command == "End")
    {
        Console.WriteLine($"{names.Count} people remaining.");
        break;
    }
}
