using System;

namespace _07.HotelRoom
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string mount = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice=0;

            switch (mount)
                {
                case "May":
                case "October":

                studioPrice = 50;
                apartmentPrice = 65;

                if (days > 7 && days <=14)
                    {
                    studioPrice -= studioPrice * 0.05;
                    }
                else if (days > 14)
                    {
                    studioPrice -= studioPrice * 0.30;
                    }
                break;

                case "June":
                case "September":
                studioPrice = 75.20;
                apartmentPrice = 68.70;               
                if (days > 14)
                    {
                    studioPrice -= studioPrice * 0.20;
                    }
                break;

                case "July":
                case "August":
                studioPrice = 76;
                apartmentPrice = 77;
                break;
                }

            double sTotal = days * studioPrice;
            double aTotal = days * apartmentPrice;
            if (days > 14)
                {
                aTotal -= aTotal * 0.10;
                }


            Console.WriteLine($"Apartment: {aTotal:f2} lv.");
            Console.WriteLine($"Studio: {sTotal:f2} lv.");
            }
        }
    }
