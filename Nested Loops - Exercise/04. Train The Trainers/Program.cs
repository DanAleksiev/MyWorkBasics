using System;

namespace _04._Train_The_Trainers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int numJuri = int.Parse(Console.ReadLine());
            string presentName = Console.ReadLine();
            double score = 0;
            int numScores = 0;
            double avarageScore = 0;
            double finalScore = 0;
            while (presentName != "Finish")
                {
                for (int rotatis = 0; rotatis < numJuri; rotatis++)
                    {
                    score += double.Parse(Console.ReadLine());
                
                    }
                
                numScores++;
                avarageScore = score / numJuri;
                finalScore += avarageScore;
                Console.WriteLine($"{presentName} - {avarageScore:f2}.");
                score = 0;
                presentName = Console.ReadLine();

                }
            Console.WriteLine($"Student's final assessment is {finalScore / numScores:f2}.");
            }
        }
    }
