using System;

namespace _01._Read_Text
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string pass= Console.ReadLine();

            while(pass != "Stop")
                {
                Console.WriteLine(pass);
                pass = Console.ReadLine();
                }

            }
        }
    }
