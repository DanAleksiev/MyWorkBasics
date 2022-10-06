using System;

namespace _05.SpecialNumbers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int num = int.Parse(Console.ReadLine());

            for (int a = 1; a <= 9; a++)
                {
                for (int b = 1; b <= 9; b++)
                    {
                    for (int c = 1; c <= 9; c++)
                        {
                        for (int d = 1; d <= 9; d++)
                            {
                            if (num % a == 0 && num % b == 0 && num % c == 0 && num % d == 0)
                                {
                                Console.Write($"{a}{b}{c}{d} ");
                                }
                            }
                        }
                    }
                }

            }
        }
    }