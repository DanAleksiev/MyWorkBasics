using System;

namespace _03._Histogram
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 1; i <= n; i++)
                {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                    {
                    p1++;
                    }
                else if (number >= 200 && number <= 399)
                    {
                    p2++;
                    }
                else if (number >= 400 && number <= 599)
                    {
                    p3++;
                    }
                else if (number >= 600 && number <= 799)
                    {
                    p4++;
                    }
                else if (number >= 800)
                    {
                    p5++;
                    }
                }
            double count1 = p1 * 1.0 / n * 100;  // *1.0 за да го превърнем в дробно число  и по 100 за да го превурнем в процент 
            double count2 = p2 * 1.0 / n * 100;
            double count3 = p3 * 1.0 / n * 100;
            double count4 = p4 * 1.0 / n * 100;
            double count5 = p5 * 1.0 / n * 100;

            Console.WriteLine($"{count1:f2}%");
            Console.WriteLine($"{count2:f2}%");
            Console.WriteLine($"{count3:f2}%");
            Console.WriteLine($"{count4:f2}%");
            Console.WriteLine($"{count5:f2}%");
            }
        }
    }
