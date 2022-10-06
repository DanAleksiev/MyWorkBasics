using System;

namespace _05._Best_Player
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string name = name = Console.ReadLine(); ;
            int gols = 0;
            int max = int.MinValue;
            string best = "";
            while (name != "END")
                {
                gols = int.Parse(Console.ReadLine());

                if (gols >max)
                    {
                    max = gols;
                    best = name;
                    }
                if (gols >= 10)
                    {
                    best = name;
                    break;
                    }
                name = Console.ReadLine();
                }
            Console.WriteLine($"{best} is the best player!");
            if (max >= 3)
                {
                Console.WriteLine($"He has scored {max} goals and made a hat-trick !!!");
                }
            else
                {
                Console.WriteLine($"He has scored {max} goals.");
                }

            }
        }
    }
