using System;
using System.Collections.Generic;

int lightDuration = int.Parse(Console.ReadLine());
int freeWindow = int.Parse(Console.ReadLine());

Queue<string> waitingCars = new Queue<string>();

int carsPassedCounter = 0;

string command;
while ((command = Console.ReadLine()) != "END")
{

    int passCounter = lightDuration + freeWindow;

    if (command != "green")
    {
        waitingCars.Enqueue(command);
    }
    else
    {
        for (int i = 0; i < waitingCars.Count; i++)
        {
            string car = waitingCars.Dequeue();

            int carCounter = car.Length;

            if (carCounter <= passCounter)
            {
                for (int r = 0; r < car.Length; r++)
                {
                    passCounter--;
                }
            }
            else
            {
                for (int l = 0; l < car.Length; l++)
                {
                    if (passCounter == 0)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{car} was hit at {car[l]}.");
                        return;
                    }

                    passCounter--;
                }
            }

            if (passCounter <= freeWindow)
            {
                carsPassedCounter++;
                break;
            }
            carsPassedCounter++;
            i = -1;
        }
    }
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{carsPassedCounter} total cars passed the crossroads.");
