using System;

namespace _03._Excursion_Calculator
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;
            double discount = 0;

            if (season == "spring")
                {
                if (people <= 5)
                    {
                    price = 50.00;
                    }
                else if (people > 5)
                    {
                    price = 48.00;
                    }
                }
            else if (season == "summer") //discount
                {
                discount = 0.15;
                if (people <= 5)
                    {
                    price = 48.50;
                    price -= price * discount;
                    }
                else if (people > 5)
                    {
                    price = 45.00;
                    price -= price * discount;
                    }
                }
            else if (season == "autumn")
                {
                if (people <= 5)
                    {
                    price = 60.00;
                    }
                else if (people > 5)
                    {
                    price = 49.50;
                    }
                }
            else if (season == "winter")//discount
                {
                discount = 0.08;
                if (people <= 5)
                    {
                    price = 86.00;
                    price += price * discount;
                    }
                else if (people > 5)
                    {
                    price = 85.00; 
                    price +=  price * discount;
                    }
                }
            double total = price * people;
            Console.WriteLine($"{total:f2} leva.");
            }
        }
    }
