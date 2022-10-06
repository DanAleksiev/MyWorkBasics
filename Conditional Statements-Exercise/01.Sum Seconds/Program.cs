using System;

namespace _01.Sum_Seconds
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;
            int minutes = totalTime / 60; //инт е без цяло число
            int seconds = totalTime % 60; //остатъка

            if (seconds < 10)
                {
                Console.WriteLine(minutes + ":0" + seconds);

                }
            else
                {
                Console.WriteLine(minutes + ":" + seconds);
                }
            }
        }
    }
