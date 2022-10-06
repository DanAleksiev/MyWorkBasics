using System;

namespace _04._Walking
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int target = 10000;
            string steps = Console.ReadLine();
            int stepCount = 0;

            while (steps != "Going home")
                {
                stepCount += int.Parse(steps);
                
                if (stepCount >= target)
                    {
                    int more = stepCount - target;
                    Console.WriteLine($"Goal reached! Good job!\r\n{more} steps over the goal!");
                    break;
                    }
                steps = Console.ReadLine();
                }

            if  (steps == "Going home")
                {
                steps = Console.ReadLine();
                stepCount += int.Parse(steps);
                if (stepCount >= target)
                    {
                    int more = stepCount - target;
                    Console.WriteLine($"Goal reached! Good job!\r\n{more} steps over the goal!");                   
                    }
                else
                    {
                    int more = target - stepCount;
                    Console.WriteLine($"{more} more steps to reach goal.");
                    }
                }
            }
        }
    }
