using System;

namespace _02._Cat_Walking
    {
    internal class Program
        {
        static void Main(string[] args)
            {


            int minWalk = int.Parse(Console.ReadLine());
            int timesWalk = int.Parse(Console.ReadLine());
            double caloriesIn = double.Parse(Console.ReadLine());

            int totalMinWalk = minWalk * timesWalk;
            int caloriesBurn = totalMinWalk * 5;
            caloriesIn *= 0.5;
            if (caloriesBurn >= caloriesIn)
                {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurn}.");
                }
            else
                {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurn}.");
                }
            }
        }
    }
