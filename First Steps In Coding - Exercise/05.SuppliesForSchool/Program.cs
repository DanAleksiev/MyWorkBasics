using System;

namespace _05.SuppliesForSchool
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double Pens = 5.80;
            double Markers = 7.20;
            double cleaner = 1.2;
            int PacksPens = int.Parse(Console.ReadLine());
            int PacksMarkers = int.Parse(Console.ReadLine());
            int LitersOfCleaner = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double discProcent = discount / 100;
            double cast = Pens * PacksPens + Markers * PacksMarkers + cleaner * LitersOfCleaner;
            double totalDiscount = cast*discProcent;
            Console.WriteLine(cast-totalDiscount);
            }
        }
    }
