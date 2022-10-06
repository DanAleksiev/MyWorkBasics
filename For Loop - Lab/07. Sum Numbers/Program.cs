using System;

namespace _07._Sum_Numbers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = int .Parse(Console.ReadLine());
            int totalSum = 0;
            for(int i = 0; i < n; i++)
                {
                int currentNumber = int.Parse(Console.ReadLine());
                totalSum += currentNumber;
                }
            Console.WriteLine(totalSum);
            }
        }
    }
