using System;

namespace _05._Puppy_Care
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int dogfood = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            dogfood *= 1000;
            int consumed = 0;
            int leftover = 0;
            while (input != "Adopted")
                {
                consumed += int.Parse(input);
                input = Console.ReadLine();
                }
            if (consumed > dogfood)
                {
                leftover = consumed - dogfood;
                Console.WriteLine($"Food is not enough. You need {leftover} grams more.");
                }
            else
                {
                leftover = dogfood - consumed;
                Console.WriteLine($"Food is enough! Leftovers: {leftover} grams.");
                }
            }
        }
    }
