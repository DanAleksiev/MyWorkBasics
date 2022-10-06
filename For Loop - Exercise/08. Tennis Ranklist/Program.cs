using System;

namespace _08._Tennis_Ranklist
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int numTournaments = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            int tournamentPoints = 0;
            double w = 0;

            for (int i = 1; i <= numTournaments; i++)
                {
                string etap = Console.ReadLine();

                if (etap == "W")
                    {
                    w++;
                    tournamentPoints += 2000;
                    }
                else if (etap == "F")
                    {
                    tournamentPoints += 1200;
                    }
                else if (etap == "SF")
                    {
                    tournamentPoints += 720;
                    }
                }
            int totalPoints = points + tournamentPoints;
            double pW = w / numTournaments * 100;
            int avarage = tournamentPoints / numTournaments;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {avarage}");
            Console.WriteLine($"{pW:f2}%");
            }
        }
    }
