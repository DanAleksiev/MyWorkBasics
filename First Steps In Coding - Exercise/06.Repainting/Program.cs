using System;

namespace _06.Repainting
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double naylon = 1.50;
            double paint = 14.50;
            double separator = 5.00;

            int NConsumped = int.Parse(Console.ReadLine());
            int PConsumed = int.Parse(Console.ReadLine());
            int SComsumed = int.Parse(Console.ReadLine());
            int Hours = int.Parse(Console.ReadLine());
            double Materials = naylon * (NConsumped + 2) + paint * (PConsumed + PConsumed * 0.10) + (separator * SComsumed) + 0.40;
            double Work = (Materials * 0.30)*Hours;
            Console.WriteLine(Materials + Work);


            }
        }
    }
