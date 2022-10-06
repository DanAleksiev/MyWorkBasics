using System;

namespace _05._Salary
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int tabs = int.Parse(Console.ReadLine());
            int pay = int.Parse(Console.ReadLine());

            for (int i = 1; i <= tabs; i++)
                {
                string sites=Console.ReadLine();

                switch (sites)
                    {
                    case "Facebook":
                    pay -= 150;
                    break;
                    case "Instagram":
                    pay -= 100;
                    break;
                    case "Reddit":
                    pay -= 50;
                    break;                  
                    }

                if (pay == 0)
                    {
                    Console.WriteLine("You have lost your salary.");
                    break;
                    }
                }
            if (pay > 0)
                {
                Console.WriteLine(pay);
                }
            }
        }
    }
