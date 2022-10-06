using System;

namespace _04._Personal_Titles
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double years = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();


            switch (sex)
                {
                case "m":
                if (years >= 16)
                    {
                    Console.WriteLine("Mr.");
                    }
                else if (years <16 )
                    {
                    Console.WriteLine("Master");
                    }
                break;

                case "f":
                if (years >= 16)
                    {
                    Console.WriteLine("Ms.");
                    }
                else if (years < 16)
                    {
                    Console.WriteLine("Miss");
                    }
                break;

                default:
                break;

                }    
            }
        }
    }
