using System;

namespace _08._Number_sequence
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n= int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue; // zadavame nai niskata/visokata stoinost i gradim na tatuk
            for (int i = 0; i < n; i++)
                {
                int num = int.Parse(Console.ReadLine());
                if (num > maxNumber)
                    {
                    maxNumber = num;
                    }
                if (num<minNumber)
                    {
                    minNumber = num;
                    }
                }
            Console.WriteLine($"Max number: {maxNumber}\r\nMin number: {minNumber}");
            }
        }
    }
