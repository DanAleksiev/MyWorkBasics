using System;

namespace _08._Graduation
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());
            double totalScore = 0;
            double avarage = 0;
            int fails = 0;
            int year = 1;

            while (year <= 12)
                {
                if (grade < 4)
                    {
                    fails++;
                    }

                if (fails == 2)
                    {
                    year--;
                    Console.WriteLine($"{name} has been excluded at {year} grade");
                    break;
                    }

                totalScore += grade;
                avarage = totalScore / year;
                year++;

                if (year > 12)
                    {
                    Console.WriteLine($"{name} graduated. Average grade: {avarage:f2}");
                    break;
                    }
                grade = double.Parse(Console.ReadLine());
                }
            }
        }
    }
