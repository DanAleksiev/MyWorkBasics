using System;

namespace _06._Oscars
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string actorName = Console.ReadLine();
            double point = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());
            double total = point + 0;

            for (int i = 1; i <= judges; i++)
                {
                string nameJudge= Console.ReadLine();
                double pointsJudge = double.Parse(Console.ReadLine());
                
                int wordLenght = nameJudge.Length;

                double totalPerJudge = wordLenght * pointsJudge / 2;

                total+=totalPerJudge;

                if (total > 1250.5)
                    {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {total:f1}!");
                    break;
                    }

                }
            if (total < 1250.5)
                {
                double need = 1250.5 - total;
                Console.WriteLine($"Sorry, {actorName} you need {need:f1} more!");
                }

            }
        }
    }
