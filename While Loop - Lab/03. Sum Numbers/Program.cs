using System;

namespace _03._Sum_Numbers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int num = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            while (num > secondNum)
                {
                secondNum += int.Parse(Console.ReadLine());
                }
            Console.WriteLine(secondNum);
            }
        }
    }
