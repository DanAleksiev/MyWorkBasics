using System;

namespace _03._Football_Souvenirs
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string team = Console.ReadLine();
            string item = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            double price = 0;
            if (team == "Argentina")
                {
                if (item == "flags")
                    {
                    price = 3.25;
                    }
                else if (item == "caps")
                    {
                    price = 7.20;
                    }
                else if (item == "posters")
                    {
                    price = 5.10;
                    }
                else if (item == "stickers")
                    {
                    price = 1.25;
                    }
                else
                    {
                    Console.WriteLine("Invalid stock!");
                    }
                }
            else if (team == "Brazil")
                {
                if (item == "flags")
                    {
                    price = 4.20;
                    }
                else if (item == "caps")
                    {
                    price = 8.50;
                    }
                else if (item == "posters")
                    {
                    price = 5.35;
                    }
                else if (item == "stickers")
                    {
                    price = 1.20;
                    }
                else
                    {
                    Console.WriteLine("Invalid stock!");                   
                    }
                }
            else if (team == "Croatia")
                {
                if (item == "flags")
                    {
                    price = 2.75;
                    }
                else if (item == "caps")
                    {
                    price = 6.90;
                    }
                else if (item == "posters")
                    {
                    price = 4.95;
                    }
                else if (item == "stickers")
                    {
                    price = 1.10;
                    }
                else
                    {
                    Console.WriteLine("Invalid stock!");
                    }

                }
            else if (team == "Denmark")
                {
                if (item == "flags")
                    {
                    price = 3.10;
                    }
                else if (item == "caps")
                    {
                    price = 6.50;
                    }
                else if (item == "posters")
                    {
                    price = 4.80;
                    }
                else if (item == "stickers")
                    {
                    price = 0.90;
                    }
                else
                    {
                    Console.WriteLine("Invalid stock!");

                    }
                }
            else
                {
                Console.WriteLine("Invalid country!");
                }
            double totalPrice = price * amount;
            if (totalPrice < 1)
                {
                Console.WriteLine();
                }
            else if (team != "Argentina" || team != "Brazil" || team != "Croatia" || team != "Denmark")
                {
                Console.WriteLine($"Pepi bought {amount} {item} of {team} for {totalPrice:f2} lv.");
                }
            else
                {
                Console.WriteLine("Invalid country!");
                }
            }
        }
    }
