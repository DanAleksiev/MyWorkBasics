using System;

namespace _01.Oscars
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int amountpaper = int.Parse(Console.ReadLine());
            int abountcloth = int.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double paperPrice = amountpaper * 5.80;
            double clothPrice = abountcloth * 7.20;
            double gluePrice = glue * 1.20;
            discount = discount / 100;

            double total = clothPrice + gluePrice + paperPrice;
            total -= total * discount;
            Console.WriteLine($"{total:f3}");
            }
        }
    }
