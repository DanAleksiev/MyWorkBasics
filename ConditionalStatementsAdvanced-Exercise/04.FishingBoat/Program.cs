using System;

namespace _04.FishingBoat
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            double rent = 0;
            double discount = 0;
            double total = 0; 

            switch (season)
                {
                case"Spring":
                rent = 3000;
                break;
                case "Summer":
                case "Autumn":
                rent = 4200;
                break;
                case"Winter":
                rent = 2600;
                break;
                }

            if (num <= 6)
                {
                discount = 0.10;
                }
            else if (num >= 7 && num <= 11)
                {
                discount = 0.15;
                }
            else if (num >= 12)
                {
                discount = 0.25;
                }

            total = rent - (rent * discount);

             if ( num % 2 == 0 && season != "Autumn" )
                {
                double aditionalDiscount = 0.05;
                total -= total * aditionalDiscount;
                }

            double leftOver = Math.Abs(budget - total);

            if (budget >= total)
                {
                Console.WriteLine($"Yes! You have {leftOver:f2} leva left.");
                }

            else if (budget < total)
                {
                Console.WriteLine($"Not enough money! You need {leftOver:f2} leva.");
                }
            }
        }
    }
