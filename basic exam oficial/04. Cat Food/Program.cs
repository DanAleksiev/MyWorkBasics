using System;

namespace _04._Cat_Food
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int numCats = int .Parse(Console.ReadLine());
            double food = 0; ;
            double foodPrice = 12.45;
            int g1 = 0;
            int g2 = 0;
            int g3 = 0;
            double totalFood=0;
            double totalPrice=0;

            while (numCats != 0)
                {
                food = double.Parse(Console.ReadLine());
                numCats--;
                if (food>=100&&food < 200)
                    {
                    g1++;
                    totalFood += food;
                    }
                else if (food>=200&&food < 300)
                    {
                    g2++;
                    totalFood+=food;
                    }
                else if (food >=300 && food < 400)
                    {
                    g3++;
                    totalFood += food;
                    }
                }
            totalPrice = (totalFood/1000) * foodPrice;
            Console.WriteLine($"Group 1: {g1} cats.");
            Console.WriteLine($"Group 2: {g2} cats.");
            Console.WriteLine($"Group 3: {g3} cats.");
            Console.WriteLine($"Price for food per day: {totalPrice:f2} lv.");
            }
        }
    }
