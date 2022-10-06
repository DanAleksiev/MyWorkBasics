using System;

namespace _02._Exam_Preparation
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int fail = int.Parse(Console.ReadLine());
            string nameExam = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            int numGrades = 0;
            double total = 0;
            double avarage = 0;
            int numFail = 0;
            string lastExam = "";
            while (nameExam != "Enough")
                {
                if (grade <= 4)
                    {
                    numFail++;
                    }
                if (numFail >= fail)
                    {
                    Console.WriteLine($"You need a break, {numFail} poor grades.");
                    break;
                    }

                numGrades++;
                total += grade;
                avarage = total / numGrades;
                lastExam = nameExam;

                nameExam = Console.ReadLine();
                if (nameExam == "Enough")
                    {
                    Console.WriteLine($"Average score: {avarage:f2}\r\nNumber of problems: {numGrades}\r\nLast problem: {lastExam}");
                    break;
                    }
                grade = double.Parse(Console.ReadLine());
                
                }
            }
        }
    }
