using System;

namespace _06._Gold_Mine
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int locations = int.Parse (Console.ReadLine());
            double expectedGold = 0;
            int days = 0;
            double actualGold=0;
            double totalGold = 0;
            double diference = 0;
            int totalDays;
            while(locations != 0)
                {
                locations--;
                expectedGold=double.Parse (Console.ReadLine());
                days= int.Parse (Console.ReadLine());
                totalDays = days;
                while (days != 0)
                    {
                    actualGold = double.Parse (Console.ReadLine());
                    totalGold+=actualGold;
                    days--;
                    }
                diference = totalGold/totalDays;
                if (diference >= expectedGold)
                    {
                    Console.WriteLine($"Good job! Average gold per day: {diference:F2}.");
                    }
                else
                    {
                    Console.WriteLine($"You need {expectedGold-diference:f2} gold.");
                    }
                totalGold = 0;
                }
            }
        }
    }
