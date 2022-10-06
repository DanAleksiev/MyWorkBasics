using System;

namespace _05.Journey
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double expanses = 0;
            string tipeTrip = "";

            if (budget <= 100)
                {
                if (season == "summer")
                    {
                    destination = "Bulgaria";
                    tipeTrip = "Camp";
                    expanses = budget * 0.3;
                    }
                else if (season == "winter")
                    {
                    destination = "Bulgaria";
                    tipeTrip = "Hotel";
                    expanses = budget * 0.7;
                    }
                }
            else if (budget >100 && budget <= 1000)
                {
                if (season == "summer")
                    {
                    destination = "Balkans";
                    tipeTrip = "Camp";
                    expanses = budget * 0.4;
                    }
                else if (season == "winter")
                    {
                    destination = "Balkans";
                    tipeTrip = "Hotel";
                    expanses = budget * 0.8;
                    }
                }
            else if (budget > 1000)
                {
                destination = "Europe";
                tipeTrip = "Hotel";
                expanses = budget * 0.9;
                }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{tipeTrip} - {expanses:f2}");


            }
        }
    }
