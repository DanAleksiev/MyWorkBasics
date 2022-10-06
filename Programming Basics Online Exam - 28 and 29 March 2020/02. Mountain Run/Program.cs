using System;

namespace _02._Mountain_Run
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double slow = Math.Floor(distance / 50)*30;
            double totalTime = (distance * time) + slow ;

            if (totalTime >= record)
                {
                double slower = totalTime - record ;
                Console.WriteLine($"No! He was {slower:f2} seconds slower.");
                }
            else
                {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
                }

            }
        }
    }
