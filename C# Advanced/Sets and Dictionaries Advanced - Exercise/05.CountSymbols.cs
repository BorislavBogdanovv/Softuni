using System;
using System.Collections.Generic;

SortedDictionary<char, int> charsCount = new SortedDictionary<char, int>();

string input = Console.ReadLine();

foreach (var ch in input)
{
	if (!charsCount.ContainsKey(ch))
	{
		charsCount.Add(ch, 0);
	}

	charsCount[ch]++;
}

foreach (var charCounts in charsCount)
{
	Console.WriteLine($"{charCounts.Key}: {charCounts.Value} time/s");
}
