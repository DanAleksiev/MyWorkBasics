using System;

namespace _04.ToyShop
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double puzzle = 2.60;
            double doll = 3;
            double bear = 4.10;
            double miner = 8.20;
            double truck = 2;
            double rent = 0.1;

            double tripPrice = double.Parse(Console.ReadLine());
            int aPuzzles = int.Parse(Console.ReadLine());
            int aDoll = int.Parse(Console.ReadLine());
            int aBear = int.Parse(Console.ReadLine());
            int aMiner = int.Parse(Console.ReadLine());
            int aTruck = int.Parse(Console.ReadLine());

            double total = puzzle * aPuzzles + bear * aBear + doll * aDoll + miner * aMiner + truck * aTruck;
            int aToys = aBear + aDoll + aMiner + aTruck + aPuzzles;


             if (aToys >= 50)
                {
                double discount = total * 0.25;
                total = total - discount;
                }


            rent = total * rent;
            double leftOvers = total - rent;
            
                
            if (leftOvers >= tripPrice)
                {
                leftOvers= leftOvers- tripPrice;
                Console.WriteLine($"Yes! {leftOvers:f2} lv left.");
                }
            else if (leftOvers < tripPrice)
                {
                leftOvers = tripPrice-leftOvers;
                Console.WriteLine($"Not enough money! {leftOvers:f2} lv needed.");
                }


            }
        }
    }
