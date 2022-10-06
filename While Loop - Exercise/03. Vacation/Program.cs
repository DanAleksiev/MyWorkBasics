using System;

namespace _03._Vacation
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double need = double.Parse(Console.ReadLine());
            double startingSavings = double.Parse(Console.ReadLine());

            int day = 0;
            int daysSpend = 0;

            while (startingSavings < need) 
                {
    
                string activity = Console.ReadLine();
                double deposit = double.Parse(Console.ReadLine());
                day++;

                if (activity == "spend")
                    {
                    daysSpend++;
                    startingSavings -= deposit;
                    if (startingSavings < 0)
                        {
                        startingSavings = 0;
                        }
                    if (daysSpend == 5)
                        {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(day);
                        break;
                        }
                    }

                if (activity == "save")
                    {
                    startingSavings += deposit;
                    daysSpend = 0 ;

                    if (startingSavings >= need)
                        {
                        Console.WriteLine($"You saved the money for {day} days.");
                        break;
                        }
                    }
                }
            }
        }
    }
