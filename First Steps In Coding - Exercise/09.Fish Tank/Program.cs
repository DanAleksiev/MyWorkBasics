using System;

namespace _09.Fish_Tank
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int lengt = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double water = lengt * width * height;
            double CuWater = water / 1000;
            double trueProcent = procent / 100;
            double TotalWater = CuWater * (1-trueProcent);

            Console.WriteLine(TotalWater);


            }
        }
    }
