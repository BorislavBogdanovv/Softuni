using System;
using System.Linq;

namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Initialize empty field
            int n = int.Parse(Console.ReadLine());      //Field size

            int[] field = new int[n];

            // bool[] boolField = new bool[n];  //Empty -> False, LadyBug -> True  (друг начин за действие)

            //2. Spawn Ladybugs on the valid indexes
            int[] initialIndexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (int index in initialIndexes)
            {
                if (index >= 0 && index < field.Length)
                {
                    field[index] = 1;
                }
            }

            //3. Proceed game moves (Start Game)
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int ladyBugIndex = int.Parse(cmdArgs[0]);

                string direction = cmdArgs[1];

                int flyLength = int.Parse(cmdArgs[2]);

                // 3.1 Validate ladyBug index is inside the field
                if (ladyBugIndex < 0 || ladyBugIndex >= field.Length)
                {
                    //Invalid index => Npthing happens
                    continue;
                }

                //3.2 Validate ladyBugIndex contains ladyBug
                if (field[ladyBugIndex] == 0)
                {
                    //There is no ladyBug (nothing happens)
                    continue;
                }

                //3.3 Try to procced move
                //Right -> ladyBugIndex + flyLength
                //Left -> ladyBugIndex - flyLength
                //First -> Out ladyBug starts flying => it removes from the field, it is in the air
                field[ladyBugIndex] = 0;
                if (direction == "left")
                {
                    flyLength *= -1;  //1 => -1
                }

                //0 Right 1 => 0 + 1 = 1
                //1 Left 1 => 1 + (-1) = 0
                int nextIndex = ladyBugIndex + flyLength;
                while (nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1)
                {
                    nextIndex +=  flyLength;
                }

                //There are 2 possibilities:
                //Variant a: nextIndex is calculated somewhere in the field
                //Variant b: nextIndex cannot be calculated in the field

                if (nextIndex < 0 || nextIndex >= field.Length)
                {
                    //Variant b : Outside of the field
                    continue;
                }

                //Variant a : Land the ladyBug on the valid next index
                field[nextIndex] = 1;
            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}
