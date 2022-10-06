using System;

namespace _02._Spaceship
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double widh = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double austronaftAvHight = double.Parse(Console.ReadLine());
            double roomWidh = 2;
            double roomlenght = 2;
            double roomHight = austronaftAvHight + 0.40;
            double roomObem = roomHight * roomlenght * roomWidh;
            double obem = widh * lenght * hight;
            double space = Math.Floor(obem / roomObem);

            if (space >=3 &&space <= 10)
                {
                Console.WriteLine($"The spacecraft holds {space} astronauts.");
                }
            else if (space < 3)
                {
                Console.WriteLine("The spacecraft is too small.");
                }
            else
                {
                Console.WriteLine("The spacecraft is too big.");
                }
            }
        }
    }
