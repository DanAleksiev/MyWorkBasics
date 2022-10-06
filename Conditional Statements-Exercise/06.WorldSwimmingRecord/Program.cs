using System;

namespace _06.WorldSwimmingRecord
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForMetter = double.Parse(Console.ReadLine());

            double lap = distance * timeForMetter;
            double delay = Math.Floor(distance / 15);
            double distTime = delay * 12.5;

            double ivanTime = lap + distTime;

            bool isRecordBeat = ivanTime < record;
            if (isRecordBeat)
                {
                Console.WriteLine($" Yes, he succeeded! The new world record is {ivanTime:f2} seconds.");
                }
            else
                {
                double notEnoughTime = Math.Abs (record-ivanTime) ;
                Console.WriteLine($"No, he failed! He was {notEnoughTime:f2} seconds slower.");
                }

            }
        }
    }
