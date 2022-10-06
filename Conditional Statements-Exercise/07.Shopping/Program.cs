using System;

namespace _07.Shopping
    {
    internal class Program
        {
        static void Main(string[] args)
            {            

            double budgete = double.Parse(Console.ReadLine());
            int videoCardsAmount = int.Parse(Console.ReadLine());
            int procesoreAmount = int.Parse(Console.ReadLine());
            int ramAmount = int.Parse(Console.ReadLine());

            double videoCardsPrice = videoCardsAmount * 250;
            double procesorPrice =  (videoCardsPrice * 0.35) * procesoreAmount;
            double ramPrice = (videoCardsPrice * 0.1) * ramAmount;

            double totalPrice = ramPrice + procesorPrice + videoCardsPrice;


            if (videoCardsAmount > procesoreAmount)
                {
                totalPrice -= totalPrice * 0.15;
                }

            if (budgete >= totalPrice)
                {
                double leftOver = (budgete - totalPrice); 
                Console.WriteLine($"You have {leftOver:f2} leva left!");
                }
            else
                {
                double leftOver= (totalPrice-budgete);
                Console.WriteLine($"Not enough money! You need {leftOver:f2} leva more!");
                }

            }
        }
    }
