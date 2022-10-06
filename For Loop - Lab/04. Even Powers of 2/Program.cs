using System;

namespace _02._Numbers_N._1
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());

            int num = 1; // != na 0 (0*x=0)

            for (int i = 0; i <= n; i+=2)
                {
                Console.WriteLine(num);
                num *= 2 * 2; // kkorenno obnojenie 
                }
            }
        }
    }
