﻿using System;

namespace _03.Time_15Minutes
    {
    internal class Program
        {
        static void Main(string[] args)
            {

            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            min += 15;

            if (min >= 60)
                {
                min -= 60;
                hour += 1;

                }
            if (hour == 24)
                {
                hour = 0 ;
                }
            if (min < 10)
                {
                Console.WriteLine($"{hour}:0{min}");
                }

            if (min >= 10)
                {
                Console.WriteLine($"{hour}:{min}");
                }
            // Console.WriteLine($"{hours}:{minutes:D2}"); може да се използва за съкращаване на последните два if кода
            }
        }
    }
