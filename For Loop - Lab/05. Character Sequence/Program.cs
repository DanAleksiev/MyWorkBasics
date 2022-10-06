using System;

namespace _05._Character_Sequence
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            int wordLenght = input.Length;

            for (int value = 0; value <= wordLenght - 1; value++)
                {
                Console.WriteLine(input[value]);
                }
            }
        }
    }
