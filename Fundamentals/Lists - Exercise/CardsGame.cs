using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayer = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int currCard1 = 0;

            int currCard2 = 0;

            bool flag = true;

            while (flag)
            {

                currCard1 = firstPlayer[0];

                currCard2 = secondPlayer[0];


                if (currCard1 > currCard2)
                {
                    firstPlayer.Add(currCard2);
                    firstPlayer.Add(currCard1);
                    DeleteCards(firstPlayer, secondPlayer);

                }
                else if (currCard1 < currCard2)
                {
                    secondPlayer.Add(currCard1);
                    secondPlayer.Add(currCard2);
                    DeleteCards(firstPlayer, secondPlayer);
                }
                else
                {
                    DeleteCards(firstPlayer, secondPlayer);
                }

                if (firstPlayer.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum(i => i)}");
                    flag = false;
                }
                else if (secondPlayer.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum(i => i)}");
                    flag = false;
                }
            }

        }

        static void DeleteCards(List<int> firstPlayer, List<int> secondPlayer)
        {
            firstPlayer.RemoveAt(0);
            secondPlayer.RemoveAt(0);
        }
    }
}
