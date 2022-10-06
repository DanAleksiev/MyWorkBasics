using System;

namespace _08.BasketballEquipment
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int YearlyTax=int.Parse(Console.ReadLine());
            double Shoes = YearlyTax * 0.60;
            double Clothes = Shoes * 0.80;
            double Ball = Clothes / 4;
            double Accesories = Ball / 5;
            double total = YearlyTax + Shoes + Clothes + Ball + Accesories;
            Console.WriteLine(total);

            }
        }
    }
