using System;

namespace _07._Moving
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int widh = int.Parse (Console.ReadLine());
            int lenth = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            string num = Console.ReadLine();
            int box =0;
            int totalBox=0;
            int realSpace = widh * lenth * hight;
            int leftOver = 0;
            while (num != "Done")
                {
                box = int.Parse(num);
                totalBox+=box;
                leftOver = totalBox - realSpace;
                if (realSpace <= totalBox)
                    {                    
                    Console.WriteLine($"No more free space! You need {leftOver} Cubic meters more.");
                    break;
                    }
                num = Console.ReadLine();
                }
            if (num == "Done")
                {
                
                Console.WriteLine($"{Math.Abs(leftOver)} Cubic meters left.");
                }
            }
        }
    }
