using System;
using System.Linq;
using System.Text.RegularExpressions;

Func<string, int, bool> checkEqualOrLargerNameSum = (name, sum) => // => name.Sum(ch => ch) >= sum; -> може и само това, без
{                                                                  // скобите { } отдолу; 
    int charsSum = name.Sum(ch => ch);
    return charsSum >= sum;
};

Func<string[], int, Func<string, int, bool>, string> getFirstName = (names, sum, match) =>
// => names.FirstOrDefault(name => match(name, sum)); -> същото като горе!
{
    foreach (var name in names)
    {
        if (match(name, sum))
        {
            return name;
        }
    }
    return null;
};

int sum = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine(getFirstName(names, sum, checkEqualOrLargerNameSum));
