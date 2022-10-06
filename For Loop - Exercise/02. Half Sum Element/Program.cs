using System;

namespace _02._Half_Sum_Element
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());
            int maxSum = int.MinValue;
            int total = 0;
             for (int i = 0; i < n; i++)
                {
                int num = int.Parse(Console.ReadLine());
                total += num;
                if (num > maxSum)
                    {
                    maxSum = num;
                    }

                }
            int rest = total - maxSum;
            int diff = maxSum-rest;
            if (maxSum == rest)
                {
                Console.WriteLine($"Yes\r\nSum = {maxSum}");
                }
            else
                {           
                Console.WriteLine($"No\r\nDiff = {Math.Abs(diff)}");
                }
            }
        }
    }
