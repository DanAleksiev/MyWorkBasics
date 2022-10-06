using System;

namespace _07.AreaofFigures
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            // формули за геометрични фигури !!!
            string Figure = Console.ReadLine();

            if (Figure == "square")
                {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine($"{area:f3}");
                }
            else if (Figure == "rectangle")
                {
                double SideA = double.Parse(Console.ReadLine());
                double SideB = double.Parse(Console.ReadLine());
                double result = SideA * SideB;
                Console.WriteLine($"{result:f3}");
                }
            else if (Figure == "circle")
                {
                double radius = double.Parse(Console.ReadLine());
                double result = radius * radius * Math.PI;
                Console.WriteLine($"{result:f3}");
                }
            else if (Figure == "triangle")
                {
                double lenghtSide = double.Parse(Console.ReadLine());
                double hightSide = double.Parse(Console.ReadLine());
                double resoult = hightSide * lenghtSide / 2 ;
                Console.WriteLine($"{resoult:f3}");
                }
            }
        }
    }
