using System;

namespace _01.Cinema
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double premiere = 12;
            double normal = 7.50;
            double discout = 5;
            string tipe = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double income = 0;

            if(tipe == "Premiere")
                {
                income = rows * colums * premiere;
                }
            else if (tipe == "Normal")
                {
                income = rows * colums * normal;
                }
            else if (tipe == "Discount")
                {
                income = rows * colums * discout;
                }
            Console.WriteLine($"{income:f2} leva");
            }
        }
    }
