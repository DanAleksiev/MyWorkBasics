using System;

namespace _08.OnTimefortheExam
    {
    internal class Program
        {
        static void Main(string[] args)
            {

            int hoursForAssignment = int.Parse(Console.ReadLine());
            int minutesForAssignment = int.Parse(Console.ReadLine());
            int arrivalHours = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int assignmetTotal = hoursForAssignment * 60 + minutesForAssignment;
            int arrivingTotal = arrivalHours * 60 + arrivalMinutes;
            int difference = assignmetTotal - arrivingTotal;

            if (difference >= 0 && difference <= 30)
                {
                Console.WriteLine("On time");
                if (difference != 0)
                    {
                    Console.WriteLine($"{difference} minutes before the start");
                    }
                }

            else if (difference > 30)
                {
                Console.WriteLine("Early");
                if (difference >= 1 && difference < 60)
                    {
                    Console.WriteLine($"{difference} minutes before the start");
                    }
                else
                    {
                    int hourEarly = difference / 60;
                    int minuteEarly = difference % 60;
                    Console.WriteLine($"{hourEarly}:{minuteEarly:d2} hours before the start");
                    }
                }

            else if (difference < 0)
                {
                Console.WriteLine("Late");
                if (difference > -60)
                    {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                    }
                else if (difference <= -60)
                    {
                    int minLate=difference % 60;
                    int hourLate=difference / 60;
                    Console.WriteLine($"{Math.Abs(hourLate)}:{Math.Abs(minLate):d2} hours after the start");
                    }
                }
            }
        }
    }
