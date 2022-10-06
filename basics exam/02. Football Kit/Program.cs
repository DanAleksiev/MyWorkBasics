using System;

namespace _02._Football_Kit
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double target = double.Parse(Console.ReadLine());

            double shorts =tshirtPrice * 0.75;
            double socks = shorts * 0.20;
            double shoues = (shorts + tshirtPrice) * 2;
            double discount = 0.15;
            double total = tshirtPrice + shorts + socks + shoues;
            total -= total * discount;
            if (total >= target)
                {
                Console.WriteLine($"Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {total:f2} lv.");
                }
            else
                {
                double difrence = target - total;
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {difrence:f2} lv. more.");
                }

            }
        }
    }
