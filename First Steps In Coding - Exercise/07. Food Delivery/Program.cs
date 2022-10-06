using System;

namespace _07._Food_Delivery
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double chicen = 10.35;
            double fish = 12.40;
            double veg = 8.15;
            double delivary = 2.50;

            double chickenAM = double.Parse(Console.ReadLine());
            double fishAM = double.Parse(Console.ReadLine());
            double vegAM = double.Parse(Console.ReadLine());

            double food = chicen * chickenAM + fish * fishAM + veg * vegAM;
            double desert = food * 0.20;
            Console.WriteLine(desert+food+delivary);
            }
        }
    }
