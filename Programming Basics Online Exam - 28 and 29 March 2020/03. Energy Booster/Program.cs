using System;

namespace _03._Energy_Booster
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            string size = Console.ReadLine();
            int orders = int.Parse(Console.ReadLine());
            double price = 0;
            double total = 0;
            double discount = 0;
            if (input == "Watermelon")
                {
                if (size == "big")
                    {
                    price = 28.70;
                    }

                else if (size == "small")
                    {
                    price = 56;
                    }
                }
            else if (input == "Mango")
                {
                if (size == "big")
                    {
                    price = 19.60;
                    }

                else if (size == "small")
                    {
                    price = 36.66;
                    }
                }
            else if (input == "Pineapple")
                {
                if (size == "big")
                    {
                    price = 24.80;
                    }

                else if (size == "small")
                    {
                    price = 42.10;
                    }
                }
            else if (input == "Raspberry")
                {
                if (size == "big")
                    {
                    price = 15.20;
                    }

                else if (size == "small")
                    {
                    price = 20.00;
                    }
                }
            if (size == "big")
                {
                total = price * orders * 5;
                }
            else if (size == "small")
                {
                total = price * orders * 2;
                }

            if(total >= 400 && total <=1000)
                {
                discount = 0.15;
                total-=total *discount;
                }
            else if (total > 1000)
                {
                discount = 0.5;
                total -= total * discount;
                } 
            Console.WriteLine($"{total:F2} lv.");
            }
        }
    }

