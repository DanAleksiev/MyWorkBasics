using System;

namespace _08.LunchBreak
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string name = Console.ReadLine();
            double episodeLenght = int.Parse(Console.ReadLine());
            double brake = int.Parse(Console.ReadLine());

            double chillTime = brake / 4;
            double lunch = brake /  8;

            double timeNeeded = episodeLenght + chillTime + lunch;
            double leftOver = Math.Abs(brake - timeNeeded);
            if (brake - timeNeeded <= 0)
                {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(leftOver)} more minutes.");

                }
            else
                {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(leftOver)} minutes free time.");
                }


            }
        }
    }
