using System;

namespace _04._Sum_of_Two_Numbers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int count=0;
            bool found = false;

            for (int x1 = num1; x1 <= num2; x1++)
                {
                for(int x2 = num1; x2 <= num2; x2++)
                    {
                    count ++;
                    if (x1 + x2 == magicNum)
                        {
                        found = true;
                        Console.WriteLine($"Combination N:{count} ({x1} + {x2} = {magicNum})");
                        break;
                        }
                    }
                if (found)
                    {
                    break;
                    }
                }
            if (!found)
                {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
                }
            }
        }
    }
