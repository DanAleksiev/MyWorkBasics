using System;

namespace _05._Account_Balance
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            double money = 0;
            
            while (input != "NoMoreMoney")
                {
                double increse = double.Parse(input);
 
                if (increse < 0)
                    {
                    Console.WriteLine($"Invalid operation!");
                    break;
                    }

                Console.WriteLine($"Increase: {increse:f2}");
                money += increse;
                input = Console.ReadLine();
                }
            Console.WriteLine($"Total: {money:f2}");
            }
        }
    }
