using System;

namespace _02._Multiplication_Table
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            for (int n = 1; n <= 10; n++)
                {
                for (int x = 1; x <= 10; x++)
                    {
                    Console.WriteLine($"{n} * {x} = {n*x}");
                    }
                }
            }
        }
    }
