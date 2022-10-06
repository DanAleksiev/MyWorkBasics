using System;

namespace _05._Coins
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double change = double.Parse(Console.ReadLine());
            int coins = 0;
            double sum = Math.Floor(change *= 100);
            
            while (sum != 0)
                {
                if (sum >= 200)
                    {
                    coins++;
                    sum -= 200;
                    }
                else if (sum >= 100)
                    {
                    coins++;
                    sum -= 100;
                    }
                else if (sum >= 50)
                    {
                    coins++;
                    sum -= 50;
                    }
                else if (sum >= 20)
                    {
                    coins++;
                    sum -= 20;
                    }
                else if (sum >= 10)
                    {
                    coins++;
                    sum -= 10;
                    }
                else if (sum >= 5)
                    {
                    coins++;
                    sum -= 5;
                    }
                else if (sum >= 2)
                    {
                    coins++;
                    sum -= 2;
                    }
                else if (sum >= 1)
                    {
                    coins++;
                    sum -= 1;
                    }
                }
            Console.WriteLine(coins);         
            }
        }
    }
