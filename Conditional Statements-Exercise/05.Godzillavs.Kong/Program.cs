using System;

namespace _05.Godzillavs.Kong
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double budget = double.Parse(Console.ReadLine());
            int numStatist = int.Parse(Console.ReadLine());
            double priceForOutfit = double.Parse(Console.ReadLine());
            double decore =  budget * 0.1;
            double spare = 0;
            priceForOutfit *= numStatist;

            if (numStatist >= 150)
                {
                priceForOutfit -= priceForOutfit * 0.1; 
                }

            double expanses = priceForOutfit + decore;

            if (expanses > budget)
                {
                spare = expanses-budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {spare:f2} leva more.");
                }
            if (expanses <= budget)
                {
                spare = budget - expanses;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {spare:f2} leva left.");
                }
            }
        }
    }
