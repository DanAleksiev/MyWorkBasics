using System;

namespace _07._Trekking_Mania
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int groups = int.Parse(Console.ReadLine());

            double musala = 0;
            double monbland = 0;
            double kilimanjaro = 0;
            double k2 = 0;
            double everest = 0;
            double num = 0;

            for (int i = 1; i <= groups; i++)
                {
                int members = int.Parse(Console.ReadLine());
                num+= members;
                if (members <= 5)
                    {
                    musala+= members;
                    }
                else if (members >= 6 && members <= 12 )
                    {
                    monbland+= members;
                    }
                else if (members >= 13&& members <= 25)
                    {
                    kilimanjaro += members;
                    }
                else if (members >= 26 && members <=40)
                    {
                    k2 += members;
                    }
                else if (members >= 41)
                    {
                    everest += members;
                    }
                }

            musala = musala/ num * 100;
            monbland = monbland/ num * 100;
            kilimanjaro = kilimanjaro/ num * 100;
            k2 = k2/ num * 100;
            everest = everest/ num * 100;

            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{monbland:f2}%");
            Console.WriteLine($"{kilimanjaro:f2}%");
            Console.WriteLine($"{k2:f2}%");
            Console.WriteLine($"{everest:f2}%");
            }
        }
    }
