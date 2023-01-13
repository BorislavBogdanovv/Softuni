string[] expression = Console.ReadLine()
    .Split(" ");

Stack<string> stack = new Stack<string>();

char command = ' ';

int count = 0;

for (int i = expression.Length - 1; i >= 0; i--)
{
    stack.Push(expression[i]);
}

while (stack.Count != 0)
{
    if (stack.Peek() != "+" && stack.Peek() != "-")
    {
        if (count == 0)
        {
            count += int.Parse(stack.Pop());
        }
        else
        {
            if (command == '+')
            {
                count += int.Parse(stack.Pop());
            }
            else if (command == '-')
            {
                count -= int.Parse(stack.Pop());
            }
        }
    }
    else
    {
        if (stack.Peek() != "+")
        {
            command = char.Parse(stack.Pop());
        }
        else if (stack.Peek() != "-")
        {
            command = char.Parse(stack.Pop());
        }
    }

}

Console.WriteLine(count);


