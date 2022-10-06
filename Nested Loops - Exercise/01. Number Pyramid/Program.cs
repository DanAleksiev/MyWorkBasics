using System;

namespace _01._Number_Pyramid
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n= int.Parse(Console.ReadLine());
            bool bigger = false;
            int current = 1;    

            for (int rows = 1; rows <= n; rows++)
                {
                for (int cols = 1; cols <= rows; cols++)
                    {
                    if (current > n)
                        {
                        bigger = true;
                        break;
                        }
                    Console.Write(current + " ");
                    current++;
                    }
                if (bigger)
                    {
                    break;
                    }
                Console.WriteLine();
                }
            }
        }
    }
