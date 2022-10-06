using System;

namespace _03.NewHouse
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string flowers = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            double total = 0;

            switch (flowers)
                {
                case "Roses":
                price = 5;
                break;
                case "Dahlias":
                price = 3.80;
                break;
                case "Tulips":
                price = 2.80;
                break;
                case "Narcissus":
                price = 3.00;
                break;
                case "Gladiolus":
                price = 2.50;
                break;
                }
            total = price * amount;

            if (flowers == "Roses"&& amount >80)
                {
                total *= 0.90;
                }
            else if (flowers == "Dahlias" && amount > 90)
                {
                total *= 0.85;
                }
            else if (flowers == "Tulips"&& amount>80)
                {
                total *= 0.85;
                }
            else if (flowers == "Narcissus" && amount < 120)
                {
                total *= 1.15;
                }
            else if (flowers == "Gladiolus"&& amount < 80)
                {
                total *= 1.20;
                }

            double leftOver = Math.Abs(total - budget);
            if (budget >= total)
                {
                Console.WriteLine($"Hey, you have a great garden with {amount} {flowers} and {leftOver:f2} leva left.");
                }
            else if (budget <= total)
                {
                Console.WriteLine($"Not enough money, you need {leftOver:f2} leva more.");
                }
            }
        
        }
    }
