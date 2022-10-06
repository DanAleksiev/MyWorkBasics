using System;

namespace _05._Small_Shop
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string produkt = Console.ReadLine();
            string grad = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double price = 0;
            double total = 0;
            switch (grad)
                {
                case "Sofia":
                switch (produkt)
                    {
                    case "coffee":
                    price = 0.50;
                    total = (price * amount);
                    Console.WriteLine(total);
                    break;
                    case "water":
                    price = 0.80;
                    total = (price * amount);
                    Console.WriteLine(total);
                    break;
                    case "beer":
                    price = 1.20;
                    total = (price * amount);
                    Console.WriteLine(total);
                    break;
                    case "sweets":
                    price = 1.45;
                    total = (price * amount);
                    Console.WriteLine(total);
                    break;
                    case "peanuts":
                    price = 1.60;
                    total = (price * amount);
                    Console.WriteLine(total);
                    break;
                    }
                break;

                case "Plovdiv":
                switch (produkt)
                    {
                    case "coffee":
                    price = 0.40;
                    total = (price * amount);
                    Console.WriteLine(total);
                    break;
                    case "water":
                    price = 0.70;
                    total = (price * amount);
                    Console.WriteLine(total);
                    break;
                    case "beer":
                    price = 1.15;
                    total = (price * amount);
                    Console.WriteLine(total);
                    break;
                    case "sweets":
                    price = 1.30;
                    total = (price * amount);
                    Console.WriteLine(total);
                    break;
                    case "peanuts":
                    price = 1.50;
                    total = (price * amount);
                    Console.WriteLine(total);
                    break;
                    }
                break ;

                case "Varna":
                switch (produkt)
                    {
                    case "coffee":
                    price = 0.45;
                    total = (price * amount);
                    Console.WriteLine(total);
                    break;
                    case "water":
                    price = 0.70;
                    total = (price * amount);
                    Console.WriteLine(total);
                    break;
                    case "beer":
                    price = 1.10;
                    total = (price * amount);
                    Console.WriteLine(total);
                    break;
                    case "sweets":
                    price = 1.35;
                    total = (price * amount);
                    Console.WriteLine(total);
                    break;
                    case "peanuts":
                    price = 1.55;
                    total = (price * amount);
                    Console.WriteLine(total);
                    break;
                    }
                break ;
                }
            }
        }
    }
