using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _25._Lab_29_Regular_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(\.|\-|\/)(?<month>[A-Z][a-z]+)\1(?<year>\d{4})\b";

            string dates = Console.ReadLine();


            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(dates);

            foreach (Match item in matchCollection)
            {
                string day = item.Groups["day"].Value;
                string month = item.Groups["month"].Value;
                string year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
