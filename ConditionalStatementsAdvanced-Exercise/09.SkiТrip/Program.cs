using System;

namespace _09.SkiТrip
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double room = 18;
            double apartment = 25;
            double presidentA = 35;

            int days = int.Parse(Console.ReadLine());
            string tipe = Console.ReadLine();
            string evaluation = Console.ReadLine();

            double nights = days - 1;
            double evDiscount = 0;
            double total=0;

            switch (tipe)
                {
                case "room for one person":
                total = room * nights;
                break;
                case "apartment":
                if (days < 10)
                    {
                    total = apartment * nights;
                    total -= total * 0.30;
                    }
                else if (days >= 10&& days <=15)
                    {
                    total = apartment * nights;
                    total -= total * 0.35;
                    }
                else if (days > 15)
                    {
                    total = apartment * nights;
                    total -= total * 0.50;
                    }
                break;
                case "president apartment":
                if (days < 10)
                    {
                    total = presidentA * nights;
                    total -= total * 0.1;
                    }
                else if (days >= 10 && days <= 15)
                    {
                    total = presidentA * nights;
                    total -= total * 0.15;
                    }
                else if (days > 15)
                    {
                    total = presidentA * nights;
                    total -= total * 0.2;
                    }
                break;
                }

            switch (evaluation)
                {
                case "positive":
                total += total *  0.25;
                break;
                case "negative":
                total -= total * 0.1;
                break;
                }
            Console.WriteLine($"{total:f2}");
            }
        }
    }
