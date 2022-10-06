using System;

namespace basic_exam_oficial
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double avarageSpeed = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            double distance = 384400 * 2;
            double time = Math.Ceiling(distance / avarageSpeed);
            time += 3;
            double fConsumption = (fuel * distance) / 100;
            Console.WriteLine(time);
            Console.WriteLine(fConsumption);
            }
        }
    }
