using System;

namespace _06._Building
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int floor = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            for (int currentFloor = floor; currentFloor >= 1; currentFloor--)
                {
                for (int currentRoom = 0; currentRoom < num; currentRoom++)
                    {
                    if (currentFloor == floor)
                        {
                        Console.Write($"L{currentFloor}{currentRoom} ");
                        }
                    else if (currentFloor %2 == 0)
                        {
                        Console.Write($"O{currentFloor}{currentRoom} ");
                        }
                    else
                        {
                        Console.Write($"A{currentFloor}{currentRoom} ");
                        }                  
                    }
                Console.WriteLine();
                } 
            }
        }
    }
