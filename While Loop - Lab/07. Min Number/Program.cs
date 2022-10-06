using System;

namespace _06._Max_Number
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int minNum = int.MaxValue;
            string input = Console.ReadLine();
            while (input != "Stop")
                {
                int num = int.Parse(input);
                if (num < minNum)
                    {
                    minNum = num;
                    }
                input = Console.ReadLine();
                }
            Console.WriteLine(minNum);
            }
        }
    }
