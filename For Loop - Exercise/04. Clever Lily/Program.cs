using System;

namespace _04._Clever_Lily
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int years = int.Parse(Console.ReadLine());
            double washer = double.Parse(Console.ReadLine());
            int toys = int.Parse(Console.ReadLine());
            double savings = 0;
            int even = 0;
            int amoutToys = 0;

            for (int i = 1; i <= years; i++)
                {
                if (i % 2 == 0)
                    {
                    even++;
                    savings += 10 * even;

                    }
                else
                    {
                    amoutToys++;
                    }
                }
            double toysPrice = amoutToys * toys;
            double totalSavings = savings + toysPrice;
            double total = (totalSavings - even) - washer ;
            if (totalSavings >= washer)
                {
                Console.WriteLine($"Yes! {Math.Abs(total):f2}");
                }
            else
                {
                Console.WriteLine($"No! {Math.Abs(total):f2}");
                }
            }
        }
    }
