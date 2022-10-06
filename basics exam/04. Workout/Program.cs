using System;

namespace _04._Workout
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int days = int.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double target = 0;
            double total = meters;
            double newMeters = meters;
            for (int i = 1; i <= days; i++)
                {
                double extent = double.Parse(Console.ReadLine());

                double exProcent = extent / 100;
                target = newMeters + newMeters * exProcent;
                newMeters = target;
                total += target;
                }
            if (total >= 1000)
                {
                double more = total - 1000;
                Console.WriteLine($"You've done a great job running {Math.Ceiling(more)} more kilometers!");
                }
            else
                {
                double less =1000 - total;
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(less)} more kilometers");
                }
            }

        }
    }
